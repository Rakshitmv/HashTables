using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyMapNode<string, string> hashTable = new MyMapNode<string, string>(5);

            //hashTable.Add("0", "To");
            //hashTable.Add("1", "be");
            //hashTable.Add("2", "or");
            //hashTable.Add("3", "not");
            //hashTable.Add("4", "to");
            //hashTable.Add("5", "be");
            //string strHold = hashTable.GetElement("2");
            //Console.WriteLine("Given index value is " + strHold);
            //Console.ReadLine();



            //MyMapNode<string, string> hashTable = new MyMapNode<string, string>(18);
            //hashTable.Add("0", "“Paranoids");
            //hashTable.Add("1", "are");
            //hashTable.Add("2", "but");
            //hashTable.Add("3", "paranoid");
            //hashTable.Add("4", "because");
            //hashTable.Add("5", "they");
            //hashTable.Add("6", "are");
            //hashTable.Add("7", "paranoid");
            //hashTable.Add("8", "but");
            //hashTable.Add("9", "because");
            //hashTable.Add("10", "they");
            //hashTable.Add("11", "keep");
            //hashTable.Add("12", "putting");
            //hashTable.Add("13", "themselves");
            //hashTable.Add("14", "deliberately");
            //hashTable.Add("15", "into");
            //hashTable.Add("16", "paranoid");
            //hashTable.Add("17", "avoidable");
            //hashTable.Add("18", "situations”");

            //string strHold = hashTable.GetElement("4");
            //Console.WriteLine("Entered value is " + strHold);
            //Console.ReadLine();

            MyMapNode<string, string> hashTable = new MyMapNode<string, string>(18);

            hashTable.Add("0", "“Paranoids");
            hashTable.Add("1", "are");
            hashTable.Add("2", "but");
            hashTable.Add("3", "paranoid");
            hashTable.Add("4", "because");
            hashTable.Add("5", "they");
            hashTable.Add("6", "are");
            hashTable.Add("7", "paranoid");
            hashTable.Add("8", "but");
            hashTable.Add("9", "because");
            hashTable.Add("10", "they");
            hashTable.Add("11", "keep");
            hashTable.Add("12", "putting");
            hashTable.Add("13", "themselves");
            hashTable.Add("14", "deliberately");
            hashTable.Add("15", "into");
            hashTable.Add("16", "paranoid");
            hashTable.Add("17", "avoidable");
            hashTable.Add("18", "situations”");

            hashTable.RemoveElement("17");
            System.Console.WriteLine(" avoidable word deleted from the paragraph");

            string strHold = hashTable.GetElement("f17");
            System.Console.WriteLine("17th word in the paragraph is " + strHold);
            Console.ReadLine();

        }
    }
}
