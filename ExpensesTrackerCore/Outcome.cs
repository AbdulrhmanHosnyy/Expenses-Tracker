using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerCore
{
    public class Outcome
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public DateTime OutcomeDate { get; set; }
        public string ReceiptNumber { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }

        //  Navigations:
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier{ get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
