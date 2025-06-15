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
        btnExport = new Button();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        dateTimePicker1 = new DateTimePicker();
        label = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
        panelBottom.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewExpenses
        // 
        dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewExpenses.Dock = DockStyle.Fill;
        dataGridViewExpenses.Location = new Point(0, 50);
        dataGridViewExpenses.Name = "dataGridViewExpenses";
        dataGridViewExpenses.RowHeadersWidth = 62;
        dataGridViewExpenses.Size = new Size(800, 490);
        dataGridViewExpenses.TabIndex = 0;
        // 
        // panelBottom
        // 
        panelBottom.BackColor = SystemColors.Control;
        panelBottom.Controls.Add(btnExport);
        panelBottom.Controls.Add(btnAdd);
        panelBottom.Controls.Add(btnEdit);
        panelBottom.Controls.Add(btnDelete);
        panelBottom.Controls.Add(dateTimePicker1);
        panelBottom.Dock = DockStyle.Bottom;
        panelBottom.Location = new Point(0, 540);
        panelBottom.Name = "panelBottom";
        panelBottom.Padding = new Padding(10);
        panelBottom.Size = new Size(800, 60);
        panelBottom.TabIndex = 1;
        // 
        // btnExport
        // 
        btnExport.Location = new Point(632, 13);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(155, 35);
        btnExport.TabIndex = 4;
        btnExport.Text = "Export";
        btnExport.UseVisualStyleBackColor = true;
        btnExport.Click += btnExport_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(10, 10);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(80, 35);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(100, 10);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(80, 35);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(190, 10);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 35);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(290, 15);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(250, 31);
        dateTimePicker1.TabIndex = 3;
        // 
        // label
        // 
        label.Dock = DockStyle.Top;
        label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label.Location = new Point(0, 0);
        label.Name = "label";
        label.Size = new Size(800, 50);
        label.TabIndex = 2;
        label.Text = "Expenses Table";
        label.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 600);
        Controls.Add(dataGridViewExpenses);
        Controls.Add(panelBottom);
        Controls.Add(label);
        MinimumSize = new Size(800, 600);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
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
    private Button btnExport;
}
