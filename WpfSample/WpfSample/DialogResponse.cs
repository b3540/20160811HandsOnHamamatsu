﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dialog
{
    public class DialogResponse
    {
        public string utt { get; set; }
        public string yomi { get; set; }
        public string mode { get; set; }
        public string da { get; set; }
        public string context { get; set; }
    }
}