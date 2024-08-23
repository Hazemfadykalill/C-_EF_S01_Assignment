using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S01_Assignment.Entities
{
    public class Department
    {

        #region Annotation
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Ins_Id { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime HiringDate { get; set; }

        #endregion
    }
}
