namespace ExpensesTracker.GUI.UserGUI
{
    partial class UserLogInForm
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
            logInButton = new Button();
            groupBox1 = new GroupBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            passwordTextBox = new TextBox();
            label6 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(logInButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 60);
            panel1.TabIndex = 0;
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.Image = Properties.Resources.Access;
            logInButton.ImageAlign = ContentAlignment.MiddleLeft;
            logInButton.Location = new Point(5, 5);
            logInButton.Margin = new Padding(5);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(377, 54);
            logInButton.TabIndex = 3;
            logInButton.Text = "Login";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += saveAndCloseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 349);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.CadetBlue;
            label11.Location = new Point(94, 157);
            label11.Name = "label11";
            label11.Size = new Size(161, 32);
            label11.TabIndex = 24;
            label11.Text = "Welcome!!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User;
            pictureBox1.Location = new Point(94, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(109, 296);
            label4.Name = "label4";
            label4.Size = new Size(15, 18);
            label4.TabIndex = 16;
            label4.Text = "*";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(134, 296);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 26);
            passwordTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 296);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(109, 257);
            label2.Name = "label2";
            label2.Size = new Size(15, 18);
            label2.TabIndex = 13;
            label2.Text = "*";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(134, 257);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(216, 26);
            usernameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 257);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // UserLogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(387, 439);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLogInForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn ";
            FormClosed += UserLogInForm_FormClosed;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logInButton;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox passwordTextBox;
        private Label label6;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private CheckBox homeAccessCheckBox;
        private Label label11;
    }
}