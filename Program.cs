// See https://aka.ms/new-console-template for more information
using LinqTest.Classes;

List<Car> cars = 
[
    new Car("car00001", "brand5", 68105, 1906, 73, 6),
    new Car("car00002", "brand4", 95653, 2013, 166, 4),
    new Car("car00003", "brand1", 140638, 2007, 176, 7),
    new Car("car00004", "brand2", 34864, 1943, 159, 6),
    new Car("car00005", "brand1", 18591, 1963, 168, 4),
    new Car("car00006", "brand3", 11240, 1980, 171, 4),
    new Car("car00007", "brand5", 64731, 1950, 119, 6),
    new Car("car00008", "brand4", 172327, 1956, 156, 6),
    new Car("car00009", "brand2", 12334, 1916, 105, 6),
    new Car("car00010", "brand1", 138736, 1903, 126, 5)
];

List<Truck> trucks = 
[
    new Truck("truck00001", "brand5", 155718, 1993, 100, 352),
    new Truck("truck00002", "brand3", 144271, 1933, 80, 604),
    new Truck("truck00003", "brand2", 154007, 2012, 87, 663),
    new Truck("truck00004", "brand5", 141437, 2011, 85, 788),
    new Truck("truck00005", "brand4", 122489, 2021, 91, 452),
    new Truck("truck00006", "brand4", 133151, 1978, 73, 662),
    new Truck("truck00007", "brand2", 110370, 2020, 96, 757),
    new Truck("truck00008", "brand2", 186256, 1998, 88, 634),
    new Truck("truck00009", "brand3", 159456, 2008, 71, 559),
    new Truck("truck00010", "brand1", 131485, 2009, 76, 760)
];

Console.WriteLine("Bai 1: ");

IEnumerable<Car> carFiltered = cars.Where(c => c.Price >= 100000 && c.Price <= 250000);
Console.WriteLine("Danh sach cac xe co gia tu 100000 den 250000");
foreach (Car car in carFiltered)
    Console.WriteLine("\t" + car);

carFiltered = cars.Where(c => c.Year >= 1990);
Console.WriteLine("\nDanh sach cac xe tu nam 1990 tro ve sau");
foreach (Car car in carFiltered)
    Console.WriteLine("\t" + car);

IEnumerable<IGrouping<string, Car>> brandGrouping = cars.GroupBy(c => c.Brand);
Console.WriteLine("\nDanh sach cac xe dua tren nhom thuong hieu: ");
foreach (IGrouping<string, Car> group in brandGrouping)
{
    Console.WriteLine($"Thuong hieu {group.Key}:");
    foreach (Car car in group)
        Console.WriteLine("\t" + car);
}


IEnumerable<(string brand, int price)> sumPriceByBrand = brandGrouping.Select(group => (group.Key, group.Sum(c => c.Price)));
Console.WriteLine("\nTong gia xe cua cac thuong hieu");
foreach ((string brand, int price) in sumPriceByBrand)
    Console.WriteLine($"\t{brand}: {price}");

Console.WriteLine("\nBai 2: ");
IEnumerable<Truck> sortedTruck = trucks.OrderByDescending(t => t.Year);
Console.WriteLine("Danh sach xe tai duoc sap xep dua tren nam san xuat theo thu tu giam dan:");
foreach (Truck truck in sortedTruck)
    Console.WriteLine("\t" + truck);

IEnumerable<string> brandNames = trucks.Select(trucks => trucks.Brand).Distinct();
Console.WriteLine("\nDanh sach cong ty cua cac hang xe tren: ");
foreach (string name in brandNames)
    Console.WriteLine("\t" + name);

