namespace LinqTest.Classes
{
    internal class Car : Vehicle
    {
        public int NumberOfChairs { get; init; }

        public Car(string name, string brand, int price, int year, int speed, int numberOfChairs) : base(name, brand, price, year, speed)
        {
            if (numberOfChairs <= 0)
                throw new ArgumentException("Number of chair cannot be less than or equals to zero", nameof(numberOfChairs));
            NumberOfChairs = numberOfChairs;
        }

        public override string ToString() => $"[Car: Name = {Name}, Brand = {Brand}, Price = {Price}, Year = {Year}, Speed = {Speed}, NumberOfChair = {NumberOfChairs}]";
    }
}
