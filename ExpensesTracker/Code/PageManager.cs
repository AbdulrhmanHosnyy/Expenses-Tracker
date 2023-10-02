using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.Code
{
    public class PageManager
    {
        private readonly Main main;
        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //  Load old page
            var oldPage = main.containerPanel.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.containerPanel.Controls.Remove(oldPage);
                oldPage.Dispose();
            }

            //  Load new page
            PageUserControl.Dock = DockStyle.Fill;
            main.containerPanel.Controls.Add(PageUserControl);
        }
    }
}
