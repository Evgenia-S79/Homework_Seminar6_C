// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение координаты b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение координаты k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение координаты b2:");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение координаты k2:");
double k2=Convert.ToDouble(Console.ReadLine());

double xIntersection=0;
double yIntersection=0;
if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    xIntersection =(b2-b1)/(k1-k2);
    yIntersection =k1*xIntersection+b1;
    Console.WriteLine("точка пересечения "+" ("+ xIntersection+" ;"+yIntersection+ ")");
}
