

using System;

namespace HTTPClientDEMO.Models
{
    public class BookDetail
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}