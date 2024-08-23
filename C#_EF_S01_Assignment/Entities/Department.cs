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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        //[MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        public int Ins_Id { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime HiringDate { get; set; }



    




        #endregion
    }
}
