
//using System.Collections.Generic;

//namespace JayFastLib.collection.list
//{
//    public class ListEnumerator<T> : IEnumerator<T>
//    {

//        public required IList<T> List;
//        public int Off {  get; private set; }

//        public T Current => throw new NotImplementedException();


//        object System.Collections.IEnumerator.Current => throw new NotImplementedException();

//        public void Dispose()
//        {
//        }

//        public bool MoveNext()
//        {
//            return Off++ < List.Count;
//        }

//        public void Reset()
//        {
//            Off = 0;
//        }
//    }
//}
