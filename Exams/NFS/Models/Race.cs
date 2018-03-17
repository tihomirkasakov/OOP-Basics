using System.Collections.Generic;

public abstract class Race
{
    protected Race(int length, string route, int prize)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prize;
        this.Participants = new List<Car>();
    }

    public int Length { get; private set; }

    public string Route { get; private set; }

    public int PrizePool { get; private set; }

    public IList<Car> Participants { get; private set; }

    public abstract string GetRanking();
}