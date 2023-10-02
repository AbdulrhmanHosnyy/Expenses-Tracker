namespace ExpensesTracker.GUI.ProjectGUI
{
    partial class AddAndEditProjectForm
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
            projectEndDateTimePicker = new DateTimePicker();
            projectStartDateTimePicker = new DateTimePicker();
            customerComboBox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            companyTextBox = new TextBox();
            label7 = new Label();
            addressTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            detailsRichTextBox = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            revenueTextBox = new TextBox();
            label10 = new Label();
            outcomeTextBox = new TextBox();
            label4 = new Label();
            incomeTextBox = new TextBox();
            label18 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(saveAndCloseButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 63);
            panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.Save2;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(620, 5);
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
            groupBox1.Controls.Add(projectEndDateTimePicker);
            groupBox1.Controls.Add(projectStartDateTimePicker);
            groupBox1.Controls.Add(customerComboBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(companyTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(detailsRichTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // projectEndDateTimePicker
            // 
            projectEndDateTimePicker.Location = new Point(169, 299);
            projectEndDateTimePicker.Name = "projectEndDateTimePicker";
            projectEndDateTimePicker.Size = new Size(288, 26);
            projectEndDateTimePicker.TabIndex = 22;
            // 
            // projectStartDateTimePicker
            // 
            projectStartDateTimePicker.Location = new Point(169, 247);
            projectStartDateTimePicker.Name = "projectStartDateTimePicker";
            projectStartDateTimePicker.Size = new Size(288, 26);
            projectStartDateTimePicker.TabIndex = 21;
            // 
            // customerComboBox
            // 
            customerComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            customerComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(169, 94);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(288, 26);
            customerComboBox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 299);
            label9.Name = "label9";
            label9.Size = new Size(100, 18);
            label9.TabIndex = 18;
            label9.Text = "Project end";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 247);
            label8.Name = "label8";
            label8.Size = new Size(108, 18);
            label8.TabIndex = 16;
            label8.Text = "Project start";
            // 
            // companyTextBox
            // 
            companyTextBox.Location = new Point(169, 196);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.Size = new Size(288, 26);
            companyTextBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 196);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 14;
            label7.Text = "Company";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(169, 142);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(288, 26);
            addressTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 142);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(144, 45);
            label5.Name = "label5";
            label5.Size = new Size(15, 18);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // detailsRichTextBox
            // 
            detailsRichTextBox.Location = new Point(169, 344);
            detailsRichTextBox.Name = "detailsRichTextBox";
            detailsRichTextBox.Size = new Size(293, 77);
            detailsRichTextBox.TabIndex = 9;
            detailsRichTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 344);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 4;
            label3.Text = "Project Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(169, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 26);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 0;
            label1.Text = "Project Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(revenueTextBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(outcomeTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(incomeTextBox);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(496, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 288);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Project Funds";
            // 
            // revenueTextBox
            // 
            revenueTextBox.Enabled = false;
            revenueTextBox.Location = new Point(42, 239);
            revenueTextBox.Name = "revenueTextBox";
            revenueTextBox.Size = new Size(212, 26);
            revenueTextBox.TabIndex = 11;
            revenueTextBox.Text = "0";
            revenueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 202);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 10;
            label10.Text = "Revenue";
            // 
            // outcomeTextBox
            // 
            outcomeTextBox.Enabled = false;
            outcomeTextBox.Location = new Point(42, 163);
            outcomeTextBox.Name = "outcomeTextBox";
            outcomeTextBox.Size = new Size(212, 26);
            outcomeTextBox.TabIndex = 9;
            outcomeTextBox.Text = "0";
            outcomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 8;
            label4.Text = "Project";
            // 
            // incomeTextBox
            // 
            incomeTextBox.Enabled = false;
            incomeTextBox.Location = new Point(42, 85);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new Size(212, 26);
            incomeTextBox.TabIndex = 7;
            incomeTextBox.Text = "0";
            incomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 48);
            label18.Name = "label18";
            label18.Size = new Size(67, 18);
            label18.TabIndex = 0;
            label18.Text = "Income";
            // 
            // AddAndEditProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(793, 510);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAndEditProjectForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Project";
            TopMost = true;
            Load += AddAndEditProjectForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detailsRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private Label label5;
        private TextBox companyTextBox;
        private Label label7;
        private TextBox addressTextBox;
        private Label label6;
        private Label label9;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox incomeTextBox;
        private Label label18;
        private TextBox revenueTextBox;
        private Label label10;
        private TextBox outcomeTextBox;
        private Label label4;
        private ComboBox customerComboBox;
        private DateTimePicker projectEndDateTimePicker;
        private DateTimePicker projectStartDateTimePicker;
    }
}