using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Demande
    {
        public int Id { get; set; }
        public string DemandeChangement { get; set; }
        public string AdresseMailSalarie { get; set; }

        public int ServiceAdminId { get; set; }
        public virtual ServiceAdmin serviceAdmin { get; set; }
        
    }
}