namespace SolidHomework;

// D - Dependency Inversion Principle (Asililigin Tersine Cevrilmesi)
// Task: Bildirisi email ve SMS ile gonder.
// Qayda: NotificationService konkret EmailSender-e yox, interfeyse bagli olmalidir.
interface IMessageSender
{
    void Send(string message);
}

class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"Email: {message}");
}

class SmsSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"SMS: {message}");
}

class NotificationService
{
    private readonly IMessageSender _sender;

    // Asililiq constructor vasitesile xaricden verilir.
    public NotificationService(IMessageSender sender)
    {
        _sender = sender;
    }

    public void Notify(string message) => _sender.Send(message);
}

static class DependencyInversion
{
    public static void Run()
    {
        Console.WriteLine("5. DIP:");
        NotificationService email = new NotificationService(new EmailSender());
        NotificationService sms = new NotificationService(new SmsSender());
        email.Notify("Salam!");
        sms.Notify("Salam!");
    }
}
