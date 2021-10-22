using ClientAtelierMVVM.Helpers;
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

namespace ClientAtelierMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour PageGestionCompte.xaml
    /// </summary>
    public partial class PageGestionCompte : Page
    {
        public PageGestionCompte()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            UserDBContext db = new UserDBContext();

            Compte c = new Compte();
            c.Login = tbxNom.Text;
            c.Password = CryptHelper.Base64Decode(tbxPasse.Text);

            db.Comptes.Add(c);
            db.SaveChanges();
        }
    }
}
