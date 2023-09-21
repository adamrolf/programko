// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;

Console.WriteLine("Hello, World!");
int x;
x = 2;
int y = 3;
double prcoento = 0.42;
// vypiš proměnné
/* cau lidi
 * bude líp
 * */

Console.WriteLine(x);
string name = "adam";
Console.WriteLine("cau " + name);

int number1 = 42;
int number2 = 18;
Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);

Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
int result = number1 / number2;


Console.WriteLine($"result = {result}");


double number3 = 42;
double number4 = 24;


Console.WriteLine($"{number3 / number4} = {number3 / number4}");

double result2 = number3 / number4;
Console.WriteLine(result2);
int result2int = (int)result2;
Console.WriteLine(result2int);

double result2Double = result2int;




bool bool1 = true;
bool bool2 = false;

Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);