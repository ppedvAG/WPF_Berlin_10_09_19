using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_PersonenDB_Bsp.ViewModel
{
    public class DetailViewModel
    {
        //Command-Properties
        public CustomCommand OkCmd { get; set; }
        public CustomCommand AbbruchCmd { get; set; }
        //Property, welche die neue oder zu bearbeitende Person beinhaltet
        public Model.Person AktuellePerson { get; set; }

        public DetailViewModel()
        {
            //OK-Command (Bestätigung)
            this.OkCmd = new CustomCommand
                (
                    //CanExe: Kann immer ausgeführt werden. Eine Prüfung auf die Validierung der einzelnen EIngabefelder findet schon in der GUI (vgl. DetailView) statt.
                    para => true,
                    //Exe:
                    para =>
                    {
                        //Nachfrage auf Korrektheit der Daten per MessageBox
                        if(MessageBox.Show("Soll die Person gespeichert werden?", "Person abspeichern", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            //Setzen des DialogResults des Views (welches per Parameter übergeben wurde) auf true, damit das LIstView weiß, dass es weiter
                            //machen kann (d.h. die neuen Person einfügen bzw. austauschen)
                            (para as View.DetailView).DialogResult = true;
                            //Schließen des Views
                            (para as View.DetailView).Close();
                        }
                    }
                );
            //Abbruch-Cmd
            this.AbbruchCmd = new CustomCommand
                (
                    //CanExe: Kann immer ausgeführt werden
                    para => true,
                    //Exe: Schließen des Fensters
                    para => (para as View.DetailView).Close()
                );
        }
    }
}
