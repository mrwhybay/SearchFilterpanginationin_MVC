namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollegePayment")]
    public partial class CollegePayment
    {
        public int id { get; set; }

        public string txnid { get; set; }

        public int? collegeid { get; set; }

        public bool? paymentstatus { get; set; }

        public DateTime? paymentdate { get; set; }

        public virtual College College { get; set; }
    }
}
