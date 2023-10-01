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
	int[] = new int a[12]
				for (int k = 0; k < 12; k++)
				{
				    
				}
				