using Bl.Interfaces;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchExample.Utlities
{
    public class UiHelper
    {
        #region dependency injection
        IBusinessLayer<TbNumber> oNumberService;
        TbNumber oTbNumber;
        public UiHelper(IBusinessLayer<TbNumber> numberService, TbNumber tbNumber)
        {
            oNumberService = numberService;
            oTbNumber = tbNumber;

        }
        #endregion

        #region PerformLinearSearch
        public void PerformBinarySearch()
        {
            oTbNumber.numbers = new int[] { 2, 3, 5, 6, 7, 10 };
            oTbNumber.targetNumber = 6;
            int result = oNumberService.BinarySearch(oTbNumber.numbers, oTbNumber.targetNumber);
            if (result != -1)
            {
                Console.WriteLine("Match found, returning the index of the element: " + result);
            }
            else
            {
                Console.WriteLine("The element was not found.");
            }
        }
        #endregion
    }
}
