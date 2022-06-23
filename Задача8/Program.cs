Console.Write("Введите Число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 1)
{
    Console.WriteLine($"Не верный ввод, число {numberN} отрицательное!");
}

Console.Write($"Для числа {numberN} -> ");
for (int i = 2; i <= numberN; i = i + 2)
{
    Console.Write($"{i}, ");
}