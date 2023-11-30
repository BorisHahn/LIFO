
namespace LIFO
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack("a", "b", "c");
            stack.Merge(new Stack("1", "2", "3"));
            var stackConcat = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
        }
    }
}