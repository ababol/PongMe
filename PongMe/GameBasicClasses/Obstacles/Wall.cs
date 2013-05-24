﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameBasicClasses.MVC;
using GameBasicClasses.BasicClasses;

namespace GameBasicClasses.Obstacles
{
    /// <summary>
    /// Bord haut et bas de la zone de jeu.
    /// </summary>
    public class Wall : Obstacle
    {
        public Wall(int clientWidth, int clientHeight) : base(clientWidth,clientHeight)
        {
            
        }

        public override bool contains(Ball b)
        {
            throw new NotImplementedException();
        }

    }
}
