  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud1.Models;
using MVCCrud1.Models.TableViewModels;
using MVCCrud1.Models.ViewModels;

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
        [HttpGet]

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new userEntities())
            {
                usermvc oUser = new usermvc();
                oUser.idState = 1;
                oUser.email = model.Email;
                oUser.password = model.Password;
                oUser.edad = model.Edad;

                db.usermvc.Add(oUser);
                db.SaveChanges(); 


            }
            return Redirect(Url.Content("~/User/"));



        }

        public ActionResult Edit(int Id)
        {
            EditViewModel model = new EditViewModel();

            using(var db = new userEntities())
                {
                var oUser = db.usermvc.Find(Id);
                model.Edad = (int)oUser.edad;
                model.Email = oUser.email;
                model.Id = oUser.id;
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new userEntities())
            {
                var oUser = db.usermvc.Find(model.Id);
                oUser.email = model.Email;
                oUser.edad = model.Edad;

                if(model.Password!=null && model.Password.Trim() != "")
                {
                    oUser.password = model.Password;
                }

                db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

            return Redirect(Url.Content("~/User/"));
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {

            using (var db = new userEntities())
            {
                var oUser = db.usermvc.Find(Id);
                oUser.idState = 3; //pa eliminar

                db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

            return Content("1");
        }
    }    
  }  
