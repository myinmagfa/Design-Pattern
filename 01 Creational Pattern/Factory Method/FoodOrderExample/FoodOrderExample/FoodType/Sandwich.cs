﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrderExample.Base;

namespace FoodOrderExample.FoodType
{
    public class Sandwich:IFood
    {
        public void Serve()
        {
            Console.WriteLine("Served Sandwich");
        }
    }
}
