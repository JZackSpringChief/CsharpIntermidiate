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