using dotnet___poo.src.Entities;

Knight knight = new Knight("Arus", 23, "Knight", 20, 40);
Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 15, 80);
Healer healer = new Healer("LucT", 51, "Supreme Healer", 10, 60);

Console.WriteLine(knight.Attack());
Console.WriteLine(wizard.Attack(2));
Console.WriteLine(wizard.Attack(8));
Console.WriteLine(healer.Heal(10, knight));