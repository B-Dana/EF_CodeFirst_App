using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_App
{
    class Program
    {
        static void Main()
        {
            using (var db = new SchoolContext())
            {
                if (!db.Students.Any() && !db.Courses.Any() && !db.Enrollments.Any())
                {
                    SeedData.PopulateDB();

                    Console.WriteLine("\nThe students with corresponding courses and grades:\n");
                    foreach (var s in db.Enrollments)
                    {
                        Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5} || {6}", s.Student.StudentID, s.Student.FirstName, s.Student.LastName, s.Student.EnrollmentDate, s.CourseID, s.Course.Title, s.Grade);
                    }

                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("\nThe students with corresponding courses and grades:\n");
                    foreach (var s in db.Enrollments)
                    {
                        Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5} || {6}", s.Student.StudentID, s.Student.FirstName, s.Student.LastName, s.Student.EnrollmentDate, s.CourseID, s.Course.Title, s.Grade);
                    }

                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                }
            }
        }
    }
}
