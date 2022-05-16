using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataStructureProject
{
    internal class ProcessBooksData
    {
        public static Stack<Book> ComputerScienceBooks()
        {
            Stack<Book> computerScienceBooks = new();

            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Computer Science"))
                {
                    computerScienceBooks.Push(book);
                }
            }
            return computerScienceBooks;
        }
        public static Stack<Book> NetworkingBooks()
        {
            Stack<Book> networkingBooks = new();

            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Networking"))
                {
                    networkingBooks.Push(book);
                }
            }
            return networkingBooks;
        }
        public static Stack<Book> MathematicsBooks()
        {
            Stack<Book> mathematicBooks = new();

            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Mathematics"))
                {
                    mathematicBooks.Push(book);
                }
            }
            return mathematicBooks;
        }
        public static Stack<Book> SoftwareDevelopmentBooks()
        {
            Stack<Book> softwareDevelopmentBooks = new();

            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Software Development"))
                {
                    softwareDevelopmentBooks.Push(book);
                }
            }
            return softwareDevelopmentBooks;
        }

        public static bool inputvalidation(TextBox[] textboxes)
        {
            /*
             * Checking that none of the textbox is empty
             */
            bool isEmpty = false;
            foreach (var textbox in textboxes)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }
            }
            return isEmpty;
        }

        public static void SaveNewBook(string book)
        {
            if(string.IsNullOrEmpty(book))
            {
                throw new Exception("Invaild Information.\nPlease provide all reaquired Information to save the book");
            }
            else
            {
                string filepath = "D:\\VisualStudio\\DataStructureProject\\DataStructureProject\\bin\\Debug\\net6.0-windows\\Data.txt";
                List<string> lines = File.ReadAllLines(filepath).ToList();
                lines.Add(book);
                File.WriteAllLines(filepath, lines);
            }
        }
    }
}
