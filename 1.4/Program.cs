/*
*******************************************************************
* Name: Amaan Dhanani
* Date: 1/9/26
* Week 1 GP – Display Text
*
* Main application (program) class.
* In this application we will print a line of text using WriteLine
* and print a line of formatted text using Write
*/
public class DisplayText
{
    static void Main(string[] args)
    {
        //Print a line of text to the console using WriteLine
        Console.WriteLine("Hello, Your Name! Welcome to C# Programming!");
        Console.WriteLine();
        Console.Write("A string followed by a newline.\n" +
            "A string following the newline.\n" +
            "Decimal (integer) value: {0:D}\n" +
            "Floating point number 3.1415 to 2 decimals: {1:F2}\n" +
            "Floating point number 1.199 to 2 decimals (rounded): {2:F2}\n",
            4, 3.1415, 1.199);
    }
}