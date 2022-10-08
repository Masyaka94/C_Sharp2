/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/
Console.WriteLine("Vvedite nomer dnya nedeli");
int nedeli =int.Parse(Console.ReadLine());
if (nedeli > 5 && nedeli <= 7)
{
    Console.WriteLine("Выходной день");
}
else if (nedeli <= 5)
{
        Console.WriteLine("Будний день");
}
else 
{
    Console.WriteLine("Ошибка ввода");
}