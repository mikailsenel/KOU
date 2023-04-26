using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Employee;

internal abstract class AircraftEmployee
{
    protected AircraftEmployee NextApprover;
    public abstract string Name { get; set; }
    public abstract string Surname { get; set; }
    public abstract int Age { get; set; }
    public abstract void ProcessRequest(int izinGunSayisi);

    public abstract void IncreaseAge();

    public void SetNextApprover(AircraftEmployee nextApprover)
    {
        this.NextApprover = nextApprover;
    }
}
