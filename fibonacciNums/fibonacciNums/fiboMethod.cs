using System;

public static int fiboCalc(int num)
{
    int a = 1, b = 0, temp;
    while (num >= -1)
    {
        temp = a;
        a = a + b;
        b = temp;
        num--;
    }
    return b;
}