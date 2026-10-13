using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        
        List<string> numList = ["hello", "Hello", "HEllo", "HELlo"];
        // numList.Add("hello");
        // numList.Add("Hello");
        // numList.Add("HEllo");
        // numList.Add("HELlo");
        //highlight a line and then press (CTRL+/) to comment it and vice versa

        static void addOne(ref List<string> numbList)
        {
            numbList.Add("Oh no");
        }


        addOne(ref numList);

        for (int i=0; i<numList.Count; i++)
        {
            Console.WriteLine(numList[i]);
        }
        Console.WriteLine(numList);
    }
}