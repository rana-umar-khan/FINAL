using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class StudentDTO
    {
        [DisplayName("Student")]
        public int StuId { get; set; }

        [Required(ErrorMessage ="")]
        [EmailAddress]
        
        public string StuName { get; set; }
        public string StuRollNo { get; set; }
        public AttendanceDTO StuAttendance { get; set; }
    }
}
