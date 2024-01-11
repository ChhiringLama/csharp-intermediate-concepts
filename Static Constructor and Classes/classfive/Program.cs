using System;

namespace staticConstructor {
    class Test{
        //fields can be made both public and privae if we access them by instace

        private static string name; 
        int a;
        static Test(){
            //Intializes all the static field of the class
            Console.WriteLine("This is static Constructor");
            name="Unknown";

            //Or you can parameterize this method to take user input
            Console.WriteLine(name);
        }

        public Test(){

            //in every other object creation this contructor is called
            Console.WriteLine("Theis is constructor"); a=0;
        }

        public Test(int x){
            Console.WriteLine("This is instace constructor");
            a=x;
        }

        public Test(Test x){
            Console.WriteLine("This is copy constructor");
            a=x.a;
        }

        ~Test(){
             Console.WriteLine("This is Destructor");
        }

        public void show(){
            Console.WriteLine(a);
        }
    }

     class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");

            Test t1=new Test(); //defaul
            Test t2=new Test(10); // parameterized;
            Test t3=new Test(t2); // Copy constructor
            t1.show(); //0
            t2.show(); //10
            t3.show(); //10
        }
    }
}