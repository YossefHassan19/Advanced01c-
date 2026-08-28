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

            #region Question04

            //What is a generic method? Write Swap<T> method.

            //A method can be generic even if the class containing it is not generic. The type parameter list (<T>) is placed directly after the method name.

            //public static void Swap<T>(ref T a, ref T b)
            //{
            //T temp = a;
            //a = b;
            //b = temp;
            //}

            #endregion

            #region Question05

            //Write a generic method FindMax<T> that finds maximum value

            //public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //return a.CompareTo(b) > 0 ? a : b;
            //}

            #endregion

            #region Question06

            //What is a generic interface? Write IRepository<T>.

            //An interface defined with type parameters. Any class implementing a generic interface must supply the type arguments

            //public interface IRepository<T>
            //{
            //void Add(T item);
            //T Get(int id);
            //List<T> GetAll();
            //}

            #endregion

            #region Question07

            //What is the 'struct' constraint? Write an example.

            //Allows you to specify which types can be used as type arguments for a generic type or method

            //public class StructContainer<T> where T : struct
            //{
            //public T Value { get; set; }
            //}

            #endregion

    }
    }
}
