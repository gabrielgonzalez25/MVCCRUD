using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud1.Models;
namespace MVCCrud1.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {            
            return View();
        }

        
        public ContentResult Enter(string user, string password)
        {
            try
            {
                using (userEntities db = new userEntities())
                {
                    var oUser = db.usermvc.FirstOrDefault(f => f.email == user && f.password == password && f.idState == 1);
                    if (oUser != null)
                    {
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario invalido :(");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Fallido" + ex.Message);
            }
        }
    }
}