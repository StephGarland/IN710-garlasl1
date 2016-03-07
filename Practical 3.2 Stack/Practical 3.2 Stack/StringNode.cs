using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3._2_Stack
{
    class StringNode
    {
        public StringNode Next { get; set; }
        public string Data { get; }

        public StringNode(string data, StringNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
