// Structural - Adapter: kohne servisi yeni interfeysle isledirik.
public interface INotification
{
    void Send(string message);
}

public class OldEmailService
{
    public void SendEmail(string text)
    {
        Console.WriteLine("Email gonderildi: " + text);
    }
}

public class EmailAdapter : INotification
{
    private readonly OldEmailService emailService;

    public EmailAdapter(OldEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void Send(string message)
    {
        emailService.SendEmail(message);
    }
}
