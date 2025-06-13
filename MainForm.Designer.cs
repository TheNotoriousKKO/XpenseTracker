namespace XpenseTracker;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        dataGridViewExpenses = new DataGridView();
        panelBottom = new Panel();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        label = new Label();
        dateTimePicker1 = new DateTimePicker();

        ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
        panelBottom.SuspendLayout();
        SuspendLayout();

        // 
        // dataGridViewExpenses
        // 
        dataGridViewExpenses.Dock = DockStyle.Fill;
        dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewExpenses.Location = new Point(0, 50);
        dataGridViewExpenses.Name = "dataGridViewExpenses";
        dataGridViewExpenses.RowHeadersWidth = 62;
        dataGridViewExpenses.TabIndex = 0;

        // 
        // panelBottom
        // 
        panelBottom.Dock = DockStyle.Bottom;
        panelBottom.Height = 60;
        panelBottom.Padding = new Padding(10);
        panelBottom.BackColor = SystemColors.Control;
        panelBottom.Controls.Add(btnAdd);
        panelBottom.Controls.Add(btnEdit);
        panelBottom.Controls.Add(btnDelete);
        panelBottom.Controls.Add(dateTimePicker1);

        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(10, 10);
        btnAdd.Size = new Size(80, 35);
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;

        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(100, 10);
        btnEdit.Size = new Size(80, 35);
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;

        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(190, 10);
        btnDelete.Size = new Size(80, 35);
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;

        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(290, 15);
        dateTimePicker1.Size = new Size(250, 31);

        // 
        // label
        // 
        label.Dock = DockStyle.Top;
        label.Text = "Expenses Table";
        label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Height = 50;

        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 600);
        MinimumSize = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;
        Controls.Add(dataGridViewExpenses);
        Controls.Add(panelBottom);
        Controls.Add(label);
        Name = "MainForm";
        Text = "Xpense Tracker";
        Load += MainForm_Load;

        ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
        panelBottom.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewExpenses;
    private Panel panelBottom;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Label label;
    private DateTimePicker dateTimePicker1;
}
