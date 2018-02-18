using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private Point topLeft;
    private Point bottomRight;

    public Rectangle(int topX, int topY, int bottomX, int bottomY)
    {
        TopLeft = new Point(topX, topY);
        BottomRight = new Point(bottomX, bottomY);
    }

    public Point BottomRight
    {
        get { return bottomRight; }
        set { bottomRight = value; }
    }

    public Point TopLeft
    {
        get { return topLeft; }
        set { topLeft = value; }
    }

    public bool Contains(Point point)
    {
        bool contains = this.TopLeft.X <= point.X && this.bottomRight.X >= point.X && this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;
        return contains;
    }
}
