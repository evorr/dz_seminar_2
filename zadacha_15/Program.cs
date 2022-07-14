// Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
int Check(int number)
{
    if (number>=1&&number<=7)return number;
    else{
        Console.Write("Введите число от 1 до 7: ");
        int newnum = Convert.ToInt32(Console.ReadLine());
        return Check(newnum);
    }
}
int day = Check(num);
if (day<6) Console.WriteLine($"{day} -> нет");
else Console.WriteLine($"{day} -> да");
