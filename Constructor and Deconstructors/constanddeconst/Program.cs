using System;
using UtilityNameSpace;

namespace MainProgram {
    class Program {
        static void Main(string[] args) {
            // ConstructorInit ConstInit=new ConstructorInit(); will say arguement is missing 
             ConstructorInit ConstInit=new ConstructorInit(2, "Chhiring"); 
             ConstInit.Introduce();
             ConstructorInit ConstInit_2=new ConstructorInit(3, "Messi"); 
             ConstInit_2.Introduce();

            OtherClasses otrcls=new OtherClasses("Boudha");
            otrcls.Addressis();
        }
    }

    class ConstructorInit{

        //We can Declare the field we want to initialize as private too
        private int roll_no;
        private string name;
        private string collegeName;

        //Note 1:
        //Constructor are not of any return type
        //Now the public fields are sent to the constructor for intialization
        public  ConstructorInit(int roll_no, string name){
        this.name=name;
        this.roll_no=roll_no;
        collegeName="Bajra"; // Changing the default value;
        }
        
        //Note 2:
        //Or if we dont want to use this keyword
        // public  ConstructorInit(int my_roll_no, string my_name){
        // name=my_name;
        // roll_no=my_roll_no;
        // }


        //Note 3:
        //If No constructor is defined the field will be intialized with default value as 0 and null


        public void Introduce(){
            Console.WriteLine($"My name is {name} and my roll no is {roll_no}");
        }
    }
}