
namespace JayFastLib.collection.list
{
    public interface IList<T> : IEnumerable<T>, IDisposable
    {

        public int Count { get; protected set; }

        public void Add(T item);
        public T Get(int index);

        public bool Contains(T item);
        public void Clear();

        public T this[int index] { get; protected set; }

    }
}
