
namespace LIFO
{
    internal class Stack
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

        public int Size => list.Count;
        public string? Top => list.LastOrDefault();

        public static Stack Concat(params Stack[] stacks)
        {
            var newStack = new Stack();

            foreach (var item in stacks)
            {
                for (var i = item.val.Length - 1; i >= 0; i--)
                {
                    newStack.Add(item.val[i]);
                }
            }
            return newStack;
        }
    }
}
