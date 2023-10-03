using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delcare a string
string name = "Zack";
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