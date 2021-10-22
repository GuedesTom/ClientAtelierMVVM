using System.Windows;
using System.Windows.Controls;
using System.Data;
using ClientAtelierMVVM.Model;
using System.Linq;
using WebService.Models;

namespace ClientAtelierMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour CreationService.xaml
    /// </summary>
    public partial class CreationService : Page
    { 
        SalarieDBContext dataEntities = new SalarieDBContext();

        public CreationService()
        {
            InitializeComponent();
           
        }
               


            private void DemandeCreation_Click(object sender, RoutedEventArgs e)
        {
            var query =
            from x in dataEntities.Demandes select x;

            dgrAfficher.ItemsSource = query.ToList();
            
        }

        private void ChangementRes_Click(object sender, RoutedEventArgs e)
        {
            int y = int.Parse(tbxResponsable.Text);
            var query =
                from x in dataEntities.ServiceAdmins
                where x.Id == y
                select x ;

            dgrAfficher.ItemsSource = query.ToList();

        }

        private void DemandeChangement_Click(object sender, RoutedEventArgs e)
        {
            var query =
            from x in dataEntities.DemandeCreations select x;

            dgrAfficher.ItemsSource = query.ToList();
        }

        private void ChangementMail_Click(object sender, RoutedEventArgs e)
        {
            ServiceAdmin f = new ServiceAdmin();
            f.NomServiceAdmin = tbxNomService.Text;
            f.ChefService = tbxResponsableService.Text;
            f.Mail = tbxNomService.Text + "@gmail.com";


            dataEntities.ServiceAdmins.Add(f);
           int i = dataEntities.SaveChanges();

            var query =
            from x in dataEntities.ServiceAdmins select x;

            dgrAfficher.ItemsSource = query.ToList();
            if (i > 0)
            {
                MessageBox.Show("Fait");
            }
            else
            {
                MessageBox.Show("CEST PAS FAIT");
            }
        }

       
        
    }
}
