namespace ExpensesTracker.GUI.NotificationGUI
{
    partial class NotificationForm
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            DescriptionLabel = new Label();
            notificationTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImage = Properties.Resources.Notification;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.CadetBlue;
            DescriptionLabel.Dock = DockStyle.Fill;
            DescriptionLabel.ForeColor = Color.White;
            DescriptionLabel.Location = new Point(66, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(318, 63);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Notification Discription";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            DescriptionLabel.Click += DescriptionLabel_Click;
            // 
            // notificationTimer
            // 
            notificationTimer.Enabled = true;
            notificationTimer.Interval = 2000;
            notificationTimer.Tick += notificationTimer_Tick;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 63);
            Controls.Add(DescriptionLabel);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "NotificationForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "NotificationForm";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        public Label DescriptionLabel;
        private System.Windows.Forms.Timer notificationTimer;
    }
}