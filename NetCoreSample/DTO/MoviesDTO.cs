using System;
using System.Collections.Generic;

namespace NetCoreSample.DTO
{
    //Fake dto model
    public class MoviesDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfRelease { get; set; }
        public string Genre { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }
}
