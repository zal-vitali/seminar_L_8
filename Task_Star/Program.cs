/* ### Задача со звёздочкой.
Написать функцию Sqrt(x) - квадратного корня, 
которая принимает на вход целочисленное значение x и 
возвращает целую часть квадратного корня от введенного числа.
* 4 -> 2
* 28 -> 5 */

// Спёр идею. Остаток от деления. Магия.
//int Sqrt(int x, int n)
//{
//if (x > n)
// {
//    return Sqrt(x - n, n + 2);
// }
//else return x;
//}

int Sqrt(int x, int n)
{
    //Console.WriteLine($"{x} {n}");
   
   if(x > n * n)
   {
    return Sqrt(x, n + 1);
   }
    else if (x == n*n) return n;
    
    else return n-1;
}

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int sqrt = Sqrt(number, 1);
Console.WriteLine(sqrt);