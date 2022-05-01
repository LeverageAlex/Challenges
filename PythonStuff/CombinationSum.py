global wins
global summands
global m
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



