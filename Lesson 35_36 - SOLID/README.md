# Lesson 35_36 - SOLID

C# ile SOLID prinsiplərinə aid 5 sade tapşırıq. Hər faylda task və izah comment-lərdə qeyd olunub.

| Fayl | Prinsip | Tapşırıq |
| --- | --- | --- |
| 01_SingleResponsibility.cs | S — Single Responsibility | Tələbə məlumatını saxla və ayrıca çap et |
| 02_OpenClosed.cs | O — Open/Closed | Kvadrat və düzbucaqlının sahəsini hesabla |
| 03_LiskovSubstitution.cs | L — Liskov Substitution | Fərqli heyvanları eyni əsas tipdən idarə et |
| 04_InterfaceSegregation.cs | I — Interface Segregation | Printer və skaner interfeyslərini ayır |
| 05_DependencyInversion.cs | D — Dependency Inversion | Email və SMS bildirişi interfeyslə göndər |

## İşə salmaq

.NET 8 SDK quraşdırılmış kompüterdə qovluğun içində terminal aç:

```bash
dotnet run
```

**Qeyd:** `Program.cs` bütün 5 nümunəni ardıcıl çağırır. Real email/SMS göndərilmir, yalnız konsolda nümunə göstərilir.
