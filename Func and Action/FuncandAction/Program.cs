using System;

namespace Nonamespace {
    
    class Program {

        
        
        public static void printtext()=>Console.WriteLine("Print a simple String");
        public static void printstring(string input)=>Console.WriteLine("Print a simple String :"+input);
        public static void printnum(int a, int b)=>Console.WriteLine("Print a number"+a+b);

        //For Funct

        public static int add(int a, int b){
            return a+b;
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            //With action, we dont need to create delegates to refer to a method
            //No paranthesis because its passesing a reference
            Action ref_1=printtext;

            //Two int because the parameter must match the method
            Action<int,int> ref_2=printnum;
            Action<string> ref_3=printstring;
            printtext();
            printnum(1,2);
            printstring("Hello from the string parameter");

            //Func 

            Func<int,int,int> ref_4=add;
            
            int value= add(4,4);
            Console.WriteLine(value);

            //Or method 2
            Console.WriteLine("The sum is ="+add(8,2));




        }

    }
}