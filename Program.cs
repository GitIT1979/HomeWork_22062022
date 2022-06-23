// // 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void ExponentAB(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Exponentiation is impossible.");
   }
    else
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = a * result;
            
        }
        Console.WriteLine(a + "," + b + " -> " + result);
    }
    
}

Console.WriteLine ("Input number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number B:");
int B = Convert.ToInt32(Console.ReadLine());
ExponentAB (A, B);

// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigits(int num)
{
    int digits = 1;
    int temp1 = num;
    while (temp1 / 10 > 0)
    {
        digits++;
        temp1 = temp1 / 10;
    }
       
       int result = 0;
    
    for (int i = 0; i < digits; i++)
    {
       int temp2 = num % 10;
       result = result + temp2;
       num = num / 10; 
    }
    return result;
}
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num + " -> " + SumDigits(num));

// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Create8DigitArray(int min, int max)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    // for (int i = 0; i < 8; i++)
    {
       array[i] = new Random().Next(min,max);   
    }
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    // for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Input minimal value of the massive: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of the massive: ");
int maximum = Convert.ToInt32(Console.ReadLine());
int [] myArray = Create8DigitArray(minimum, maximum);
PrintArray(myArray);
Console.Write(" -> [");
PrintArray(myArray);
Console.Write("]");