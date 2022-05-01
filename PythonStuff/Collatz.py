t = int(input())
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
