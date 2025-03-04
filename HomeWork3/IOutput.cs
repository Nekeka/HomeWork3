using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public interface IOutput
    {
        /// <summary>
        /// displays array elements on console
        /// </summary>
        void show();
        /// <summary>
        /// displays array elements on console
        /// </summary>
        /// <param name="info">informational string</param>
        void show(string info);

    }
}
