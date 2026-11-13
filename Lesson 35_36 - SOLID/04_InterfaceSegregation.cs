namespace SolidHomework;

// I - Interface Segregation Principle (Interfeyslerin Ayrilmasi)
// Task: Printer ve skaner cihazlarini ayri-ayri qur.
// Qayda: Class istifade etmediyi metodu yazmaga mecbur olmamalidir.
interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class SimplePrinter : IPrint
{
    public void Print() => Console.WriteLine("Printer cap edir.");
}

class MultiFunctionPrinter : IPrint, IScan
{
    public void Print() => Console.WriteLine("Coxfunksiyali cihaz cap edir.");
    public void Scan() => Console.WriteLine("Coxfunksiyali cihaz skan edir.");
}

static class InterfaceSegregation
{
    public static void Run()
    {
        Console.WriteLine("4. ISP:");
        SimplePrinter printer = new SimplePrinter();
        MultiFunctionPrinter multi = new MultiFunctionPrinter();
        printer.Print(); // Sade printerden Scan() teleb olunmur.
        multi.Print();
        multi.Scan();
        Console.WriteLine();
    }
}
