using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Entities
{
    public class Order : Entity
    {
        public string OrderNumber { get; set; }
        public int ProductId { get; set; }

    }
}
