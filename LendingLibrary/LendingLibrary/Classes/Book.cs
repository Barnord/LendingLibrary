using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public Book() { }
        public Book(string firstName, string lastName, string title)
        {
            firstName = firstName;
            lastName = lastName;
            title = title;
        }
    }
}
