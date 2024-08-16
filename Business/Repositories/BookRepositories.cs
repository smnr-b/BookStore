using Business.Abstaction;
using Business.Mappings;
using DataAccess.DTOs;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Business.Repositories
{
    internal class BookRepositories : IBookRepositories
    {
        public List<BookDTO> GetAll()
        {
            string jsonData = File.ReadAllText("Bookdata.json");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            var dtoModel = new MapBook().mapBookList(books);
            return dtoModel;
        }

        public List<BookDTO> GetByAuthor(string author)
        {
            string jsonData = File.ReadAllText("Bookdata.json");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            var dtoModel = books.Where(x => x.author.Contains(author)).FirstOrDefault();
            var dtoMapping = new MapBook().mapBookList(books);
            return dtoMapping;
        }

        public List<BookDTO> GetByISBN(int isbn)
        {
            string jsonData = File.ReadAllText("Bookdata.json");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            var dtoMpdel = books.Where(x => x.ISBN==isbn).FirstOrDefault();
            var dtoMapping = new MapBook().mapBookList(books);
            return dtoMapping;
        }

        public List<BookDTO> GetByTitle(string title)
        {
            string jsonData = File.ReadAllText("Bookdata.json");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            var dtoModel= books.Where(x => x.title.Contains(title)).FirstOrDefault();
            var dtoMapping = new MapBook().mapBookList(books);
            return dtoMapping;
        }
        public List<BookDTO> GetByPrice(int price)
        {
            string jsonData = File.ReadAllText("Bookdata.json");
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonData);
            var dtoMpdel = books.Where(x => x.price.value == price).FirstOrDefault();
            var dtoMapping = new MapBook().mapBookList(books);
            return dtoMapping;
        }

        public List<BookDTO> GetByPrice(string pricevalue)
        {
            throw new NotImplementedException();
        }
    }
}
