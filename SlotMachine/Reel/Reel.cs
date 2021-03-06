﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineModel
{
    public class Reel
    {
        private List<int> symbols;
        private int position;
        private Random rando;

        /*
         * Creates a new reel with the symbols 1-10 in order
         */
        public Reel(Random randPaul)
        {
            symbols = new List<int>();
          
            for(int i = 1; i <= 3; i++)
            {
                symbols.Add(i);
            }

            position = 0;

            rando = randPaul;
        }

        /*
         * Spins the reel to get a new value
         */
        public void spin()
        {
            position = rando.Next(symbols.Count);
        }

        /*
         * returns the symbol the reel is currently on
         */
        public int getCurrentSymbol()
        {
            return symbols[position];
        }

        /*
         * returns the symbol above the symbol that it is currently on.
         */
        public int getAboveSymbol()
        {
            return symbols[(position + 1) % symbols.Count];
        }

        /*
         * returns the symbol below the symbol that it is currently on.
         */
        public int getBelowSymbol()
        {
            // C#'s % symbol does the remained after division not modulus ugh.
            return symbols[(position + (symbols.Count - 1)) % symbols.Count];
        }
    }
}
