Console.Write("Введите Число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN % 2 == 0)
{
    Console.Write($"Число {numberN} -> да четное");
}
else
{
    Console.Write($"Число {numberN} -> нет не четное");
}
