using MongoDB.Bson;

namespace Library
{
    public class Page
    {
        public ObjectId Id { get; set; }
        public string Content { get; set; }
    }
}