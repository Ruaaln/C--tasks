// Creational - Singleton: eyni obyekt her defe istifade olunur.
public sealed class AppSettings
{
    private static readonly AppSettings instance = new AppSettings();

    public static AppSettings Instance => instance;
    public string Theme { get; set; } = "Light";

    private AppSettings() { }
}
