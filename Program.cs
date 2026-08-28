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

            #region Question08

            //What is the 'class' constraint? Write an example.

            //Specifies that the type argument must be a reference type

            //public class ReferenceContainer<T> where T : class
            //{
            //public T Value { get; set; }
            //}

            #endregion

            #region Question09

            //What is the 'new()' constraint? Write an example.

            //Specifies that the type argument must have a public parameterless constructor, allowing the generic class to instantiate objects of type T using new T().

            //public class Creator<T> where T : new()
            //{
            //public T CreateInstance()
            //{
            //    return new T();
            //}
            //}

            #endregion

            #region Question10

            //What is the interface constraint? Write an example.

            //Specifies that the type argument must implement a specific interface, allowing access to that interface's members safely

            //public class Printer<T> where T : IComparable<T>
            //{
            //public int Compare(T item1, T item2)
            //{
            //    return item1.CompareTo(item2);
            //}
            //}

            #endregion

            #region Question11

            //What is the base class constraint? Write an example.

            //Specifies that the type argument must inherit from a specific base class

            //public class Animal { }
            //public class Dog : Animal { }

            //public class AnimalShelter<T> where T : Animal
            //{
            //public T Resident { get; set; }
            //}

            #endregion

            #region Question12

            //How do you apply multiple constraints? Write an example.

            //You can combine multiple constraints for a type parameter. The class/struct constraint must come first, followed by interface constraints, and new() must be last.

            //public class Repository<T> where T : class, IComparable<T>, new()
            //{
            //public T CreateAndCompare(T other)
            //{
            //    T newItem = new T();
            //    return newItem;
            //}
            //}

            #endregion

            #region Question13

            //What does the 'default' keyword do in generics?

            //The default keyword returns the default value of a type parameter T: , null for refrence , 0 for value

            #endregion

            #region Question14

            //Write a SafeList<T> that returns default when the index is invalid.

            //public class SafeList<T>
            //{
            //private List<T> _items = new List<T>();

            //public void Add(T item) => _items.Add(item);

            //public T GetAt(int index)
            //{
            //    if (index < 0 || index >= _items.Count)
            //    {
            //        return default(T);
            //    }
            //    return _items[index];
            //}
            //}

            #endregion

            #region Question15

            //What is covariance? Explain the 'out' keyword.

            //Covariance allows you to use a more derived type
            //Use to specify that the type parameter is used only as output (return type)

            //interface IProduct<out T>
            //{
            //T Get();
            //}

            #endregion

        }
    }
}
