# Times-Net
[![NuGet version (Times.Net)](https://img.shields.io/nuget/v/Times.Net.svg?style=flat-square)](https://www.nuget.org/packages/Times.Net/)
[![License](https://img.shields.io/github/license/Jose-LeonJL/Times-Net.svg?label=License&maxAge=86400)](LICENSE.md) 

El propósito de esta librería es abstraer la complejidad de trabajar con fechas en formato UNIX en .Net.
### Soporte
-  .Net Framework
- .Net Core
- .Net Standar

### Instalacion
- Package Manager `Install-Package Times.Net -Version 1.0.0`
- .Net CLI `dotnet add package Times.Net --version 1.0.0`
- PackageReference `<PackageReference Include="Times.Net" Version="1.0.0" />`
### Uso
>Vb.Net

```vb
Imports Times
Public Class Ejemplo
  Public sub Times_Test()
    Dim Times as Times
    Times = New Times()
    Console.WriteLine(Times.Now())
  end sub
end Class
```
> C#

```csharp
Using Times;
public class Ejemplo
{
  public void Times_Test()
  {
    Times Times;
    Times = New Times();
    Console.WriteLine(Times.Now());
  }
}
```
