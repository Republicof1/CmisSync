﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparkleLib.Cmis
{
    public class CmisServerNotFoundException : Exception
    {
        public CmisServerNotFoundException(string message) : base(message) { }
    }
}
