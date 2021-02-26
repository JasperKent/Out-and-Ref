namespace OutAndRef
{
    public class MyCollection<T> 
    {
        private T[] _array;

        public MyCollection(int size)
        {
            _array = new T[size];
        }

        public ref T this[int idx] => ref _array[idx];
    }
}
