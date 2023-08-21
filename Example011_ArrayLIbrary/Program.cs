// Example011_ArrayLibrary FillArray PrintArray
Console.WriteLine("Example011_ArrayLibrary!!!");

// FillArray - Метод заполнения массива 
// PrintArray Метод печати его на экран

﻿// new int[10] - означает создай новый массив в котором будет 10 элементов
// collection.Length; - длинна массива
// void - если у нас метод ничего не возвращает, он называется void методом
// При использовании void в коде мы не используем оператор return

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
           Console.WriteLine(col[position]); 
           position++;
        }

    }
 int IndexOf(int[] collection, int find)
 {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
 }   

 int[] array = new int[10];
    
FillArray(array);  // Метод FillArray заполнил наш массив
array[4] = 4;
array[7] = 4;

PrintArray(array); // Метд PrintArray распечатал наш массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);