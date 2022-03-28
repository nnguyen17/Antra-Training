/* 04 Generics
 * 
 * Test your knowledge
 * 
 * 1. Describe the problem generics address.
 * Generic allows us to use a class or method that can work with any data type. We need to define 
 * the data type while using class or method. Usually the type is specified by the <T>.  
 * We can make a class, interface or method generic.
 * 
 * 2. How would you create a list of strings, using the generic List class?
 * List<string> str = new List<string>();
 * 
 * 3. How many generic type parameters does the Dictionary class have?
 * Two
 * 
 * 4. True/False. When a generic class has multiple type parameters, they must all match.
 * True
 * 
 * 5. What method is used to add items to a List object?
 * Add(), AddRange(), Insert() or InsertRang()
 * 
 * 6. Name two methods that cause items to be removed from a List.
 * Remove() or RemoveAt()
 * 
 * 7. How do you indicate that a class has a generic type parameter?
 * When we use <T>
 * 
 * 8. True/False. Generic classes can only have one generic type parameter.
 * False
 * 
 * 9. True/False. Generic type constraints limit what can be used for the generic type.
 * True
 * 
 * 10. True/False. Constraints let you use the methods of the thing you are constraining to.
 * True
 * 
 */

/* Practice working with Generics
 * 1. Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
 *    a. int Count()
 *    b. T Pop()
 *    c. Void Push()
 */
using System.Collections;
public class MyStack<T>
{
    LinkedList<T> stack = new LinkedList<T>();

    int Count()
    {
        return stack.Count;
    }
    T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("The Stack is empty");
        }
        T value = stack.First.Value;
        stack.RemoveFirst();
        return value;
    }
    void Push(T value)
    {
        stack.AddFirst(value);
    }
}

/* 2. Create a Generic List data structure MyList<T> that can store any data type. Implement the following methods.
 *    a. void Add (T element)
 *    b. T Remove (int index)
 *    c. bool Contains (T element)
 *    d. void Clear ()
 *    e. void InsertAt (T element, int index)
 *    f. void DeleteAt (int index)
 *    g. T Find (int index)
 */
public class MyList<T>
{
    T[] list;
    int size = 0, capacity;

    void Resize()
    {
        T[] resize = new T[capacity * 2];
        for (int i = 0; i < capacity; i++)
        {
            resize[i] = list[i];
        }
        list = resize;
        capacity = capacity * 2;
    }

    void Add(T element)
    {
        if (size == capacity)
        {
            Resize();
        }
        list[size] = element;
        size++;
    }
    T Remove (int index)
    {
        if (size == capacity)
        {
            Resize();
        }
        for (int i = index; i < size; i++)
        {
            if (i != size - 1)
            {
                list[i] = list[i + 1];
            }
            else
            {
                list[i] = default(T);
            }
        }
        size--;
        return list[index];
    }
    bool Contains (T element)
    {
        for (int i = 0; i < size; i++)
        {
            T currentValue = list[i];
            if (currentValue.Equals(element))
            {
                return true;
            }
        }
        return false;
    }
    void Clear()
    {
        list = new T[capacity];
        size = 0;
    }
    void InsertAt (T element, int index)
    {
        if (size == capacity)
        {
            Resize();
        }

        for (int i = size; i > index; i--)
        {
            list[i] = list[i - 1];
        }

        list[index] = element;
        size++;
    }
    void DeleteAt (int index)
    {
        for (int i = index; i < size - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[size - 1] = default(T);
        size--;
    }
    T Find (int index)
    {
        T element = list[index];
        return element;
    }
}

/* 3. Implement a GenericRepository<T> class that implements IRepository<T> interface that will 
 * have common /CRUD/ operations so that it can work with any data source such as SQL Server, 
 * Oracle, In-Memory Data etc. Make sure you have a type constraint on T were it should be of 
 * reference type and can be of type Entity which has one property called Id. IRepository<T> should 
 * have following methods
 *    a. void Add(T item)
 *    b. void Remove(T item)
 *    c. Void Save()
 *    d. IEnumerable<T> GetAll()
 *    e. T GetById(int id)
 */
