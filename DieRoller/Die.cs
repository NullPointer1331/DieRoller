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
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is held, false otherwise
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Creates the die, rolls it, and sets <see cref="IsHeld"/> to false
        /// </summary>
        public Die()
        {
            Roll();
            IsHeld = false;
        }

        /// <summary>
        /// Rolls the die and sets <see cref="FaceValue"/> to
        /// a random number if <see cref="IsHeld"/> is false 
        /// it then returns <see cref="FaceValue"/>
        /// </summary>
        /// <returns>the new value of <see cref="FaceValue"/></returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
                FaceValue = (byte)_random.Next(1, 7);
            }
            return FaceValue;
        }
    }
}
