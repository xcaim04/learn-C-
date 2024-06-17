# Funciones c# nativas

## Casting
```cs
    Convert.ToString(myVar);  
    Convert.ToDouble(myVar);  
    Convert.ToInt32(myVar);
    Convert.ToInt64(myVar);
    Convert.ToBoolean(myVar);
```

## Ordenar un array
```cs
    int[] myNumbers1 = {5, 1, 8, 9};
    Array.Sort(myNumbers1);
```

## Min, Max, Sum
```cs
    using System.Linq;
    Console.WriteLine(myNumbers.Max());  // returns the largest value
    Console.WriteLine(myNumbers.Min());  // returns the smallest value
    Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
```