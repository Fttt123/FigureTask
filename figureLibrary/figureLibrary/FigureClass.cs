namespace figureLibrary
{
    abstract internal class Figure
    {
        internal float x { get; set; }

        virtual internal float Square()
        {
            return (float)Math.PI * x * 2;
        }
    }

    internal class Triangle : Figure
    {
        float y { get; set; }
        float z { get; set; }

        internal Triangle(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        override internal float Square()
        {
            float p = x + y + z;
            return (float)Math.Sqrt(p*(p-z)*(p-y)*(p-x));
        }

        internal bool RightTriangle()
        {
            if(x>z&&x>y)
                return x*x == z*z+y*y;
            if (z > x && z > y)
                return z * z == x * x + y * y;
            return y * y == z * z + x * x;
        }
    }

    internal class Сircle : Figure
    {
        internal Сircle(float x)
        {
            this.x = x;
        }
    }
}