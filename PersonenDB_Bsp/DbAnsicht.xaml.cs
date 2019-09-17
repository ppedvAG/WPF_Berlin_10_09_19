using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PersonenDB_Bsp
{
    /// <summary>
    /// Interaction logic for DbAnsicht.xaml
    /// </summary>
    public partial class DbAnsicht : Window
    {
        public ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>();

        public DbAnsicht()
        {
            InitializeComponent();

            Personenliste.Add(new Person() { Vorname = "Otto", Nachname = "Meier", Geburtsdatum = new DateTime(2002, 5, 12), Verheiratet = true, Lieblingsfarbe = Colors.Blue, Geschlecht = Gender.Männlich });
            Personenliste.Add(new Person() { Vorname = "Jürgen", Nachname = "Müller", Geburtsdatum = new DateTime(2002, 5, 12), Verheiratet = true, Lieblingsfarbe = Colors.Blue, Geschlecht = Gender.Divers });
            Personenliste.Add(new Person() { Vorname = "Maria", Nachname = "Fischer", Geburtsdatum = new DateTime(2002, 5, 12), Verheiratet = true, Lieblingsfarbe = Colors.Blue, Geschlecht = Gender.Weiblich });

            this.DataContext = this;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Personenliste.Remove(DgdPersonen.SelectedItem as Person);
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            PersonenDialog personenDialog = new PersonenDialog();

            if (personenDialog.ShowDialog() == true)
                Personenliste.Add(personenDialog.NeuePerson);
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            PersonenDialog personenDialog = new PersonenDialog();
            personenDialog.NeuePerson = new Person(DgdPersonen.SelectedItem as Person);
            personenDialog.DataContext = personenDialog.NeuePerson;

            if (personenDialog.ShowDialog() == true)
                Personenliste[Personenliste.IndexOf(DgdPersonen.SelectedItem as Person)] = personenDialog.NeuePerson;
        }
    }
}
