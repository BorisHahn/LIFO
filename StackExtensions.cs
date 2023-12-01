using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack newStack)
        {
            var stackSize = newStack.Size;

            for (var i = 0; i < stackSize; i++)
            {
                stack.Add(newStack.Pop());
            }
        }
    }
}
