using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; } = new List<Page>();
    }
}
