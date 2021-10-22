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
using System.Windows.Shapes;

namespace ClientAtelierMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour FenAuthentification.xaml
    /// </summary>
    public partial class FenAuthentification : Window
    {
        private static int Nbessaie = 3;
        public FenAuthentification()
        {


            InitializeComponent();
        }

        private void Connecter_Click(object sender, RoutedEventArgs e)
        {

            if (chkModeAuth.IsChecked == true)
            {
                AuthentificationWindows();
            }
            else
            {
                AuthentificationBase();
            }
            
           


        }

        private void AuthentificationBase()
        {
            MessageBox.Show("Authentification en Base");
            UserDBContext db = new UserDBContext();
            string login = tbxLogin.Text;
            string passwdCrypte = CryptHelper.Base64Decode(pwdUser.Password);

            var compteAchercher = db.Comptes.FirstOrDefault(x => x.Login.Equals(login) && x.Password.Equals(passwdCrypte)  );
            if (compteAchercher != null)
            {

            this.DialogResult = true;
            }
            else
            {
                Nbessaie--;

                this.DialogResult = true;
                if(Nbessaie == 0)
                {
                    MessageBox.Show("nb essaies depassé");
                    this.DialogResult = false;
                }

            }


        }

        private void AuthentificationWindows()
        {
            MessageBox.Show($"le login est {tbxLogin.Text}, mot de passe {pwdUser.Password}");

            bool ok = false;

            ok = AccessHelper.IsLoginCorrecte(tbxLogin.Text, pwdUser.Password, "");

            if (ok)
            {
                this.DialogResult = true;
            }
            else
            {
                this.DialogResult = false;
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
