// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    while (number>=1000||number<=-1000)
    {
        number=number/10;
    }
    int result = number%10;
    if(result>=0) return result;
    else {
        result=result*-1;}
        return result;
}
int thirdDigit=ThirdDigit(num);
if (num<100&&num>-100)Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> {thirdDigit}");

