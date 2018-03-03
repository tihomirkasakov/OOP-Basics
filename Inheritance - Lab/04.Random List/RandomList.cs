using System;
using System.Collections.Generic;
using System.Text;

public class RandomList : List<string>
{
    Random rng = new Random();

    public string RandomString()
    {
        string result = string.Empty;
        if (this.Count>0)
        {
            int index = rng.Next(0, this.Count-1);
            result = this[index];
            this.RemoveAt(index);
        }
        return result;
    }
}