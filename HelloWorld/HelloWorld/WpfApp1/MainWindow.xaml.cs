using HelloWorld.Data;
using HelloWorld.Model;
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

namespace WpfApp1
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

        private void btnPersonDetail_Click(object sender, RoutedEventArgs e)
        {
            Person p = (Person)grdPeople.SelectedItem;
                        
            PersonDetail personDetail = new PersonDetail(p);
        
            personDetail.Show();

            //Test statické naplnění properties
            //Person p = new Person();
            //p.FirstName = "Pavel";
            //p.LastName = "Pekař";
            //p.DateofBirth = new DateTime(1973, 3, 7);

        }

        private void wMain_Loaded(object sender, RoutedEventArgs e)
        {
            var file = @"C:\Users\pes.PHA\source\repos\PeSul\NET6-1\HelloWorld\HelloWorld\HelloWorld\bin\Debug\net5.0";
            var filepath = System.IO.Path.Combine(file, "people.txt");

            var people = PersonData.LoadPeople(filepath); //test bez povinného parametru v PersonData.cs
            //PersonData.LoadPeople(filepath);

            grdPeople.ItemsSource = people;
        }
    }
}
