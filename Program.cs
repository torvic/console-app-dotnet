using Humanizer;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor ingrese un nombre");
var nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese cargo");
var cargo = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords()}.");