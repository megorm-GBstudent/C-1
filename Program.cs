// See https://aka.ms/new-console-template for more information
/*
int n1 = 49;
int n2 = 7;
if (n1 == n2 * n2)
{
    Console.WriteLine("n1 - квадрат числа n2");
}
else
{
    Console.WriteLine("n1 - не квадрат числа n2");
}
*/

/*
//задача 3
Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else 
{
    Console.WriteLine("День недели введен неверно");
}
*/

/*
//Задача 5
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int start = -Math.Abs(n);
int finish = Math.Abs(n);

Console.WriteLine("Начало ввода: ");
while (start <= finish)
{
    Console.WriteLine(start);
    start++;
}
*/

/*
//задача 7

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int b;
b = n%10;
Console.WriteLine("Последнее число");
Console.WriteLine(b);
*/

//Домашнее задание (1 семинар)

/*
//Задание 1

int n1 = 15;
int n2 = 24;

if (n1 > n2)
{
    Console.WriteLine("max = 15");
}
else
{
    Console.WriteLine("max = 24");
}
*/

/*
//Задание 2

Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine("max = " +n1);
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine("max = " +n2);
}
else 
{
    Console.WriteLine("max = " +n3);
}
*/

/*
//Задание 3

Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2==0)
{
    Console.WriteLine("число - четное");
}
else 
{
    Console.WriteLine("число - нечетное");
}
*/


//Задание 4
/*
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int a = 2;
while (a < n)
{
    Console.WriteLine(a);
    a += 2;
}
*/








//SEMINAR 2
//Работа на семинаре
//Задача 9

/*
Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine(number);
int digit1 = number/10;
Console.WriteLine(digit1);
int digit2 = number%10;
Console.WriteLine(digit2);
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}
*/

//Задача 11  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);
int digit1 = number/100;
int digit2 = number%10;
Console.WriteLine(digit1*10 + digit2);
*/
//Другой вариант 11 задачи
/*
Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine(number.ToString()[0]);
Console.WriteLine(number.ToString()[2]);


//Задача 12
/*
Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1%n2==0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.Write("не кратно, остаток равен = ");
    Console.Write(n1%n2);
}

//второй вариант 12 задачи
Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1%n2==0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.Write($"{n1} не кратно {n2}, остаток {n1%n2}");
}
*/

//Задача 14
/*
Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1%7 == 0 && n1%23 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
*/

//Задача 16
/*
Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2*n2 == n1)
{
    Console.WriteLine($"{n1} является квадратом {n2}");
}
else
{
    Console.WriteLine($"{n1} не является квадратом {n2}");
}
*/
//второй вариант 16 задачи
/*
int a,b;
Console.WriteLine("Введите 2 числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
int max, min;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

if (max/min == min)
{
    Console.WriteLine($"{max} является квадратом {min}");
}
else
{
    Console.WriteLine($"{max} не является квадратом {min}");
}
*/

//Домашняя работа (2 семинар)

//Задача 15 (вариант 1)

/*
Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6)
{
    Console.WriteLine("да");
}
else if (day == 7)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
*/

//Задача 15(вариант 2)
/*
Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
*/

//Задача 13
/*
Console.WriteLine("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 > 99)
{
    Console.WriteLine(n1.ToString()[2]);

}
else
{
    Console.WriteLine("третьей цифры нет");
}
*/







//SEMINAR 3


//Задача 17
/*
Console.WriteLine("Введите координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{x}; {y}]");

if (x == 0 || y == 0)
{
    Console.WriteLine("Введите ненулевые значения");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("точка лежит в 1 четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("точка лежит вo 2 четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("точка лежит в 3 четверти");
    }
    else
    {
        Console.WriteLine("точка лежит в 4 четверти");
    }
}
*/

//Задача 18

/*
Console.WriteLine("Введите координаты значение от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("(0;+ беск); (0; +беск)");
}
else if (x == 2)
{
    Console.WriteLine("(-беск; 0); (0; +беск)");
}
else if (x == 3)
{
    Console.WriteLine("(-беск; 0); (0; -беск)");
}
else if (x == 4)
{
    Console.WriteLine("(0; +беск); (0; -беск)");
}
*/


//Задача 21

/*
Console.WriteLine("Введите координаты значение x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Координаты точки А: [{x1}; {y1}]");
Console.WriteLine($"Координаты точки B: [{x2}; {y2}]");

Console.WriteLine("Расстояние между точками А и B равно: ");
Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)));
*/

//Задача 21 (второй способ с массивами)

/*
int[] pointA = new int[2] {5, 9};
int[] pointB = new int[2];
pointB[0] = 2;
pointB[1] = 5;

Console.WriteLine(Math.Sqrt(Math.Pow(pointA[0]-pointB[0],2) + Math.Pow(pointA[1] - pointB[1], 2)));
*/

//Задача 22

/*
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= n)
{
    Console.WriteLine(a*a);
    a++;
}
*/





//Домашняя работа (семинар 3)

//Задача 23
/*
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= n)
{
    Console.WriteLine($"{a} --> {Math.Pow(a, 3)}");
    a++;
}
*/

//Задача 19
/*
Console.WriteLine("Введите пятизначное число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 9999 && a < 100000)
{
    if (a.ToString()[0] == a.ToString()[4] && a.ToString()[1] == a.ToString()[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
else
{
    Console.WriteLine("Введено неверное число");
}
*/

//Задача 21
/*
Console.WriteLine("Введите координаты значение x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты значение z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Координаты точки А: [{x1}; {y1}; {z1}]");
Console.WriteLine($"Координаты точки B: [{x2}; {y2}; {z2}]");

Console.WriteLine("Расстояние между точками А и B равно: ");
Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)));
*/