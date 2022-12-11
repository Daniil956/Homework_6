// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.Write("Enter number of digits in massiv: ");
int numberOfDigits = int.Parse(Console.ReadLine());
int[] arrey = new int [numberOfDigits];
int sum = 0;

for (int i = 0; i < arrey.Length; i++)
{
    System.Console.Write("Enter the number under the index " + i + ": ");
    arrey[i] = int.Parse(Console.ReadLine());
    while (arrey[i] > 0)
    {
        sum +=1;
    }
}
System.Console.WriteLine("[" + string.Join(", ", arrey) + "] -> " + sum);
