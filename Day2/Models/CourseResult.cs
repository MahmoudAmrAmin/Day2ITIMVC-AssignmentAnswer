using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class CourseResult
    {
        public int Id { get; set; }

        public int Degree { get; set;  }


        [ForeignKey("Course")]
        public int CoursetId { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }  




        Course Course { get; set; }
        Trainee Trainee { get; set; }   
    }
}
