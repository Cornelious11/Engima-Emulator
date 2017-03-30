using System.Collections.Generic;

namespace Enigma_Emulator
{
    /*
     * Abstract class to manipulate the rotors and get their current states
     */ 
    abstract class Rotor
    {
        private static int AlphabetLength = 27;
        protected Queue<char> rotor = new Queue<char>();
        private int rotations = 0;

        public int Rotations { get => rotations; }

        public int CharIndex(char c)
        {
            int count = 0;
            foreach (char a in rotor)
            {
                if (a == c)
                {
                    break;
                }
                count++;
            }
            return count;
        }

        public char CharAt(int i)
        {
            i = i % 27;
            char[] array = rotor.ToArray();
            return array[i];
        }

        public void Rotate()
        {
            char c = this.rotor.Dequeue();
            this.rotor.Enqueue(c);
            this.rotations++;
        }

        public Rotor()
        {
            this.rotations = 0;
            SetAlphabet();
        }

        public abstract void SetAlphabet();
    }
}
