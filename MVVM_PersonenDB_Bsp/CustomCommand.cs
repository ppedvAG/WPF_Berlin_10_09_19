using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_PersonenDB_Bsp
{
    //Klasse, welche die Commands (bzw. deren zu befüllende Hülle) zu Verfügung stellt (vgl. Modul 13)
    public class CustomCommand : ICommand
    {
        public delegate bool CanExecuteDelegate(object parameter);
        public delegate void ExecuteDelegate(object parameter);

        public CanExecuteDelegate CanExecuteMethode { get; set; }
        public ExecuteDelegate ExecuteMethode { get; set; }


        public CustomCommand(CanExecuteDelegate can, ExecuteDelegate exe)
        {
            this.CanExecuteMethode = can;
            this.ExecuteMethode = exe;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteMethode(parameter);
        }
        
        public void Execute(object parameter)
        {
            ExecuteMethode(parameter);
        }
    }
}
