using System;

class SampleCollection<V>
{
   // Declare an array to store the data elements.
   private V[] arr = new V[100];

   // Define the indexer to allow client code to use [] notation.
   public V this[int i]
   {
      get { return arr[i]; }
      set { arr[i] = value; }
   }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      Console.WriteLine(stringCollection[0]);
   }
}
// The example displays the following output:
//       Hello, World.