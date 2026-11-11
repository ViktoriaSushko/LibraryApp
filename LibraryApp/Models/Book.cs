using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable{ get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public virtual Author? Author { get; set; }
        public virtual Genre? Genre { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Author?.LastName} {Author?.FirstName}, {Genre?.Name}, {PublishYear},{Pages} pages,{(IsAvailable?"доступна":"видана")}";
        }
    }
}
