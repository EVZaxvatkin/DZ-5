// See https://aka.ms/new-console-template for more information


//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в 
//массиве.

/*void Zadacha34()
{
    Console.Write("Задача 34. В представленном массиве: ");
    int size = 5;
    int[] array = new int[size];
    Fillarray(array);
    Printarray(array);
    EvenNumber(array);

}

void EvenNumber(int[] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.Write("Количество четных чисел = " + count);
}

void Fillarray(int []array, int startNumber = 0, int finishNumber = 0) // создаем массив
{
finishNumber++;
Random random = new Random();

    for (int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
}    

void Printarray(int[] array)  // создем вывод масива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }

}
Zadacha34();

//Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.

void Zadacha36()
{
    Console.Write("Задача 36. В представленном массиве: ");
    int size = 6;
    int[] array = new int[size];
    Fillarray(array);
    Printarray(array);
    ElemetSumNumbers(array);
    
}

void ElemetSumNumbers(int[] array)
{
    Console.WriteLine();
    int SumNumbers = 0;
    int i = 1;
    while (i <= array.Length)
        {
            SumNumbers = SumNumbers + array[i];
            i+=2;
        }
    Console.WriteLine("Сумма элементов нечетных позиций = " + SumNumbers);
}

void Fillarray(int []array, int startNumber = 0, int finishNumber = 0) // создаем массив
{
finishNumber++;
Random random = new Random();

    for (int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(1,10);
    }
}    

void Printarray(int[] array)  // создем вывод масива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }

}

Zadacha36();


//Задача 38: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным элементов 
//массива.

void Zadacha38()
{
    Console.Write("Задача 38. В представленном массиве: ");
    int size = 7;
    double[] array = new double[size];
    Fillarray(array);
    Printarray(array);
    DifferensNumber(array);
    
}

void DifferensNumber(double[] array)
{
    Console.WriteLine();

    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i =0; i < array.Length; i++)
    {
        if (maxNumber < array[i]) maxNumber = array[i];
        if (minNumber > array[i]) minNumber = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxNumber} - {minNumber} = {maxNumber - minNumber}");
}

void Fillarray(double[] array)
{
        Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100); 
    }
}

void Printarray(double[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
    Console.Write(array[i] + "\t");
     }
}

Zadacha38();
*/