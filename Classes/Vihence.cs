namespace LinqTest.Classes
{
    internal abstract class Vehicle
    {
        public string Name { get; init; }
        public string Brand { get; init; }
        public int Price { get; init; }
        public int Year { get; init; }
        public int Speed { get; init; }

        public Vehicle(string name, string brand, int price, int year, int speed)
        {
            if (speed <= 0)
                throw new ArgumentException("Speed cannot be less than or equals to zero.", nameof(speed));
            if (year <= 0)
                throw new ArgumentException("Year must be greater than or equals to 0.", nameof(year));
            Name = name;
            Brand = brand;
            Price = price;
            Year = year;
            Speed = speed;
        }

        public abstract override string ToString();
    }
}
