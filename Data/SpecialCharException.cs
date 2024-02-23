﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hybridapp.Data
{
    internal class SpecialCharException : Exception
    {
        public SpecialCharException() : base() { } //no argument
        public SpecialCharException(string message) : base(message) { } //message from todo class
        public SpecialCharException(string message, Exception inner) : base(message, inner) { } // message and innerException
    }
}
