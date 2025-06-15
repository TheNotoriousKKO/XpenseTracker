namespace XpenseTracker
{
    partial class AddEditExpenseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            cmbCategory = new ComboBox();
            labelTitle = new Label();
            labelCategory = new Label();
            labelDescription = new Label();
            txtDescription = new TextBox();
            labelAmount = new Label();
            numAmount = new NumericUpDown();
            labelDate = new Label();
            dtDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Control;
            panelMain.Controls.Add(cmbCategory);
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(labelCategory);
            panelMain.Controls.Add(labelDescription);
            panelMain.Controls.Add(txtDescription);
            panelMain.Controls.Add(labelAmount);
            panelMain.Controls.Add(numAmount);
            panelMain.Controls.Add(labelDate);
            panelMain.Controls.Add(dtDate);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(btnCancel);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(430, 300);
            panelMain.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(150, 57);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(250, 33);
            cmbCategory.TabIndex = 11;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Franklin Gothic Demi", 14F, FontStyle.Italic);
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Add Expense";
            // 
            // labelCategory
            // 
            labelCategory.Location = new Point(10, 60);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(134, 30);
            labelCategory.TabIndex = 1;
            labelCategory.Text = "Category";
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(10, 100);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(134, 30);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = SystemColors.ControlText;
            txtDescription.Location = new Point(150, 100);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 34);
            txtDescription.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.Location = new Point(10, 140);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(134, 30);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Amount";
            // 
            // numAmount
            // 
            numAmount.BorderStyle = BorderStyle.FixedSingle;
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 10F);
            numAmount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAmount.Location = new Point(150, 140);
            numAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(250, 34);
            numAmount.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.Location = new Point(10, 180);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(134, 30);
            labelDate.TabIndex = 7;
            labelDate.Text = "Date";
            // 
            // dtDate
            // 
            dtDate.CalendarTitleBackColor = Color.PowderBlue;
            dtDate.Font = new Font("Segoe UI", 10F);
            dtDate.Location = new Point(150, 180);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 34);
            dtDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditExpenseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 300);
            Controls.Add(panelMain);
            Name = "AddEditExpenseForm";
            Text = "Add/Edit Expense";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelTitle;
        private Label labelCategory;
        private Label labelDescription;
        private TextBox txtDescription;
        private Label labelAmount;
        private NumericUpDown numAmount;
        private Label labelDate;
        private DateTimePicker dtDate;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbCategory;
    }
}
