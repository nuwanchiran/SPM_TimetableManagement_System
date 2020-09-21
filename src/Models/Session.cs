using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Management_System.src.Models
{
    class Session
    {

        public string sessionId { get; set; }
        public string tag { get; set; }
        public int year { get; set; }
        public int semester { get; set; }
        public string program { get; set; }
        public string group { get; set; }
        public string subGroup { get; set; }
        public string subjectId { get; set; }
        public int noOfStudents { get; set; }
        public int sessionDuration { get; set; }
}
}
