using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class Zip
    {
        [Key]
        public int ZipId { get; set; }
        public string ZipCode { get; set; }
    }
}