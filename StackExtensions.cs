using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack newStack)
        {
            for (var i = newStack.val.Length - 1; i >= 0; i--)
            {
                stack.list.Add(newStack.val[i]);
            }
        }
    }
}
