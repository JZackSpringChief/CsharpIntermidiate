//Generics allow the reuse of code across different types.
//ex.
static void Swap(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}
//Our Swap method will work only for integer parameters. If we want to use it for other types,
// for example, doubles or strings, we have to overload it for all the types we want to use it with.
// Besides a lot of code repetition, it becomes harder to manage the code because changes
// in one method mean changes to all of the overloaded methods. 
//Generics provide a flexible mechanism to define a generic type.
static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}
	class Program
	{
		static void Swap<T>(ref T a, ref T b) {
			T temp = a;
			a = b;
			b = temp;
		}
		static void Main(string[] args)
		{
			int a = 4, b = 9;
			Swap<int>(ref a, ref b);
			Console.WriteLine(a+" "+b);
			
			string x = "Hello";
			string y = "World";
			Swap<string>(ref x, ref y);
			Console.WriteLine(x+" "+y);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        //your code goes here
        		public static void Print<T>(T a)
        		{
        			Console.WriteLine("Showing "+a);
        		}
        
    }
//generic classes generic types can also be used with generic classes/
//The most common use for generic classes is with collections of items, where operations such as adding
// and removing items from the collection are performed in basically the same way regardless of the type
// of data being stored. One type of collection is called a stack. Items are "pushed", or
// added to the collection, and "popped", or removed from the collection. A stack is sometimes
// called a Last In First Out (LIFO) data structure. ex
class Stack<T> {
  int index=0;
  T[] innerArray = new T[100];
  public void Push(T item) {
    innerArray[index++] = item; 
  }
  public T Pop() {
    return innerArray[--index]; 
  }
  public T Get(int k) { return innerArray[k]; }
}
//The generic class stores elements in an array. As you can see, the generic type T is used as the
// type of the array, the parameter type for the Push method, and the return type for the Pop and
// Get methods. 
//Now we can create objects of our generic class:s
Stack<int> intStack = new Stack<int>();
Stack<string> strStack = new Stack<string>();
Stack<Person> PersonStack = new Stack<Person>();


namespace SoloLearn
{
	class Program
	{
		class Stack<T> {
			int index=0;
			T[] innerArray = new T[100];
			public void Push(T item) {
				innerArray[index++] = item; 
			}
			public T Pop() {
				return innerArray[--index]; 
			}
			public T Get(int k) { return innerArray[k]; }
		}
		static void Main(string[] args)
		{
			Stack<int> intStack = new Stack<int>();
			intStack.Push(3);
			intStack.Push(6);
			intStack.Push(7);
			
			Console.WriteLine(intStack.Get(1));
		}
	}
}

using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Elems<string> elems1 = new Elems<string>();
            elems1.Add("John", "Tamara", "David");
            elems1.Show();

            Console.WriteLine();

            Elems<int> elems2 = new Elems<int>();
            elems2.Add(5, 14, 13);
            elems2.Show();

        }
    }
    //make this class generic
    class Elems<T>
    {
        public T[] elements = new T[3];

        public void Add(T elem1, T elem2, T elem3)
        {
            elements[0] = elem1;
            elements[1] = elem2;
            elements[2] = elem3;
        }

        public void Show()
        {
            foreach (T item in elements)
            {
                Console.Write(item + " ");
            }
        }
    }
}