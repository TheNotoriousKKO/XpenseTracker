using System;
using System.Windows.Forms;
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

            if (_expenseToEdit != null)
            {
                // Editing mode — prefill fields
                txtCategory.Text = _expenseToEdit.Category;
                txtDescription.Text = _expenseToEdit.Description;
                numAmount.Value = _expenseToEdit.Amount;
                dtDate.Value = _expenseToEdit.Date;
            }
        }

        public Expense GetExpense()
        {
            return new Expense
            {
                Id = _expenseToEdit?.Id ?? 0, // preserve ID if editing
                Category = txtCategory.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Amount = numAmount.Value,
                Date = dtDate.Value.Date
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
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
