// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecDigit(int num)
{
    int res = (num%1000)/100;
    if(res>=0)return res;
    else{
        res=res*-1;}
    return res;
}
int secondDigit=SecDigit(num);
if (num<100&&num>=-100)Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> {secondDigit}");

