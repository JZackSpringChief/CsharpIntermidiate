//struts - a strut is a type of value used to encapsulate small groups of related variables such as
// the coordinates of a rectangle or the characteristics of an item in an inventory. ex
struct Book {
  public string title;  
  public double price;
  public string author;
}
		static void Main(string[] args)
		{
			Book b;
			b.title = "Test";
			b.price = 5.99;
			b.author = "David";
			
			Console.WriteLine(b.title);
		}

//structs share most of the syntax of classes, but are more limited than classes.
//unlike classes, structs can be instantiated without using a new operator
//structs do not support inheritance and cannot contain virtual methods.
//Structs can contain methods, properties, indexers, and so on. Structs cannot contain default constructors 
//(a constructor without parameters), but they can have constructors that take parameters. 
//In that case the new keyword is used to instantiate a struct object, similar to class objects. ex
namespace SoloLearn
{
	class Program
	{
		struct Point {
			public int x;
			public int y;
			public Point(int x, int y) {
				this.x = x;
				this.y = y;
			}
		}
		static void Main(string[] args)
		{
			Point p = new Point(10, 15);
			Console.WriteLine(p.x);
		}
	}
}
//structs are much more simpler than classes. consider using a struct when trying to represent a simple set of data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        //create a constructor
        	public Cuboid(int length, int width, int height){
        		this.length = length;
        		this.width = width; 
        		this.height = height;
        	}
        
        
        //complete this method
        public int Volume()
        {
            	return length*width*height;
        }
        //complete this method
        public int Perimeter()
        {
            	return 4*(length+width+height);
        }
    }
}
//Enums = is used to declare an enumeration: a type that consists of a set of name consts called the
//enumerator list. ex
enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; //by defalut the first enumerater has a value of 0
//and the value of each successive enumerator is increased by 1.
	    {
			int x = (int)Days.Tue; //dot notation
			Console.WriteLine(x);// outputs 2
		}
//basically, enums define variables that represeent members of a fixed set. ex, days, months, cards in a deck.
//enums are often used in switch statements.
namespace SoloLearn
{
	class Program
	{
		enum TrafficLights { Green, Red, Yellow };
		static void Main(string[] args)
		{
			TrafficLights x = TrafficLights.Red;
			switch (x) {
				case TrafficLights.Green:
					Console.WriteLine("Go!");
					break;
				case TrafficLights.Red:
					Console.WriteLine("Stop!");
					break;
				case TrafficLights.Yellow:
					Console.WriteLine("Caution!");
					break;
			}
		}
	}
}
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    
    /*
    Easy => "You have 3 minutes 45 seconds"
    Medium = > "You have 3 minutes 20 seconds"
    Hard => "You have 3 minutes"
    */

    class Player
    {
        public Player(Difficulty x)
        {
            //your code goes here
            	
            		switch (x){
            		case Difficulty.Easy:
            		Console.WriteLine("You have 3 minutes 45 seconds");
            		break;
            		case Difficulty.Medium:
            		Console.WriteLine("You have 3 minutes 20 seconds");
            		break;
            		case Difficulty.Hard:
            		Console.WriteLine("You have 3 minutes");
            		break;
            		
            		}
            
        }
    }
     enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}
//Exception Handling
// an exception is a problem that occurs during a program execution. 
//an exception can occur for many different reasons. some ex
// a user enter invalid data
// a file that needs to be opened cannot be found
// a network connection has be lost in the middle of communications.
// insufficient mem and other issues related to physical resources
//ex
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 4, 5, 8 };
			Console.Write(arr[8]);
		}
	}
}// bad hanling error
//use good error handling remember try/catch from js. same thing bro
	class Program
	{
		static void Main(string[] args)
		{
			try {
				int[] arr = new int[] { 4, 5, 8 };
				Console.Write(arr[8]);
			}
			catch(Exception e) {
				Console.WriteLine("An error occurred");//can also use e.Message
			}
		}
	}
int x, y;
try {
  x = Convert.ToInt32(Console.Read());
  y = Convert.ToInt32(Console.Read());
  Console.WriteLine(x / y);
}
catch (DivideByZeroException e) {
  Console.WriteLine("Cannot divide by 0");
}
catch(Exception e) {
  Console.WriteLine("An error occurred");
}
//The following exception types are some of the most commonly used: FileNotFoundException,
// FormatException, IndexOutOfRangeException, InvalidOperationException, OutOfMemoryException.
//optional use is "finally" = can be used after catch blocks/
//the finally block is used to execute a given set of statements, whether an exceptoin is thrown or not.
//ex
	class Program
	{
		static void Main(string[] args)
		{
			int result=0;
			int num1 = 8;
			int num2 = 4;
			try {
				result = num1 / num2;
			}
			catch (DivideByZeroException e) {
				Console.WriteLine("Error");
			}
			finally {
				Console.WriteLine(result);
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            	int choice = Convert.ToInt32(Console.ReadLine());
            
            //your code goes here
            try
            {
             	   	
             	   	Console.WriteLine(tours[choice]);//to access choice array use array.userinput...
            }
            catch (Exception e)
            {
                	Console.WriteLine("Wrong number");
            }
            finally
            {
                	Console.WriteLine("Goodbye");
            }
        }
    }
//Working with files. System.IO has various classes that are used for performing numerous operations
//with files such as creating and deleting file, reading from or writing to a file, closing, and more
// the "File" class is one of em. ex
string str = "Some text";
File.WriteAllText("test.txt", str);

		static void Main(string[] args)
		{
			string str = "Some text";
			File.WriteAllText("test.txt", str);
			
			string txt = File.ReadAllText("test.txt");
			Console.WriteLine(txt); 
		}
        //outputs Some text
//The following methods are available in the File class: 
//AppendAllText() - appends text to the end of the file. 
// Create() - creates a file in the specified location. 
// Delete() - deletes the specified file. 
// Exists() - determines whether the specified file exists. 
// Copy() - copies a file to a new location. 
// Move() - moves a specified file to a new location
//robot-barmen
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                //your code goes here
                Console.WriteLine(drinks/shelves);

            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least one shelf");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}