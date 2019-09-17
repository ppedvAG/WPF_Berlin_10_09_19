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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Properties vom Typ ObservableCollection informieren die GUI automatisch über Veränderungen (z.B. neuer Listeneintrag). Sie eignen sich besonders gut
        //für eine Bindung an ein ItemControl (z.B. ComboBox, ListBox, DataGrid, ...)
        public ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>();

        public Person BspPerson { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            //Erstellen von Bsp-Daten
            Personenliste.Add(new Person() { Vorname = "Otto", Nachname = "Meier", Alter = 50 });
            Personenliste.Add(new Person() { Vorname = "Jürgen", Nachname = "Müller", Alter = 24 });
            Personenliste.Add(new Person() { Vorname = "Maria", Nachname = "Fischer", Alter = 86 });

            BspPerson = new Person() { Vorname = "Anna", Nachname = "Meier", Alter = 28 };

            //Setzen des DataContext des Fensters auf sich selbst (Einfache Bindungen zu Properties in dieser datei möglich)
            this.DataContext = this;

            //Setzen des DataContext eines StackPanels auf die BspPerson
            splPersonenBsp.DataContext = BspPerson;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Klick funktioniert");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Erhöhung des Alters der Person im DataContextes des StackPanels
            (splDataContextBsp.DataContext as Person).Alter++;
        }

        private void Neu_Click(object sender, RoutedEventArgs e)
        {
            //Hinzufügen einer neuen Person
            Personenliste.Add(new Person() { Vorname = "Sara", Nachname = "Schmidt", Alter = 45 });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Ausgabe einer Person
            MessageBox.Show(BspPerson.Vorname + " " + BspPerson.Nachname);
        }
    }
}
