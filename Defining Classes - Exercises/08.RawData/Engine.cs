public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int speed, int power)
    {
        this.EngineSpeed = speed;
        this.EnginePower = power;
    }

    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }

}