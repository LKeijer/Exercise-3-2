using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesPrototype.Data
{
    // Types of user
    public enum Role { Teacher, Student };

    // TODO: Exercise 2: Task 1a: Create the Grade struct
    public struct Grade
    {
        int StudentID { get; set; }
        string AssessmentDate { get; set; }
        string SubjectName {get; set; }
        string Assessment { get; set; }
        string Comments { get; set; }
    }

    // TODO: Exercise 2: Task 1b: Create the Student struct
    public struct Student
    {
        int StudentID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string TeacherID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    
    // TODO: Exercise 2: Task 1c: Create the Teacher struct
    public struct Teacher
    {
        int TeacherID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Class { get; set; }
    }
}
