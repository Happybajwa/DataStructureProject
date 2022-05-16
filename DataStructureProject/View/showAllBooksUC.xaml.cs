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
            bookDataGrid.Items.Clear();
            var books = ReadDataFile.readBook();
            if (books.Count == 0)
            {
                MessageBox.Show("No Books To Show.");
            }
            else
            {    
                bookDataGrid.ItemsSource = books;
            }
        }
    }
}
