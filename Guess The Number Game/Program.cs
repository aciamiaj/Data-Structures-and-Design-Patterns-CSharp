using System.Diagnostics;

Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
Console.WriteLine("Humber ID: N01516797");
Console.WriteLine();

int[] num = new int[5]; //array of integer
Random rand = new Random(); //create random variable
Stack<int> stack = new Stack<int>(); //create stack

Console.WriteLine("Creating 5 random numbers...");
for (int i = 0; i < num.Length; i++)
{ 
    num[i] = rand.Next(1,49); //random number 1-49
    stack.Push(num[i]);
}
Array.Sort(num); //sort the array
for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + "\t"); //print the array elements
}
Console.WriteLine();
//declare variables for score
int guessNum;
int stepCount = 0;
int correctAns = 0;
do
{
    Console.Write("Guess the first number: ");
    guessNum = int.Parse(Console.ReadLine());
    //check if the guess is not the first number
    if (guessNum != stack.First()) 
    {
        Console.WriteLine("Try again!");
        stepCount++;
    }
    else if (guessNum == stack.First()) //if guess is correct
    {
        Console.WriteLine("You got that correct!");
        stack.Pop();
        stepCount++;
        correctAns++;
        Console.WriteLine("=======================================");  
        int[] num2 = new int[stack.Count]; //create new array to copy the contents of the stack
        stack.CopyTo(num2, 0); //copy the stack to new array
        Array.Sort(num2); //sort array
        for (int i = 0; i < num2.Length; i++)
        {
            Console.Write(num2[i] + "\t"); //print the array
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Number not in the list!");
    }
}
 while(stack.Count != 1);
int score = 1000 - (stepCount - correctAns) * 100; //compute the score
Console.WriteLine("You guessed all the numbers in {0} attempts. Your score is {1}.", stepCount, score);

