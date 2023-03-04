// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 44 -> 101100
// // 3  -> 11
// // 2  -> 10

// int ReadInt(string promt)
// {
//     System.Console.WriteLine(promt);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[] ConverToBinary(int value)
// {
//     int count = 0;
//     int value2 = value;
//     while (value2 > 0)
//     {
//         value /= 2;
//         count++;
//     }
//     int[] result = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         result[i] = value2%2;
//         value /=2;
//     }
//     Array.Reverse(result);
//     return result;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine(string.Join("", array));
// }

// int num = ReadInt("Введите число: ");
// int[] binaryNum = ConverToBinary(num);
// PrintArray(binaryNum);


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
    if (num == 0) return;
    GetBinaryView(num / 2);
    System.Console.Write(num % 2);
}

int N = ReadInt("Введите число");
GetBinaryView(N);
