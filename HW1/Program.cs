//Hw1.1

Console.WriteLine("Enter first number");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
var num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter fourth number");
var num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the operator");
var oper = Console.ReadLine();

if (oper == "+")
    Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1 + num2 + num3 + num4}");

else if (oper == "-")
    Console.WriteLine($"{num1} - {num2} - {num3} - {num4} = {num1 - num2 - num3 - num4}");

else if (oper == "*")
    Console.WriteLine($"{num1} * {num2} * {num3} * {num4} = {num1 * num2 * num3 * num4}");

else if (oper == "/")
    Console.WriteLine($"{num1} / {num2} / {num3} / {num4} = {num1 / num2 / num3 / num4}");

//Hw1.2 (Naghes)


Console.WriteLine("Enter first number");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
var num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter fourth number");
var num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter first operator");
var oper1 = Console.ReadLine();

Console.WriteLine("Enter second operator");
var oper2 = Console.ReadLine();


Console.WriteLine(num1 + oper1 + num2);



//Hw1.3

Console.WriteLine("Enter a number for square root");
var rootNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number raise to the power 2");
var powNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(rootNum));
Console.WriteLine(Math.Pow(powNum, 2));


Hw1 .4

Console.Write("Enter any number: ");
var Num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter any number: ");
var Num2 = Convert.ToInt32(Console.ReadLine());

var power = 1;
for (int i = 1; i <= Num2; i++)
{
    power = power * Num1;
    Console.Write("Power : " + power);
}




//Hw.2

Console.WriteLine("Enter number of elements :");
var n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter numbers");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
int sub = 0;
int div = 0;
int mult = 0;

Console.WriteLine("Enter operator");
var oper = Console.ReadLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (oper == "+")
    {
        sum += numbers[i];

    }

    else if (oper == "-")
    {
        sub -= numbers[i];

    }

    else if (oper == "/")
    {
        div /= numbers[i];

    }
    else if (oper == "*")
    {
        mult *= numbers[i];

    }

}

Console.WriteLine("sum :" + sum);
Console.WriteLine("submission :" + sub);
Console.WriteLine("divison:" + div);
Console.WriteLine("multication" + mult);


//Hw.3 (naghes)


Console.WriteLine("Enter number of elements :");
var n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter numbers");
    numbers[i] = Convert.ToInt32(Console.ReadLine());

}

Array.Sort(numbers);
foreach (int i in numbers)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    int sum = Console.ReadLine(numbers[0] + numbers[1]);
    int dis = Console.ReadLine(numbers[2] - numbers[3]);
    int div = Console.ReadLine(numbers[4] * numbers[5]);
    var mult = Console.ReadLine(numbers[6] / numbers[7]);
}



if (res > 0)
    Console.WriteLine("Valid");
else if (res == 0)
    Console.WriteLine("The result is zero");
else if (res < 0)
    Console.WriteLine("Invalid");







