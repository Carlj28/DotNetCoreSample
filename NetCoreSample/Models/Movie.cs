using System;

namespace NetCoreSample.Models
{
    //Fake entity model
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfRelease { get; set; }
        public string Genre { get; set; }
    }
}
