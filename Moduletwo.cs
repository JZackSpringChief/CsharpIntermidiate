//arrays 
int[]myArray; //to delcare array
int[]myArray = new int[5]; //arrays are object and we need to instantiate them like so.
myArray[0] = 23; //this would assign the first element of the array the value of 23.

string[] names = {"zack", "dan", "kyle"};
double[] prices = {23, 33, 55};
//short hand of writing an array.

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
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
               int x = Convert.ToInt32( Console.ReadLine());
            if (x < 0 || x > 4)
            {
                Console.WriteLine("Invalid number");
            }
        
            else
            {
            Console.WriteLine(games[x]);
            
        }
    }
}

//arrays in loops
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ ] a = new int[10];
			for (int k = 0; k < 10; k++) {
				a[k] = k*2;
			}
			for (int k = 0; k < 10; k++) {
				Console.WriteLine(a[k]);
			}
		}
	}
}namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ ] a = new int[10]; // creates array
			for (int k = 0; k < 10; k++) {
				a[k] = k*2; //fills in array
			}
			for (int k = 0; k < 10; k++) { //iterates array
				Console.WriteLine(a[k]); // outputs array results
			}
		}
	}
}

//foreach provides shorter and easier way of accessing an array elements
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ ] a = new int[10];
			for (int k = 0; k < 10; k++) {
				a[k] = k*2;
			}
			foreach (int k in a) {
				Console.WriteLine(k);
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
			int[ ] arr = {11, 35, 62, 555, 989};
			int sum = 0; //to get full sum we create a varaible and initialize at "0" 
			
			foreach (int x in arr) {
				sum += x;
			}
			Console.WriteLine(sum);
		}
	}
}


namespace SoloLearn
{
	static void Main(string[] args)
	{
		int[] numbers = int[5];
		int count = 0;
		int sum = 0;

		while (count < 5)
		{
			numbers[count] = Convert.ToInt32(Console.WriteLine());
			count++;
		}
		for (numbers[i]%2 == 0)
		{
			sum += numbers[i];
		}
		Console.WriteLine(sum);
	}
}

//multidimentional arrays
//declared
type[, , … ,] arrayName = new type[size1, size2, …, sizeN];
//to declare a 2 dim array
int[,] arrayN = new int [8,8];
//this will make 8 rows with 8 columns
