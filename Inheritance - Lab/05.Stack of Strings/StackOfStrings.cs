using System.Collections.Generic;

public class StackOfStrings : List<string>
{
    public void Push(string input)
    {
        this.Add(input);
    }

    public string Pop()
    {
        string result = "";
        if (this.Count>0)
        {
            result = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
        }
        return result;
    }

    public string Peek()
    {
        string result = "";
        if (this.Count > 0)
        {
            result = this[this.Count - 1];
        }
        return result;
    }

    public bool IsEmpty()
    {
        if (this.Count>0)
        {
            return false;
        }

        return true;
    }
}
