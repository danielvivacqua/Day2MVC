using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }

        //foreign key for CustomerModels
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        //foreign key for PropertyModels
        public int PropertyId { get; set; }
        public PropertyModel Property { get; set; }


        public decimal SalesPrice { get; set; }
        public DateTime SalesDate { get; set; }
        //This is going to be the join table for Customers and Properties
        //To Do - PropertyId and CustomerId as Foreign Keys
    }
}