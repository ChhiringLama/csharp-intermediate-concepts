using System;
using System.Collections.Specialized;
using System.Diagnostics.SymbolStore;
using System.Reflection;

//Indexers allows us to make classes behave like an array to manipulate their properties with the use of getters and setters

//  syntax
//  <modifier> <type> this[<parameter list>]{
// [int i] now we use index to access the array
// [string i] now we access the array with its key // Look at getters
//    get{

//    }set{

//    }
//    }

class Employee{
   double salary;
   string name, designation, address;
   int age;
   
   public Employee(double salary, string name, string designation, string address, int age){
      this.salary=salary;
      this.name=name;
      this.designation=designation;
      this.address=address;
      this.age=age;
   }

   //Defining an indexer under a class makes it work like an array to access the field
   //Object type contains every type of data
   public object this[int indexofthearray]{
   // public object this[string keyname]{
      get {
         // if(keyname=="Salary")
         // return salary; // now to access we use the bracket notation look at the main section
         if(indexofthearray==0)
          return salary;
         else if(indexofthearray==1)
          return name;
         else if(indexofthearray==2)
          return designation;
         else if(indexofthearray==3)
          return address;
         else if(indexofthearray==4)
          return age;
         return null;
      }
      set{
         if(indexofthearray==1)
          salary=(int)value;
         else if(indexofthearray==2)
            name=(string)value;
                   
         else if(indexofthearray==3)
            designation=(string)value;
                   
         else if(indexofthearray==2)
            address=(string)value;
                   
         else if(indexofthearray==2)
            age=(int)value;      
      }
   }
}

class Program{
   public static void Main(){
         //This is how we create a new object of an employe by manually passing value to constructor; 
         Employee emp_1=new Employee(20000.00, "Chhiring", "Manager", "Boudha",23);
         //1, To access the property of the class using the instance emp_1 we will either have to make the class field as public (which will allow an
         //anyone to access them and modify them which we do not want)
         

         //2, If we declare the field with properties we can declare the private field and access them.

         //3, We can access the properties of the class using the indexers 

         Console.WriteLine($"Salary: {emp_1[0]}");
         Console.WriteLine($"Name: {emp_1[1]}");
         Console.WriteLine($"Post: {emp_1[2]}");
         Console.WriteLine($"Address: {emp_1[3]}");
         Console.WriteLine($"Age: {emp_1[4]}");

         //Modifying is now made possible with setter
         emp_1[1]=4000;
         Console.WriteLine($"Salary: {emp_1[0]}");
         Console.WriteLine($"Name: {emp_1[1]}");
         Console.WriteLine($"Post: {emp_1[2]}");
         Console.WriteLine($"Address: {emp_1[3]}");
         Console.WriteLine($"Age: {emp_1[4]}");

         //Parameter list <string>
         // emp_1["salary"]

   }
}


