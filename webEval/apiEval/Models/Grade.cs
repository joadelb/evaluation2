namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Grade
    {
        [Key]
        public int gradeID { get; set; }
        public int studentID { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        [Range(0, 100)]
        public int score { get; set; }
        public Student Students { get; set; }

    }
}