int number = 15621;
string numberStr = Convert.ToString(number);
if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3] )
{
    Console.WriteLine($"Число {number} палиндром");
}
else
{
    Console.WriteLine($"Число {number} НЕ палиндром");
}
