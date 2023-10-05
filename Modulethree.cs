using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delcare a string
string name = "Zack";
string lastName = "Spring Chief";
//declare a integer
int age = 33; //no need for quotes and we can declare using int, double, and float(we use f for float)
//declare booleon
bool isCool = true;
// delcare single letter 
char grade = 'A';
//how to access name varialbe 
Console.WriteLine(name); //can use any variable OR
Console.Write(age); //this does not write in a line
//user interactivity
Console.Readline(); //gets user to input information
//Converting
Convert.ToInt32(); //can use other numbers like 16, 32, and 64
Convert.ToString(); //convert input to string.
// there are other methods
name.ToUpper(); //converts name to uppercase in this example.
name.ToLower(); //same but to lower case;
name.Length; //gives length aomunt in value
// how to store an user inputted value
//declare value
string input = Console.Readline();
// concatanation adding values together(not multipying)
Console.WriteLine("Hello my name is: " + name + " and my age is: " + age);
//interpoleation
Console.WriteLine($"My full name is: {name} {lastName}")

//destructors -- as constructors are used when a class in instantiated, destructors are automaticall
//invoked when an object is destroyed or deleted.
/* - a class can only have one Destructor
   - Destructors cannot be called. they are invoked automatically.
   - a destructor does not take modifiers or have parameters.
   - the name of a destructor is exactly the same as the class prefixed with a tilde (~) ex */

class Dog
{
  ~Dog() 
  {
    // code statements
  }
}

namespace SoloLearn
{
	class Program
	{
		class Dog
		{
			public Dog() {
				Console.WriteLine("Constructor");
			}
			~Dog() {
				Console.WriteLine("Destructor");
			}
		}
		static void Main(string[] args)
		{
			Dog d = new Dog();
		}
	}
}

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            //this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            //complete the constructor
            Console.WriteLine("Winner is " + finalists[winner] );
        }
        
        //create destructor => "Game Over"
        	~FinalRound() {
        		Console.WriteLine("Game Over");
        	}
        
        
    }
}

//static members FINALLY TIME TO DICUSS WHAT STATIC MEANS!!!
static void Main(string[] args)
//Class members (variables, properties, methods) can also be declared as static. This makes those members belong to the class itself, 
//instead of belonging to individual objects. No matter how many objects of the class are created, there is only one copy of the static member. 
//For example:
class Cat {
  public static int count=0;
  public Cat() {
    count++;
  }
}

	class Program
	{
		class Cat {
			public static int count=0;
			public Cat() {
				count++;
			}
		}
		static void Main(string[] args)
		{
			Cat c1 = new Cat();
			Cat c2 = new Cat();
			Console.WriteLine(Cat.count);
		}
	}
    	class Program
	{
		class Cat {
			public static int count=0;
			
			public Cat() {
				count++;
			}
		}
		class Dog {
		public static int count=0;
		    public Dog() {
			    count++;
			}
		}
		static void Main(string[] args)
		{
			Cat c1 = new Cat();
			Cat c2 = new Cat();
			Cat c3 = new Cat();
			Cat c4 = new Cat();
			Dog d1 = new Dog();
			Console.WriteLine(Cat.count);
			Console.WriteLine(Dog.count);
		}
	}
    	class Program
	{
		class Dog
		{
			public static void Bark() {
				Console.WriteLine("Woof");
			}
		}
		static void Main(string[] args)
		{
			Dog.Bark();
		}
	}
//Constant members are static by definition
    	class Program
	{
    
		class MathClass {
			public const int ONE = 1;
		}
		static void Main(string[] args)
		{
			Console.Write(MathClass.ONE);
		}
	}

//static constructors can be declared static to initialize static members of the class.
	class Program
	{
		class SomeClass {
			public static int X { get; set; }
			public static int Y { get; set; }
			
			static SomeClass() {
				X = 10;
				Y = 20;
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine(SomeClass.X);
			Console.WriteLine(SomeClass.Y);
			Console.WriteLine(SomeClass.X * SomeClass.Y);
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {
        
        public string depName;

        //declare static depCount member with value of 2
        public static int depCount = 2;
        //complete the constructor
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            	depCount++;
        }
    }