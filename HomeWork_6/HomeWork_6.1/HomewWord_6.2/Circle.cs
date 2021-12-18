using System;

namespace HomewWord_6._2
{
    class Circle : Point
    {
        private double Radius { get; set; }
        private double Square { get; set; }
        public Circle(Coordinates coordinates, Color color, bool visiblity, double radius) : base(coordinates, color, visiblity)
        {
            Radius = radius;
        }

        public double CircleArea()
        {
             return Math.Round( Math.PI  * Math.Pow(Radius, 2));
        }

        public override string ToString()
        {
            return $"Это окружность. Текущие координаты X:{this.Coordinates.X} Y:{this.Coordinates.Y} " +
                $"Цвет: {this.Color} Состояние видимости: {this.Visiblity} \nПлощадь: {CircleArea()}";
        }
    }
}
