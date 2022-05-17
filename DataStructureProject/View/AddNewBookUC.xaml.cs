using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AddNewBookUC.xaml
    /// </summary>
    public partial class AddNewBookUC : UserControl
    {
        public AddNewBookUC()
        {
            InitializeComponent();
            yearComboBox.ItemsSource = Enumerable.Range(1991, DateTime.UtcNow.Year - 1991).Reverse().ToList();            
            conditionLabel.Content = ProcessBooksData.AddingBookNewConditionString();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] textboxes = { authorNameTextBox, bookNameTextBox, publisherTextBox};
            if (ProcessBooksData.inputvalidation(textboxes) || isbnTextBox.Text == null 
                || string.IsNullOrEmpty(yearComboBox.Text) || string.IsNullOrEmpty(categoryComboBox.Text)) 
            {
                MessageBox.Show("Please provide all the required information to save book data");
            }
            else
            {
                int ISBN = int.Parse(isbnTextBox.Text);
                string authorName = authorNameTextBox.Text;
                string bookName = bookNameTextBox.Text;
                string publisher = publisherTextBox.Text;
                int releasedYear = int.Parse(yearComboBox.Text);
                string category = categoryComboBox.Text;

                string bookInfo = ISBN.ToString() + "," + authorName + "," + bookName + ","+ publisher + "," + releasedYear.ToString() + "," + category;
                ProcessBooksData.SaveNewBook(bookInfo);
                MessageBox.Show("Given Book Information has been Saved Successfully.");
            }
        }
    }
}
