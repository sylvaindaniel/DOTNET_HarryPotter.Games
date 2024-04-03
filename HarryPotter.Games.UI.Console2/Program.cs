// See https://aka.ms/new-console-template for more information
using HarryPotter.Game.Core;

Console.WriteLine("Hello, World!");


var menu = new Menu();
menu.Add(1, "TEST 1");
menu.Add(1, "TEST 2");

menu.Afficher(Console.WriteLine);