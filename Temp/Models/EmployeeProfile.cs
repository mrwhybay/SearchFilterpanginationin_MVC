using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Temp.Models
{
    public class EmployeeProfile
    {

        public int Id { get; set; }
        public string  FatherName { get; set; }
        public string  EmplyeeName { get; set; }
        public DateTime DateTime  { get; set; }
        public virtual Departmnet Departmnet { get; set; }

    }

   public  class Departmnet     
    {
        public int Int { get; set; }
        public string departmentName { get; set; }

    }


    
}