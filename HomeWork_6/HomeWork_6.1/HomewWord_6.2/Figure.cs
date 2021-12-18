namespace HomewWord_6._2
{
    class Figure
    {
        public Coordinates Coordinates { get; set; }
        public Color Color { get; set; }
        public bool Visiblity { get; set; }

        public Figure(Coordinates coordinates, Color color, bool visiblity)
        {
            Coordinates = coordinates;
            Color = color;
            Visiblity = visiblity;
        }

        public void HorizontalMove()
        {
            
            this.Coordinates = new Coordinates(Coordinates.X + 1, Coordinates.Y);
        }

        public void VerticalMove()
        {
           this.Coordinates = new Coordinates(Coordinates.X, Coordinates.Y + 1);
        }
         
        public void ColorSetting(Color color)
        {
            Color = color;
        }

        public bool IsVisible()
        {
            return Visiblity;
        }

        public override string ToString()
        {
            return $"Текущие координаты X:{this.Coordinates.X} Y:{this.Coordinates.Y} " +
                $"Цвет: {this.Color} Состояние видимости: {this.Visiblity}";
        }
    }
}
