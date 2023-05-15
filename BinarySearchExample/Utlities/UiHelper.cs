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
    }
}
