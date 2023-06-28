import random

баллы =  0
for i in range(3):
    числа_программы = [random.randint(1, 24) for i in range(3) ]
    print(числа_программы)
    число_пользователя = int(input("введите число от 1 до 24"))
    if число_пользователя in числа_программы :
        баллы +=1
    if баллы >= 1:
        print("вин")
    else:
        print("проигрыш")

