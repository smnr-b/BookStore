using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class BookDTO
    {
        public int isbnNumber { get; set; }
        public string titleName { get; set; }
        public string authorName { get; set; }
        public string priceValue {  get; set; }
    }
}
