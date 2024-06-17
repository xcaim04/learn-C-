# Loops in C#

## WHILE SENTENCE
```
while (condition)
{
    // Code...
}
```

## DO WHILE SENTENCE
```
do
{
    // Code...
} while (condition);
```

## FOR SENTENCE
```
for (int i = 0; i < 10; i++)
{
    // Code...
}
```

## FOREACH SENTENCE
```
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
```


## Loop a two-dimensional array

> Tienes que usar GetLength(int dimension) en lugar de Length

```cs
    for (int i = 0; i < numbers.GetLength(0); i++) 
    { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.WriteLine(numbers[i, j]); 
        } 
    }  

```

```cs
    foreach (int i in numbers1)
    {
        Console.Write(i + " ");
    }
```