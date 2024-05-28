# Herencia entre clases

### Referencia
[Palabra clave base](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/base)

## Sintaxis de herencia

> Se puede indicar que una clase hereda de otra utilizando la sintaxis mostrada a continuacion, de esta manera la clase heredaria todas las caracteristicas de la clase original.

```cs
class Man : Person {
  /* code... */
}
```
> La palabra clave **base** se usa para **acceder a los miembros de la clase base desde una clase *****derivada*** **.

```cs
public class Person
{
    ...
    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("SSN: {0}", ssn);
    }
}
class Employee : Person
{
    ...
    public override void GetInfo()
    {
        // Calling the base class GetInfo method:
        base.GetInfo();
        Console.WriteLine("Employee ID: {0}", id);
    }
}

class TestClass
{
    static void Main()
    {
        Employee E = new Employee();
        E.GetInfo();
    }
}

/******
  Aqui tener en cuenta, que cuando se usa
  base.SomeMethod se hace referencia a ese 
  SomeMethod en la clase de la que se hereda.
  Es decir, si tienes un metodo en la clase original
  que se llama igual a un metodo en nuestra clase derivada
  se puede llamar el metodo original usando la palabra reservada base.
*/

```

## Usando base() para heredar el constructor.
****
```cs
public class DerivedClass: BaseClass {
    public DerivedClass() : base(){}
}
/*********** De esta forma dices que el constructor DerivedClass sera heredado de BaseClass, si le pasas parametros a ejemplo: base(i) se podra usar ese valor en el constructor.*/

// This constructor will call BaseClass.BaseClass(int i)
public DerivedClass(int i) : base(i){}
```

