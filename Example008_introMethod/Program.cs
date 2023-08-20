// Example008_introMethod !!
// Console.WriteLine("Example008_introMethod!")

 ﻿int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;                // Данный кусоч кода от строки int Max и до окончания
   if(arg2 > result) result = arg2;  // фигурных скобок отвечает за нахождение максимума
   if(arg3 > result) result = arg3;  // из трех чисел
   return result;                      
}

int a1 = 1527;
int b1 = 21;
int c1 = 3485;
int a2 = 12;
int b2 = 52366487;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max = a1;
// if(b1 > max) max=b1;
// if(c1 > max) max=c1;

// if(a2 > max) max=a2;
// if(b2 > max) max=b2;
// if(c2 > max) max=c2;

// if(a3 > max) max=a3;
// if(b3 > max) max=b3;
// if(c3 > max) max=c3;

//  int max1 = Max(a1, b1, c1);
//  int max2 = Max(a2, b2, c2);
//  int max3 = Max(a3, b3, c3);
//  int max = Max(max1, max2, max3);

 int max = Max(
     Max(a1, b1, c1),
     Max(a2, b2, c2),
     Max(a3, b3, c3));

Console.WriteLine(max);
