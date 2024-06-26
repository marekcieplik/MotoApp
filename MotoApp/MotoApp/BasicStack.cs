namespace MotoApp
{
    public class BasicStack
    {
        //table of etams in stock
        private readonly double[] _items;
        //current index of actual item
        private int _index = -1;

        //constructor in new form
        public BasicStack() => _items = new double[10];

        //stack items counter
        public int Count => _index + 1;

        //methods in stack
        public void Push(double value) => _items[++_index] = value;
        public double Pop() => _items[_index--];
    }
}
