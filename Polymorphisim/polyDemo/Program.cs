using System;


//Mechanism to assign multiple functionality to a single programming component or we can say single programming compenent have multiple form

//Design time polymorphisim
//Runtime polymorphisim


namespace PolyNamespace {
    class Program {
        static void Main(string[] args) {
           ChildofMethodcollection x =new ChildofMethodcollection();
           Methodcollection.add(2,4);
           Methodcollection.add(2,4,1);
           x.balance();

        }
    }

    class  Methodcollection{

        //Method Overloading
        public static void add(int x, int y){
            Console.WriteLine($"{x+y}");
        }
        public static void add(int x, int y, int z){
             Console.WriteLine($"{x+y+z}");
        }

        //Virtual Keyword is required to override a method
        public virtual int balance(){
            return 10;
        } 
        }

    class ChildofMethodcollection:Methodcollection{

        //Method overriding
        public override int balance(){
            return 20;
        }
    } 
}