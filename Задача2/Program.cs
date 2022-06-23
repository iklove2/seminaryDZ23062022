Console.Write("Введите первое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
    Console.Write($"Число а = {numberA} меньше числа b = {numberB}");
}
if (numberA > numberB)
{
    Console.Write($"Число а = {numberA} больше числа b = {numberB}");
}
if (numberA == numberB)
{
    Console.Write($"Число а = {numberA} равно числу b = {numberB}");
}