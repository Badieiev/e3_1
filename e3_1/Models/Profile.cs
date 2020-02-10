using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e3_1.Models
{
     public class Profile
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Single { get; set; }

        public bool NoSingle { get; set; }

        public bool None { get; set; }
        public bool High_school { get; set; }
        public bool Bachelor { get; set; }
        public bool Master { get; set; }
        public bool Phd { get; set; }
    }
}