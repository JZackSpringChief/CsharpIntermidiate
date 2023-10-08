//inheritance & polymorphism
//inheritance allows us to define a class based on another class. class Base ===> class Derived
//for ex base class of "animal" can be used to derive Cat and Dog classes. 
//the derived class inherites all the features from the base class, and can have its own additinal features
using System.Runtime.InteropServices;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
	class Program
	{
		class Shape {
			public virtual void Draw() {
				Console.WriteLine("Base Draw");
			}
		}
		class Circle : Shape {
			public override void Draw() {
				// draw a circle...
				Console.WriteLine("Circle Draw");
			}
		}
		class Rectangle : Shape {
			public override void Draw() {
				// draw a rectangle...
				Console.WriteLine("Rectangle Draw");
			}
		}
		class Square : Shape {
		    public override void Draw() {
		        // draw a square...
		        Console.WriteLine("Square Draw");
		    }
		}
		static void Main(string[] args)
		{
			Shape c = new Circle();
			c.Draw();

			Shape r = new Rectangle();
			r.Draw();
			
			Shape s = new Square();
			
			Shape z = new Shape();
			z.Draw();
			s.Draw();
		}
	}
}

// test q

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    
    /*derive the class from Unit class
    and override Attack() method*/
    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Musketeer ATTACK!");
        }
    }
    /*derive the class from Unit class
    and override Attack() method*/
    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Magician ATTACK!");
        }
    }
}

//Abstract classes -- you cannot create objects of aclass containing an abstract method 
abstract class Shape {
   public abstract void Draw();
}// denoted my the abstract class
//abstract methods are only accessable by the abstract class itself
//abstract classes are intended to be the base classes for inherited classes. it acts like a
//template for its derived classes.
	class Program
	{
		abstract class Shape {
			public abstract void Draw();
		}
		class Circle : Shape {
			public override void Draw() {
				Console.WriteLine("Circle Draw");
			}
		}
		class Rectangle : Shape {
			public override void Draw() {
				Console.WriteLine("Rect Draw");
			}
		}
		static void Main(string[] args)
		{
			Shape c = new Circle();
			c.Draw();
		}
	}
//differenc from "Sealed" as sealed prevents a class from being inherited and "Abstract" mod requires a 
//class to be inherited.

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
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);

            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());
        }
    }
    abstract class Figure
    {
        //define abstract method Perimeter with no body
        	public abstract int Perimeter();
        
    }
    class Rectangle : Figure
    {
        public int width;
        public int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        //override Perimeter method for rectangle
        	public override int Perimeter() {
        		return 2*width+2*height;
        	}
        
    }
    class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;
        public Triangle(int s1, int s2, int s3)
        {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        
        //override Perimeter method for triangle
        	public override int Perimeter() {
        		return side1+side2+side3;
        	}
        
    }
}
//interfaces -- interface is a completly abstract class, which contains only abstract members.
//declared using "interface" keyword ex
public interface IShape
{
    void Draw();
}
// all members of the interface are default abstract, so no need to used the abstract keyword.
//inrterfaces can only be public(by default), private and protected members.

namespace SoloLearn
{
    class Program
    {
        public interface iShape {
            void Draw();
        }
        class Circle : iShape {
            public void Draw () {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            iShape c = new Circle();
            c.Draw();
        }
    }
}
//override keyword is not needed when you implement a interface;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }
    
    //implement IColor & IEquipment interfaces
    public class Car : IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }
        
        //reimplement this method
        public void GetColor()
        {
            Console.WriteLine("Color: " + color);
        }
        //reimplement this method
        public void GetEquipment()
        {
            Console.WriteLine("Equiment: " + equipment);
    }
}

//default implementation in interfaces allows us to write an implementation of any method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
	class Program
	{
		public interface IShape {
			void Draw();
			void Finish(){
				Console.WriteLine("Done!");
			}
		}
		class Circle : IShape {
			public void Draw() {
				Console.WriteLine("Circle Draw");
			}
		}
		static void Main(string[] args)
		{
			IShape c = new Circle();
			c.Draw();
			c.Finish();
		}
	}
}