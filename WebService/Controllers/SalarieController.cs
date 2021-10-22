using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class SalarieController : ApiController
    {

        private SalarieDBContext db = new SalarieDBContext();

        [HttpPost]
        [Route ("Add/Salarie")]
        public HttpStatusCode AjoutSalarie(Salarie s)
        {
            try
            {
            db.ServiceAdmin.Add(s);
            db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            { 
                return HttpStatusCode.InternalServerError;

            }


        }

        [HttpDelete]
        [Route ("Supprimer/Salarie")]
        public HttpStatusCode SupprimerSalarie(int id)
        {
            try
            {
            Salarie salarieAsupprimer = db.ServiceAdmin.FirstOrDefault(x => x.Id == id);
            if (salarieAsupprimer == null)
            {
                return HttpStatusCode.NotFound;
            }
            db.ServiceAdmin.Remove(salarieAsupprimer);
            db.SaveChanges();
            return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }
           
        }

        [HttpPut]
        [Route("Modifier/Salarie")]
        public HttpStatusCode ModifierSalarie(Salarie salarie)
        {
            try
            {
                Salarie salarieAModifier = db.ServiceAdmin.FirstOrDefault(x => x.Id == salarie.Id);
                if(salarieAModifier == null)
                {
                    return HttpStatusCode.NotFound;
                }
                salarieAModifier.Nom = salarie.Nom;
                salarieAModifier.Prenom = salarie.Prenom;
                salarieAModifier.TypeContrat = salarie.TypeContrat;
                salarieAModifier.PhotoProfil = salarie.PhotoProfil;
                salarieAModifier.Adresse = salarie.Adresse;
                salarieAModifier.AdresseMail = salarie.AdresseMail;
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }
        }
        [HttpGet]
        [Route("Rechercher/Salarie/{crit}")]
        public List<Salarie> RechercherSalarie (string crit)
        {
            var list = db.ServiceAdmin.Where(x => x.Nom.Contains(crit)||x.Prenom.Contains(crit)||x.TypeContrat.Contains(crit)|| x.Adresse.Contains(crit));
            return list.ToList();
        }

        
    }
}
