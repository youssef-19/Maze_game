using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public interface ImazeObject
    {
        char Icon { get; }
        bool IsSolid {  get; }

    }
}
