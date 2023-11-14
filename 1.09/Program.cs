int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// int a1 = 15; // научились создавать массивы и по этому часть этого кода больше не нужна
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

int[] array = {15, 21, 39, 12, 23, 33, 13, 23, 33};

// int max = a1; // научились создавать функции и по этому часть этого кода больше не нужна
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;
// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;
// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
int max = Max(max1, max2, max3);

Console.Write(max);