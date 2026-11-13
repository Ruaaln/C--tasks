# Lesson 33_34 - UML

3 sade Design Pattern numunesi ve onlara uygun UML Class Diagram sekilleri.

| Kateqoriya | Design Pattern | Kod | UML sekli |
|---|---|---|---|
| Creational | Singleton | `Singleton.cs` | `UML/01-Singleton.png` |
| Behavioral | Strategy | `Strategy.cs` | `UML/02-Strategy.png` |
| Structural | Adapter | `Adapter.cs` | `UML/03-Adapter.png` |

## Isletmek

.NET 8 SDK qurulu olmalidir. Layihenin qovlugunda terminal acin:

```bash
dotnet run
```

### Qisa izah

1. **Singleton:** `AppSettings` sinfinden yalniz bir obyekt yaradilir; `Instance` her defe eyni obyekti qaytarir.
2. **Strategy:** `Calculator` eyni qalir, `IOperation` vasitesile toplama ve vurma usullari deyisdirilir.
3. **Adapter:** `EmailAdapter`, kohne `OldEmailService.SendEmail()` metodunu yeni `INotification.Send()` interfeysi ile uygunlasdirir.

UML sxemlerinde `+` public, `-` private, `<interface>` interfeys demekdir. Kesik ox (implements) interfeysin tetbiqini, adi ox asilligi/istifadeni gosterir.
