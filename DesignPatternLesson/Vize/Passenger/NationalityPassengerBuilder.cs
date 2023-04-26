namespace Vize.Passenger;

abstract class NationalityPassengerBuilder
{
    protected Passenger _passenger;
    public Passenger Passenger { get { return _passenger; } }
    public abstract void SetNationality();
}
