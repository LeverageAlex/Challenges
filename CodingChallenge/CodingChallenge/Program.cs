using System;
class Program { 
    int t = int.Parse(Console.ReadLine());
    int n;
    int m;
    int[] summands;
    int wins;

    public Program()
    {
        for (int i = 0; i < t; i++)
        {
            wins = 0;
            String[] line = Console.ReadLine().Split(" ");
            n = int.Parse(line[0]);
            m = int.Parse(line[1]);
            summands = new int[m];

            line = Console.ReadLine().Split(" ");
            for (int j = 0; j < m; j++)
            {
                summands[j] = int.Parse(line[j]);
            }
            BackTracker(0, 0);
            Console.WriteLine(wins);


        }
    }

   /* static void Main(string[] args)
    {
        new Program();
  
}*/



void BackTracker(int currentVal, int index)
{
    for (int i = index; i < m; i++)
    {
        if(currentVal > n)
        {
            return;
        }
        if(currentVal == n)
        {
            wins++;
            return;
        }
        BackTracker(currentVal + summands[i], i);


    }

}

/*
 * global wins
global summands
summands = []
global m
m = 0
wins = 0
t = int(input())

def backTracker(currentVal, targetVal, index):
    global wins
    global summands
    global m
    for o in range(index, m):
        if(currentVal > targetVal):
            return
        if(currentVal == targetVal):
            wins += 1
            return
        backTracker(currentVal + summands[o], targetVal, o)


for p in (range(t)):
    summands = []
    line = input().split()
    n = int(line[0])
    m = int(line[1])
    line = input().split()
    for o in range(m):
        summands.append(int(line[o]))
    wins = 0
    backTracker(0, n, 0)
    print(str(wins))
*/

}