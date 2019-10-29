using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib
{
    /// <summary>
    /// Contains functions related to circles.
    /// </summary>
    public static class CircleHelper
    {
        public const double Pi = 3.14159;

        /// <summary>
        /// Calculates are of a circle with given radius
        /// </summary>
        /// <param name="r">Radius of the circle</param>
        /// <returns>Area of the circle if radius is correct and -1 and an error if the radius is incorrect</returns>
        public static (double, Errors) Area(double r)
        {
            if (r < 0)
            {
                return (-1, Errors.NegativeRadius);
            }
            return (Pi * r * r, Errors.None);
        }
    }
}
