Console.Write("Введите первое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число с: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int maxNumber = numberA;
if (numberB > maxNumber)
{
    maxNumber = numberB;
}
if (numberC > maxNumber)
{
    maxNumber = numberC;
}

Console.Write($"{numberA}, {numberB}, {numberC} -> {maxNumber} ");
