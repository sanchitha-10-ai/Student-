using System;
using System.Collections.Generic;
using System.Linq;

public delegate bool StudentFilter(Student s);

public class StudentService
{
    AppDbContext context = new AppDbContext();

    public List<Student> FilterStudents(StudentFilter filter)
    {
        var students = context.Students.ToList();

        List<Student> result = new List<Student>();

        foreach (var s in students)
        {
            if (filter(s))
            {
                result.Add(s);
            }
        }

        return result;
    }
}