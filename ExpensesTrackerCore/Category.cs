using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerCore
{
    //[Table("Categories", Schema = "dbo")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; }
        public string Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }

        //  Navigations:
        public virtual List<Outcome> Outcomes { get; set; }
    }
}
