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
            // TODO: Show Add Expense form
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Load selected expense and show Edit form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Delete selected expense
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Add your logic here, e.g., handle cell clicks
        }
    }
}
