// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int index = 0; 
Console.WriteLine("Сколько чисел вы хотите ввести? "); 
index = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[index]; 

void FillArray(int[] array)
{
    for (index = 0 ; index < array.Length; index++) 
    {
    Console.WriteLine($"Введите {index + 1} число"); 
    array[index] = Convert.ToInt32 (Console.ReadLine());  
    }
}

void PrintArray(int[]array)
{
   for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    } 
    Console.WriteLine();
} 

int GetNumbersPositive(int[]array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array [index] > 0)
            count ++;
    } 
    return count;
}

FillArray (array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 = " +GetNumbersPositive(array));