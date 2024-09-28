using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Trainee
    {
        public int Id { get; set; } 

        public string Name { get; set; }    

        public string ImageUrl { get; set; }    

        public string Address { get; set; } 

        public int Gard { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }   

        Department Department { get; set; }

        public List<CourseResult>? CourseResults { get; set; }

    }
}
