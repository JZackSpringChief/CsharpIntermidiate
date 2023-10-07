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