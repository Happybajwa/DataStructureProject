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
    /// Interaction logic for showAllBooksUC.xaml
    /// </summary>
    public partial class showAllBooksUC : UserControl
    {
        public showAllBooksUC()
        {
            InitializeComponent();
        }

        private void showAllBooksButton_Click(object sender, RoutedEventArgs e)
        {
            bookDataGrid.ItemsSource = null;
            var books = BookDataStructure.books;
            if (books.Count == 0)
            {
                //Checking that book list is not empty iof its empty will show error message to user
                MessageBox.Show("No Books To Show.");
            }
            else
            {    
                bookDataGrid.ItemsSource = books;
            }
        }
    }
}
