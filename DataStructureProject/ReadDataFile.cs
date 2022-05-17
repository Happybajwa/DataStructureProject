using DataStructureProject.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    internal class ReadDataFile
    {
        public static void readBook()
        {
            StreamReader reader = new StreamReader("Data.txt");
            string lines = "";
            while ((lines = reader.ReadLine()) != null)
            {
                string[] words = lines.Split(",");
                Book book= new();
                book.ISBN = int.Parse(words[0]);
                book.AuthorName = words[1];
                book.BookName = words[2];
                book.Publisher = words[3];
                book.ReleasedYear = int.Parse(words[4]);
                book.Category = words[5];
                /* 
                 * Checking that all conditions and policies are met when adding a book in queue
                 * The library management has decided to keep the books that have been published after 1990 and belong to 
                 * one of the following categories:
                 * 1. Computer Science
                 * 2. Networking
                 * 3. Mathematics
                 * 4. Software Development
                 */

                if (book.ReleasedYear > 1990 && book.Category.Equals("Software Development") || 
                   book.Category.Equals("Networking") || book.Category.Equals("Mathematics") || 
                   book.Category.Equals("Computer Science"))
                {                
                    BookDataStructure.books.Enqueue(book);
                }
            }
        }
    }
}
