﻿int[] array = {1, 12, 31, 41, 15, 16, 71, 18};
int n = array.Length;
int find = 41;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.Write(index);
    }
    index++;
}