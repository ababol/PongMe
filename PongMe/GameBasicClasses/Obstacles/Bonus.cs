﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameBasicClasses.MVC;
using GameBasicClasses.BasicClasses;

namespace GameBasicClasses.Obstacles
{
    public class Bonus : Obstacle
    {
        public Bonus(int clientWidth, int clientHeight) : base(clientWidth, clientHeight)
        {

        }

        public override bool contains(Ball b)
        {
            throw new NotImplementedException();
        }
    }
}