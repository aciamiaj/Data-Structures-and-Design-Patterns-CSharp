Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
Console.WriteLine("Humber ID: N01516797");
Console.WriteLine("");

//ontarioFarm
Farm[] ontarioFarm = new Farm[8];
//List Animal
List<Animal> animals = new List<Animal>();

Farm.AddAnimal(animals);

Console.ForegroundColor = ConsoleColor.DarkGreen;
//Print name of the Farm
Console.WriteLine(nameof(ontarioFarm)); 

//Methods
Farm.GetAnimal(animals);

Farm.GetName(animals);

Farm.FindAnimal(animals);

Farm.RemoveAnimal(animals);

Farm.GetNumAnimal(animals);
