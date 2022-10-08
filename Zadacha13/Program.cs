// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Vvedite trehznachnoe chislo a");
string a = (Console.ReadLine());
int l = a.Length;
if (l >= 3)
{
    Console.WriteLine(a[2]);
}
else
{
    Console.WriteLine("Третьего числа нет");
}


// второй способ
int b = int.Parse(a);

if (b / 100 > 0)
{
    Console.WriteLine((b % 100) % 10);
}
else
{
    Console.WriteLine("Третьего числа нет");
}