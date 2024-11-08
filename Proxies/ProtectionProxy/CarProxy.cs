namespace ProtectionProxy;

public class CarProxy : ICar
{
    private Driver driver;
    private Car car = new Car();

    public CarProxy(Driver driver)
    {
        this.driver = driver;
    }

    public void Drive()
    {
        if (driver.Age >= 16)
            car.Drive();
        else
            WriteLine("The driver is not allowed to drive.");
    }
}