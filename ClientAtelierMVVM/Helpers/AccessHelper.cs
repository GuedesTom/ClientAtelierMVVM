using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAtelierMVVM.Helpers
{
    public class AccessHelper
    {
        [STAThread] // Le model de Thread qui sera appelé - 
        [System.Runtime.InteropServices.DllImport("advapi32.dll")] // import de bibliotheque
        public static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);
        //

        // Méthode qui dit si le compte windows est correcte ou pas
        public static bool IsLoginCorrecte(string login, string password, string domain)
        {

            IntPtr tokenHandler = IntPtr.Zero;

            bool isValid = LogonUser(login, domain, password, 2, 0, ref tokenHandler);
            return isValid;

        }

        //public bool IsAuthentificationCorrecte(string userName, string motDepasse)
        //{
        //    return IsLoginCorrecte(userName, "", motDepasse);

        //}

    }
}
