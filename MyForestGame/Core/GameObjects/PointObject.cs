﻿using System;
using System.Collections.Generic;
using MyForestGame.Core.BaseObjects;
using MyForestGame.Core.Models;

namespace MyForestGame.Core.GameObjects
{
    public class PointObject : StaticGameObjectBase
    {
        internal int Points { get; set; }

        public PointObject(PositionModel currentPosition) : base(currentPosition)
        {
            var objects = new List<(string name, string model, int points, ConsoleColor colorObject, ConsoleColor colorBackground)>()
            {
                ("Apples", "-$-", 1, ConsoleColor.White, ConsoleColor.DarkGreen),
                ("Cherries", "-$-", 1, ConsoleColor.White, ConsoleColor.DarkGreen),
                ("Bananas", "-$-", 1, ConsoleColor.White, ConsoleColor.DarkGreen)
            };
            (Name, Model, Points, ColorObject, ColorBackground) = objects[new Random().Next(objects.Count)];
        }
    }
}
