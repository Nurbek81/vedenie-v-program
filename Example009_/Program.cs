﻿//найти максимум massiv из 9 чисел используя функцию Max

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//             0  1  2  3  4  5  6  7  8
/*int[]array = {16,26,35,44,53,99,61,17,18,};
array[0] = 12;
Console.WriteLine(array[0]);

int result = Max( Max(array[0],array[1],array[2]),
Max (array[3],array[4],array[5]),
Max (array[6],array[7],array[8]));

Console.WriteLine(result); */


// имеется одномерный массив array из н элементов,нужно найти элемент массива равный find.

int [] array = {1,12,33,4,55,57,32,12,};
int n = array.Length;
int find = 32;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); 
        break;
    }
    index++;

} 







