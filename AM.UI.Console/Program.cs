// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
Plane plane = new Plane();
plane.Capacity = 100;
plane.ManufactureDate = new DateTime(2000, 12, 01);
plane.Normal = PlaneType.Boing;
Console.WriteLine(plane);