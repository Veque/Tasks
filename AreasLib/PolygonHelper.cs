using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib
{
    public static class PolygonHelper
    {
        /// <summary>
        /// Calculates an area of a polygon
        /// </summary>
        /// <param name="points">an array of points comprising the polygon. 
        /// This function expects sides to be between every 2 adjacent points and between the first and the last ones.
        /// This function doesn't check whether sides cross each other.</param>
        /// <returns>An area of the polygon if points are correct or -1 and an error otherwise.</returns>
        public static (double, Errors) Area(params Point[] points)
        {
            if (points.Length < 3)
                return (-1, Errors.NeedMorePoints);

            var s = 0d;
            var zero = points[0];
            var prev = points[1];
            for (int i = 2; i < points.Length; i++)
            {
                var current = points[i];
                var dx1 = prev.X - zero.X;
                var dy1 = prev.Y - zero.Y;
                var dx2 = current.X - zero.X;
                var dy2 = current.Y - zero.Y;

                // vector product equals twice the area of the triangle by absolute value
                // the sign of the vector product represents convexity of the polygon 
                // and negative products cancel out with positive ones giving the right result in the end
                s += dx1 * dy2 - dx2 * dy1;
                prev = current;
            }

            if (s < 0)
            {
                return (-0.5 * s, Errors.None);
            }
            return (0.5 * s, Errors.None);
        }
    }
}
