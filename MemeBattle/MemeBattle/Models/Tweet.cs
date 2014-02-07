﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemeBattle.Models
{
    public class Tweet
    {
        public string SearchTerm { get; set; }
        public Results Results { get; set; }
    }

    public class Results
    {
        public int ResultNum { get; set; }
        public string From_User { get; set; }
        public string Text { get; set; }
    }
}