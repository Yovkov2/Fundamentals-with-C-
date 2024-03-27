string input = Console.ReadLine();
List<Vehicle> vehicles = new List<Vehicle>();
while(input != "End")
{
    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string types = tokens[0];
    string model = tokens[1];
    string color = tokens[2];
    int horsePower =int.Parse(tokens[3]);
    Vehicle vehicle = new Vehicle(types, model, color, horsePower);
    vehicles.Add(vehicle);
    input = Console.ReadLine();
}
string type = Console.ReadLine();
while(type != "Close the Catalogue")
{
    var vehicle = vehicles.Where(x=> x.Model == type).First();
    Console.WriteLine($"Type: {vehicle.Type}");
    Console.WriteLine($"Model: {vehicle.Model}");
    Console.WriteLine($"Color: {vehicle.Color}");
    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
    type = Console.ReadLine();
}

if(vehicles.Where(x=> x.Type == "Car").Count() > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {vehicles.Where(x => x.Type == "Car").Select(x=>x.HorsePower).Average():f2}");
}
else
{
    Console.WriteLine("Cars have average horsepower of: 0.00.");
}
if(vehicles.Where(x=> x.Type == "Truck").Count() > 0)
{
    Console.WriteLine($"Truck have average horsepower of {vehicles.Where(x=> x.Type == "Truck").Select(x=> x.HorsePower).Average():f2}");
}
else
{
    Console.WriteLine("Truck have average horsepower of: 0.00.");
}
public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}