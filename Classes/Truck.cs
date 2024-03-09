namespace LinqTest.Classes
{
    internal class Truck : Vehicle
    {
        public float Capacity { get; init; }

        public Truck(string name, string brand, int price, int year, int speed, int capacity) : base (name, brand, price, year, speed)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity cannot be less than or equals to zero", nameof(capacity));
            Capacity = capacity;
        }

        public override string ToString() => $"[Truck: Name = {Name}, Brand = {Brand}, Price = {Price}, Year = {Year}, Speed = {Speed}, Capacity = {Capacity}]";
    }
}
