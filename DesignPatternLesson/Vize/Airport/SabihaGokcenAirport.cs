using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vize.Plane;
using Vize.Tower;

namespace Vize.Airport;

internal class SabihaGokcenAirport : IAirport
{
    private static SabihaGokcenTower _instance;
    private SabihaGokcenAirport() { }

    public static Tower.Tower getInstance()
    {
        _instance = _instance ?? new SabihaGokcenTower();
        return _instance;
    }
}
