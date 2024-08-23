using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S01_Assignment.Entities
{
    public class Course
    {

        public int Id { get; set; }
        public int Top_Id { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
