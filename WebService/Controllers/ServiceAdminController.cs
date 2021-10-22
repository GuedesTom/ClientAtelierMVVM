using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class ServiceAdminController : ApiController
    {

        private SalarieDBContext db = new SalarieDBContext();

        [HttpPost]
        [Route("Add/ServiceAdmin")]
        public HttpStatusCode AjoutServiceAdmin(ServiceAdmin serviceadmin)
        {
            try
            {
                db.ServiceAdmins.Add(serviceadmin);
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;

            }


        }

        [HttpDelete]
        [Route("Supprimer/ServiceAdmin")]
        public HttpStatusCode SupprimerSalarie(int id)
        {
            try
            {
                Salarie serviceadminAsupprimer = db.ServiceAdmin.FirstOrDefault(x => x.Id == id);
                if (serviceadminAsupprimer == null)
                {
                    return HttpStatusCode.NotFound;
                }
                db.ServiceAdmin.Remove(serviceadminAsupprimer);
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }

        }

        [HttpPut]
        [Route("Modifier/ServiceAdmin")]
        public HttpStatusCode ModifierServiceAdmin(ServiceAdmin s)
        {
            try
            {
                ServiceAdmin serviceadminAModifier = db.ServiceAdmins.FirstOrDefault(x => x.Id == s.Id);
                if (serviceadminAModifier == null)
                {
                    return HttpStatusCode.NotFound;
                }
                serviceadminAModifier.NomServiceAdmin = s.NomServiceAdmin;
                serviceadminAModifier.ChefService = s.ChefService;
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {

                return HttpStatusCode.InternalServerError;
            }
        }
        [HttpGet]
        [Route("Rechercher/ServiceAdmin/{crit}")]
        public List<ServiceAdmin> RechercherServiceAdmin(string crit)
        {
            var list = db.ServiceAdmins.Where(x => x.NomServiceAdmin.Contains(crit) || x.ChefService.Contains(crit));
            return list.ToList();
        }
    }
}
