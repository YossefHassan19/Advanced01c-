namespace Advanced01c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //What is a generic class? Why use generics?

            //A generic class allows you to write a class with type parameters
            //1-Type safe                      2-Code reuseability
            //3-Better performance             4-Cleaner code

            #endregion

            #region Question02

            //Write a generic class Container<T> with Add and Get methods.

            //public class Container<T>
            //{
            //private T _item;

            //public void Add(T item)
            //    {
            //        _item = item;
            //    }

            //public T Get()
            //    {
            //        return _item;
            //    }
            //}

            #endregion

            #region Question03

            //What are multiple type parameters? Write Pair<TKey, TValue>.

            //Generic classes can have more than one type parameter separated by commas to handle multiple independent types

            //public class Pair<TKey, TValue>
            //{
            //public TKey Key { get; set; }
            //public TValue Value { get; set; }

            //public Pair(TKey key, TValue value)
            //{
            //    Key = key;
            //    Value = value;
            //}
            //}

            #endregion

        }
    }
}
