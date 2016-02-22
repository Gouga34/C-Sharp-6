# Nouveautés du C# 6

## Propriétés accessibles uniquement en lecture

Les propriétés accessibles uniquement en lecture ont habituellement un accesseur en lecture public et un accesseur en écriture privé. En C# 6, si l'accesseur en écriture privé n'est pas déclaré, il est automatiquement interprété comme un accesseur existant en readonly. Pour effectuer le même rendu avant l'implémentation de cette fonctionnalité, il fallait déclarer la propriété comme `readonly`.

Déclarer une nouvelle propriété avec cette méthode :

```cs
  public class Dog
  {
    public string Age{get;}
    public string Name{get;set;}
  }
```

## Imports statiques
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
## Écriture lambda dans les propriétés, fonctions, ...
On peut maintenant écrire directement le contenu d'une fonction/propriété/procédure en utilisant la syntaxe lambda ( `=>` ). 
