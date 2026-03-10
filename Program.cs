using System;

class Program
{
    static void Main()
    {
        StudentService service = new StudentService();

        var topStudents = service.FilterStudents(IsTopStudent);

        foreach (var s in topStudents)
        {
            Console.WriteLine(s.Name);
        }
    }

    static bool IsTopStudent(Student s)
    {
        return s.Marks > 80;
    }
}
