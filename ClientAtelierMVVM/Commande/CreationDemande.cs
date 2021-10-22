using ClientAtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientAtelierMVVM.Commande
{
    public class CreationDemande : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private  DemandeViewModel demandeViewModel;

        public CreationDemande(DemandeViewModel demandeViewModel)
        {
            this.demandeViewModel = demandeViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            demandeViewModel.AjouterDemande();
           

        }
    }
}
