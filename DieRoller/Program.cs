using DieRoller;

Die die = new Die();
Console.WriteLine(die.FaceValue);
Console.WriteLine(die.Roll());
Console.WriteLine(die.Roll());
die.IsHeld = true;
Console.WriteLine("Holding");
Console.WriteLine(die.Roll());
Console.WriteLine(die.Roll());