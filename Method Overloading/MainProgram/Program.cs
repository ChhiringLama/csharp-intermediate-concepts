using System;
using System.Data;
using System.Diagnostics;

namespace MainProgram {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            MethodCollection.SayHello();
            MethodCollection.SayHello("chhiring");

            MethodCollection AccessMethods=new MethodCollection();
            AccessMethods.SayHello(10);
        }
    }

    class MethodCollection{
        
        //This wont be able to be called since we havent defined it with public modifier
        // static void SayHello(){

        // }


        //Internal modifier specifies this method is for only the current assemble (Compiled File)
       internal static void SayHello(){
            Console.Write("Hello");
        }

       public  static void SayHello(string name){
            Console.Write($"{name} says hello");
        }

        //Return type difference doesnt matter, this is still a method overloading
        public int SayHello(int x){
            for(int k=0;k<=x;k++){
                Console.Write($"\n Hello this is no: {k}");
            };
                return 0;
        }
    }
}