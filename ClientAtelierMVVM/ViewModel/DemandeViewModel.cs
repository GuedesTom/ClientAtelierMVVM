using ClientAtelierMVVM.Commande;
using ClientAtelierMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WebService.Models;
using Microsoft.Data.Sqlite;


namespace ClientAtelierMVVM.ViewModel
{
    public class DemandeViewModel
    {
        public Salarie NouveauRespVM { get; set; }
        public Salarie AncienRespVM { get; set; }
        public ObservableCollection<Salarie> SalariesVM { get; set; }
        public Demande DemandeVM { get; set; }
        public CreationDemande CreationDemandeVM { get; set; }
        private SalarieDBContext db = new SalarieDBContext();
        public DemandeViewModel()
        {
            DemandeVM = new Demande();
            CreationDemandeVM = new CreationDemande(this);
            if(SalariesVM == null)
            {
                SalariesVM = new ObservableCollection<Salarie>(db.Salaries);

            }
            if (NouveauRespVM == null)
            {
                NouveauRespVM = new Salarie();
            }
            if (AncienRespVM == null)
            {
                AncienRespVM = new Salarie();
            }
        } 

        public void AjouterDemande()
        {

            DemandeVM.NouveauRes = NouveauRespVM;
            DemandeVM.AncienRes = AncienRespVM;
            db.Demandes.Add(DemandeVM);
            int i = db.SaveChanges();
            if (i > 0)
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
