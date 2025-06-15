using System;
using System.Linq;
using System.Windows.Forms;
using XpenseTracker.Data;
using XpenseTracker.Models;

namespace XpenseTracker
{
    public partial class AddEditExpenseForm : Form
    {
        private Expense? _expenseToEdit;

        public AddEditExpenseForm(Expense? expense = null)
        {
            InitializeComponent();
            _expenseToEdit = expense;

            LoadCategories();

            if (_expenseToEdit != null)
            {
                // Editing mode — prefill fields
                cmbCategory.Text = _expenseToEdit.Category;
                txtDescription.Text = _expenseToEdit.Description;
                numAmount.Value = _expenseToEdit.Amount;
                dtDate.Value = _expenseToEdit.Date;
            }
        }

        private void LoadCategories()
        {
            using var db = new AppDbContext();
            var categories = db.Expenses
                .Select(e => e.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            cmbCategory.Items.AddRange(categories.ToArray());
        }

        public Expense GetExpense()
        {
            return new Expense
            {
                Id = _expenseToEdit?.Id ?? 0,
                Category = cmbCategory.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Amount = numAmount.Value,
                Date = dtDate.Value.Date
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Category is required.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
