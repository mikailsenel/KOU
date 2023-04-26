using Vize.Tower;

namespace Vize.Plane;

internal class Boeing707 : Plane
{
    public Boeing707(Tower.Tower tower) : base(tower)
    {

    }
    public override int PassengerCapacity { get; set; }
    public override decimal LoadingCapacity { get; set; }
    public override decimal MaximumSpeed { get; set; }
    public override string AircraftName => "PGS2695 / PGS2695";

    public override PlaneTypes Type => PlaneTypes.Boeing707;

    public override void RequestLandingClearance()
    {
        Console.WriteLine(String.Format("As flight {0} , I request landing clearance.", this.AircraftName));
        _tower.RequestLandingClearance(this);
    }
}
