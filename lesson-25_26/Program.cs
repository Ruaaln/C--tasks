using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
string folder = Path.Combine(desktop, "Images");
Directory.CreateDirectory(folder);

Console.WriteLine("Enter - Screenshot cek");
Console.WriteLine("L - Sekillerin adlarini goster");
Console.WriteLine("Q - Cixis");

while (true)
{
    ConsoleKey key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.Q)
        break;

    if (key == ConsoleKey.L)
    {
        foreach (string file in Directory.GetFiles(folder, "*.png"))
            Console.WriteLine(Path.GetFileName(file));
    }

    if (key == ConsoleKey.Enter)
    {
        Rectangle screen = Screen.PrimaryScreen!.Bounds;
        using Bitmap image = new Bitmap(screen.Width, screen.Height);
        using Graphics graphics = Graphics.FromImage(image);

        graphics.CopyFromScreen(screen.Left, screen.Top, 0, 0, screen.Size);

        string name = $"Screenshot_{DateTime.Now:yyyyMMdd_HHmmss_fffffff}.png";
        string path = Path.Combine(folder, name);
        image.Save(path, ImageFormat.Png);

        Console.WriteLine($"Yadda saxlandi: {name}");
    }
}
