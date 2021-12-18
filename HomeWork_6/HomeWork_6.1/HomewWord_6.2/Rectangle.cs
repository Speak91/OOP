namespace HomewWord_6._2
{
    class Rectangle : Point
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(Coordinates coordinates, Color color, bool visiblity, double sideA, double sideB) 
            : base(coordinates, color, visiblity)
        {
            SideA = sideA;
            SideB = sideB;

        }

        public double Square()
        {
            double square = 0;
            square = SideA * SideB;
            return square;
        }

        public override string ToString()
        {
            return $"Это прямоугольник. Текущие координаты X:{this.Coordinates.X} Y:{this.Coordinates.Y} " +
                 $"Цвет: {this.Color} Состояние видимости: {this.Visiblity} Площадь: {Square()}";
        }
    }
}
