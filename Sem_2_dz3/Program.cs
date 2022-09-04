// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)

{
    if (number == 1 ^ number == 2 ^ number == 3 ^ number == 4 ^ number == 5)
    {
        Console.WriteLine("Этот день не выходной");
    }
    if (number == 6 ^ number == 7)
    {
        Console.WriteLine("Это выходной");
    }
}

else
{
    Console.WriteLine("Вы ввели неверное число");
};
