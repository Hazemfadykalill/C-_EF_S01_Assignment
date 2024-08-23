using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S01_Assignment.Entities
{
    public class Instructor
    {
        #region Convention
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public double HourRate { get; set; }
        public int? Dept_Id { get; set; }
        #endregion
    }
}
