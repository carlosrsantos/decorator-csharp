using Decorators.Component;
using Decorators.DTO;

namespace Decorators.Decorator;
public class VehicleDecorator
{
    private readonly IVehicle _vehicle;

    public VehicleDecorator(IVehicle vehicle)
    {
        this._vehicle = vehicle;
    }

    public virtual VehicleDTO GetVehicle()
    {
        return this._vehicle.GetVehicle();
    }

    public override string ToString()
    {
        return this._vehicle.GetVehicle().Brand + " - " + this._vehicle.GetVehicle().Name;
    }
}
