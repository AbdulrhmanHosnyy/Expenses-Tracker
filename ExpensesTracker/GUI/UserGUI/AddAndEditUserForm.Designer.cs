namespace ExpensesTracker.GUI.UserGUI
{
    partial class AddAndEditUserForm
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
            label11 = new Label();
            pictureBox1 = new PictureBox();
            phoneTextBox = new TextBox();
            label10 = new Label();
            emailTextBox = new TextBox();
            label8 = new Label();
            label4 = new Label();
            passwordTextBox = new TextBox();
            label6 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            fullNameTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeCheckBox = new CheckBox();
            categoryCheckBox = new CheckBox();
            customerCheckBox = new CheckBox();
            supplierCheckBox = new CheckBox();
            projectCheckBox = new CheckBox();
            userCheckBox = new CheckBox();
            settingsCheckBox = new CheckBox();
            systemLogCheckBox = new CheckBox();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            categoryAccessCheckBox = new CheckBox();
            supplierAccessCheckBox = new CheckBox();
            customerAccessCheckBox = new CheckBox();
            projectAccessCheckBox = new CheckBox();
            userAccessCheckBox = new CheckBox();
            incomeAccessCheckBox = new CheckBox();
            outcomeAccessCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            addCheckBox = new CheckBox();
            deleteCheckBox = new CheckBox();
            editCheckBox = new CheckBox();
            exportCheckBox = new CheckBox();
            searchCheckBox = new CheckBox();
            openCheckBox = new CheckBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(saveAndCloseButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 63);
            panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.Save2;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(558, 4);
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
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(fullNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 397);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.CadetBlue;
            label11.Location = new Point(170, 92);
            label11.Name = "label11";
            label11.Size = new Size(194, 32);
            label11.TabIndex = 24;
            label11.Text = "Add new user";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User;
            pictureBox1.Location = new Point(6, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(134, 340);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(216, 26);
            phoneTextBox.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 340);
            label10.Name = "label10";
            label10.Size = new Size(59, 18);
            label10.TabIndex = 20;
            label10.Text = "Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(134, 303);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(216, 26);
            emailTextBox.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 303);
            label8.Name = "label8";
            label8.Size = new Size(51, 18);
            label8.TabIndex = 17;
            label8.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(109, 266);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 16;
            label4.Text = "*";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(134, 266);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 26);
            passwordTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 266);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(109, 227);
            label2.Name = "label2";
            label2.Size = new Size(15, 18);
            label2.TabIndex = 13;
            label2.Text = "*";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(134, 227);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(216, 26);
            usernameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 227);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(109, 186);
            label5.Name = "label5";
            label5.Size = new Size(15, 18);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(134, 186);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(216, 26);
            fullNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 186);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 5;
            label1.Text = "Full Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(385, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 113);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Permissions";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(homeCheckBox);
            flowLayoutPanel1.Controls.Add(categoryCheckBox);
            flowLayoutPanel1.Controls.Add(customerCheckBox);
            flowLayoutPanel1.Controls.Add(supplierCheckBox);
            flowLayoutPanel1.Controls.Add(projectCheckBox);
            flowLayoutPanel1.Controls.Add(userCheckBox);
            flowLayoutPanel1.Controls.Add(settingsCheckBox);
            flowLayoutPanel1.Controls.Add(systemLogCheckBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(278, 91);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // homeCheckBox
            // 
            homeCheckBox.AutoSize = true;
            homeCheckBox.Checked = true;
            homeCheckBox.CheckState = CheckState.Checked;
            homeCheckBox.Location = new Point(3, 3);
            homeCheckBox.Name = "homeCheckBox";
            homeCheckBox.Size = new Size(64, 19);
            homeCheckBox.TabIndex = 0;
            homeCheckBox.Text = "Home";
            homeCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryCheckBox
            // 
            categoryCheckBox.AutoSize = true;
            categoryCheckBox.Location = new Point(73, 3);
            categoryCheckBox.Name = "categoryCheckBox";
            categoryCheckBox.Size = new Size(98, 19);
            categoryCheckBox.TabIndex = 1;
            categoryCheckBox.Text = "Categories";
            categoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerCheckBox
            // 
            customerCheckBox.AutoSize = true;
            customerCheckBox.Location = new Point(177, 3);
            customerCheckBox.Name = "customerCheckBox";
            customerCheckBox.Size = new Size(97, 19);
            customerCheckBox.TabIndex = 2;
            customerCheckBox.Text = "Customers";
            customerCheckBox.UseVisualStyleBackColor = true;
            // 
            // supplierCheckBox
            // 
            supplierCheckBox.AutoSize = true;
            supplierCheckBox.Location = new Point(3, 28);
            supplierCheckBox.Name = "supplierCheckBox";
            supplierCheckBox.Size = new Size(88, 19);
            supplierCheckBox.TabIndex = 3;
            supplierCheckBox.Text = "Suppliers";
            supplierCheckBox.UseVisualStyleBackColor = true;
            // 
            // projectCheckBox
            // 
            projectCheckBox.AutoSize = true;
            projectCheckBox.Location = new Point(97, 28);
            projectCheckBox.Name = "projectCheckBox";
            projectCheckBox.Size = new Size(81, 19);
            projectCheckBox.TabIndex = 4;
            projectCheckBox.Text = "Projects";
            projectCheckBox.UseVisualStyleBackColor = true;
            // 
            // userCheckBox
            // 
            userCheckBox.AutoSize = true;
            userCheckBox.Location = new Point(184, 28);
            userCheckBox.Name = "userCheckBox";
            userCheckBox.Size = new Size(64, 19);
            userCheckBox.TabIndex = 5;
            userCheckBox.Text = "Users";
            userCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsCheckBox
            // 
            settingsCheckBox.AutoSize = true;
            settingsCheckBox.Location = new Point(3, 53);
            settingsCheckBox.Name = "settingsCheckBox";
            settingsCheckBox.Size = new Size(80, 19);
            settingsCheckBox.TabIndex = 6;
            settingsCheckBox.Text = "Settings";
            settingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // systemLogCheckBox
            // 
            systemLogCheckBox.AutoSize = true;
            systemLogCheckBox.Location = new Point(89, 53);
            systemLogCheckBox.Name = "systemLogCheckBox";
            systemLogCheckBox.Size = new Size(101, 19);
            systemLogCheckBox.TabIndex = 7;
            systemLogCheckBox.Text = "System Log";
            systemLogCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(385, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 93);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quick Access";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(categoryAccessCheckBox);
            flowLayoutPanel2.Controls.Add(supplierAccessCheckBox);
            flowLayoutPanel2.Controls.Add(customerAccessCheckBox);
            flowLayoutPanel2.Controls.Add(projectAccessCheckBox);
            flowLayoutPanel2.Controls.Add(userAccessCheckBox);
            flowLayoutPanel2.Controls.Add(incomeAccessCheckBox);
            flowLayoutPanel2.Controls.Add(outcomeAccessCheckBox);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(275, 71);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // categoryAccessCheckBox
            // 
            categoryAccessCheckBox.AutoSize = true;
            categoryAccessCheckBox.Location = new Point(3, 3);
            categoryAccessCheckBox.Name = "categoryAccessCheckBox";
            categoryAccessCheckBox.Size = new Size(86, 19);
            categoryAccessCheckBox.TabIndex = 1;
            categoryAccessCheckBox.Text = "Category";
            categoryAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // supplierAccessCheckBox
            // 
            supplierAccessCheckBox.AutoSize = true;
            supplierAccessCheckBox.Location = new Point(95, 3);
            supplierAccessCheckBox.Name = "supplierAccessCheckBox";
            supplierAccessCheckBox.Size = new Size(81, 19);
            supplierAccessCheckBox.TabIndex = 3;
            supplierAccessCheckBox.Text = "Supplier";
            supplierAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerAccessCheckBox
            // 
            customerAccessCheckBox.AutoSize = true;
            customerAccessCheckBox.Location = new Point(182, 3);
            customerAccessCheckBox.Name = "customerAccessCheckBox";
            customerAccessCheckBox.Size = new Size(90, 19);
            customerAccessCheckBox.TabIndex = 2;
            customerAccessCheckBox.Text = "Customer";
            customerAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // projectAccessCheckBox
            // 
            projectAccessCheckBox.AutoSize = true;
            projectAccessCheckBox.Location = new Point(3, 28);
            projectAccessCheckBox.Name = "projectAccessCheckBox";
            projectAccessCheckBox.Size = new Size(74, 19);
            projectAccessCheckBox.TabIndex = 4;
            projectAccessCheckBox.Text = "Project";
            projectAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // userAccessCheckBox
            // 
            userAccessCheckBox.AutoSize = true;
            userAccessCheckBox.Location = new Point(83, 28);
            userAccessCheckBox.Name = "userAccessCheckBox";
            userAccessCheckBox.Size = new Size(57, 19);
            userAccessCheckBox.TabIndex = 9;
            userAccessCheckBox.Text = "User";
            userAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // incomeAccessCheckBox
            // 
            incomeAccessCheckBox.AutoSize = true;
            incomeAccessCheckBox.Location = new Point(146, 28);
            incomeAccessCheckBox.Name = "incomeAccessCheckBox";
            incomeAccessCheckBox.Size = new Size(74, 19);
            incomeAccessCheckBox.TabIndex = 7;
            incomeAccessCheckBox.Text = "Income";
            incomeAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // outcomeAccessCheckBox
            // 
            outcomeAccessCheckBox.AutoSize = true;
            outcomeAccessCheckBox.Location = new Point(3, 53);
            outcomeAccessCheckBox.Name = "outcomeAccessCheckBox";
            outcomeAccessCheckBox.Size = new Size(85, 19);
            outcomeAccessCheckBox.TabIndex = 8;
            outcomeAccessCheckBox.Text = "Outcome";
            outcomeAccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(flowLayoutPanel3);
            groupBox4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(391, 315);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(278, 93);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Standard Operations";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(addCheckBox);
            flowLayoutPanel3.Controls.Add(deleteCheckBox);
            flowLayoutPanel3.Controls.Add(editCheckBox);
            flowLayoutPanel3.Controls.Add(exportCheckBox);
            flowLayoutPanel3.Controls.Add(searchCheckBox);
            flowLayoutPanel3.Controls.Add(openCheckBox);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(272, 71);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // addCheckBox
            // 
            addCheckBox.AutoSize = true;
            addCheckBox.Location = new Point(3, 3);
            addCheckBox.Name = "addCheckBox";
            addCheckBox.Size = new Size(51, 19);
            addCheckBox.TabIndex = 0;
            addCheckBox.Text = "Add";
            addCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteCheckBox
            // 
            deleteCheckBox.AutoSize = true;
            deleteCheckBox.Location = new Point(60, 3);
            deleteCheckBox.Name = "deleteCheckBox";
            deleteCheckBox.Size = new Size(69, 19);
            deleteCheckBox.TabIndex = 1;
            deleteCheckBox.Text = "Delete";
            deleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // editCheckBox
            // 
            editCheckBox.AutoSize = true;
            editCheckBox.Location = new Point(135, 3);
            editCheckBox.Name = "editCheckBox";
            editCheckBox.Size = new Size(52, 19);
            editCheckBox.TabIndex = 2;
            editCheckBox.Text = "Edit";
            editCheckBox.UseVisualStyleBackColor = true;
            // 
            // exportCheckBox
            // 
            exportCheckBox.AutoSize = true;
            exportCheckBox.Location = new Point(193, 3);
            exportCheckBox.Name = "exportCheckBox";
            exportCheckBox.Size = new Size(69, 19);
            exportCheckBox.TabIndex = 3;
            exportCheckBox.Text = "Export";
            exportCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchCheckBox
            // 
            searchCheckBox.AutoSize = true;
            searchCheckBox.Location = new Point(3, 28);
            searchCheckBox.Name = "searchCheckBox";
            searchCheckBox.Size = new Size(73, 19);
            searchCheckBox.TabIndex = 4;
            searchCheckBox.Text = "Search";
            searchCheckBox.UseVisualStyleBackColor = true;
            // 
            // openCheckBox
            // 
            openCheckBox.AutoSize = true;
            openCheckBox.Location = new Point(82, 28);
            openCheckBox.Name = "openCheckBox";
            openCheckBox.Size = new Size(60, 19);
            openCheckBox.TabIndex = 5;
            openCheckBox.Text = "Open";
            openCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddAndEditUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 493);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAndEditUserForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit User";
            TopMost = true;
            FormClosed += AddAndEditUserForm_FormClosed;
            Load += AddAndEditUserForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox phoneTextBox;
        private Label label10;
        private TextBox emailTextBox;
        private Label label8;
        private Label label4;
        private TextBox passwordTextBox;
        private Label label6;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox homeCheckBox;
        private CheckBox categoryCheckBox;
        private CheckBox customerCheckBox;
        private CheckBox supplierCheckBox;
        private CheckBox projectCheckBox;
        private CheckBox userCheckBox;
        private CheckBox settingsCheckBox;
        private CheckBox systemLogCheckBox;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox homeAccessCheckBox;
        private CheckBox categoryAccessCheckBox;
        private CheckBox customerAccessCheckBox;
        private CheckBox supplierAccessCheckBox;
        private CheckBox projectAccessCheckBox;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox addCheckBox;
        private CheckBox deleteCheckBox;
        private CheckBox editCheckBox;
        private CheckBox exportCheckBox;
        private CheckBox searchCheckBox;
        private CheckBox openCheckBox;
        private Label label11;
        private CheckBox incomeAccessCheckBox;
        private CheckBox outcomeAccessCheckBox;
        private CheckBox userAccessCheckBox;
    }
}