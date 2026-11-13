namespace SolidHomework;

// L - Liskov Substitution Principle (Evezetme Prinsipi)
// Task: Heyvanlarin hereketlerini goster.
// Qayda: Alt class esas class-in yerine problemsiz istifade oluna bilmelidir.
abstract class Animal
{
    public abstract void Move();
}

class Dog : Animal
{
    public override void Move() => Console.WriteLine("It qacir.");
}

class Bird : Animal
{
    public override void Move() => Console.WriteLine("Qus hereket edir.");
}

static class LiskovSubstitution
{
    public static void Run()
    {
        Console.WriteLine("3. LSP:");
        // Hem Dog, hem Bird Animal kimi isleyir.
        Animal[] animals = { new Dog(), new Bird() };
        foreach (Animal animal in animals)
            animal.Move();
        Console.WriteLine();
    }
}
