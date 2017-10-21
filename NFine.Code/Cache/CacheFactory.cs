/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code
{
    public class CacheFactory
    {
        public static ICache Cache()
        {
            return new Cache();
        }
    }
}
