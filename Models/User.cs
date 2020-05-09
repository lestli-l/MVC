using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_core.Models
{
    public class User
    {
    [Key]
    public int Id{ get; set; }
    public string UserName{ get; set; }
    public string PassWord{ get; set; }
    public string email{ get; set; }
   
    }
}
