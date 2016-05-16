using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class ZipToCity
    {
        [Key]
        public int ZTCId { get; set; }

        public int ZipId { get; set; }
        public Zip Zip { get; set; }

        public int CityId { get; set; }
        public Cities City { get; set; }
    }
}