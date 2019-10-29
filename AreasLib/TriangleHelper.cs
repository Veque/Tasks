using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib
{
    public static class TriangleHelper
    {
        /// <summary>
        /// Checkks whether a triangle is right
        /// </summary>
        /// <param name="p1">Vertex 1 of the triangle</param>
        /// <param name="p2">Vertex 2 of the triangle</param>
        /// <param name="p3">Vertex 3 of the triangle</param>
        /// <returns>True if the triangle is right</returns>
        public static bool CheckOrthogonal(Point p1, Point p2, Point p3)
        {
            // If scalar product == 0 then the angle is right
            var scalar = (p2.X-p1.X)*(p3.X-p1.X) + (p2.Y-p1.Y)*(p3.Y-p1.Y);
            if (scalar == 0)
                return true;

            scalar = (p2.X - p1.X) * (p3.X - p2.X) + (p2.Y - p1.Y) * (p3.Y - p2.Y);
            if (scalar == 0)
                return true;

            scalar = (p3.X - p1.X) * (p3.X - p2.X) + (p3.Y - p1.Y) * (p3.Y - p2.Y);
            if (scalar == 0)
                return true;

            return false;
        }

        /// <summary>
        /// Calculates and area of a triangle using Heron's formula
        /// </summary>
        /// <param name="a">Side 1</param>
        /// <param name="b">Side 2</param>
        /// <param name="c">Side3</param>
        /// <returns>Area of the triangle if all sides are correct otherwise -1 with an error</returns>
        public static (double, Errors) Area(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                return (-1, Errors.NegativeSide);

            var s = a + b;

            var s1 = s - c;
            if (s1 < 0)
                return (-1, Errors.WrongSides);

            var s2 = b + c - a;
            if (s2 < 0)
                return (-1, Errors.WrongSides);

            var s3 = a + c - b;
            if (s3 < 0)
                return (-1, Errors.WrongSides);

            s += c;
            return (0.25 * Math.Sqrt(s * s1 * s2 * s3), Errors.None);
        }
    }
}
