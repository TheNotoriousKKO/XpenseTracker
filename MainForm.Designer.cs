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
        btnExportCsv = new Button();
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
        dataGridViewExpenses.Size = new Size(1013, 495);
        dataGridViewExpenses.TabIndex = 0;
        // 
        // panelBottom
        // 
        panelBottom.BackColor = SystemColors.Control;
        panelBottom.Controls.Add(btnExportCsv);
        panelBottom.Controls.Add(btnExport);
        panelBottom.Controls.Add(btnAdd);
        panelBottom.Controls.Add(btnEdit);
        panelBottom.Controls.Add(btnDelete);
        panelBottom.Controls.Add(dateTimePicker1);
        panelBottom.Dock = DockStyle.Bottom;
        panelBottom.Location = new Point(0, 545);
        panelBottom.Name = "panelBottom";
        panelBottom.Padding = new Padding(10);
        panelBottom.Size = new Size(1013, 60);
        panelBottom.TabIndex = 1;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(10, 12);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(113, 35);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(133, 12);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(113, 35);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(256, 12);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(113, 35);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(379, 15);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(200, 31);
        dateTimePicker1.TabIndex = 3;
        // 
        // btnExportCsv
        // 
        btnExportCsv.Location = new Point(585, 12);
        btnExportCsv.Name = "btnExportCsv";
        btnExportCsv.Size = new Size(113, 35);
        btnExportCsv.TabIndex = 4;
        btnExportCsv.Text = "Export CSV";
        btnExportCsv.UseVisualStyleBackColor = true;
        btnExportCsv.Click += btnExportCsv_Click;
        // 
        // btnExport
        // 
        btnExport.Location = new Point(708, 12);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(113, 35);
        btnExport.TabIndex = 5;
        btnExport.Text = "Export Excel";
        btnExport.UseVisualStyleBackColor = true;
        btnExport.Click += btnExport_Click;

        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(830, 550);
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
    private Button btnExportCsv;
}
