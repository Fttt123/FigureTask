using System;

namespace figureLibrary
{
    public interface iFigure
    {
        float Square();
    }

    class Triangle : iFigure
    {
        public float sideX { get; set; }
        public float sideY { get; set; }
        public float sideZ { get; set; }

        public float Square()
        {
            float p = sideX + sideY + sideZ;
            return (float)Math.Sqrt(p * (p - sideZ) * (p - sideY) * (p - sideX));
        }

        public bool RightTriangle()
        {
            float[] sides = { sideX, sideY, sideZ };
            Array.Sort(sides);

            float x = sides[0];
            float y = sides[1];
            float z = sides[2];

            return Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2);
        }
    }

    class Сircle : iFigure
    {
        public float radius { get; set; }

        public float Square()
        {
            return (float)Math.PI * radius * 2;
        }
    }

    public class ShapeFactory
    {
        public static iFigure CreateFigure(string figureType)
        {
            switch (figureType.ToLower())
            {
                case "circle":
                    return new Сircle();
                case "triangle":
                    return new Triangle();
                default:
                    throw new ArgumentException($"Фигура не найдена: {figureType}");
            }
        }
    }
}