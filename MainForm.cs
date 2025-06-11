using System;
using System.Linq;
using System.Windows.Forms;
using XpenseTracker.Data;
using XpenseTracker.Models;

namespace XpenseTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            using var db = new AppDbContext();
            var expenses = db.Expenses
                .OrderByDescending(e => e.Date)
                .ToList();

            dataGridViewExpenses.DataSource = null;
            dataGridViewExpenses.DataSource = expenses;

            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                LoadExpenses(); // refresh UI
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Add your logic here, e.g., handle cell clicks
        }
    }
}
