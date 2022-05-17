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
        //returning a stack of computer science books from BookDataStructure class
        //or we can say our main list where we adding books from text file
        //by checking the book category and if category is
        //computer science so we will add that book in newly defined stack of books
        //in the function and return it on request
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

        //returning a stack of Networking books from Queue of books from BookDataStructure class
        //or we can say our main list where we adding books from text file
        //by checking the book category and if category is
        //networking so we will add that book in newly defined stack of books
        //in the function and return it on request
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

        //returning a stack of Mathematics books from Queue of books from BookDataStructure class
        //or we can say our main list where we adding books from text file
        //by checking the book category and if category is
        //Mathematics so we will add that book in newly defined stack of books
        //in the function and return it on request
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

        //returning a stack of Software Development books from Queue of books from BookDataStructure class
        //or we can say our main list where we adding books from text file
        //by checking the book category and if category is
        //Software Development so we will add that book in newly defined stack of books
        //in the function and return it on request
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
             * Checking that none of the textbox is empty or null
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

        //Adding new book in the text file
        //before adding new book in the system we are checking that
        //book passed in parameter is not null
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

        //returning the string for the warning label 
        //for addnewbook form.
        public static string AddingBookNewConditionString()
        {
            string condition = "Note: The library management has decided to keep the books\n that have been published" +
                " after 1990 and belong to one of the\n following categories:\n1.Computer Science\n2.Networking" +
                "\n3.Mathematics\n4.Software Development";
            return condition;
        }
    }
}
