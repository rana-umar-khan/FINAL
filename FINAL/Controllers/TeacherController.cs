using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINAL.Controllers
{
    public class TeacherController : Controller
    {
        private attendanceEntities db = new attendanceEntities();
        // GET: Teacher
        public ActionResult Dashboard()
        {

            if (Session["login"] == null)
            {
                return Redirect("~/SignIn/Index");
            }
            Teacher t = db.Teachers.Find(Session["id"]);
            return View(t);
        }

        public ActionResult markAttendance(int courseId)
        {
            return Redirect("~/Attendance/MarkAttendance?courseId=" + courseId);
        }
    }
}