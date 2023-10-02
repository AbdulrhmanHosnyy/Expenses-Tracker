using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.GUI.NotificationGUI
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()  
        {
            InitializeComponent();
            notificationTimer.Interval = Properties.Settings.Default.HideNotificationInterval * 1000;
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
