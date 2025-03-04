using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal interface IMath
    {
        /// <summary>
        /// return max
        /// </summary>
        /// <returns></returns>
        public int Max();
        /// <summary>
        /// return min
        /// </summary>
        /// <returns></returns>
        public int Min();
        /// <summary>
        /// return average
        /// </summary>
        /// <returns></returns>
        float Avg();
        /// <summary>
        /// search valueToSerch into container 
        /// </summary>
        /// <param name="valueToSearch"></param>
        /// <returns>true if exists</returns>

        bool Search(int valueToSearch);
    }
}
