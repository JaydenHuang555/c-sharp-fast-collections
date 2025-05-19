
namespace JayFastLib.collection.entryutil
{
    public class DecreasingDoubleEntry<T1, T2> : DoubleEntry<T1, T2>
    {

        public DecreasingDoubleEntry<T1, T2> Prev;

        public DecreasingDoubleEntry(T1? first, T2? second) : base(first, second) {}

    }
}
