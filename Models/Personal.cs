using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_core.Models
{
    public class Personal
    {
        [Key]
        public string IdentityCard { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { set; get; }
        public Marriage Marriage { get; set; }

        public byte[] Photo { get; set; }
        public Sex Sex { get; set; }

        public string Nation { get; set; }

        public string HouseHold { get; set; }
        public Rear Rear { get; set; }


    }
    public enum Marriage { spinsterhood, married }
    public enum Sex { male, female }
    public enum Rear { None, Yes }
}

