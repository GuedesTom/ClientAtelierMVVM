using ClientAtelierMVVM.Model;
using ClientAtelierMVVM.ViewModel;
using Microsoft.Win32;
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
    /// Logique d'interaction pour SalariePage.xaml
    /// </summary>
    public partial class SalariePage : Page
    {
        private ClientViewModel viewModel = new ClientViewModel();


        public SalariePage()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void RechercherImage_Clicik(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if (ofg.ShowDialog() == true)
            {

                string chemin = ofg.FileName;
                var r = new Uri(chemin);
                imgImage.Source = new BitmapImage(r);

            }
        }

        //private void Ajouter_Click(object sender, RoutedEventArgs e)
        //{
        //    Salarie s = new Salarie();
        //    s.Prenom = tbxPrenom.Text;
        //    s.Nom = tbxNom.Text;
        //    s.DateNaissance = dtpDateNaissance.DisplayDate;
        //    s.LieuNaissance = tbxLieuxdeNaissance.Text;
        //    s.Adresse = tbxAdresse.Text;
        //    s.TypeContrat = tbxTypeDeContrat.Text;
        //    s.PhotoProfil = ((BitmapImage)imgImage.Source).UriSource.AbsoluteUri;
        //    s.AdresseMail = tbxNom.Text.Substring(0,1) + tbxPrenom.Text+"@gmail.com";

        //    SalarieDBContext db = new SalarieDBContext();
        //    db.Salaries.Add(s);
        //    db.SaveChanges();
           

        //}
    }
}
