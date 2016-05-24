using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asp.Models
{
    public class Guest
    {
        [Key]
        public int uid { get; set;  } 
        public string email { get; set; }
        public string name { get; set; }
        protected string pwd { get; set; }
        protected string logip { get; set; }
        protected DateTime logtime { get; set; }
    }
}