using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Entities
{
    public class Customer : Entity
    {
        public string Fullname { get; set; }
        public List<Order> Orders { get; set; }

    }
}
