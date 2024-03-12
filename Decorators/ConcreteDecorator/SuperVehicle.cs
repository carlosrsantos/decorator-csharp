

using Decorators.Component;
using Decorators.Decorator;
using Decorators.DTO;

namespace Decorators.ConcreteDecorator;
public class SuperVehicle : VehicleDecorator
{
    private string Engine { get; set; }
    public SuperVehicle(IVehicle vehicle) : base(vehicle)
    {
        this.Engine = "1.0";
    }
    public SuperVehicle(IVehicle vehicle, string engine) : base(vehicle)
    {
        this.Engine = engine;
    }

    public override SuperVehicleDTO GetVehicle()
    {
        return new SuperVehicleDTO() 
        {
            Name = base.GetVehicle().Name,
            Brand = base.GetVehicle().Brand,
            Engine = this.Engine
        };        
    }

    public override string ToString()
    {
        return base.ToString() + " - " + Engine;
    }

}
