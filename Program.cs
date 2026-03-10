using System;

class Program
{
    static void Main()
    {
        StudentService service = new StudentService();

        // 1️⃣ Using delegate method
        var topStudents = service.FilterStudents(IsTopStudent);

        Console.WriteLine("Top Students (Delegate Method):");

        foreach (var s in topStudents)
        {
            Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        // 2️⃣ Using lambda expression instead of method
        var topStudentsLambda = service.FilterStudents(s => s.Marks > 80);

        Console.WriteLine("Top Students (Lambda Expression):");

        foreach (var s in topStudentsLambda)
        {
            Console.WriteLine(s.Name);
        }
    }

    static bool IsTopStudent(Student s)
    {
        return s.Marks > 80;
    }
}