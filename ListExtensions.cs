﻿using CL_Inventory_MGMT_Console_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTest.BL
{
    public static class ListExtensions
    {
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list
                .Where(x => x.Quantity > 0)
                .ToList();
        }
    }
}
