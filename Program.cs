FIRST TASK
Console.WriteLine("ПЕРВАЯ ЗАДАЧА");
Console.WriteLine("введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2) {
    Console.WriteLine($"большее число {num1} ");
}
else {
    Console.WriteLine($"большее число {num2} ");
}

******* SECOND TASK *************************************************************************
Console.WriteLine("_____ ВТОРАЯ ЗАДАЧА _____");
Console.WriteLine("введите первое число");
int num21 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int num22 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите Третье число");
int num23 = int.Parse(Console.ReadLine()!);
if (num21 > num22 & num21 > num23) {
    Console.WriteLine($"Большее число {num21} ");
}
else if (num22 > num21 & num22 > num23) {
    Console.WriteLine($"Большее число {num22} ");
}
else {
    Console.WriteLine($"Большее число {num23} ");
}

******* THIRD TASK *************************************************************************
Console.WriteLine("_____ ТРЕТЬЯ ЗАДАЧА _____");
Console.WriteLine("введите число");
int num31 = int.Parse(Console.ReadLine()!);
if ( num31%2 == 0) {
    Console.WriteLine($"число {num31} является четным ");
}
 else Console.WriteLine($"число {num31} НЕ является четным ");

 ******* FOURTH TASK *************************************************************************
Console.WriteLine("_____ ЧЕТВЕРТАЯ ЗАДАЧА _____");
Console.WriteLine("введите число");
int num41 = int.Parse(Console.ReadLine()!);
Console.WriteLine("все четные числа от 0 до введенного числа: ");
for (int i =1; i < num41; i++ ) {
 if (i%2 == 0) {
Console.Write($"{i}  ");
 }
}
