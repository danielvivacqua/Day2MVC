using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2MVC.Models
{
    public class PropertyModel
    {
        [Key]
        public int PropertyId { get; set; }
        public string Title { get; set;}
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}