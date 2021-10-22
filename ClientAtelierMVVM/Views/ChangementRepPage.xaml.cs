using ClientAtelierMVVM.ViewModel;
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
using Microsoft.Data.Sqlite;


namespace ClientAtelierMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour ChangementRepPage.xaml
    /// </summary>
    public partial class ChangementRepPage : Page
    {
        private DemandeViewModel demandeViewModel = new DemandeViewModel();
        public ChangementRepPage()
        {

            InitializeComponent();
            DataContext = demandeViewModel;
        }
    }
}
