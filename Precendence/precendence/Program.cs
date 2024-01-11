using System;

namespace PrecedenceIntro {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            //Left Associative ( except assignment operator( equals sign)  lamda expression and null coalescing operators) evaluates an expression if 
            //all operators are same


            //Lambda, null coalescing and conditional operator are right associative.
            //x=y=3 
            //3 is assigned to y and y to x

            //?? => is null coalescing operator
            //string s1 = null;
            //string s2 = s1?? ""; //s2 evaluates to "" 
            // this aviods the probabiliy of error

            //null-conditional operator
            //string s=null;
            //string y=s?.Tostring(); // If s is not null convert to string


            //Statement means any line of code that terminates with semicolon that states what a line of code does.
            //programs are collection of statements
            //Block statement -> A set of statement inclosed in curly braces 

            //If a statement declares, mentions and specifies a variable than it is a declarative statement


            //Local and global variable

            //Expression statement are also statemetns that performs and operation and produces a value

            //control statement -> controls the flow of program execution (selection or decision statment,-> if else), (iteration, for loop),
            //(jump statement, break and continue)

            //foreach is a relative reference loop, no need to specify or use index to find element, useful for list structure like array, string

            //goto statement

            //try throw and catch
        
        }
    }
}