﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OrderProcessing
{
    public class WorkOrder : Order
    {
        public string Vendor { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
