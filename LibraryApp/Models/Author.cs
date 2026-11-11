using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public virtual List<Book> Books { get; set; } = [];
        public override string ToString()
        {
            return $"{LastName} {FirstName} ({BirthYear})";
        }

    }
}
