using ExpensesTracker.GUI.NotificationGUI;
using ExpensesTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.Code
{
    public static class MessageCollection
    {
        //  Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public static void ShowServerError()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public static void ShowFieldsRequired()
        {
            MessageBox.Show(Resources.FieldRequiredText, Resources.FieldRequiredCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void ShowRequiredDeleteRow()
        {
            MessageBox.Show(Resources.ShowRequiredDeleteRowText, Resources.ShowRequiredDeleteRowCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //  Dialog
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  Notification

        public static void ShowAddNotification()
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.DescriptionLabel.Text = "Added Successfully";
            notificationForm.Show();
        }

        public static void ShowUpdateNotification()
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.DescriptionLabel.Text = "Edited Successfully";
            notificationForm.Show();
        }

        public static void ShowDeleteNotification()
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.DescriptionLabel.Text = "Deleted Successfully";
            notificationForm.Show();
        }
         
    }
}
