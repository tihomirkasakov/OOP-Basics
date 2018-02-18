using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    private decimal price;
    private int days;
    private Season season;
    private Discount discount=Discount.None;

    public PriceCalculator(string input)
    {
        var tokens = input.Split();
        price = decimal.Parse(tokens[0]);
        days = int.Parse(tokens[1]);
        season = Enum.Parse<Season>(tokens[2]);

        if (tokens.Length==4)
        {
            discount = Enum.Parse<Discount>(tokens[3]);
        }
    }

    public decimal TotalPrice()
    {
        decimal totalPrice = price * days * (int)season * (1-(decimal)discount / 100);
        return totalPrice;
    }
}
