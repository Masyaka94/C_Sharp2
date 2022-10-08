/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
Console.WriteLine ("Vvedite trehznachnoe chislo a");
string a = (Console.ReadLine());
Console.WriteLine(a[1]);

// второй способ
int b = int.Parse(a);
Console.WriteLine((b %100)/10);