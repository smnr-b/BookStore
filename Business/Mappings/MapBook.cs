using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTOs;
using DataAccess.Entities;

namespace Business.Mappings
{
    public class MapBook
    {
        public BookDTO mapSingleBook(Book entity)
        {
            BookDTO bookDTO = new BookDTO();
            bookDTO.isbnNumber = entity.ISBN;
            bookDTO.titleName = entity.title;
            bookDTO.authorName = entity.author;
            bookDTO.priceValue = entity.price.value.ToString();

            return bookDTO;
        }

        public List<BookDTO> mapBookList(List<Book> Entitys)
        {
            List<BookDTO> bookList = new List<BookDTO>();
            foreach(var entity in Entitys)
            {
                BookDTO bookDTO= new BookDTO();
                bookDTO.isbnNumber=entity.ISBN;
                bookDTO.titleName=entity.title;
                bookDTO.authorName=entity.author;
                bookDTO.priceValue=entity.price.value.ToString();

                bookList.Add(bookDTO);
            }
            return bookList;
        }
    }
}
