internal class Farm
{
    string name;
    List<Animal> animals = new List<Animal>();

    public Farm(string name)
    {
        this.name = name;     
    }
    //AddAnimal method
    internal static void AddAnimal(List<Animal> animals)
    {
        animals.Add(new Cow("Cow1"));
        animals.Add(new Cow("Cow2"));
        animals.Add(new Cow("Cow3"));
        animals.Add(new Cow("Cow4"));
        animals.Add(new Cow("Cow5"));
        animals.Add(new Chicken("Chicken1"));
        animals.Add(new Chicken("Chicken2"));
        animals.Add(new Chicken("Chicken3"));
    }
    //GetAnimal method
    internal static void GetAnimal(List<Animal> animals)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ResetColor();
        //Total number of animals in the farm
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Total number of animals in the farm: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(animals.Count);
    }

    //GetName method
    internal static void GetName(List<Animal> animals)
    {
       
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("List of Cows");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < animals.Count - 3; i++)
        {
            Console.Write("ID: " + (i) + " ");
            Console.WriteLine(animals[i].ToString());
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("List of Chickens");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 5; i < animals.Count; i++)
        {
            Console.Write("ID: " + (i) + " ");
            Console.WriteLine(animals[i].ToString());
        }
    }

    //FindAnimal method
    internal static void FindAnimal(List<Animal> animals)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter animal ID to find: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        int searchID = Convert.ToInt32(Console.ReadLine());
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("Animal with ID {0} is {1}.", search, animals[search]);
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("=======================================");
        if (searchID >= 0 && searchID <= 7)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Animal with ID {0} is {1}.", searchID, animals[searchID]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid animal ID!");
            Console.ResetColor();
            FindAnimal(animals);
        }
       
    }

    //RemoveAnimal method
    internal static void RemoveAnimal(List<Animal> animals)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter animal ID to remove: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        int removeAnimal = Convert.ToInt32(Console.ReadLine());

            if (removeAnimal >= 0 && removeAnimal <= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Animal with ID {0}, {1} is removed.", removeAnimal, animals[removeAnimal]);
                animals.RemoveAt(removeAnimal);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid animal ID!");
                RemoveAnimal(animals);
            }
     }

    //GetNumAnimal method
    internal static void GetNumAnimal(List<Animal> animals)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Updated animal list:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < animals.Count; i++)
        {
            Console.Write("ID: " + (i) + " ");
            Console.WriteLine(animals[i].ToString());
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=======================================");
        Console.ResetColor();
    }
}