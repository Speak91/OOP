namespace HomewWord_6._2
{
    class Point : Figure
    {
        public Point(Coordinates coordinates, Color color, bool visiblity) :base (coordinates, color, visiblity)
        {

        }

        public override string ToString()
        {
            return $"Это точка. Текущие координаты X:{this.Coordinates.X} Y:{this.Coordinates.Y} " +
                $"Цвет: {this.Color} Состояние видимости: {this.Visiblity}";
        }
    }
}
