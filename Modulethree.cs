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
Console.ReadLine(); //gets user to input information
//Converting
Convert.ToInt32(3.2); //can use other numbers like 16, 32, and 64
Convert.ToString(true); //convert input to string.
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
//Static classes only one instance of a static class can exist in a program. you cannot instantiate and object.
Console.WriteLine(Math.Pow(2, 3)); //you can access all the members of the math class name, without
//declaring an object.
// Math  

// Math.PI the constant PI. 
// Math.E represents the natural logarithmic base e. 
// Math.Max() returns the larger of its two arguments. 
// Math.Min() returns the smaller of its two arguments. 
// Math.Abs() returns the absolute value of its argument. 
// Math.Sin() returns the sine of the specified angle. 
// Math.Cos() returns the cosine of the specified angle. 
// Math.Pow() returns a specified number raised to the specified power. 
// Math.Round() rounds the decimal number to its nearest integral value. 
// Math.Sqrt() returns the square root of a specified number. 

// Arrays
int[] arr = {1, 2, 3, 4};

// Array.Reverse(arr);
 //arr = {4, 3, 2, 1}

// Array.Sort(arr);
 //arr = {1, 2, 3, 4}

 //String 
//  string s1 = "some text";
// string s2 = "another text";

// String.Concat(s1, s2); // combines the two strings

// String.Equals(s1, s2); // returns false

//DateTime
	// Console.WriteLine(DateTime.Now);
	// 		Console.WriteLine(DateTime.Today);
			
	// 		Console.WriteLine(DateTime.DaysInMonth(2016, 2));

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //your code goes here
            	Array.Sort(numbers);
            	for (int n = 0; n < numbers.Length; n++)
				{
					Console.WriteLine(numbers[n]);
				}
            
        }
    }
}
//the this Keyword
class Person {
  private string name;
  public Person(string name) {
    this.name = name;
  }
}

//the readonly modifier

class Person {
  private readonly string name = "John"; 
  public Person(string name) {
    this.name = name; 
  }
}

readonly string name; // OK can be declared without initialization.
const double PI; // Error as it must be initialized when it is declared

//readonly can only be changed within its contructor. but a const cannot
//readonly can be assigned a value that is the result of a calculation but const cannot. ex
readonly double a = Math.Sin(60); // OK


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;
        
        //create the constructor
        	public Avg(double num1, double num2)
        	{
        		this.num1 = num1;
        		this.num2 = num2;
        	}

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
}

//indexer allows an object to be indexed like an array. 
	class Program
	{
		static void Main(string[] args)
		{
			string str = "Hello World";
			char x = str[2];
			Console.WriteLine(x);
		}
	}
class Clients {
  private string[] names = new string[10];

  public string this[int index] {
    get {
      return names[index];
    }
    set {
      names[index] = value;
    }
  }
}

namespace SoloLearn
{
	class Program
	{
		class Clients {
			private string[] names = new string[10];
			public string this[int index] {
				get {
					return names[index];
				}
				set {
					names[index] = value;
				}
			}
		}
		static void Main(string[] args)
		{
			Clients c = new Clients();
			c[0] = "Dave";
			c[1] = "Bob";
			
			Console.WriteLine(c[1]);
		}
	}
}

//operator overloading
class Box {
  public int Height {get; set;}
  public int Width {get; set;}
  public Box(int h, int w) {
    Height = h;
    Width = w;
  }
}
static void Main(string[] args) {
  Box b1 = new Box(14, 3);
  Box b2 = new Box(5, 7);
}
 Box b3 = b1 + b2;// add these 2 box objects, with would result in a new, bigger box
 //The Height and Width properties of object b3 should be equal to the sum of the 
 //corresponding properties of the b1 and b2 objects.

 public static Box operator+ (Box a, Box b) {
  int h = a.Height + b.Height;
  int w = a.Width + b.Width;
  Box res = new Box(h, w);
  return res;
}

	class Program
	{
		class Box {
			public int Height { get; set; }
			public int Width { get; set; }
			public Box(int h, int w) {
				Height = h;
				Width = w;
			}
			public static Box operator+(Box a, Box b) {
				int h = a.Height + b.Height;
				int w = a.Width + b.Width;
				Box res = new Box(h, w);
				return res;
			}
		}
		static void Main(string[] args)
		{
			Box b1 = new Box(14, 3);
			Box b2 = new Box(5, 7);
			Box b3 = b1 + b2;
			
			Console.WriteLine(b3.Height);
			Console.WriteLine(b3.Width);
		}
	}// finished module 2b quiz
