using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }

        public int ZipId { get; set; }
        public Zip Zip { get; set; }

        public string Description { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}