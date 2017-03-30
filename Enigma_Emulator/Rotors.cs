using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * All of these classes are purely initializations of all the rotors so that they can be used without having to create each individual rotor as its own class
 */
namespace Enigma_Emulator
{
    class RotorI : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'B', 'D', 'F', 'H', 'J', 'L', 'N', 'P', 'R', 'T', 'V', 'X', 'Z', 'A', 'C', 'E', 'G', 'I', 'K', 'M', 'O', 'Q', 'S', 'U', 'W', 'Y' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorII : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorIII : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorIV : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'E', 'S', 'O', 'V', 'P', 'Z', 'J', 'A', 'Y', 'Q', 'U', 'I', 'R', 'H', 'X', 'L', 'N', 'F', 'T', 'G', 'K', 'D', 'C', 'M', 'W', 'B' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorV : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'V', 'Z', 'B', 'R', 'G', 'I', 'T', 'Y', 'U', 'P', 'S', 'D', 'N', 'H', 'L', 'X', 'A', 'W', 'M', 'J', 'Q', 'O', 'F', 'E', 'C', 'K' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorVI : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'J', 'P', 'G', 'V', 'O', 'U', 'M', 'F', 'Y', 'Q', 'B', 'E', 'N', 'H', 'Z', 'R', 'D', 'K', 'A', 'S', 'X', 'L', 'I', 'C', 'T', 'W' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorVII : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'N', 'Z', 'J', 'H', 'G', 'R', 'C', 'X', 'M', 'Y', 'S', 'W', 'B', 'O', 'U', 'F', 'A', 'I', 'V', 'L', 'P', 'E', 'K', 'Q', 'D', 'T' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorVIII : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'F', 'K', 'Q', 'H', 'T', 'L', 'X', 'O', 'C', 'B', 'J', 'S', 'P', 'D', 'Z', 'R', 'A', 'M', 'E', 'W', 'N', 'I', 'U', 'Y', 'G', 'V' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorBeta : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'L', 'E', 'Y', 'J', 'V', 'C', 'N', 'I', 'X', 'W', 'P', 'B', 'Q', 'M', 'D', 'R', 'T', 'A', 'K', 'Z', 'G', 'F', 'U', 'H', 'O', 'S' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }

    class RotorGamma : Rotor
    {
        public override void SetAlphabet()
        {
            char[] rotorSetting = { ' ', 'F', 'S', 'O', 'K', 'A', 'N', 'U', 'E', 'R', 'H', 'M', 'B', 'T', 'I', 'Y', 'C', 'W', 'L', 'Q', 'P', 'Z', 'X', 'V', 'G', 'J', 'D' };
            foreach (char c in rotorSetting)
            {
                rotor.Enqueue(c);
            }
        }
    }
}
