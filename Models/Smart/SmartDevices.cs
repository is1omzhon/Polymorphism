namespace Models.Smart.SmartDevices;

class Device
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Device turned on !!!");
    }
}

class Phone : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Phone is turning on");
    }
}

class Laptop : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Laptop is turning on");
    }
}

class TV : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("TV is turning on");
    }
}