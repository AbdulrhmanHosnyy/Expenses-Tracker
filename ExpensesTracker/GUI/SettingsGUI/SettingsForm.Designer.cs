namespace ExpensesTracker.GUI.SettingsGUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            groupBox1 = new GroupBox();
            saveGenralSettingsButton = new Button();
            uploadLinkLabel = new LinkLabel();
            logoPictureBox = new PictureBox();
            label4 = new Label();
            dataRowNumericUpDown = new NumericUpDown();
            notificationNumericUpDown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            companyTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            saveConnectionStringButton = new Button();
            passwordTextBox = new TextBox();
            label9 = new Label();
            usernameTextBox = new TextBox();
            label8 = new Label();
            timeOutNumericUpDown = new NumericUpDown();
            label7 = new Label();
            databaseTextBox = new TextBox();
            label6 = new Label();
            serverTextBox = new TextBox();
            label5 = new Label();
            networkConnectionRadioButton = new RadioButton();
            localConnectionRadioButton = new RadioButton();
            groupBox3 = new GroupBox();
            restoreButton = new Button();
            backUpButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataRowNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notificationNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeOutNumericUpDown).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveGenralSettingsButton);
            groupBox1.Controls.Add(uploadLinkLabel);
            groupBox1.Controls.Add(logoPictureBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataRowNumericUpDown);
            groupBox1.Controls.Add(notificationNumericUpDown);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(companyTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 434);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " General Settings";
            // 
            // saveGenralSettingsButton
            // 
            saveGenralSettingsButton.Image = Properties.Resources.Save;
            saveGenralSettingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveGenralSettingsButton.Location = new Point(8, 380);
            saveGenralSettingsButton.Margin = new Padding(5);
            saveGenralSettingsButton.Name = "saveGenralSettingsButton";
            saveGenralSettingsButton.Size = new Size(275, 46);
            saveGenralSettingsButton.TabIndex = 10;
            saveGenralSettingsButton.Text = "Save";
            saveGenralSettingsButton.TextAlign = ContentAlignment.MiddleRight;
            saveGenralSettingsButton.UseVisualStyleBackColor = true;
            saveGenralSettingsButton.Click += saveGenralSettingsButton_Click;
            // 
            // uploadLinkLabel
            // 
            uploadLinkLabel.AutoSize = true;
            uploadLinkLabel.Location = new Point(195, 328);
            uploadLinkLabel.Name = "uploadLinkLabel";
            uploadLinkLabel.Size = new Size(64, 18);
            uploadLinkLabel.TabIndex = 9;
            uploadLinkLabel.TabStop = true;
            uploadLinkLabel.Text = "Upload";
            uploadLinkLabel.LinkClicked += uploadLinkLabel_LinkClicked;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(82, 207);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(177, 118);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 8;
            logoPictureBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 207);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Logo";
            // 
            // dataRowNumericUpDown
            // 
            dataRowNumericUpDown.Location = new Point(211, 149);
            dataRowNumericUpDown.Margin = new Padding(6, 5, 6, 5);
            dataRowNumericUpDown.Name = "dataRowNumericUpDown";
            dataRowNumericUpDown.Size = new Size(72, 26);
            dataRowNumericUpDown.TabIndex = 6;
            dataRowNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // notificationNumericUpDown
            // 
            notificationNumericUpDown.Location = new Point(211, 98);
            notificationNumericUpDown.Margin = new Padding(4);
            notificationNumericUpDown.Name = "notificationNumericUpDown";
            notificationNumericUpDown.Size = new Size(72, 26);
            notificationNumericUpDown.TabIndex = 5;
            notificationNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 4;
            label3.Text = "Number Of Data Displayed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 2;
            label2.Text = "Hide Notification Interval";
            // 
            // companyTextBox
            // 
            companyTextBox.Location = new Point(101, 41);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.Size = new Size(182, 26);
            companyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(328, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 434);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = " Database Settings";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(saveConnectionStringButton);
            groupBox4.Controls.Add(passwordTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(usernameTextBox);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(timeOutNumericUpDown);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(databaseTextBox);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(serverTextBox);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(networkConnectionRadioButton);
            groupBox4.Controls.Add(localConnectionRadioButton);
            groupBox4.Location = new Point(6, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(315, 322);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Connection text";
            // 
            // saveConnectionStringButton
            // 
            saveConnectionStringButton.Image = Properties.Resources.Save;
            saveConnectionStringButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveConnectionStringButton.Location = new Point(23, 263);
            saveConnectionStringButton.Margin = new Padding(5);
            saveConnectionStringButton.Name = "saveConnectionStringButton";
            saveConnectionStringButton.Size = new Size(275, 48);
            saveConnectionStringButton.TabIndex = 11;
            saveConnectionStringButton.Text = "Save";
            saveConnectionStringButton.TextAlign = ContentAlignment.MiddleRight;
            saveConnectionStringButton.UseVisualStyleBackColor = true;
            saveConnectionStringButton.Click += saveConnectionStringButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Enabled = false;
            passwordTextBox.Location = new Point(96, 232);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(213, 23);
            passwordTextBox.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 238);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 18;
            label9.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Enabled = false;
            usernameTextBox.Location = new Point(96, 193);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(213, 23);
            usernameTextBox.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 199);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 16;
            label8.Text = "Username";
            // 
            // timeOutNumericUpDown
            // 
            timeOutNumericUpDown.Enabled = false;
            timeOutNumericUpDown.Location = new Point(146, 152);
            timeOutNumericUpDown.Margin = new Padding(4);
            timeOutNumericUpDown.Name = "timeOutNumericUpDown";
            timeOutNumericUpDown.Size = new Size(161, 23);
            timeOutNumericUpDown.TabIndex = 11;
            timeOutNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 154);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 15;
            label7.Text = "Connection Period";
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(94, 102);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(213, 23);
            databaseTextBox.TabIndex = 14;
            databaseTextBox.Text = "ExpensesTracker";
            databaseTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 108);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 13;
            label6.Text = "Database";
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(94, 60);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(213, 23);
            serverTextBox.TabIndex = 12;
            serverTextBox.Text = ".\\\\SQLEXPRESS";
            serverTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 66);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Server";
            // 
            // networkConnectionRadioButton
            // 
            networkConnectionRadioButton.AutoSize = true;
            networkConnectionRadioButton.Location = new Point(152, 26);
            networkConnectionRadioButton.Name = "networkConnectionRadioButton";
            networkConnectionRadioButton.Size = new Size(158, 19);
            networkConnectionRadioButton.TabIndex = 1;
            networkConnectionRadioButton.Text = "Network Connection";
            networkConnectionRadioButton.UseVisualStyleBackColor = true;
            networkConnectionRadioButton.CheckedChanged += networkConnectionRadioButton_CheckedChanged;
            // 
            // localConnectionRadioButton
            // 
            localConnectionRadioButton.AutoSize = true;
            localConnectionRadioButton.Checked = true;
            localConnectionRadioButton.Location = new Point(8, 26);
            localConnectionRadioButton.Name = "localConnectionRadioButton";
            localConnectionRadioButton.Size = new Size(139, 19);
            localConnectionRadioButton.TabIndex = 0;
            localConnectionRadioButton.TabStop = true;
            localConnectionRadioButton.Text = "Local Connection";
            localConnectionRadioButton.UseVisualStyleBackColor = true;
            localConnectionRadioButton.CheckedChanged += localConnectionRadioButton_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.CadetBlue;
            groupBox3.Controls.Add(restoreButton);
            groupBox3.Controls.Add(backUpButton);
            groupBox3.Location = new Point(6, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 76);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Backup and Assignment";
            // 
            // restoreButton
            // 
            restoreButton.Image = Properties.Resources.Update;
            restoreButton.ImageAlign = ContentAlignment.MiddleLeft;
            restoreButton.Location = new Point(165, 24);
            restoreButton.Margin = new Padding(5);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(142, 46);
            restoreButton.TabIndex = 12;
            restoreButton.Text = "Restore";
            restoreButton.TextAlign = ContentAlignment.MiddleRight;
            restoreButton.UseVisualStyleBackColor = true;
            restoreButton.Click += restoreButton_Click;
            // 
            // backUpButton
            // 
            backUpButton.Image = Properties.Resources.Export;
            backUpButton.ImageAlign = ContentAlignment.MiddleLeft;
            backUpButton.Location = new Point(8, 24);
            backUpButton.Margin = new Padding(5);
            backUpButton.Name = "backUpButton";
            backUpButton.Size = new Size(142, 46);
            backUpButton.TabIndex = 11;
            backUpButton.Text = "Backup";
            backUpButton.TextAlign = ContentAlignment.MiddleRight;
            backUpButton.UseVisualStyleBackColor = true;
            backUpButton.Click += backUpButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 458);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System Settings";
            FormClosing += SettingsForm_FormClosing;
            FormClosed += SettingsForm_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataRowNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)notificationNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeOutNumericUpDown).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox companyTextBox;
        private Label label1;
        private PictureBox logoPictureBox;
        private Label label4;
        private NumericUpDown dataRowNumericUpDown;
        private NumericUpDown notificationNumericUpDown;
        private Label label3;
        private LinkLabel uploadLinkLabel;
        private Button saveGenralSettingsButton;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button saveConnectionStringButton;
        private TextBox passwordTextBox;
        private Label label9;
        private TextBox usernameTextBox;
        private Label label8;
        private NumericUpDown timeOutNumericUpDown;
        private Label label7;
        private TextBox databaseTextBox;
        private Label label6;
        private TextBox serverTextBox;
        private Label label5;
        private RadioButton networkConnectionRadioButton;
        private RadioButton localConnectionRadioButton;
        private GroupBox groupBox3;
        private Button restoreButton;
        private Button backUpButton;
    }
}