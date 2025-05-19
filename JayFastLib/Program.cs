using JayFastLib.collection.list.orderedlist;

namespace External
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedList<string> li = new OrderedList<string>();
            li.Add("1");
            li.Add("2");
            Console.WriteLine("Cound: " + li.Count);
            foreach(string str in li) Console.WriteLine(str);
        }
    }
}
