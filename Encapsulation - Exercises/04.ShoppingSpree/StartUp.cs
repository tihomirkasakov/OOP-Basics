using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var personsMoney = SplitInput(Console.ReadLine());
        var productsCost = SplitInput(Console.ReadLine());
        List<Person> persons = new List<Person>();
        List<Product> products = new List<Product>();
        try
        {
            for (int i = 0; i < personsMoney.Length; i++)
            {
                var personMoney = SplitTokens(personsMoney[i]);
                Person person = new Person(personMoney[0], decimal.Parse(personMoney[1]));
                persons.Add(person);
            }

            for (int i = 0; i < productsCost.Length; i++)
            {
                var productCost = SplitTokens(productsCost[i]);
                Product product = new Product(productCost[0], decimal.Parse(productCost[1]));
                products.Add(product);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        var command = Console.ReadLine();
        while (command != "END")
        {
            var args = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = args[0];
            var productName = args[1];

            var buyer = persons.FirstOrDefault(p => p.Name == name);
            var productToBuy = products.FirstOrDefault(p => p.Name == productName);
            if (buyer == null || productToBuy == null)
            {
                command = Console.ReadLine();
                continue;
            }
            var output = TryToBuyItem(buyer, productToBuy);
            Console.WriteLine(output);
            command = Console.ReadLine();
        }

        foreach (var person in persons)
        {
            if (person.Products.Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
                continue;
            }
            Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
        }
    }

    public static string TryToBuyItem(Person buyer, Product product)
    {
        if (buyer.Money < product.Cost)
        {
            return $"{buyer.Name} can't afford {product.Name}";
        }
        else
        {
            buyer.Products.Add(product);
            buyer.Money -= product.Cost;
            return $"{buyer.Name} bought {product.Name}";
        }
    }

    private static string[] SplitTokens(string tokens)
    {
        return tokens.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
    }

    private static string[] SplitInput(string input)
    {
        return input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
