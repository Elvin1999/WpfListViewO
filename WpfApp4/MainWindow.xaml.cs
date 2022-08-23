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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Richter",
                Genre="Fun",
                Pages=1100,
                Publisher="Baku",
                Title="C# via CLR",
                ImagePath="images/img1.jpg"
            },
            new Book
            {
                Id=2,
                Author="Exupery",
                Genre="Not so Fun",
                Pages=650,
                Publisher="Baku",
                Title="Little Prince",
                ImagePath="images/img2.jpg"
            },
            new Book
            {
                Id=3,
                Author="GOF",
                Genre="Very Fun",
                Pages=700,
                Publisher="Baku",
                Title="Design Pattern Principles",
                ImagePath="images/img3.jpg"
            },
        };
        public MainWindow()
        {
            InitializeComponent();
            ////listview.ItemsSource = Books;
            ///

            this.DataContext = this;
        }

        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var book=listview.SelectedItem as Book;
            //MessageBox.Show(book.Title);
        }
    }
}
