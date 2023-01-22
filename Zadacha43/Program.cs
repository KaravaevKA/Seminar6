//Вывод точки пересечения по коэффициентам
Console.WriteLine("Заданы две прямые вида y=kx+b. Необходимо определить координаты точки пересечения");
Console.WriteLine("Введите b1");
double BFirst = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double KFirst = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double BSecond = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double KSecond = Convert.ToDouble(Console.ReadLine());

double X = (BSecond-BFirst)/(KFirst-KSecond);
double Y = (KFirst*(BSecond-BFirst)/(KFirst-KSecond)) + BFirst;
Console.Write("(");
Console.Write(X);
Console.Write(";");
Console.Write(Y);
Console.Write(")");