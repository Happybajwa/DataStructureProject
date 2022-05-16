using DataStructureProject.View;
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

namespace DataStructureProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showAllBooksMenuItem_Click(object sender, RoutedEventArgs e)
        {
            showAllBooksUC showAllBooksUC = new();
            mainPanel.Children.Clear();
            mainPanel.Children.Add(showAllBooksUC);
        }

        private void softwareDevelopmentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            softwareDevBooksUC showSoftwareDevBooksUC = new softwareDevBooksUC();
            mainPanel.Children.Clear();
            mainPanel.Children.Add((showSoftwareDevBooksUC));
        }

        private void computerScienceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ComputerScienceBooksUC showComputerScienceBooksUC = new ComputerScienceBooksUC();
            mainPanel.Children.Clear();
            mainPanel.Children.Add(showComputerScienceBooksUC);
        }

        private void mathmeticsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MathematicsBooksUC showMathematicsUC = new MathematicsBooksUC();
            mainPanel.Children.Clear();
            mainPanel.Children.Add(showMathematicsUC);
        }

        private void networkingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            NetworkingBooksUC networkingBooksUC = new NetworkingBooksUC();
            mainPanel.Children.Clear();
            mainPanel.Children.Add(networkingBooksUC);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addNewBookMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddNewBookUC addNewBookUC = new AddNewBookUC();
            mainPanel.Children.Clear();
            mainPanel.Children.Add(addNewBookUC);
        }
    }
}
