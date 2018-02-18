using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string carModel;
    private decimal fuel;
    private decimal fuelConsumption;
    private int distance;

    public Car()
    {

    }

    public Car(string model, decimal fuel, decimal consumption, int distance=0)
    {
        this.CarModel = model;
        this.Fuel = fuel;
        this.FuelConsumption = consumption;
        this.Distance = distance;
    }

    public int Distance
    {
        get { return distance; }
        set { distance = value; }
    }

    public decimal FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public decimal Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }

    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }

    public bool CanTravelDistance(int distance)
    {
        decimal consumption = distance * fuelConsumption;
        if (Fuel-consumption>=0)
        {
            Fuel -= consumption;
            Distance += distance;
            return true;
        }
        return false;
    }
}