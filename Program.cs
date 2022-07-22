// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int lastDig = num % 10;
// int penDig = num % 100;
// int penDigRes = penDig / 10;
// int secDig = num % 10000;
// int secDigRes = secDig / 1000;
// int firstDig = num / 10000;

// if(firstDig == lastDig && penDigRes == secDigRes) {
//     Console.WriteLine("Данное число является палиндромом");
// } 
// else {
//     Console.WriteLine("Данное число не является палиндромом");
// }






// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координаты первой точки: ");
// Console.WriteLine("X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Z: ");
// double z = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// Console.WriteLine("X: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Y: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Z: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// double result = 0;

// result = Math.Round(Math.Sqrt((Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2)) + Math.Pow(z1 - z, 2)), 2);
// Console.WriteLine($"{result}");





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++) 
{
    Console.Write(Math.Pow(i, 3) + " ");
}