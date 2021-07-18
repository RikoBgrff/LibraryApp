using LibraryApp.Entities;
using LibraryApp.ViewModels;
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

namespace LibraryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Book> items = new List<Book>();
            items.Add(new Book() { Name = "Art və Xaos", BookAuthor = "Qaraqan", BookPublisher = "Libraff", Quantity = 100, PublishTime = new DateTime(2019, 01, 07) });
            items.Add(new Book() { Name = "Art və Xaos", BookAuthor = "Qaraqan", BookPublisher = "Libraff", Quantity = 100, PublishTime = new DateTime(2019, 01, 07) });
            items.Add(new Book() { Name = "Art və Xaos", BookAuthor = "Qaraqan", BookPublisher = "Libraff", Quantity = 100, PublishTime = new DateTime(2019, 01, 07) });
            BookListView.ItemsSource = items;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void LibraryLVI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
        }
        private void HomeLVI_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
        }
        private void LibraryBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Visibility = Visibility.Visible;
        }

    }
}