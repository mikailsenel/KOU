using Vize.Tower;

namespace Vize.Airport;

internal class IstanbulAirport : IAirport
{
    private static İstanbulAirportTower _instance;
    private IstanbulAirport() { }

    public static Tower.Tower getInstance()
    {
        _instance = _instance ?? new İstanbulAirportTower();
        return _instance;
    }
}