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