//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;

}
Console.Write("[ ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write("] - Ваш массив чисел.");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля = {sum}.");