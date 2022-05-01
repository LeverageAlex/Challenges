t = int(input())
fibNbrs = []

x = 0
y = 1
#fibNbrs.append(1)
for p in range(121):
    fibNbrs.append(x + y)
    x = y
    y = fibNbrs[p]

for count in range(t):
    numb = int(input())-1
    if(numb == 0):
        print(0)
        continue
    # print(fibNbrs[numb])
    odd = 0
    sum = 1
    index = 0
    while odd < numb:
        if fibNbrs[index] % 2 == 1:
            sum += fibNbrs[index]
            odd += 1
        index += 1
    print(str(sum))
