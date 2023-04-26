using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Employee;

internal class AircraftWorker
{
    private List<AircraftEmployee> _employeeList;

    public AircraftWorker()
    {
        this._employeeList = new List<AircraftEmployee>();
    }

    public void AddWorker(AircraftEmployee employee)
    {
        _employeeList.Add(employee);
    }

    public void RemoveWorker(AircraftEmployee employee)
    {
        _employeeList.Remove(employee);
    }

    public void Notify()
    {
        _employeeList.ForEach(x => x.IncreaseAge());
        Console.WriteLine("Age increased.");
    }
}
