using Decorators.ConcreteComponent;
using Decorators.ConcreteDecorator;

var car = new Vehicle(new() { Name = "Uno", Brand = "Fiat" });

var car2 = new SuperVehicle(car);
var car3 = new SuperVehicle(car,"1.4");

Console.WriteLine(car.ToString());
Console.WriteLine(car2.ToString());
Console.WriteLine(car3.ToString());