using System;

namespace NoNameSpace {
        // T refers to the generic 
    public delegate void MyDelegate<T>(T x,T y);
    class Program {
        static void Main(string[] args) {

            MyDelegate<int> ref_1=multiply;
            multiply(1,2);

            MyDelegate<double> ref_2=add;
            add(1,2);
        }

        public static void add (double a, double b){
            double sum= a+b;
            Console.WriteLine("The sum is =" +sum);
        }

         public static void multiply (int a, int b){
            double sum= a+b;
            Console.WriteLine("The sum is =" +sum);
        }
    }
}