// // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// // является ли оно палиндромом.

// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Является Палиндром");//($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine( "Не является палиндром");//($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine("Не является пятизначным");//($"ОШИБКА: {number} - не является пятизначным");
}



// // Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// // и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координат х первой точки");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат y первой точки");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат z второй точки");
int z1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат x второй точки");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат y второй точки");
int y2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат z второй точки");
int z2 =Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(result);

// // Задача 23 Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num =Convert.ToInt32(Console.ReadLine());
int[]array = new int [num];

for(int i = 0; i < num;i++)
{
    array[i]=(i+1)*(i+1)*(i+1);
    Console.WriteLine(array[i]);
}
