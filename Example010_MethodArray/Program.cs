﻿// Example010_MethodArray
// Console.WriteLine("Example010_MethodArray!");

// Имеется одномерный массив array из n элементов, требуется найти 
// элемент массива, равный *find*

// 1. Установить счетчик index в позицию 0
// 2. Усли array [index] = find, алгоритм завершил работу успешно завершил работу.
// 3. Увеличить index на 1
// 4. Усли index < n, то перейти к шагу 2. В противноом случае
// алгоритм завершил работу безуспешно.

// Инд (элем мас) 0   1   2   3   4  5   6   7   8   9
﻿int[] array = { 1, 12, 31, 16, 15, 4, 15, 16, 17, 18 }; // Имеется одномерный массив array из n элементов, требуется найти 
//элемент массива, равный *find*

int n = array.Length; // массив array из n элементов
int find = 16; // требуется найти элемент массива, равный *find*

int index = 0; // Установить счетчик index в позицию 0

while (index < n)  //  создаем цикл while, если индекс меньше n выполн нижеуказ действия
{
    if(array[index] == find) // если элемент массива, совпадает *find*
    {
         Console.WriteLine(index);  //  Показываем тек значение идекса
         break; // ставим комманду break, чтобы недублировал одинаковые значения 
    }
    //index = index + 1; 
    index++; // ставим счетчик
}