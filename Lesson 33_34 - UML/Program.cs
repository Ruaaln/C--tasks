using System;

Console.WriteLine("1. Singleton (Creational)");
var settings = AppSettings.Instance;
settings.Theme = "Dark";
Console.WriteLine("Theme: " + AppSettings.Instance.Theme);

Console.WriteLine("\n2. Strategy (Behavioral)");
var calculator = new Calculator(new AddStrategy());
Console.WriteLine("Toplama: " + calculator.Calculate(8, 2));
calculator.SetStrategy(new MultiplyStrategy());
Console.WriteLine("Vurma: " + calculator.Calculate(8, 2));

Console.WriteLine("\n3. Adapter (Structural)");
INotification notification = new EmailAdapter(new OldEmailService());
notification.Send("Salam!");
