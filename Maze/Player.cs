﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Player : ImazeObject
    {
        public int x {  get; set; }
        public int y { get; set; }
        public char Icon { get => '@';  }
        public bool IsSolid { get => true; }
    }
}
