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
        [MaxLength(50)]
        [Column("TopicName")]
        public string Name { get; set; }

        [ForeignKey("Ins_Id")]
        public int Ins_Id { get; set; }
        [Column(TypeName = "HiringDate")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        #endregion
    }
}
