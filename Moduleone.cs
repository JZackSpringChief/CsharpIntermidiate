//Classes and objects
//creating an object is called "instantiation"
//charactoristics of an object are called properties

//values and Reference types.
//Stack is used for static mem allocation, which includes all your value types.
//Heap is used for dynamic mem allocation, which includes custom objecrs, that might need additional mem during the runtime of your program.
//example of a class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Person 
{
    int age;
    string name;
    public void SayHi()
    {
        Console.WriteLine("hi");
 	}
}


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


//can use the dot "." operator to get info in object


namespace SoloLearn
{
	class Program
	{
		class Dog
		{
			public string name;
			public int age;
		}
		static void Main(string[] args)
		{
			Dog bob = new Dog();
			bob.name = "Bobby";
			bob.age = 3;
			
			Console.WriteLine(bob.age);
		}
	}
}

//encapsulation also meaning information hiding.

namespace SoloLearn
{
	class BankAccount {
		private double balance=0;
		public void Deposit(double n) {
			balance += n;
		}
		public void Withdraw(double n) {
			balance -= n;
		}
		public double GetBalance() {
			return balance;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount b = new BankAccount();
			b.Deposit(199);
			b.Withdraw(42);
			Console.WriteLine(b.GetBalance());
		}
	}
}


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }
    
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            	winrate = wins*100/games;
                Console.WriteLine(winrate);
        }
    }
}

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Welcome object with the same name
            Welcome welcome = new Welcome();
            		
            	
            
            
            welcome.WelcomeMessage();
            welcome.SuperMessage();
            
        }
    }
    
    class Welcome
    {
        //complete the class, add WelcomeMessage() method
        	public void WelcomeMessage()
        	{
        		Console.WriteLine("Welcome to OOP");
        	}
            public void SuperMessage()
            {
                Console.WriteLine("This is a super message");
            }
    }
}

//class constructors = a constructor has exactly the same name as its class. is public, and does not have any return type.
//ex
class Person
{
  private int age;
  public Person()
  {
    Console.WriteLine("Hi there");
  }
  static void Main(string[] args)
  {
    Person p = new Person();
  }
}

namespace SoloLearn
{
	class Program
	{
		class Person
		{
			private int age;
			private string name;
			public Person(string nm)
			{
				name = nm;
			}
			public string getName()
			{
				return name;
			}
		}
		static void Main(string[] args)
		{
			Person p = new Person("David");
			Console.WriteLine(p.getName());
		}
	}
}

//properties 

namespace SoloLearn
{
	class Program
	{
		class Person
		{
			private string name;
			public string Name
			{
				get { return name; }
				set { name = value; }
			}
		}
		static void Main(string[] args)
		{
			Person p = new Person();
			p.Name = "Bob";
			Console.WriteLine(p.Name);
		}
	}
}


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();

            //fix the output
            Console.WriteLine(card1.AccountNum);
            
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        //create a property to get the account
        	public string AccountNum{
        		get {return accountNum;}
        	}
    }
}


namespace SoloLearn
{
	class Program
	{
		class Person
		{
			public string Name { get; set; }
		}
		static void Main(string[] args)
		{
			Person p = new Person();
			p.Name = "Bob";
			Console.WriteLine(p.Name);
		}
	}
}

// Social Network  
 
// You are making a social network application and want to add post creation functionality. 
// As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share. 
// The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content. 
// Complete the class with 
// - a constructor, which outputs "New post" as called, 
// - Text property, which will allow you to get and set the value of the text field. 
 
// Once you have made the changes to the program so that it works correctly, then in main, the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it. 
 
// Sample Input 
// Hello! 
 
// Sample Output 
// New post 
// Hello!


namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;
        
        //write a constructor here
        	public Post()
        	{
        		Console.WriteLine("New post");
        	}
        

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        //write a property for member text
        	public string Text {
        		set { text = value; }
        		get { return text; }
        	} 
        
    }
}