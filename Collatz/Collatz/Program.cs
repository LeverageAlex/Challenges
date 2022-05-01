using System;

public class Collatz {

    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            String[] line = Console.ReadLine().Split(" ");
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            int currentMax = 0;
            int currentMaxCounter = 0;

            for (int z = a; z <= b; z++)
            {
                int counter = 1;
                int x = z;
                while (x != 1)
                {
                    counter++;
                    if (x % 2 == 0)
                    {
                        x = x / 2;
                    }
                    else
                    {
                        x = 3 * x + 1;
                    }

                }
                if (currentMaxCounter < counter)
                {
                    currentMax = z;
                    currentMaxCounter = counter;

                }





            }
            Console.WriteLine(currentMax + " " + currentMaxCounter);


        }
    }
}

/*
 * 
 * 
 * t = int(input())
for wdh in range(t):
    line = input().split()
    a = int(line[0])
    b = int(line[1])

    if(a > b):
        temp = a
        a = b
        b = temp

    currentMax = 0
    currentMaxCounter = 0

    for z in range(a, b+1):
        counter = 1
        x = z
        while x != 1:
            counter += 1
            # print(x)
            if x % 2 == 0:
                x = x//2
            else:
                x = 3*x + 1
        if currentMaxCounter < counter:
            currentMax = z
            currentMaxCounter = counter

    print(str(currentMax) + " " + str(currentMaxCounter))
*/


