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
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetail.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {
        Person person;
        MainWindow mainWindow;
        bool isNewPerson = false;

        public PersonDetail(Person _person, MainWindow _mainWindow,bool _isNewPerson)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            isNewPerson = _isNewPerson;

            if(isNewPerson)
                person = new Person();
            else

            person = _person;


            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtDateofBirth.Text = person.DateofBirth.ToShortDateString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;

            if(isNewPerson)
                DataAccess.AddPerson(person);
            else
                DataAccess.SavePerson(person);

            DataAccess.LoadPeopleFromDb();
            mainWindow.grdPeople.ItemsSource = DataAccess.people;
            Close();
        }
    }
}
