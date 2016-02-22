# Nouveautés du C# 6

## Sommaire

- [Propriétés accessibles uniquement en lecture](#proplectureseule)
- [Imports statiques](#importsStatiques)
- [Écriture lambda dans les propriétés, fonctions, ...](#ecritureLambda)
- [Initialiseurs avec membres indexés](#initMembresIndexes)
- [`await` dans les blocks catch et finally d'un try](#awaitCatchFinally)
- [Filtres dans les blocs d'exception](#filtresExceptions)

## Propriétés accessibles uniquement en lecture <a id="proplectureseule"></a>

Les propriétés accessibles uniquement en lecture ont habituellement un accesseur en lecture public et un accesseur en écriture privé. En C# 6, si l'accesseur en écriture privé n'est pas déclaré, il est automatiquement interprété comme un accesseur existant en readonly. Pour effectuer le même rendu avant l'implémentation de cette fonctionnalité, il fallait déclarer la propriété comme `readonly`.

Déclarer une nouvelle propriété avec cette méthode :

```cs
  public class Dog
  {
    public string Age{get;}
    public string Name{get;set;}
  }
```

## Imports statiques <a id="importsStatiques"></a>
`using static` appliqué à une classe permet d'importer tous les membres statiques de cette classe.

Avant :
```cs
using System;
namespace CSharpSix
{
    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Hello world");
      }
    }
}
```

Après :
```cs
using static System;
namespace CSharpSix
{
    class Program
    {
      static void Main(string[] args)
      {
        WriteLine("Hello world");
      }
    }
}
```
## Écriture lambda dans les propriétés, fonctions, ... <a id="ecritureLambda"></a>
On peut maintenant écrire directement le contenu d'une fonction/propriété/procédure en utilisant la syntaxe lambda ( `=>` )


Exemple :
```cs
public class Point
{
  public int PointA{get;set;}
  public string PointB{get;set;}
  public int Distance => (int)(PointA-PointB);

  public void SayHello => Console.WriteLine("Hello world");
}
```

## Initialiseurs avec membres indexés <a id="initMembresIndexes"></a>
On peut maintenant initialiser les Dictionnaires avec la syntaxe suivante :

```cs
var chiens = new Dictionary<string, int>
{
    ["shana"] = 1,
    ["pepita"] = 2,
    ["gold"] = 3,
    ["neska"] = 4,
    ...
};
```
## `await` dans les blocs catch et finally d'un try  <a id="awaitCatchFinally"></a>
En C# 5, `await` ne pouvait pas être utilisé dans les blocs `catch` et `finally`.

On peut donc maintenant faire :
```cs
private async Task DoSomethingAsync()
{
    try
    {
        ...
    }
    catch (Exception ex)
    {
        var dialog = new MessageDialog("Exception");
        await dialog.ShowAsync();
    }
}
```
## Filtres dans les blocs d'exception <a id="filtresExceptions"></a>
On peut maintenant mettre en place des filtres lorsque une exception est levée :

```cs
  try
  {
    ...
  }
  catch(Exception e) when(e is NotImplementedException)
  {
    ...
  }
```
