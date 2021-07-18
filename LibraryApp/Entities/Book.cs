using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Entities
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public int? PageNumber { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public DateTime? PublishTime { get; set; }
        public int? Quantity { get; set; }

    }
}
