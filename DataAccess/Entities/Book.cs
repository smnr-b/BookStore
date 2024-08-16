using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Book
    {
        public int ISBN { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string summary { get; set; }
        public string image { get; set; }
        public Price price { get; set; }

        public class Price 
        {
            public string currency { get; set; }
            public int value { get; set; }
            public string displayValue { get; set; }
        }
    }
    
}
