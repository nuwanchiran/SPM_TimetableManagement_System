using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Management_System.src.Models
{
    class Subject
    {
        public String subjectCode { get; set; }
        public String subjectName { get; set; }
        public int offeredYear { get; set; }
        public int offeredSemester { get; set; }
        public String program { get; set; }

        public bool isParallel { get; set; }
        public String category { get; set; }
    }
}
