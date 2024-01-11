using System;

namespace InterfaceNamespace {
    class Program {
        static void Main(string[] args) {
           MethodCollection refer=new MethodCollection();
           refer.getData(2,1);
           refer.printdata();
        }
    }

    interface InterfaceExample{
       public void getData(int x, int b);
       public void printdata();
      
    }

    class MethodCollection:InterfaceExample{
        public int data;

        public void getData(int x, int b ){
           data= x+b;
        }

        public void printdata(){
            Console.WriteLine("The Output is :"+data);
        }


    }
}