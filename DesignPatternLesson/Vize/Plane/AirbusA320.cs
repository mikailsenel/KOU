using Vize.Tower;

namespace Vize.Plane;

internal class AirbusA320 : Plane
{
    public AirbusA320(Tower.Tower tower) : base(tower)
    {

    }

    public override int PassengerCapacity { get; set; }
    public override decimal LoadingCapacity { get; set; }
    public override decimal MaximumSpeed { get; set; }

    public override string AircraftName => "THY2695 / TK2695";
    public override PlaneTypes Type => PlaneTypes.AirbusA320;


    public override void RequestLandingClearance()
    {
        Console.WriteLine(String.Format("As flight {0} , I request landing clearance.", this.AircraftName));
        _tower.RequestLandingClearance(this);
    }
}
