namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        public string FIrstName { get; set; }
        [Key]
        public int id { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }
    }
}
