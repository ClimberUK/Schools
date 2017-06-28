using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDB
{
    public class DAL
    {
        public string GetStudentName(int id)
        {
            using (var dbCtx = new SchoolDBEntities())
            {
                var std = dbCtx.Students.Where(s => s.StudentID == id).FirstOrDefault();
                return std.StudentName;
            }
        }
    }
}
