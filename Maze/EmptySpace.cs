using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class EmptySpace : ImazeObject
    {
        public char Icon { get => ' '; }
        public bool IsSolid { get => false; }
    }
}
