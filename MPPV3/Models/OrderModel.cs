using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MPPV3.Models;

namespace MPPV3.Models
{
    public class OrderModel
    {
        public string product { get; set; }
        public string country { get; set; }
        public int mass { get; set; }
    }
}