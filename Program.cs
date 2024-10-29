using Laba2_task_2_3_;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Лабораторная работа №2. Задания 2 и 3");
        Console.WriteLine("Выберите номер задания");
        short number = short.Parse(Console.ReadLine());
        switch (number)
        {
            case 2:
                Console.WriteLine("Задание 2. Тестирование методов и конструкторов");
                //коструктор по умолчанию
                Console.WriteLine("1) Конструктор по умолчанию (инициализация координат нулями)");
                Point new_point = new Point();
                Console.WriteLine(new_point.ToString());
                Console.WriteLine("Расстояние от данной точки до начала координат: " + new_point.DistanceToOrigin());

                Console.WriteLine();

                //конструктор с параметрами
                Console.WriteLine("2) Конструктор с параметрами\nВведите координаты x и y");
                if (double.TryParse(Console.ReadLine(), out double x1) && (double.TryParse(Console.ReadLine(), out double y1)))
                {
                    Point new_point1 = new Point(x1, y1);
                    Console.WriteLine(new_point1.ToString());
                    Console.WriteLine("Расстояние от данной точки до начала координат: " + new_point1.DistanceToOrigin());
                }
                else Console.WriteLine("Некорректный формат входных данных");

                Console.WriteLine();

                //конструктор копирования
                Console.WriteLine("3) Конструктор копирования");
                Console.WriteLine("Введите координаты x и y");
                if (double.TryParse(Console.ReadLine(), out double x2) && (double.TryParse(Console.ReadLine(), out double y2)))
                {
                    Point new_point2 = new Point(x2, y2);
                    Console.WriteLine("Новый объект: " + new_point2.ToString());
                    Point copy_new_point2 = new Point(new_point2);
                    Console.WriteLine("Копия: " + copy_new_point2.ToString());
                    Console.WriteLine("Расстояние от данной точки до начала координат: " + new_point2.DistanceToOrigin());
                    Console.WriteLine("Расстояние от копии данной точки до начала координат: " + copy_new_point2.DistanceToOrigin());
                }
                else Console.WriteLine("Некорректный формат входных данных");
                break;

            case 3:
                Console.WriteLine("Задание 3. Перегрузка операций");
                Console.WriteLine("Введите координаты x и y");
                if (double.TryParse(Console.ReadLine(), out double x) && (double.TryParse(Console.ReadLine(), out double y)))
                {
                    Point p = new Point(x, y);
                    Console.WriteLine("Вы ввели: " + p.ToString() + "\n");
                    Console.WriteLine("1) Уменьшение координат x и y на 1: " + p--.ToString());

                    Console.WriteLine();

                    Point new_p = new Point(x, y);
                    Console.WriteLine("2) Поменяли местами координаты x и y: " + -new_p);

                    Console.WriteLine();

                    Point point = new Point(x, y);

                    int Int_X = point;
                    Console.WriteLine("3) Целая часть координаты x: " + Int_X + "\n");

                    double Double_Y = (double)point;
                    Console.WriteLine("4) Координата y: " + Double_Y);

                    Console.WriteLine();

                    Point inp_point = new Point(x, y);
                    Console.WriteLine("Введите целое значение, на которое нужно уменьшить координату x");
                    if (int.TryParse(Console.ReadLine(), out int value_x))
                    {
                        Point point1 = inp_point - value_x;
                        Console.WriteLine("5) Point p, целое число (левосторонняя операция, уменьшается координата х); " + point1 + "\n");

                    }
                    else Console.WriteLine("Некорректный формат входных данных\n");

                    Console.WriteLine("Введите целое значение, на которое нужно уменьшить координату y");
                    if (int.TryParse(Console.ReadLine(), out int value_y))
                    {
                        Point point2 = value_y - inp_point;
                        Console.WriteLine("6) целое число, Point p (правосторонняя операция, уменьшается координата y);  " + point2 + "\n");


                    }
                    else Console.WriteLine("Некорректный формат входных данных\n");

                    Console.WriteLine("Нахождение расстояния от точки до точки");
                    Console.WriteLine("Введите координаты x и y для двух точек");
                    if (double.TryParse(Console.ReadLine(), out double X1) && double.TryParse(Console.ReadLine(), out double Y1) &&
                        double.TryParse(Console.ReadLine(), out double X2) && double.TryParse(Console.ReadLine(), out double Y2))
                    {
                        Point p1 = new Point(X1, Y1);
                        Point p2 = new Point(X2, Y2);
                        Console.WriteLine("Новая точка 1: " + p1);
                        Console.WriteLine("Новая точка 2: " + p2);
                        double distance = p1 - p2;
                        Console.WriteLine("Расстояние от точки 1 до точки 2 = " + distance);
                    }
                    else Console.WriteLine("Некорректный формат входных данных");
                }
                else Console.WriteLine("Некорректный формат входных данных");
                break;
            default: break;
        }
    }
}