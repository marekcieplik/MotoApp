namespace MotoApp
{
    public class BasicStack<T>
    {
        //table of etams in stock
        private readonly T[] _items;
        //current index of actual item
        private int _index = -1;

        //constructor in new form
        public BasicStack() => _items = new T[10];

        //stack items counter
        public int Count => _index + 1;

        //methods in stack
        public void Push(T value) => _items[++_index] = value;
        public T Pop() => _items[_index--];
    }
}
