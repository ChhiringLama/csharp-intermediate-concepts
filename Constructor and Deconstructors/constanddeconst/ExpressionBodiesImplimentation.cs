using System;

namespace UtilityNameSpace {
   class OtherClasses{
        private string address;

        public OtherClasses(string address)=>this.address=address;
        
        public void Addressis(){
            Console.WriteLine(address);
        }
        
   }
}