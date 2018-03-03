using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            if (char.IsDigit(value.Split().Last().First()))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type: {this.GetType().Name}");
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Author: {this.Author}");
        sb.Append($"Price: {this.Price:f2}");
        return sb.ToString();
    }
}
