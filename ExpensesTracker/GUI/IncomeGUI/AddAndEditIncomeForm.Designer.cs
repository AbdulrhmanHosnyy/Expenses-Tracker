namespace ExpensesTracker.GUI.IncomeGUI
{
    partial class AddAndEditIncomeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            detailsRichTextBox = new RichTextBox();
            label5 = new Label();
            label8 = new Label();
            RecipientComboBox = new ComboBox();
            IncomeDateTimePicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            NewCustomerLinkLabel = new LinkLabel();
            NewCategoryLinkLabel = new LinkLabel();
            label9 = new Label();
            label4 = new Label();
            amountTextBox = new TextBox();
            label7 = new Label();
            receiptNumberTextBox = new TextBox();
            label6 = new Label();
            categoryComboBox = new ComboBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(saveAndCloseButton);
            panel1.Location = new Point(2, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 63);
            panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.Save2;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(387, 4);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(108, 54);
            saveButton.TabIndex = 6;
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
            saveAndCloseButton.TabIndex = 7;
            saveAndCloseButton.Text = "Save and Close";
            saveAndCloseButton.TextAlign = ContentAlignment.MiddleRight;
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 306);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 4;
            label3.Text = "Income Details";
            // 
            // detailsRichTextBox
            // 
            detailsRichTextBox.Location = new Point(184, 302);
            detailsRichTextBox.Name = "detailsRichTextBox";
            detailsRichTextBox.Size = new Size(293, 77);
            detailsRichTextBox.TabIndex = 5;
            detailsRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(135, 45);
            label5.Name = "label5";
            label5.Size = new Size(15, 18);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 144);
            label8.Name = "label8";
            label8.Size = new Size(109, 18);
            label8.TabIndex = 16;
            label8.Text = "Income Date";
            // 
            // RecipientComboBox
            // 
            RecipientComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RecipientComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            RecipientComboBox.FormattingEnabled = true;
            RecipientComboBox.Location = new Point(184, 93);
            RecipientComboBox.Name = "RecipientComboBox";
            RecipientComboBox.Size = new Size(288, 26);
            RecipientComboBox.TabIndex = 1;
            // 
            // IncomeDateTimePicker
            // 
            IncomeDateTimePicker.Location = new Point(184, 143);
            IncomeDateTimePicker.Name = "IncomeDateTimePicker";
            IncomeDateTimePicker.Size = new Size(288, 26);
            IncomeDateTimePicker.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(NewCustomerLinkLabel);
            groupBox1.Controls.Add(NewCategoryLinkLabel);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(amountTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(receiptNumberTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(IncomeDateTimePicker);
            groupBox1.Controls.Add(RecipientComboBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(detailsRichTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 402);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Income Information";
            // 
            // NewCustomerLinkLabel
            // 
            NewCustomerLinkLabel.AutoSize = true;
            NewCustomerLinkLabel.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NewCustomerLinkLabel.Location = new Point(93, 99);
            NewCustomerLinkLabel.Name = "NewCustomerLinkLabel";
            NewCustomerLinkLabel.Size = new Size(36, 15);
            NewCustomerLinkLabel.TabIndex = 31;
            NewCustomerLinkLabel.TabStop = true;
            NewCustomerLinkLabel.Text = "New";
            NewCustomerLinkLabel.LinkClicked += NewCustomerLinkLabel_LinkClicked;
            // 
            // NewCategoryLinkLabel
            // 
            NewCategoryLinkLabel.AutoSize = true;
            NewCategoryLinkLabel.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NewCategoryLinkLabel.Location = new Point(93, 50);
            NewCategoryLinkLabel.Name = "NewCategoryLinkLabel";
            NewCategoryLinkLabel.Size = new Size(36, 15);
            NewCategoryLinkLabel.TabIndex = 30;
            NewCategoryLinkLabel.TabStop = true;
            NewCategoryLinkLabel.Text = "New";
            NewCategoryLinkLabel.LinkClicked += NewCategoryLinkLabel_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(135, 134);
            label9.Name = "label9";
            label9.Size = new Size(15, 18);
            label9.TabIndex = 29;
            label9.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(135, 82);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 28;
            label4.Text = "*";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(184, 246);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(288, 26);
            amountTextBox.TabIndex = 4;
            amountTextBox.Text = "0";
            amountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 250);
            label7.Name = "label7";
            label7.Size = new Size(70, 18);
            label7.TabIndex = 27;
            label7.Text = "Amonut";
            // 
            // receiptNumberTextBox
            // 
            receiptNumberTextBox.Enabled = false;
            receiptNumberTextBox.Location = new Point(184, 194);
            receiptNumberTextBox.Name = "receiptNumberTextBox";
            receiptNumberTextBox.Size = new Size(288, 26);
            receiptNumberTextBox.TabIndex = 3;
            receiptNumberTextBox.Text = "0";
            receiptNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 198);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 25;
            label6.Text = "Receipt Number";
            // 
            // categoryComboBox
            // 
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(184, 44);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(288, 26);
            categoryComboBox.TabIndex = 0;
            // 
            // AddAndEditIncomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(502, 491);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAndEditIncomeForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Income";
            TopMost = true;
            Activated += AddAndEditIncomeForm_Activated;
            Load += AddAndEditIncomeForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox detailsRichTextBox;
        private Label label5;
        private Label label8;
        private ComboBox RecipientComboBox;
        private DateTimePicker IncomeDateTimePicker;
        private GroupBox groupBox1;
        private Label label9;
        private Label label4;
        private TextBox amountTextBox;
        private Label label7;
        private TextBox receiptNumberTextBox;
        private Label label6;
        private ComboBox categoryComboBox;
        private LinkLabel NewCustomerLinkLabel;
        private LinkLabel NewCategoryLinkLabel;
    }
}