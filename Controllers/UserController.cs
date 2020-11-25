 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud1.Models;
using MVCCrud1.Models.TableViewModels;

namespace MVCCrud1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            List<UserTableViewModel> lst = null;
            using (userEntities db = new userEntities())
            {
                lst = (from d in db.usermvc
                       where d.idState == 1
                       orderby d.email
                       select new UserTableViewModel
                       {
                           Email = d.email,
                           Id = d.id,
                           Edad = d.edad
                       }).ToList();
            }


                return View(lst);
        }




    }
}