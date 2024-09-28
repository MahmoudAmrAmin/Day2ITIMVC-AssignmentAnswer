﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Course
    {


        public int Id { get; set; } 

        public string Name { get; set; }

        public int Degree { get; set; } 

        public int MinDegree { get; set; }

        public int Hours { get; set; }  

        [ForeignKey("Department")]
        public int DeparmentId { get; set; }    

        Department Department { get; set; } 

        public List<Instructor> Instructors { get; set; }

        public List<Trainee> Trainees { get; set; }

        public List<CourseResult> CourseResults { get; set; } 


    }
}
