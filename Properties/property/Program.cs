using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;


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

    public Test(string name,int symbolNo){
        //Property is capitalized
        Name=name;
        SymbolNo=symbolNo;
    }

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
            symbolNo=value;
        }
    }
}