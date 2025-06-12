using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XpenseTracker.Data;
using XpenseTracker.Models;

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
            this.dataGridViewExpenses.ColumnHeaderMouseClick += DataGridViewExpenses_ColumnHeaderMouseClick;
        }

        private void MainForm_Load(object sender, EventArgs e)
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

            if (dataGridViewExpenses.Columns["Id"] != null)
            {
                dataGridViewExpenses.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewExpenses.Columns["Id"].Width = 60;
            }

        }

        private void DataGridViewExpenses_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

            // Reset glyphs
            foreach (DataGridViewColumn col in dataGridViewExpenses.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            // Apply glyph to the clicked column
            var sortOrder = _sortAscending ? SortOrder.Ascending : SortOrder.Descending;
            dataGridViewExpenses.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = sortOrder;
        }

        private object? GetPropertyValue(Expense expense, string propertyName)
        {
            return typeof(Expense).GetProperty(propertyName)?.GetValue(expense, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditExpenseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newExpense = form.GetExpense();
                using var db = new AppDbContext();
                db.Expenses.Add(newExpense);
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
    }
}
