using System;

public class RomanNumerals
{
    int n;
    public RomanNumerals()
    {
        
        int t = int.Parse(Console.ReadLine());

        for (int p = 0; p < t; p++)
        {
            n = int.Parse(Console.ReadLine());



            Rekursiv(0, 0, 0, 0, 0, 0, 0, n);







        }



    }

    public void Rekursiv(int i, int v, int x, int l, int c, int d, int m, int left)
    {
        if (left == 0)
        {
            Console.WriteLine("Found Result with I:" + i + "V" + v + "X" + x + "l" + l + "c" + c+ "d" + d + "m" + m);
            return;
        }
        if (left / 1000 >= 1)
        {
            Rekursiv(i, v, x, l, c, d, m + 1, left - 1000);
        }
        else if(left / 500 >= 1)
        {
            if (d + 1 <= 3)
            {
 
                    Rekursiv(i, v, x, l, c, d + 1, m, left - 500);
                
                if (left - 700 >= 0 && d + 1 <= 3 && m + 1 <= 3)
                {
                    if(left - 900 >= 0)
                    Rekursiv(i, v, x, l, c, d + 1, m + 1, left - 900);
                    if (left - 800 >= 0 && d + 2 <= 3)
                        Rekursiv(i, v, x, l, c, d + 2, m + 1, left - 800);
                    if (left - 700 >= 0 && d + 3 <= 3)
                        Rekursiv(i, v, x, l, c, d + 3, m + 1, left - 700);
                }
            }
        }
        else if(left / 100 >= 1)
        {
            if (c + 1 <= 3)
            {
                Rekursiv(i, v, x, l, c + 1, d, m, left - 100);
                if (left - 200 >= 0 && c + 1 <= 3 && d + 1 <= 3)
                {
                    if(left- 400 >= 0 && c + 1 <= 3)
                    Rekursiv(i, v, x, l, c + 1, d + 1, m, left - 400);
                    if (left - 300 >= 0 && c + 2 <= 3)
                        Rekursiv(i, v, x, l, c + 2, d + 1, m, left - 300);
                    if (left - 200 >= 0 && c + 3 <= 3)
                        Rekursiv(i, v, x, l, c + 3, d + 1, m, left - 200);
                }
            }
        }
        else if(left / 50 >= 1)
        {
            if (l + 1 <= 3)
            {
                Rekursiv(i, v, x, l + 1, c, d, m, left - 50);

                if (left - 70 >= 0 && l + 1 <= 3 && c + 1 <= 3)
                {
                    if (left - 90 >= 0)
                        Rekursiv(i, v, x, l + 1, c + 1, d, m, left - 90);
                    if (left - 80 >= 0 && l + 2 <= 3)
                        Rekursiv(i, v, x, l + 2, c + 1, d, m, left - 80);
                    if (left - 70 >= 0 && l + 3 <= 3)
                        Rekursiv(i, v, x, l + 3, c + 1, d, m, left - 70);
                }
            }
        }
        else if(left / 10 >= 1)
        {
            if (x + 1 <= 3)
            {
                Rekursiv(i, v, x + 1, l, c, d, m, left - 10);

                if (left - 40 >= 0 && l + 1 >= 0)
                {
                    if (left - 40 >= 0 && x + 1 <= 3)
                        Rekursiv(i, v, x + 1, l + 1, c, d, m, left - 40);
                    if (left - 30 >= 0 && x + 2 <= 3)
                        Rekursiv(i, v, x + 2, l + 1, c, d, m, left - 30);
                    if (left - 20 >= 0 && x + 3 <= 3)
                        Rekursiv(i, v, x + 3, l + 1, c, d, m, left - 20);
                }
            }
        }
        else if (left / 5 >= 1)
        {
            if (v + 1 <= 3)
            {
                Rekursiv(i, v + 1, x, l, c, d, m, left - 5);
                if (left - 7 >= 0 && x + 1 <= 3)
                {
                    if (left - 9 >= 0 && v + 1 <= 3)
                        Rekursiv(i, v + 1, x + 1, l, c, d, m, left - 9);
                    if (left - 8 >= 0 && v + 2 <= 3)
                        Rekursiv(i, v + 2, x + 1, l, c, d, m, left - 8);
                    if (left - 7 >= 0 && v + 3 <= 3)
                        Rekursiv(i, v + 3, x + 1, l, c, d, m, left - 7);
                }
            }
        }
        else
        {
            if (i + 1 <= 3)
            {
                Rekursiv(i + 1, v, x, l, c, d, m, left - 1);
                if (left - 2 >= 0 && v + 1 <= 3)
                {
                    if (left - 4 >= 0 && i + 1 <= 3)
                        Rekursiv(i + 1, v + 1, x, l, c, d, m, left - 4);
                    if (left - 3 >= 0 && i + 2 <= 3)
                        Rekursiv(i + 2, v + 1, x, l, c, d, m, left - 3);
                    if (left - 2 >= 0 && i + 3 <= 3)
                        Rekursiv(i + 3, v + 1, x, l, c, d, m, left - 2);
                }
            }

        }



    }





    public static void Main(string[] args)
    {
        new RomanNumerals();
    }


}
