using System.Xml.Linq;
using LIFO;

namespace LIFO
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack("a", "b", "c");
            stack.Merge(new Stack("1", "2", "3"));

            var stackConcat = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            
            foreach (var item in stackConcat.list)
            {
                Console.Write($"{item}, ");
            }
        }
    }

    class Stack
    {
        public List<string> list = new();
        public string[] val;
        public Stack(params string[] val)
        {
            this.val = val;
  
            foreach (var item in this.val)
            {
                list.Add(item);
            }
        }
        public void Pop()
        {
            try
            {
                list.Remove(list.Last());
            }
            catch 
            {
                Console.WriteLine("Стек пустой");
            }
        }
        public void Add(string elem)
        {
            list.Add(elem);
        }

        public int Size
        {
            get { return list.Count; }
        }

        public string? Top
        {
            get { return list.LastOrDefault(); }
        }
        public static Stack Concat(params Stack[] stacks)
        {
            var newStack = new Stack();

            foreach (var item in stacks)
            {
                for (var i = item.val.Length - 1; i >= 0; i --)
                {
                    newStack.Add(item.val[i]);
                }
            }
            return newStack;
        }
    }
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