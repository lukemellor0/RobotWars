﻿using RobotWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWarsConsole.Robots
{
    public class VeryStupidRobot : IRobot
    {
        public Int64 Health { get; set; }

        public string GetName()
        {
            return "Very Stupid Robot";
        }

        public List<RobotAction> MyTurn(List<RobotAction> competitors)
        {
            var random = new Random();
            var victim = competitors[random.Next(0, competitors.Count - 1)];
            victim.Attacks = 3;
            return competitors;
        }

        public void UpdateHealth(Int64 health)
        {
            Health = health;
        }
    }
}
