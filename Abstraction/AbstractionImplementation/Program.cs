using System;

namespace AbstractNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodCollection refer = new MethodCollection();
            refer.getData(2, 1);
            refer.printdata();
        }
    }

    public abstract class AbstractExample
    {
        public int data;

        public void getData(int x, int b)
        {
            this.data = x + b;
        }

        public abstract void printdata();
    }

    class MethodCollection : AbstractExample
    {
        public override void printdata()
        {
            Console.WriteLine("The Output is: " + this.data);
        }
    }

    //Also try multiple subclass overridden of the same abstract method
}
