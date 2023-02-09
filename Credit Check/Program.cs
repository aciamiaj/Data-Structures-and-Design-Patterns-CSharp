 //Program.cs
Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
Console.WriteLine("Humber ID: N01516797");
Console.WriteLine();

double[] limit  = { 1000, 1000 };

//ask user the method to check credit limit
Console.WriteLine("Choose how you want to check your account");
CreditCheckFactory singleton = CreditCheckFactory.getSingleton();
singleton.getSingletonList().ForEach(Console.WriteLine);
Console.Write(": ");

string checkType = Console.ReadLine();
Console.Write("Enter customer ID: "); //ask user for customer ID
int cID = Convert.ToInt32(Console.ReadLine());

//create instance of CreditCheckFactory
CreditCheckFactory creditFactory = new CreditCheckFactory();
//check if online of offline check of credit limit and show the limit
ICreditCheck creditCheck = creditFactory.FactoryMethod(checkType, limit);
Console.WriteLine("Customer ID: {0} Credit Limit: {2}\n{1}", cID,
    creditCheck.CreditLimit(), creditCheck.GetCreditCheck());
