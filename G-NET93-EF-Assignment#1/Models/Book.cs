using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_1.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public bool InStock { get; set; }

     }
}
