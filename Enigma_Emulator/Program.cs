using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Enigma_Emulator
{
    class Program
    {
        //change the class of the rotor at all uses in order to create a new configuration
        private static RotorI rotorA = new RotorI();
        private static RotorII rotorB = new RotorII();
        private static RotorIII rotorC = new RotorIII();

        private static void Refresh()
        {
            rotorA = new RotorI();
            rotorB = new RotorII();
            rotorC = new RotorIII();
        }

        static void Main(string[] args)
        {
            string cipher = Encrypt("The Quick brown fox jumps over the lazy dog");
            Console.WriteLine("Encrypted Text: " + cipher);
            Console.WriteLine("\n\n");
            Console.WriteLine("Decrypted Text: " + Decrypt(cipher));
            Console.Read();
        }

        public static string Encrypt(string plainText)
        {
            
            //Validation of the input to prevent errors during encryption
            plainText = plainText.ToUpper();
            string pattern = @"[^A-Z ]*";
            string replacement = "";
            plainText = Regex.Replace(plainText, pattern, replacement);
            //Validating that there is infact something inside the plaintext string
            if (String.IsNullOrEmpty(plainText))
            {
                return null;
            }
            Console.WriteLine("Encrypting: " + plainText);
            char[] plain = plainText.ToCharArray();
            Queue<char> cipher = new Queue<char>();
            foreach (char c in plain)
            {
                cipher.Enqueue(EncryptChar(c));
            }
            Console.WriteLine();
            char[] cipherText = cipher.ToArray();
            Refresh();
            return new String(cipherText);
        }

        public static string Decrypt(string cipherText)
        {
            Console.WriteLine("Decrypting: " + cipherText);
            Queue<char> plain = new Queue<char>();
            foreach (char c in cipherText)
            {
                plain.Enqueue(DecryptChar(c));
            }
            Console.WriteLine();
            char[] plainText = plain.ToArray();
            Refresh();
            return new String(plainText);
        }

        public static char EncryptChar(char c)
        {
            Console.Write( c + " -> ");
            char e = '\0';
            e = rotorA.CharAt(rotorC.CharIndex(c));
            e = rotorA.CharAt(rotorB.CharIndex(e));

            rotorC.Rotate();
            if(rotorC.Rotations%27 == 0)
            {
                rotorB.Rotate();
            }
            Console.Write(e + "\t");
            return e;
        }

        public static char DecryptChar(char c)
        {
            Console.Write(c + " -> ");
            char d = '\0';
            d = rotorB.CharAt(rotorA.CharIndex(c));
            d = rotorC.CharAt(rotorA.CharIndex(d));

            rotorC.Rotate();
            if (rotorC.Rotations % 27 == 0)
            {
                rotorB.Rotate();
            }
            Console.Write(d + "\t");
            return d;
        }
    }
}
