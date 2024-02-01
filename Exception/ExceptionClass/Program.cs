using System;

namespace Mynamespace {
    class Program {
        static void Main(string[] args) {

            int x=10;
            try{
                if(x==10){
                    throw new ArgumentOutOfRangeException();
            }
            }
            catch{
                Console.WriteLine("Error generated!! Age is set="+x);
            }
        }
    }
}