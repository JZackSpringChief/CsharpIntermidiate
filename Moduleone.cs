//Classes and objects
//creating an object is called "instantiation"
//charactoristics of an object are called properties

//values and Reference types.
//Stack is used for static mem allocation, which includes all your value types.
//Heap is used for dynamic mem allocation, which includes custom objecrs, that might need additional mem during the runtime of your program.
//example of a class
class Person 
{
    int age;
    string name;
    public void SayHi()
    {
        Console.WriteLine("hi");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
	class Program
	{
		class Person {
			int age;
			string name;
			public void SayHi() {
				Console.WriteLine("Hi");
			}
		}
		static void Main(string[] args)
		{
			Person p1 = new Person();
			p1.SayHi();
		}
	}
}