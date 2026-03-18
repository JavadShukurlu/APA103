using _05_AbstractClassPolymorphismForEach.Models;

Car car1 = new()
{
    Brand = "Mercedes",
    Model = "E200",
    Year = 2023,
    DoorCount = 4,
    TrunkCapacity = 500,
    IsAutomatic = true,
    MaxSpeed = 220
};
Car car2 = new()
{
    Brand = "BMW",
    Model = "320I",
    Year = 2022,
    DoorCount = 4,
    TrunkCapacity = 480,
    IsAutomatic = true,
    MaxSpeed = 235
};
Car car3 = new()
{
    Brand = "Toyota",
    Model = "Camry",
    Year = 2021,
    DoorCount = 4,
    TrunkCapacity = 524,
    IsAutomatic = true,
    MaxSpeed = 210
};

Motorcycle motorcycle1 = new()
{
    Brand = "Yamaha R1",
    Year = 2023,
    EngineCapacity = 998,
    Type = "Sport",
    HasSidecar = false,
    MaxSpeed = 299
};
Motorcycle motorcycle2 = new()
{
    Brand = "Harley-Davidson",
    Year = 2022,
    EngineCapacity = 1868,
    Type = "Cruiser",
    HasSidecar = true,
    MaxSpeed = 180
};

Truck truck1 = new()
{
    Brand = "MAN TGX",
    Year = 2020,
    CargoCapacity = 18,
    AxleCount = 3,
    CurrentLoad = 12,
    MaxSpeed = 120
};
Truck truck2 = new()
{
    Brand = "Volvo FH16",
    Year = 2021,
    CargoCapacity = 25,
    AxleCount = 4,
    CurrentLoad = 18,
    MaxSpeed = 110
};

Console.WriteLine(car1.CalculateFuelCost(500));
car1.ShowBasicInfo();
Console.WriteLine(car1.GetVehicleInfo());
Console.WriteLine("---------------------------");
Console.WriteLine(car2.CalculateFuelCost(500));
car2.ShowBasicInfo();
Console.WriteLine(car2.GetVehicleInfo());
Console.WriteLine("---------------------------");
Console.WriteLine(car3.CalculateFuelCost(500));
car3.ShowBasicInfo();
Console.WriteLine(car3.GetVehicleInfo());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

Console.WriteLine(motorcycle1.CalculateFuelCost(300));
motorcycle1.ShowBasicInfo();
Console.WriteLine(motorcycle1.GetVehicleInfo());
Console.WriteLine("---------------------------");
Console.WriteLine(motorcycle2.CalculateFuelCost(300));
motorcycle2.ShowBasicInfo();
Console.WriteLine(motorcycle2.GetVehicleInfo());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

Console.WriteLine(truck1.CalculateFuelCost(800));
truck1.ShowBasicInfo();
Console.WriteLine(truck1.GetVehicleInfo());
Console.WriteLine("---------------------------");
Console.WriteLine(truck2.CalculateFuelCost(800));
truck2.ShowBasicInfo();
Console.WriteLine(truck2.GetVehicleInfo());
Console.WriteLine("Elave olunmus yuk:");
truck1.LoadCargo(5);

Vehicle[] vehicles = { car1, car2, car3, motorcycle1, motorcycle2, truck1, truck2 };
Console.WriteLine("Umumi neqliyyat sayi:");
Console.WriteLine(vehicles.Length);
int Sum = 0;
foreach(var item in vehicles)
{
    Sum+= item.MaxSpeed;
}
Console.WriteLine("Ortalama suret:");
Console.WriteLine(Sum/7);

Vehicle maxVehicle = null;
double maxCost = 0;

Console.WriteLine("En bahali yanacaq xerci olan neqliyyat:");
foreach (var item in vehicles)
{
    double distance = 0;

    if (item is Car)
        distance = 500;
    else if (item is Motorcycle)
        distance = 300;
    else if (item is Truck)
        distance = 800;

    double cost = item.CalculateFuelCost(distance);

    if (cost > maxCost)
    {
        maxCost = cost;
        maxVehicle = item;
    }
}
Console.WriteLine($"Brand->{maxVehicle.Brand}");



