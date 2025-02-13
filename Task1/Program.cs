using Classes;
using System;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №5");
            Console.WriteLine("1-21");
            int sm = Convert.ToInt32(Console.ReadLine());

            double a, b, c, ax, ay, bx, by, r, a1, b1, c1, r1;

            switch (sm)
            {
                case 1:
                    Console.WriteLine("Введите значение А");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator1 calculator1 = new Calculator1(a, b);
                    if (calculator1.CalculateA())
                        Console.WriteLine("Сумма квадратов больше, чем квадрат суммы");
                    else Console.WriteLine("Квадрат суммы больше, сумма квадратов");
                    break;

                case 2:
                    Console.WriteLine("Введите ваш стаж:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вашу зарплату:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator2 calculator2 = new Calculator2(a, b);
                    Console.WriteLine($"Надбавка к зарплате: {calculator2.CalculateA()}");
                    Console.WriteLine($"Сумма к выплате: {calculator2.CalculateB()}");
                    break;

                case 3:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Bx");
                    bx = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату By");
                    by = Convert.ToDouble(Console.ReadLine());


                    Calculator3 calculator3 = new Calculator3(ax, ay, bx, by);
                    if (calculator3.CalculateA()) Console.WriteLine("Точка A раполагается на более удалённом расстоянии");
                    else Console.WriteLine("Точка B раполагается на более удалённом расстоянии");
                    break;

                case 4:
                    Console.WriteLine("Введите значение стороны треугольника А:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника B:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника C:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Calculator4 calculator4 = new Calculator4(a, b, c);
                    if (calculator4.CalculateA()) Console.WriteLine("Треугольник ABC является треугольником");
                    else Console.WriteLine("Треугольник ABC не является треугольником");
                    break;

                case 5:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Calculator5 calculator5 = new Calculator5(a, b, c);
                    double[] arr = calculator5.CalculateA();
                    Console.WriteLine("Ваши числа после изменения:");
                    foreach (int i in arr) Console.Write(i + ", ");
                    break;

                case 6:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator6 calculator6 = new Calculator6(ax, ay);
                    Console.WriteLine($"Точка А находится в {calculator6.CalculateA()} четверти");
                    break;

                case 7:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator7 calculator7 = new Calculator7(ax, ay, r);
                    if (calculator7.CalculateA()) Console.WriteLine("Точка А лежит внутри окружности");
                    else Console.WriteLine("Точка А не лежит внутри окружности");
                    break;

                case 8:
                    Console.WriteLine("Введите сторону 1 треугольника A");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону 1 треугольника B");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону 1 треугольника C");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2 треугольника A");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2 треугольника B");
                    b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону 2 треугольника C");
                    c1 = Convert.ToDouble(Console.ReadLine());


                    Calculator8 calculator8 = new Calculator8(a, b, c, a1, b1, c1);
                    if (calculator8.CalculateA()) Console.WriteLine("Площадь первого треугольника больше площади второго");
                    else Console.WriteLine("Площадь второго треугольника больше площади первого");
                    break;

                case 9:
                    Console.WriteLine("Введите сторону квадрата");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус круга:");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator9 calculator9 = new Calculator9(a, r);
                    if (calculator9.CalculateA()) Console.WriteLine("Площадь квадрата больше, чем площадь круга");
                    else Console.WriteLine("Площадь круга больше, чем площадь квадрата");
                    break;

                case 10:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Calculator10 calculator10 = new Calculator10(a, b, c);
                    arr = calculator10.CalculateA();
                    Console.WriteLine("Ваши числа после изменения:");
                    foreach (int i in arr) Console.Write(i + ", ");
                    break;

                case 11:
                    Console.WriteLine("Введите наторальное число");
                    int ai = Convert.ToInt32(Console.ReadLine());

                    Calculator11 calculator11 = new Calculator11(ai);
                    if (calculator11.CalculateA() == 1) Console.WriteLine("Число является четным");
                    else if (calculator11.CalculateA() == 2) Console.WriteLine("Число оканчивается на 3");
                    else Console.WriteLine("Число не является натуральным или не является четным, или не оканчивается на три");
                    break;

                case 12:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator12 calculator12 = new Calculator12(ax, ay);
                    if (calculator12.CalculateA()) Console.WriteLine("Данная точка лежит в первой четверти");
                    else Console.WriteLine("Данная точка лежит в первой четверти");
                    break;

                case 13:
                    Console.WriteLine("Введите срок договора:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сумму вклада:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator13 calculator13 = new Calculator13(a, b);
                    Console.WriteLine($"Сумма ежемесячных выплат по депозиту: {calculator13.CalculateA()}");
                    break;

                case 14:
                    Console.WriteLine("Введите значение А");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator14 calculator14 = new Calculator14(a, b);
                    if (calculator14.CalculateA())
                        Console.WriteLine("Разность квадратов больше, чем модуль квадрата разности");
                    else Console.WriteLine("Модуль квадрата разности больше, чем разность квадратов");
                    break;

                case 15:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Bx");
                    bx = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату By");
                    by = Convert.ToDouble(Console.ReadLine());


                    Calculator15 calculator15 = new Calculator15(ax, ay, bx, by);
                    if (calculator15.CalculateA()) Console.WriteLine("Точка A раполагается на более удалённом расстоянии");
                    else Console.WriteLine("Точка B раполагается на более удалённом расстоянии");
                    break;

                case 16:
                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности");
                    r1 = Convert.ToDouble(Console.ReadLine());

                    Calculator16 calculator16 = new Calculator16(ax, ay, r, r1);
                    if (calculator16.CalculateA()) Console.WriteLine("Два числа из четырёх - чётные");
                    else Console.WriteLine("Либо меньше двух чисел четные, либо больше");
                    break;

                case 17:


                    Console.WriteLine("Введите координату Ax");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator17 calculator17 = new Calculator17(ax, ay);
                    if (calculator17.CalculateA()) Console.WriteLine("Данная точка лежит в 4 четверти");
                    else Console.WriteLine("Данная точка лежит в 4 четверти");
                    break;

                case 18:
                    Console.WriteLine("Введите значение стороны треугольника А:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника B:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника C:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Calculator18 calculator18 = new Calculator18(a, b, c);
                    if (calculator18.CalculateA()) Console.WriteLine("Треугольник ABC является равнобедренным");
                    else Console.WriteLine("Треугольник ABC не является равнобедренным");
                    break;

                case 19:
                    Console.WriteLine("Введите первое число:");
                    ai = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int bi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    int ci = Convert.ToInt32(Console.ReadLine());
                    Calculator19 calculator19 = new Calculator19(ai, bi, ci);
                    if (calculator19.CalculateA()) Console.WriteLine("Числа являются тройкой пифагора");
                    else Console.WriteLine("Числа не являются тройкой пифагора");
                    break;

                case 20:
                    БАБАБУНДА;
                    Calculator20 calculator20 = new Calculator20();
                    calculator20.CalculateB();
                    break;

                case 21:
                    БАБАБУНДА;
                    Console.WriteLine("Введите ваш стаж от 0 до 10 лет:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Calculator21 calculator21 = new Calculator21(a);
                    Console.WriteLine($"Ваш коэффициент составляет: {calculator21.CalculateA()}");
                    break;
            }
        }
    }
}