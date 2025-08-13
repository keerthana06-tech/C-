using System;
public class reverse
{
    public int get_reverse(int number)
    {
        int rev = 0;
        while (number != 0)
        {
            rev = rev * 10 + number % 10;
            number /= 10;
        }
        return rev;
    }
}
