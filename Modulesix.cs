//Generics allow the reuse of code across different types.
//ex.
static void Swap(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}
//Our Swap method will work only for integer parameters. If we want to use it for other types,
// for example, doubles or strings, we have to overload it for all the types we want to use it with.
// Besides a lot of code repetition, it becomes harder to manage the code because changes
// in one method mean changes to all of the overloaded methods. 
//Generics provide a flexible mechanism to define a generic type.
static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}
	class Program
	{
		static void Swap<T>(ref T a, ref T b) {
			T temp = a;
			a = b;
			b = temp;
		}
		static void Main(string[] args)
		{
			int a = 4, b = 9;
			Swap<int>(ref a, ref b);
			Console.WriteLine(a+" "+b);
			
			string x = "Hello";
			string y = "World";
			Swap<string>(ref x, ref y);
			Console.WriteLine(x+" "+y);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        //your code goes here
        		public static void Print<T>(T a)
        		{
        			Console.WriteLine("Showing "+a);
        		}
        
    }