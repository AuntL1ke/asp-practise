using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; } = default!;
        public IEnumerable<Course> Courses { get; set; } = default!;
        public IEnumerable<Enrollment> Enrollments { get; set; } = default!;
    }
}