namespace ExpensesTracker.GUI.CategoryGUI
{
    partial class AddAndEditCategoryForm
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
            panel1 = new Panel();
            saveButton = new Button();
            saveAndCloseButton = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            detailsRichTextBox = new RichTextBox();
            typeComboBox = new ComboBox();
            balanceTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(saveAndCloseButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 63);
            panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.Save2;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(356, 5);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(108, 54);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.TextAlign = ContentAlignment.MiddleRight;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Image = Properties.Resources.Save;
            saveAndCloseButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveAndCloseButton.Location = new Point(5, 5);
            saveAndCloseButton.Margin = new Padding(5);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(202, 54);
            saveAndCloseButton.TabIndex = 3;
            saveAndCloseButton.Text = "Save and Close";
            saveAndCloseButton.TextAlign = ContentAlignment.MiddleRight;
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(detailsRichTextBox);
            groupBox1.Controls.Add(typeComboBox);
            groupBox1.Controls.Add(balanceTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(144, 118);
            label6.Name = "label6";
            label6.Size = new Size(15, 18);
            label6.TabIndex = 11;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(144, 70);
            label5.Name = "label5";
            label5.Size = new Size(15, 18);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // detailsRichTextBox
            // 
            detailsRichTextBox.Location = new Point(169, 176);
            detailsRichTextBox.Name = "detailsRichTextBox";
            detailsRichTextBox.Size = new Size(268, 132);
            detailsRichTextBox.TabIndex = 9;
            detailsRichTextBox.Text = "";
            // 
            // typeComboBox
            // 
            typeComboBox.BackColor = Color.White;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Payment", "Collect" });
            typeComboBox.Location = new Point(169, 118);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(268, 26);
            typeComboBox.TabIndex = 8;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Enabled = false;
            balanceTextBox.Location = new Point(169, 334);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(268, 26);
            balanceTextBox.TabIndex = 7;
            balanceTextBox.Text = "0";
            balanceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 334);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 6;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 173);
            label3.Name = "label3";
            label3.Size = new Size(141, 18);
            label3.TabIndex = 4;
            label3.Text = "Category Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 118);
            label2.Name = "label2";
            label2.Size = new Size(125, 18);
            label2.TabIndex = 2;
            label2.Text = "Category Type";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(169, 70);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(268, 26);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(132, 18);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // AddAndEditCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 474);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAndEditCategoryForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Category";
            TopMost = true;
            Load += AddAndEditCategoryForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detailsRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private Label label6;
        private Label label5;
    }
}