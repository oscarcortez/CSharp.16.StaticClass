# CSharp.16.StaticClass


STATIC: una clase estatica no puede ser instanciada

una clase normal puede tener static methods y se las llama sin instanciar la clase

```csharp
public class Calculadora
{
    public static int Suma(int x, int y)
    {
        return x + y;
    }

    public int Mult(int x, int y)
    {
        return x * y;
    }
}
```

como se ve se puede usar como estatico y tambien como clase normal
```csharp
Console.WriteLine($"Calculadora.suma: {Calculadora.Suma(4,5) }");

Calculadora c = new Calculadora();
Console.WriteLine($"calculadora instanciada: {c.Mult(2, 4)}");
```
