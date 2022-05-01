t = int(input())

for x in range(t):
    number = int(input())
    values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1]
    chars = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"]
    res = ''
    for i in range(len(values)):
        while number >= values[i]:
            number -= values[i]
            res += chars[i]
    print(res)