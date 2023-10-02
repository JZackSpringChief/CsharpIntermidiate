//arrays 
int[]myArray; //to delcare array
int[]myArray = new int[5]; //arrays are object and we need to instantiate them like so.
myArray[0] = 23; //this would assign the first element of the array the value of 23.

string[] names = {"zack", "dan", "kyle"};
double[] prices = {23, 33, 55};
//short hand of writing an array.


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
		int min = 0;

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


int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };
//three rows and two columns nested curly brackets define values for each row.
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; 
			for (int k = 0; k < 3; k++) {
				for (int j = 0; j < 2; j++) {
					Console.Write(someNums[k, j]+" ");
				}
				Console.WriteLine();
			}

			int[,] nums = {{1,2,3},{4,5,6},{7,8,9}};
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(nums[i,j]);
				}
				Console.WriteLine();
			}
		}
	}
}

//jagged arrays ex/
int[ ][ ] jaggedArr = new int[3][ ];

//initialize array upon declaration
int[ ][ ] jaggedArr = new int[ ][ ] 
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};

//full example
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ ][ ] jaggedArr = new int[ ][ ] 
			{
				new int[ ] {1,8,2,7,9},
				new int[ ] {2,4,6},
				new int[ ] {33,42}
			};
			int x = jaggedArr[2][1];
			Console.WriteLine(x);
		}
	}
}

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());


            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

            };
            //your code goes here
            	string a = olympiad[0][day1Winner-1];
            	Console.WriteLine(a);
            	string b = olympiad[1][day2Winner-1];
            	Console.WriteLine(b);
            	string c = olympiad[2][day3Winner-1];
            	Console.WriteLine(c);
            
        }
    }
}

//array properties and methods.
namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int[ ] arr = {2, 4, 7};
			
			Console.WriteLine(arr.Length); 
			
			Console.WriteLine(arr.Rank); 
			
		}
	}
}

//array methods
int[ ] arr = { 2, 4, 7, 1};
			Console.WriteLine(arr.Max());
			Console.WriteLine(arr.Min());
			Console.WriteLine(arr.Sum());