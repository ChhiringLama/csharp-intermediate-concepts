using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

// A field is only a proeperty if only it it access (manipulated) using the accessor, i.e setter and getter
class Program { 
        static void Main(string[] args) {
            Test ref_1=new Test("Lama",2);
            Console.WriteLine(ref_1.SymbolNo);
            Console.WriteLine(ref_1.name);
        }
    }

public class Test{

    public string name;
    private int symbolNo;

    //Constructor
    public Test(string name,int symbolNo){
        //Property is capitalized
        Name=name;
        SymbolNo=symbolNo;
    }

    //This is called accessor

    public string Name{
        get{
            return name;
        }
        set{
            name=value;
        }
    }

    public int SymbolNo {
        get{
            return symbolNo;
        }set{
            //In setters we use the keyword 'value' to refer to any value that is being assigned to a  property
            symbolNo=value;
        }
    }
}