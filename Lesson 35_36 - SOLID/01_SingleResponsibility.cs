namespace SolidHomework;

// S - Single Responsibility Principle (Tek Mesuliyyet Prinsipi)
// Task: Telebenin melumatlarini saxla ve ekranda goster.
// Qayda: Her class yalniz bir ise cavabdeh olmalidir.
class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

// Melumati gostermek ayrica class-in vezifesidir.
class StudentPrinter
{
    public void Print(Student student)
    {
        Console.WriteLine($"Telebe: {student.Name}");
    }
}

static class SingleResponsibility
{
    public static void Run()
    {
        Console.WriteLine("1. SRP:");
        Student student = new Student("Ali");
        StudentPrinter printer = new StudentPrinter();
        printer.Print(student);
        Console.WriteLine();
    }
}
