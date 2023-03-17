using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPestanalista
{
    internal class Item
    {
        public int value { get; set; }
        public Item next { get; set; }

        public Item(int x)
        {
            value = x;
            next = null;
        }

    }
}
