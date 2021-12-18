using System;
namespace HomewWord_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Coordinates(2, 3), Color.Blue, true);
            Console.WriteLine(figure);
            figure.VerticalMove();
            Console.WriteLine("Движемся по вертикали");
            Console.WriteLine(figure);
            Console.WriteLine("Меняем цвет");
            figure.ColorSetting(Color.Brown);
            Console.WriteLine();

            Point point = new Point(new Coordinates(3, 4), Color.Gray, false);
            Console.WriteLine(point);
            point.VerticalMove();
            Console.WriteLine("Движемся по вертикали");
            Console.WriteLine(point);
            Console.WriteLine("Меняем цвет");
            point.ColorSetting(Color.Brown);
            Console.WriteLine(point);
            Console.WriteLine();

            Circle circle = new Circle(new Coordinates(5, 6), Color.Purple, false, 2.5);
            Console.WriteLine(circle);
            circle.VerticalMove();
            Console.WriteLine("Движемся по вертикали");
            Console.WriteLine(circle);
            Console.WriteLine("Меняем цвет");
            circle.ColorSetting(Color.Brown);
            Console.WriteLine(circle);
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(new Coordinates(6, 8), Color.Pink, true, 3, 4);
            Console.WriteLine(rectangle);
            rectangle.VerticalMove();
            Console.WriteLine("Движемся по вертикали");
            Console.WriteLine(rectangle);
            Console.WriteLine("Меняем цвет");
            rectangle.ColorSetting(Color.Brown);
            Console.WriteLine(rectangle);
            Console.WriteLine();
        }
    }
}
