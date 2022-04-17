Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = n1;
int min = n1;

if (n1 > max) max = n1;
if (n1 < max) min = n1;
if (n2 > max) max = n2;
if (n2 < max) min = n2;

Console.WriteLine("max = " +max);
Console.WriteLine("min = " +min);
