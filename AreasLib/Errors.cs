using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib
{
    /// <summary>
    /// Possible errors
    /// </summary>
    public enum Errors
    {
        None,
        NegativeRadius,
        NegativeSide,
        WrongSides,
        NeedMorePoints
    }
}
