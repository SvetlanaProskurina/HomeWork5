/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементом массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,100);
    }
void MinMax(int [] massive)
{
    int max=0;
    int min=massive[0];

    for(int i = 0; i < massive.Length; i++)
    {
        if (massive[i]>max)
        {
            max=massive[i];  
        }
        
        if (massive[i]<min)
        {
            min=massive[i];
        }
    }
    Console.WriteLine("min значение равно " +min);
    Console.WriteLine("max значение равно " +max);
}


void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
    
PrintArray(massive);
Console.WriteLine();
MinMax(massive);

