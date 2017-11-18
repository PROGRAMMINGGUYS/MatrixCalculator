using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{
    class Util
    {
        /// <summary>
        /// Returns the program's assembly version
        /// </summary>
        /// <returns></returns>
        public static string GetVersionString()
        {
            return "v" + typeof(Util).Assembly.GetName().Version.ToString();
        }
    }
}
