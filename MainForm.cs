using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using XpenseTracker.Data;
using XpenseTracker.Models;
using ClosedXML.Excel;

namespace XpenseTracker
{
    public partial class MainForm : Form
    {
        private List<Expense> _expenseCache = new();
        private string _lastSortedColumn = "";
        private bool _sortAscending = true;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            dataGridViewExpenses.ColumnHeaderMouseClick += DataGridViewExpenses_ColumnHeaderMouseClick;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            using var db = new AppDbContext();
            _expenseCache = db.Expenses.ToList();

            dataGridViewExpenses.AutoGenerateColumns = true;
            dataGridViewExpenses.DataSource = null;
            dataGridViewExpenses.DataSource = _expenseCache;

            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewExpenses.Columns["Amount"] != null)
                dataGridViewExpenses.Columns["Amount"].DefaultCellStyle.Format = "C2";

            if (dataGridViewExpenses.Columns["Date"] != null)
                dataGridViewExpenses.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            
            if (dataGridViewExpenses.Columns["Id"] != null)
                dataGridViewExpenses.Columns["Id"].Width = 60;

        }

        private void DataGridViewExpenses_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewExpenses.Columns[e.ColumnIndex].DataPropertyName;

            if (_lastSortedColumn == columnName)
                _sortAscending = !_sortAscending;
            else
                _sortAscending = true;

            _lastSortedColumn = columnName;

            var sorted = _sortAscending
                ? _expenseCache.OrderBy(x => GetPropertyValue(x, columnName)).ToList()
                : _expenseCache.OrderByDescending(x => GetPropertyValue(x, columnName)).ToList();

            dataGridViewExpenses.DataSource = sorted;

            foreach (DataGridViewColumn col in dataGridViewExpenses.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;

            var sortOrder = _sortAscending ? SortOrder.Ascending : SortOrder.Descending;
            dataGridViewExpenses.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = sortOrder;
        }

        private object? GetPropertyValue(Expense expense, string propertyName)
        {
            return typeof(Expense).GetProperty(propertyName)?.GetValue(expense);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditExpenseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using var db = new AppDbContext();
                db.Expenses.Add(form.GetExpense());
                db.SaveChanges();
                LoadExpenses();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.CurrentRow?.DataBoundItem is not Expense selectedExpense)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            var form = new AddEditExpenseForm(selectedExpense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var updated = form.GetExpense();

                using var db = new AppDbContext();
                var existing = db.Expenses.Find(updated.Id);
                if (existing != null)
                {
                    existing.Category = updated.Category;
                    existing.Description = updated.Description;
                    existing.Amount = updated.Amount;
                    existing.Date = updated.Date;
                    db.SaveChanges();
                    LoadExpenses();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.CurrentRow?.DataBoundItem is not Expense selectedExpense)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                db.Expenses.Remove(selectedExpense);
                db.SaveChanges();
                LoadExpenses();
            }
        }

        private void btnExport_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"Expenses_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Expenses");

            ws.Cell(1, 1).Value = "Category";
            ws.Cell(1, 2).Value = "Description";
            ws.Cell(1, 3).Value = "Amount";
            ws.Cell(1, 4).Value = "Date";
            ws.Row(1).Style.Font.Bold = true;

            for (int i = 0; i < _expenseCache.Count; i++)
            {
                var expense = _expenseCache[i];
                ws.Cell(i + 2, 1).Value = expense.Category;
                ws.Cell(i + 2, 2).Value = expense.Description;
                ws.Cell(i + 2, 3).Value = expense.Amount;
                ws.Cell(i + 2, 4).Value = expense.Date.ToShortDateString();
            }


            workbook.SaveAs(dialog.FileName);
            MessageBox.Show("Export complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"Expenses_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            using var writer = new StreamWriter(dialog.FileName);
            writer.WriteLine("Category,Description,Amount,Date");

            foreach (var expense in _expenseCache)
            {
                writer.WriteLine($"\"{expense.Category}\",\"{expense.Description}\",{expense.Amount},{expense.Date:yyyy-MM-dd}");
            }

            MessageBox.Show("CSV Export complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
