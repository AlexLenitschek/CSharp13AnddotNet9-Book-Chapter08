using Packt.Shared;
using System.Numerics; // BigInteger

Write("Enter a number: ");
string? input = ReadLine();
if (input is null) return;

if (input.Length > 21)
{
    WriteLine("I cannot handle more than twenty one digits!");
    return;
}

BigInteger number = BigInteger.Parse(input);

WriteLine($"{number:N0} in words is {number.PacktToWords()}.");// Example Solution of this algorithm  
if ((int)number < 10000)
{
    WriteLine($"{number:N0} in words is {number.ToWords()}.");// My solution of this algorithm. (goes up to 9999)
}