using System;


    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");
            GrandChild ref=new GrandChild();
            ref.Print():
            ref.Addition();
        }
    }

    public class ParentClass{
        public int a =10, b=20;
    }
    
    class Siblingclass:ParentClass{

    }
    
    class Childclass:ParentClass{
        int a=30, b=40;
        public void Print(){
            Console.Write("Operations from Childclass : Parentclass");
            Console.Write("The value of a is "+a);
            Console.Write("The value of a is "+ base.a);
        }

    }

    public class GrandChild:ParentClass{
        int c=0;
        public void Addition(){
        c=base.a+base.b;
        Console.Write("The sum of the two variable is "+c);
        }
    }

