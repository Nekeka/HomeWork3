using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal interface ISort
    {
        /// <summary>
        /// 
        /// </summary>
        public void SortAsc();
        /// <summary>
        /// 
        /// </summary>
        public void SortDesc();
        /// <summary>
        /// sorting depending on the passed parameter
        /// </summary>
        /// <param name="isAsc">If isAsc is true, sort in ascending order, if is false, sort in descending order</param>
        public void SortByParam(bool isAsc);
    }
}
