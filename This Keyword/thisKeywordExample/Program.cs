using System;

namespace ThisKeyWord {
    class Program {
        static void Main(string[] args) {
           MethodCollection ref_1=new MethodCollection(2,"Chhiring");
           ref_1.DisplayInfo();
         
        }
    }

    class MethodCollection{
        public int rollNo;
        public string name;
        public MethodCollection(int rollNo,string name){
            this.rollNo=rollNo;
            this.name=name;
        }

        public void DisplayInfo(){
            Console.WriteLine($"{name}'s roll no: is {rollNo}");
        }
    }
}