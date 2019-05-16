using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_2
{
    public class Desk
    {
        // Desk description
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public int Area { get; set; }
        
        // Desktop surface materials
        public enum Surface
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer,
        }

        // Constraints
        public int MinWidth = 24;
        public int MaxWidth = 96;
        public int MinDepth = 12;
        public int MaxDepth = 48;
    }
}
