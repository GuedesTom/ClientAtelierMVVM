using ClientAtelierMVVM.Views;
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

namespace ClientAtelierMVVM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PageGestionCompte pageGestionCompte = new PageGestionCompte();
        public MainWindow()
        {
            InitializeComponent();
            Authentifier();
        }

        private void Authentifier()
        {
            //this.Hide();
            FenAuthentification fenAuth = new FenAuthentification();

            if (fenAuth.ShowDialog()==true)
            {
                //Authentifié
                //this.Show();
            }
            else
            {
                MessageBox.Show("Connexion abandonnée, fermeture de l'application");
                this.Close();
            }
        }

        private void ChangementResp_Click(object sender, RoutedEventArgs e)
        {
            Frm_Navigation.Navigate(new ChangementRepPage());
        }

        private void Salarie_Click(object sender, RoutedEventArgs e)
        {
            Frm_Navigation.Navigate(new SalariePage());
        }

        private void CreationBoiteAdmin_Click(object sender, RoutedEventArgs e)
        {
            Frm_Navigation.Navigate(new CreationAdmin());

        }

        private void CreationService_Click(object sender, RoutedEventArgs e)
        {
            Frm_Navigation.Navigate(new CreationService());
        }
    }
}
