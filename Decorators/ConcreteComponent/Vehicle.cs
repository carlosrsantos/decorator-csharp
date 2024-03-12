using Decorators.Component;
using Decorators.DTO;

namespace Decorators.ConcreteComponent;
public class Vehicle : IVehicle
{
    private readonly VehicleDTO _vehicle;
    public Vehicle(VehicleDTO vehicle)
    {
        this._vehicle = vehicle;
    }

    public VehicleDTO GetVehicle()
    {
        return this._vehicle;
    }

    public override string ToString()
    {
        return _vehicle.Brand + " - " + _vehicle.Name;
    }

}
