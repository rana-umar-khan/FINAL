using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FINAL.Controllers
{
    public class AttendanceController : Controller
    {
        private attendanceEntities db = new attendanceEntities();
        // GET: Attendance
        public ActionResult MarkAttendance(int courseId)
        {
            Course c = db.Courses.Find(courseId);
            return View(c);
        }
    }
}