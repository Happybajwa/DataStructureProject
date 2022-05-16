using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public int ReleasedYear { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return ISBN + ", " + AuthorName + ", " + BookName + ", " + Publisher + ", " + ReleasedYear + ", " + Category;
        }
    }
}
