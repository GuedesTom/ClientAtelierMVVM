using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class DemandeController : ApiController
    {

        private SalarieDBContext db = new SalarieDBContext();

        [HttpPost]
        [Route("Add/Demande")]
        public HttpStatusCode AjoutDemande(Demande demande)
        {
            try
            {
                db.Demandes.Add(demande);
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;

            }


        }

        [HttpDelete]
        [Route("Supprimer/Demande")]
        public HttpStatusCode SupprimerDemande(int id)
        {
            try
            {
                Demande demandeAsupprimer = db.Demandes.FirstOrDefault(x => x.Id == id);
                if (demandeAsupprimer == null)
                {
                    return HttpStatusCode.NotFound;
                }
                db.Demandes.Remove(demandeAsupprimer);
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }

        }

        [HttpPut]
        [Route("Modifier/Demande")]
        public HttpStatusCode ModifierDemande(Demande s)
        {
            try
            {
                Demande demandeAModifier = db.Demandes.FirstOrDefault(x => x.Id == s.Id);
                if (demandeAModifier == null)
                {
                    return HttpStatusCode.NotFound;
                }
                demandeAModifier.ServiceAdminId = s.ServiceAdminId;
                demandeAModifier.AdresseMailSalarie = s.AdresseMailSalarie;
                demandeAModifier.DemandeChangement = s.DemandeChangement;
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }
        }
        [HttpGet]
        [Route("Rechercher/Demande/{crit}")]
        public List<Demande> RechercherDemande(string crit)
        {
            var list = db.Demandes.Where(x => x.AdresseMailSalarie.Contains(crit));
            return list.ToList();
        }
    }
}
