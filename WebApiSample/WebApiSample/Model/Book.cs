﻿namespace WebApiSample.Model
{
    public class Book
    {
        public int BookID {  get; set; }
        public string Title { get; set; }
        public int PageCount {  get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN {  get; set; }
    }
}
