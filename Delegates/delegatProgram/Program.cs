using System;
    //  In traditional object-oriented programming, methods are typically associated with classes, 
    // and to call a method, you need to create an object of that class. This means if you have 
    // methods in two different classes, you would indeed need two object references to call those
    //  methods.

    // However, when you use delegates in C#, you decouple the method from the object instance. 
    // Delegates allow you to create references to methods without needing an instance of a particular
    //  class. This is particularly useful in scenarios where you want to pass around methods as parameters,
    //   store them in data structures, or create more flexible and modular code.  
    public delegate void SuperDelegate(int x,int y);

    class Program {

        public static void MethodFromDelegate(int x, int y){
            Console.WriteLine("Hello from Method of a delegate and i print"+ (y+x));
        }

        public static void MethodTwoFromDelegate(int x, int y){
            Console.WriteLine("Hello from Method of a delegate and i print"+ (y+x));
        }
        
        static void Main(string[] args) {

        //When a delegate can refer to multiple methods into a same reference and calls every methods then this is called multicast delegate
        SuperDelegate Obj_1=MethodFromDelegate;
        Obj_1+=MethodTwoFromDelegate;

        Obj_1(5,2);
        }

    
    }
