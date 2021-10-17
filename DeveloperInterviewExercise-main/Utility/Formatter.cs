using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utility
{
    /// <summary>
    /// This class is basic formatter 
    /// class for any string manupulation 
    /// </summary>
    public class Formatter : Factory
    {
        /// <summary>
        /// Get new instance
        /// </summary>
        /// <returns></returns>
        public override Factory GetInstance()
        {
            return new Formatter();
        }

    }
}
