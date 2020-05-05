using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_core.Models
{
    public class Employee
    {
        public int IdCard { get; set; }
        public string WorkState{ get; set; }
        public ClassOfSalary ClassOfSalary { get; set; }
        public ClassOfEmployee ClassOfEmployee { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? LeaveDate { get; set; }
       
        public String ReasonOfLeaveing { get; set; }
    }
    public enum ClassOfSalary { normal, unnormal };
    public enum ClassOfEmployee { Y, N };
    public enum WorkState{ 离职,在职};
}
