using System;

namespace MainProgram {
    class Program {
        //Copy constructors take the field values of a base object's 
        //If the base object has some part of the field undefind the copy cosntructor will also 
        //take the undefined variable.


        //Copy constructor is useful to take field values of older data and update them with new data,
        //However since new constructor is initialized with new name, the memory space allocated are 
        //also different, so both new and old constructors initialization exists.
        static void Main(string[] args) {
            MethodCollection detail=new MethodCollection("Chhiring");
            detail.Introduce();

            MethodCollection detailmore=new MethodCollection(detail);
            detailmore.hobby="Football";
            detailmore.Introduce();

        }
    }

    public class  MethodCollection{
        private string name;
        internal string hobby="Unknown";

        public MethodCollection(string name){
        this.name=name;
        }

        public MethodCollection(MethodCollection previousStudent){
        name=previousStudent.name;
        }

        public void Introduce(){
            Console.WriteLine($"My name is {name} and my hobby is {hobby}");
        }
    }
}