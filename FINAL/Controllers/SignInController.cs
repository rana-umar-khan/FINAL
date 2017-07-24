using FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINAL.Controllers
{
    public class SignInController : Controller
    {
        HttpCookie cookie;
        public ActionResult Index()
        {
            //if (Session["remember"] != null)
            //{
            //    if ((string)Session["remember"] == "on")
            //    {
            //        //SignIn((string)Session["login"], (string)Session["password"], (string)Session["remember"]);
            //        return Redirect("~/Teacher/Dashboard");
            //    }
            //}
            SignIn s = new SignIn();
            s.username = "";
            s.password = "";
            return View(s);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignIn s)
        {
            if (cookie == null)
            {
                cookie = new HttpCookie("loginCookie", "Invalid");
            }
            Object data = null;
            using (var context = new attendanceEntities())
            {
                var q = (from d in context.Teachers where d.TeaEmail == s.username  select d).Single();
                if (q!=null && q.TeaPassword == s.password)
                {
                    data = new
                    {
                        valid = true,
                        urlToRedirect = "~/Teacher/Dashboard"
                    };
                    cookie.Value = "Valid";
                    Session["Name"] = q.TeaFirstName + " " + q.TeaLastName;
                    Session["id"] = q.TeaId;
                    Session["login"] = s.username;
                    Session["password"] = s.password;
                    
                    //Session["remember"] = remember;
                    cookie.Expires = DateTime.Now.AddHours(24);
                    return Redirect("~/Teacher/Dashboard");
                }
                else
                {
                    Session["login"] = null;
                    Session.Abandon();
                    
                    return View("Index");
                }
            }
            

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}