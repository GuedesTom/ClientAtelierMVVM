using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Salarie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string TypeContrat { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string PhotoProfil { get; set; }
        public string Adresse { get; set; }
        public string AdresseMail { get; set; }
        public override string ToString()
        {
            return Nom + " " +Prenom ;
        }



    }
}