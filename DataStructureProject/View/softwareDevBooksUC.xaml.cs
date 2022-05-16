using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataStructureProject.View
{
    /// <summary>
    /// Interaction logic for softwareDevBooksUC.xaml
    /// </summary>
    public partial class softwareDevBooksUC : UserControl
    {
        public softwareDevBooksUC()
        {
            InitializeComponent();
            var books = ProcessBooksData.SoftwareDevelopmentBooks();
            if(books.Count == 0)
            {
                MessageBox.Show("This Category Doesnt have any books to show");
            }
            else
            {
                softwareBooksDataGrid.ItemsSource = books;
            }
        }
    }
}
