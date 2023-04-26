using Vize.Tower;

namespace Vize.Plane;

internal class PlaneCreater
{
    public Plane FactoryMethod(PlaneTypes planeType)
    {
        switch (planeType)
        {
            case PlaneTypes.AirbusA320:
                return new AirbusA320(new SabihaGokcenTower());
            case PlaneTypes.Boeing707:
                return new Boeing707(new SabihaGokcenTower());
            default:
                throw new NotImplementedException();
        }
    }
}
