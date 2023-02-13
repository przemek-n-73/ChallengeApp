using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

int number = 41562600;
string numberToString = number.ToString();
char[] numbersAsLetters = numberToString.ToArray();
List<int> counterList = new List<int>();

Console.WriteLine("Wynik dla liczby: " + number);

Console.WriteLine("");
Console.WriteLine("--- ilości poszczególnych cyfr nie przechowywane w zmiennych ---");

for (var digit = 0; digit < 10; digit++)
{
    var counter = 0;
    foreach (var chars in numbersAsLetters)
    {
        if (Convert.ToString(chars) == Convert.ToString(digit)) counter++;
    }

    Console.WriteLine(digit + " => " + counter);

    counterList.Add(counter);
}

Console.WriteLine("");
Console.WriteLine("--- ilości poszczególnych cyfr przechowywane w liście ---");

for (var digit2 = 0; digit2 <= 9; digit2++)
{
    Console.WriteLine(digit2 + " => " + counterList[digit2]);
}
