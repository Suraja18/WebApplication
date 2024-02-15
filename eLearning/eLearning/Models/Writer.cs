using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Data.Base;
using eLearning.Data.Enums;

namespace eLearning.Models
{
    public class Writer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string Profilepic { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 Characters")]

        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]

        public string Bio { get; set;}
        public Gender Gender { get; set;}
        //Relationships
        public List<Book_Writer> Book_Writer { get; set;}
    }
}
