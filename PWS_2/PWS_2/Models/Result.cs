using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWS_2.Models
{
    public class Result
    {
        public static int result = 0;
        public static ConcurrentStack<int> stack = new ConcurrentStack<int>();
    }
}