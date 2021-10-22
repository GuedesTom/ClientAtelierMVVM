using ClientAtelierMVVM.Commande;
using ClientAtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WebService.Models;
using Microsoft.Data.Sqlite;


namespace ClientAtelierMVVM.ViewModel
{
    class ClientViewModel
    {

        public Salarie SalarieVM { get; set; }
        public CreationSalarie CreationSalarieVM { get; set; }
        

        public ClientViewModel()
        {
            
            CreationSalarieVM = new CreationSalarie(this);
            if (SalarieVM == null)
            {
                SalarieVM = new Salarie();
                SalarieVM.DateNaissance = DateTime.Now;
            }
        }
        public void AjouterClient()
        {


            SalarieVM.AdresseMail = SalarieVM.Nom.Substring(0, 1) + SalarieVM.Prenom + "@gmail.com";
            SalarieDBContext db = new SalarieDBContext();
            db.Salaries.Add(SalarieVM);
            int i = db.SaveChanges();
            if(i > 0)
            {
                MessageBox.Show("Fait");
                
            }
            else 
            {
                MessageBox.Show("Pas fait");
            }
        }



    }
}
