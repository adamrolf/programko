//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("ENTER PASSWORD");
//string password = Console.ReadLine();
//Console.WriteLine("what is our name?");
//string name = Console.ReadLine();
//Console.WriteLine("hello " + name);

//if (password == "1234" )
//{
//    Console.WriteLine("you are the chosen one");
//}
//else
//{
//    Console.WriteLine("wrong password");
//}
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("hobluj");
//}
//int number = 0;
//while (number < 5)
//{ 
//    Console.WriteLine(number);
//    number = number + 1;
//{ 
int otherNumber = 6;
do
{ 
Console.WriteLine(otherNumber);
    otherNumber = otherNumber + 1;  
} while (otherNumber < 5);

Console.WriteLine("Enter a number") ;
string numIterstionstring = Console.ReadLine();

int numIterstions = 0;

bool success = int. TryParse(numIterstionstring, out numIterstions);
Console.WriteLine("success =" + success);
for (int i = 0; i < numIterstions; i = i + 1)
{
    Console.WriteLine(i);
}
if ( success == false)
do
{
    Console.WriteLine("to neni cislo bro delej znova");
    Console.ReadLine();
} while (success == false);