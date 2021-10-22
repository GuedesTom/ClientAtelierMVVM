using ClientAtelierMVVM.Model;
using ClientAtelierMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WebService.Models;

namespace ClientAtelierMVVM.Commande
{
    class CreationSalarie : ICommand
    {
        private ClientViewModel clientViewModel;

        public CreationSalarie(ClientViewModel clientViewModel)
        {
            this.clientViewModel = clientViewModel;
        }

        public event EventHandler CanExecuteChanged;
       
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

       

        public void Execute(object parameter)
        {
            clientViewModel.AjouterClient();

            //Salarie salarie = (Salarie)parameter;
            //salarie.AdresseMail = salarie.Nom.Substring(0, 1)+ salarie.Prenom + "@gmail.com" ;
            //SalarieDBContext db = new SalarieDBContext();
            //db.Salaries.Add(salarie);
            //db.SaveChanges();

        }
    }
}
