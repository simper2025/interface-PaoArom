// See https://aka.ms/new-console-template for more information
using Fractional;

var list = new List<RationalNumber>
{
    new RationalNumber(1,7),
    new RationalNumber(4,10),
    new RationalNumber(15,25),
    new RationalNumber(17,23),
    new RationalNumber(12,15),
};

var threefifths = new RationalNumber(3, 5);
var index = list.IndexOf(threefifths);
Console.WriteLine($"Found {threefifths} at index {index}");

list.Sort();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].ToString());
}

var listNegative = new List<RationalNumber>
{
    new RationalNumber(-1,7),
    new RationalNumber(4,-10),
    new RationalNumber(-15,25),
    new RationalNumber(17,-23),
    new RationalNumber(-12,-15),
};

System.Console.WriteLine("Negative list:");
var negThreeFifths = new RationalNumber(-3, 5);
var negIndex = listNegative.IndexOf(negThreeFifths);
Console.WriteLine($"Found {negThreeFifths} at index {negIndex}");

listNegative.Sort();
for (int i = 0; i < listNegative.Count; i++)
{
    Console.WriteLine(listNegative[i].ToString());
}

var listWithZero = new List<RationalNumber>
{
    new RationalNumber(0,7),
    new RationalNumber(4,0),
    new RationalNumber(0,25),
    new RationalNumber(17,0),
    new RationalNumber(0,15),
};

System.Console.WriteLine("List with zero:");
var zero = new RationalNumber(0, 1);
var zeroIndex = listWithZero.IndexOf(zero);

Console.WriteLine($"Found {zero} at index {zeroIndex}");

listWithZero.Sort();
for (int i = 0; i < listWithZero.Count; i++)
{
    Console.WriteLine(listWithZero[i].ToString());

    if(listWithZero[i].ToString() == "1/0")
    {
        Console.WriteLine("Warning: Division by zero is undefined.");
    }
}
