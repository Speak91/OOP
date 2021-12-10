namespace HomeWork4
{
    public class House
    {
        /// <summary>
        /// Уникальный номер дома
        /// </summary>
        private static int _id;

        /// <summary>
        /// Количество этажей
        /// </summary>
        private int _numberOfFloors;

        /// <summary>
        /// Количество подьездов
        /// </summary>
        private int _numberOfEntrances;

        /// <summary>
        /// Количество квартир
        /// </summary>
        private int _numberOfApartments;

        /// <summary>
        /// Высота этажа
        /// </summary>
        private float _height;

        /// <summary>
        /// Количество квартир в подьезде
        /// </summary>
        private static int _numberApartmentsInTheEntrance;

        /// <summary>
        /// Количество квартир на этаже
        /// </summary>
        private static int _apartmentsOnFloor;

        /// <summary>
        /// Количество этажей 
        /// </summary>
        public int NumberOfFloors { get { return _numberOfFloors; } set { _numberOfFloors = value; } }
        
        public int NumberOfEntrances { get { return _numberOfEntrances; } set { _numberOfEntrances = value; } }
        public int NumberOfApartments { get { return _numberOfApartments; } set { _numberOfApartments = value; } }
        public float Height { get { return _height; } set { _height = value; } }
        public int NumberApartmentsInTheEntrance { get { return _numberApartmentsInTheEntrance; } set { _numberApartmentsInTheEntrance = value; } }
        public int ApartmentsOnFloor { get { return _apartmentsOnFloor; } set { _apartmentsOnFloor = value; } }
        public int Number { get; }

       internal House()
        {
            Number = ++_id;
            Height = 3;
            NumberOfFloors = 1;
            NumberOfApartments = 1;
            NumberOfEntrances = 1;
        }

        /// <summary>
        /// Вычисления количества квартир в подьезде
        /// </summary>
        /// <returns></returns>
        public virtual int ApartmentsAtTheEntrance()
        {
            if (NumberOfApartments != 0 && NumberOfEntrances !=0)
            {
                NumberApartmentsInTheEntrance = NumberOfApartments / NumberOfEntrances;
                return NumberApartmentsInTheEntrance;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Вычисление количества квартир на этаже
        /// </summary>
        /// <returns></returns>
        public virtual int ApartmentsAtTheFloor()
        {
            if (NumberOfApartments != 0 && NumberOfFloors != 0)
            {
                ApartmentsOnFloor = NumberOfApartments / NumberOfFloors;
                return ApartmentsOnFloor;
            }
            else
            {
                return 0;
            }
        }
        
        /// <summary>
        /// Выичсление Высоты этажа
        /// </summary>
        /// <returns></returns>
        public virtual float FloorAtTheHeight()
        {
            if (Height != 0 && NumberOfFloors != 0)
            {
                float floorHeight = Height / (float)NumberOfFloors;
                return floorHeight;
            }
            else
            {
                return 0;
            }
            
        }

        public override string ToString()
        {
            return $"Номер дома: {Number}\n" +
                 $"Кол-во этажей: {NumberOfFloors}\n" +
                 $"Кол-во подъездов: {NumberOfEntrances}\n" +
                 $"Кол-во квартир: {NumberOfApartments}\n" +
                 $"Кол-во квартир в подъезде: {ApartmentsAtTheEntrance()}\n" +
                 $"Кол-во квартир на этаже: {ApartmentsAtTheFloor()}\n";
        }

    }
}
