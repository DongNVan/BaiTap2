﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }

        public abstract void Display();
    }
}
