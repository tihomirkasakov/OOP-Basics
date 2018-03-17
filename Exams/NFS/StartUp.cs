public class StartUp
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager();
        Engine engine = new Engine(carManager);
        engine.Run();
    }
}