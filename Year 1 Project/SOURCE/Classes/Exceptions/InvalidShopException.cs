﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exceptions
{
    public class InvalidShopException : Exception
    {
        public InvalidShopException() { }
        public InvalidShopException(string message) : base(message) { }
        public InvalidShopException(string message, Exception inner) : base(message, inner) { }
    }
}
