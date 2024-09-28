namespace Day2.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MangerName { get; set; } 
        
        List<Instructor> ? instructors { get; set; }

        List<Course>courses { get; set; }
    }
}
