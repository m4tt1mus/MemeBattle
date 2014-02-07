using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemeBattle.Models
{
    public class Tweet
    {
        public Results results { get; set; }
    }

    public class Results
    {
        public string from_user { get; set; }
        public string text { get; set; }
    }
}