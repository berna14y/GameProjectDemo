﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int UnitStock { get; set; }
    }
}
