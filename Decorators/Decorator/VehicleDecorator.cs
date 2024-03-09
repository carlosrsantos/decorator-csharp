using Decorators.Component;
using Decorators.DTO;

namespace Decorators.Decorator;
public class VehicleDecorator
{
    private readonly IVehicle _vehicle;

    public VehicleDecorator(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public virtual VehicleDTO GetVehicle()
    {
        return _vehicle.GetVehicle();
    }

    public override string ToString()
    {
        return _vehicle.GetVehicle().Brand + " - " + _vehicle.GetVehicle().Name;
    }
}
