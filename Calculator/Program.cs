Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
Console.WriteLine("Humber ID: N01516797\n");

Calculator calc = new Calculator(); //Context

IStrategy addStrategy = new AddStrategy();

calc.SetStrategy(addStrategy); //Create a stragtegy object and assign to the context
Console.WriteLine(calc.Calculate(65, 75));

IStrategy multiplyStrategy = new MultiplyStrategy();
calc.SetStrategy(multiplyStrategy); //Create a stragtegy object and assign to the context
Console.WriteLine(calc.Calculate(65, 75));


