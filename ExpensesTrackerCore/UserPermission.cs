﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerCore
{
    public class UserPermission
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool Value { get; set; }

        //  Navigation
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
