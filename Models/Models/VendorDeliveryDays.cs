﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class VendorDeliveryDays
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public bool ECOFriendly { get; set; }
        public string MaterialName { get; set; }
        public int MaterialPrice { get; set; }
        public int DeliveryTimeDays { get; set; }
    }
}
