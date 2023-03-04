// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string text)
{
    System.Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] LengthArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = ReadInt ($"Введите {i + 1}-й элемент: ");
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"а[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = ReadInt("Введите количество элементов >");
int[] array;
array = LengthArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");