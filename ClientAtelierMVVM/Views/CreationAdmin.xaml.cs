using ClientAtelierMVVM.Model;
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
using WebService.Models;

namespace ClientAtelierMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour CreationAdmin.xaml
    /// </summary>
    public partial class CreationAdmin : Page
    {
        public CreationAdmin()
        {
            InitializeComponent();
        }

        private void Creer_Cick(object sender, RoutedEventArgs e)
        {
            SalarieDBContext db = new SalarieDBContext();
            DemandeCreation s = new DemandeCreation();
            s.Motif = tbxMotif.Text;
            s.NomBoite= tbxNomBoite.Text;
            s.NomDemandeur =tbxNomDemandeur.Text;
            s.ServiceAdminId  = int.Parse(tbxResponsableCompte.Text);
            

            
            db.DemandeCreations.Add(s);
           int i = db.SaveChanges();
            if (i > 0)
            {
                MessageBox.Show("Fait");
            }
            else
            {
                MessageBox.Show("CEST PAS FAIT");
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
