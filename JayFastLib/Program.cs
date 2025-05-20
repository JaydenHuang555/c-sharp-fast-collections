using JayFastLib.collection.list.orderedlist;
using JayFastLib.collection.stack;


namespace External
{


    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            JayFastLib.collection.stack.Stack<string?> stack = new JayFastLib.collection.stack.Stack<string?>();
            while(!s.Equals("test"))
            {
                stack.Push((s = Console.ReadLine()));
            }
            while(!stack.IsEmpty()) Console.WriteLine(stack.Pop());
        }
    }
}
