//inheritance & polymorphism
//inheritance allows us to define a class based on another class. class Base ===> class Derived
//for ex base class of "animal" can be used to derive Cat and Dog classes. 
//the derived class inherites all the features from the base class, and can have its own additinal features
class Animal { //base
  public int Legs {get; set;}
  public int Age {get; set;}
}

class Dog : Animal { //derived
  public Dog() {
    Legs = 4;
  }
  public void Bark() {
    Console.Write("Woof");
  }
}

	class Program
	{
		class Animal {
			public int Legs {get; set;}
			public int Age {get; set;}
            	public void Pet() {
			    Console.WriteLine("*Pet me*");
			}
		}
		class Dog : Animal {
			public Dog() {
				Legs = 4;
			}
			public void Bark() {
				Console.Write("Woof");
			}
		}
		static void Main(string[] args)
		{
			Dog d = new Dog();
			Console.WriteLine(d.Legs);
				Dog a = new Dog();
			
			a.Pet();
			
			d.Bark();
		}
	}

//method inheritance
	class Program
	{
		class Person {
			public void Speak() {
				Console.WriteLine("Hi there");
			}
		}
		class Student : Person {
			int number;
		}
		static void Main(string[] args)
		{
			Student s = new Student();
			s.Speak();
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
            
            	  	/*Car a = new Car();
        	a.ShowBrand();
        	a.ShowModel();*/ //need to delete but will keep in as i messed this up.
        }
    }
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    //complete the Car class
    class Car : Vehicle
    {
        public string Model { get; set; }
        
        public void ShowModel()
        {
            Console.WriteLine("Model: " + Model);
        }
        
    }
}

//protected
//protected is similar to private insofar as derived classed can access then. ex
namespace SoloLearn
{
	class Program
	{
		class Person {
			protected int Age {get; set;}
			protected string Name {get; set;}
		}
		class Student : Person {
			public Student(string nm, int a) {
				Name = nm;
                Age = a;
			}
			public void Speak() {
				Console.Write("Name: "+Name + " i Am: " + Age);
			}
		}
		static void Main(string[] args)
		{
			Student s = new Student("David");
			s.Speak();
		}
	}
}
// trying to access outside of the derived class
	{
		class Person {
			protected int Age {get; set;}
			protected string Name {get; set;}
		}
		class Student : Person {
			public Student(string nm) {
				Name = nm;
			}
			public void Speak() {
				Console.Write("Name: "+Name);
			}
		}
		static void Main(string[] args)
		{
			Student s = new Student("David");
			s.Name = "Bob"; 
		}
	}

//sealed -- a class can prevent other classes from inheriting it, or any of its members, by using the sealed modifier.
//ex.

	class Program
	{
		sealed class Animal {
			//some code
		}
		class Dog : Animal { } //Error
		
		static void Main(string[] args)
		{
			
		}
	}

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account
    {
        /*private*/ protected double Balance { get; set; }
    }

    class User : Account
    {
        protected string AccNumber { get; set; }
        
        //complete the constructor
        public User(string accNumber, double balance)
        {
            AccNumber = accNumber;
            Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}

//derived class Constructor and Destructor
class Animal {
  public Animal() {
    Console.WriteLine("Animal created");
  }
  ~Animal() {
    Console.WriteLine("Animal deleted");
  }
}
class Dog: Animal {
  public Dog() {
    Console.WriteLine("Dog created");
  }
  ~Dog() {
    Console.WriteLine("Dog deleted");
  }
}

// we have to define the Animal class with both a constructor and destructor and a derived Dog
//class with its own constructor and destructor as well. 
	class Program
	{
		class Animal {
			public Animal() {
				Console.WriteLine("Animal created");
			}
			~Animal() {
				Console.WriteLine("Animal deleted");
			}
		}
		class Dog: Animal {
			public Dog() {
				Console.WriteLine("Dog created");
			}
			~Dog() {
				Console.WriteLine("Dog deleted");
			}
		}
		static void Main(string[] args)
		{
			Dog d = new Dog();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            WayStatus status = new WayStatus();
        }
    }
    class Flight
    {
        public Flight()
        {
            Console.WriteLine("Registration");
        }
        ~Flight()
        {
            Console.WriteLine("Closed");
        }
    }
    /*derive this class from Flight class,
    define constructor and destructor for it*/
    class WayStatus : Flight
    {
        	public WayStatus() {
        		Console.WriteLine("On the way");
        	}
        	
        	~WayStatus() {
        		Console.WriteLine("Landed");
        	}
    }

class A {

  public int x=7;

  public A() {

    x++;

  }

}

class B: A {

  public B() {

    x++;

  }

}

//Polymorphism meaning "Having many forms"
//simply, polymorphism means that a single method can have a number of different implementations.
class Shape {
  public virtual void Draw() {
    Console.Write("Base Draw");
  }
}//using the "virtual keyword" which allows methods to be overridden in derived classes
//virtual methods enable you to work with groups of related objects in a uniform way

//using the override keyword
class Circle : Shape {
  public override void Draw() {
    // draw a circle...
    Console.WriteLine("Circle Draw");
  }
}
class Rectangle : Shape {
  public override void Draw() {
    // draw a rectangle...
    Console.WriteLine("Rect Draw");
  }
}