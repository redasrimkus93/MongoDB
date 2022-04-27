using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BooksRepository
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoCollection<Book> _booksCollection;

        public BooksRepository()
        {
            _mongoClient = new MongoDBClientInitializor().GetMongoClient();
            _booksCollection = GetBooksCollection();
        }

        public void AddBook(Book book)
        {
            _booksCollection.InsertOne(book);
        }

        public void DeleteBook(string name)
        {
            var filter = Builders<Book>.Filter.Eq("Name", name);
            _booksCollection.DeleteOne(filter);
        }

        private IMongoCollection<Book> GetBooksCollection()
        {
            return _mongoClient.GetDatabase("Library").GetCollection<Book>("Books");
        } 














    }
}
