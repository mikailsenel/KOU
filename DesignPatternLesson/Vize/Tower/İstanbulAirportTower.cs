using Vize.Plane;

namespace Vize.Tower;

internal class İstanbulAirportTower : Tower
{
    public override void RequestLandingClearance(Plane.Plane plane)
    {
        switch (plane.Type)
        {
            case PlaneTypes.Boeing707:
                AllowLanding(plane);
                return;
            case PlaneTypes.AirbusA320:
                DoNotAllowLanding(plane);
                return;
            default:
                throw new Exception("Aircraft not found");
        }
    }
}
