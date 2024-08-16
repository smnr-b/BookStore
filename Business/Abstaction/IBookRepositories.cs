using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTOs;
using DataAccess.Entities;

namespace Business.Abstaction
{
    public interface IBookRepositories
    {
        List<BookDTO> GetAll();
        List<BookDTO> GetByISBN(int isbn);
        List<BookDTO> GetByAuthor(string author);
        List<BookDTO> GetByTitle(string title);
        List<BookDTO> GetByPrice(string pricevalue);
    }
}
