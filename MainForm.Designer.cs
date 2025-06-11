namespace XpenseTracker;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridViewExpenses = new DataGridView();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        label = new Label();
        dateTimePicker1 = new DateTimePicker();
        ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewExpenses
        // 
        dataGridViewExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewExpenses.Location = new Point(12, 42);
        dataGridViewExpenses.Name = "dataGridViewExpenses";
        dataGridViewExpenses.RowHeadersWidth = 62;
        dataGridViewExpenses.Size = new Size(837, 528);
        dataGridViewExpenses.TabIndex = 0;
        dataGridViewExpenses.CellContentClick += dataGridView1_CellContentClick;
        // 
        // btnAdd
        // 
        btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAdd.Location = new Point(12, 576);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(99, 31);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEdit.Location = new Point(117, 576);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(99, 31);
        btnEdit.TabIndex = 2;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = true;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDelete.Location = new Point(222, 576);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(99, 31);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label.Location = new Point(12, 9);
        label.Name = "label";
        label.Size = new Size(175, 30);
        label.TabIndex = 4;
        label.Text = "Expenses Table";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        dateTimePicker1.Location = new Point(327, 576);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(379, 31);
        dateTimePicker1.TabIndex = 5;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(861, 644);
        Controls.Add(dateTimePicker1);
        Controls.Add(label);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        Controls.Add(dataGridViewExpenses);
        Name = "MainForm";
        Text = "MainForm";
        ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewExpenses;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Label label;
    private DateTimePicker dateTimePicker1;
}
