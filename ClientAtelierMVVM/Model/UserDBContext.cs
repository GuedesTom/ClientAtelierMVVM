using System;
using System.Data.Entity;
using System.Linq;
using WebService.Models;

namespace ClientAtelierMVVM.Model
{
    public class UserDBContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « UserDBContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « ClientAtelierMVVM.Model.UserDBContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « UserDBContext » dans le fichier de configuration de l'application.
        public UserDBContext()
            : base("name=MailDBContext")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<Salarie> Salaries { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}