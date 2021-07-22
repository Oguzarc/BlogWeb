using System;

namespace BlogWeb.entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Summary { get; set; }
        public string  Text { get; set; }
        public string CategoryName { get; set; }
    }
}
