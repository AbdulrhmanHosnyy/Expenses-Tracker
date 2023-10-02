using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerCore
{
    public class SystemRecord
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
