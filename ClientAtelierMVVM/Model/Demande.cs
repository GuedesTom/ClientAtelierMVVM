//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientAtelierMVVM.Model
{
    using System;
    using System.Collections.Generic;
    using WebService.Models;

    public partial class Demande
    {
        public int Id { get; set; }
        public string DemandeChangement { get; set; }
        public int AncienResId { get; set; }
        public int NouveauResId { get; set; }
        public int ServiceAdminId { get; set; }
    
        public virtual Salarie AncienRes { get; set; }
        public virtual Salarie NouveauRes { get; set; }
        public virtual ServiceAdmin ServiceAdmin { get; set; }
    }
}
