using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class Die
    {
        byte FaceValue { get; set; }
        bool IsHeld { get; set; }

        public Die() {
        }

        public int Roll()
        {
            Random rnd = new Random();
            FaceValue = rnd.Next(1, 7);
            return FaceValue;
        }
    }
}
