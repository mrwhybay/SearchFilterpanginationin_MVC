using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Temp.Models;

namespace Temp.viewmodel
{
    public class EmplyeeProfileVM
    {
        public int Id { get; set; }
        public string FatherName { get; set; }
        public string EmplyeeName { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Departmnet Departmnet { get; set; }

    }
}