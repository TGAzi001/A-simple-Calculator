// A simple Calculator
Console.WriteLine("What operation would you like to carry out? \n Multiplication(*) \n Addition(+) \n Subtraction(-) \n Division(/)");
Console.WriteLine("Kindly input the math operator/ symbol");
string operationValue = Convert.ToString(Console.ReadLine());

Console.WriteLine("Input the value(s) you would like to calculate");
Console.WriteLine("Input first value below");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second value below");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (operationValue == "*")
{
    int multiply = Convert.ToInt32(firstValue * secondValue);
    Console.WriteLine("Your answer is: " + multiply);
}
else if (operationValue == "+")
{
    int add = Convert.ToInt32(firstValue + secondValue);
    Console.WriteLine("Your answer is: " + add);
}
else if (operationValue == "-")
{
    int subtract = Convert.ToInt32(firstValue - secondValue);
    Console.WriteLine("Your answer is: " + subtract);
}
else if (operationValue == "/")
{
    int divide = Convert.ToInt32(firstValue / secondValue);
    Console.WriteLine("Your answer is: " + divide);
}
else
{
    Console.WriteLine("Enter a valid operator");
}

