// Example 012 Methods Методы
// Console.WriteLine("Example 012 Methods!!!");

﻿//Методы

// count++ - Увеличение счетчика на 1-цу называют Инкриментом,
// а уменьшение счётчика на 1-цу называют Дэнкриментом

/* 1 группа методов - Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ....");
} 
// КАК ВЫЗЫВАЕТСЯ ДАННЫЙ МЕТОД:
// ДЛЯ ВЫЗОВА МЕТОДА: Указ Идентиф данного метода Method1 и указ круглые скобки() Например:
Method1();
*/

/* 2 группа методов - это методы, которые могут принимать какие-нибудь
// аргументы, но в тоже время ничего не возвращают, но могут
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);
// Если мы используем именованные аргументы, в этом случае
// не обязательно писать их по порядку. Например:
Method21(count: 3, msg: "Новый текст");


// Method21("Текст", 4) - Цифра 4 в скобках означает сколько раз
// мы хотим увидить слово Текст; 
*/

/* 3  группа методов - это методы, которые ничего не принимают,
// но что-то возвращают (с их помощью можно генерировать случайные данные)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

/* 4 группа методов - это методы, которые что-то принимают,
// и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//Для вызова этого метода используем команду указ ниже:
string res = Method4(10, "Зорро");
Console.WriteLine(res);
*/

/*  Цикл FOR
// Позволяет объединять в одни скобки (Инициализацию счетчика: int i = 0, 
// Проверку условия: while (i < count), Сам счетчик: i++ ). Например:

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//Для вызова этого метода используем команду указ ниже:
string res = Method4(10, "Цикл FOR!!! ");
Console.WriteLine(res);
*/

/* "ИТЕРПОЛЯЦИИ СТРОК" Console.WriteLine($"{i} * {j} = {i*j}");
/Console.WriteLine($"{i} * {j} = {i*j}"); - произведение берется с помощью
способа "ИТЕРПОЛЯЦИИ СТРОК". 
Пример ИНТЕРПОЛЯЦИЯ СТРОК:
Console.WriteLine($"{i} * {j} = {i*j}");
*/

/* Покажем как работает цикл for на примере таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
       Console.WriteLine($"{i} * {j} = {i * j}"); // способ "ИТЕРПОЛЯЦИЯ СТРОК".
    }
    Console.WriteLine();
}
*/

// ЗАДАЧИ !!!!!
/* Task 1  === Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на большие "К",
// а маленькие "с" заменить на большие "С"  

// Ясна ли задача?

 string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// Позиц симво 0123..
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // Инициализация пустой строки выглядит так. 

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '/');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'п', 'П');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'и', 'И');
Console.WriteLine(newText);
*/

/* Task 2 === 
Алгоритм сортировки методом выбора (Алгоритм сортировки мини-макса)
Пример:

6 8 3 2 1 4 5 7 - Допустим у нас есть какая-то последовательность чисел.
Наша задача выбрать самый первый элемент, и в оставшейся части массива
с учетом нашей текущей позиции опеределить МИНИМАЛЬНЫЙ элемент, после того
как он найден нужно его поменять местамис первым элементом массива. После
этого начинает сравнивать второй элемент массива с третим, и ставить на
место второго элемента МИНИМАЛЬНОЕ значение. И так со всеми элементами массива.

// Например:
 
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы
*/
// Объявим наш массив int[] arr с элементами
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // Снач заведем массив с нескол переменными
// Объявим локальную функцию PrintArray 
void PrintArray(int[] array) // Выводим дан масс на экран с пом методa void? в кач аргум будет прих массив 
{
    int count = array.Length; // Объявл перем count = количества элементов массива

    for (int i = 0; i < count; i++) // Объявим цикл for
    {
        Console.Write($"{array[i]} "); // Выводим массив на экран
    }
    Console.WriteLine(); // Выведим пустую строку
}
// PrintArray(arr); // Проверим с пом коман PrintArray(arr) вывод массива на экран
// Следующим этапом нам нужно написать метод, который
// будет упорядочивать наш массив.


void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)//с пом цикл for пробеж по всем эл наш масс
    {
        int minPosition = i; // на след этапе опред ту позиц, на котор смотрим, и назов ее minPosition
        for(int j = i + 1; j < array.Length; j++) // ищем миним элемент
        {
            if(array[j] < array[minPosition]) 
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
