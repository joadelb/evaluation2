

namespace webEval.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public enum sex
    {
        male,female,gay
    }
    
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public sex Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }
        public virtual ICollection<Grade> grade { get; set; }
    }
}