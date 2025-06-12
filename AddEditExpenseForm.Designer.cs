namespace XpenseTracker
{
    partial class AddEditExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            txtCategory = new TextBox();
            Category = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            dtDate = new DateTimePicker();
            numAmount = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(147, 30);
            label.TabIndex = 5;
            label.Text = "Add expense";
            // 
            // txtCategory
            // 
            txtCategory.BackColor = SystemColors.WindowFrame;
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Font = new Font("Segoe UI", 10F);
            txtCategory.ForeColor = SystemColors.MenuBar;
            txtCategory.Location = new Point(236, 52);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(203, 34);
            txtCategory.TabIndex = 6;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Segoe UI", 10F);
            Category.Location = new Point(12, 52);
            Category.Name = "Category";
            Category.Size = new Size(92, 28);
            Category.TabIndex = 7;
            Category.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 9;
            label1.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.WindowFrame;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = SystemColors.MenuBar;
            txtDescription.Location = new Point(236, 92);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(203, 34);
            txtDescription.TabIndex = 8;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI", 10F);
            dtDate.Location = new Point(236, 172);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(203, 34);
            dtDate.TabIndex = 10;
            // 
            // numAmount
            // 
            numAmount.BackColor = SystemColors.WindowFrame;
            numAmount.BorderStyle = BorderStyle.FixedSingle;
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 10F);
            numAmount.ForeColor = SystemColors.MenuBar;
            numAmount.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numAmount.Location = new Point(236, 132);
            numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(203, 34);
            numAmount.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 13;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 12;
            label3.Text = "Amount";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(203, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddEditExpenseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 285);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(numAmount);
            Controls.Add(dtDate);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(Category);
            Controls.Add(txtCategory);
            Controls.Add(label);
            Name = "AddEditExpenseForm";
            Text = "AddEditExpenseForm";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox txtCategory;
        private Label Category;
        private Label label1;
        private TextBox txtDescription;
        private DateTimePicker dtDate;
        private NumericUpDown numAmount;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
    }
}