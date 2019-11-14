using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //create string array
        string[] stringArray1 = { "Anne Wu", "Bill Tinker", "Frank Jone", "Anna Nim", "Lucy Url","Kelly MacNamara"};

        //prompt user to enter a number (0-5) to print corresponding index from the the array
        Console.WriteLine("Please enter employee ID number (0-5) to find corresponding employee name.");
        int EmployeeName = Convert.ToInt16(Console.ReadLine());

        //IfElse Statement to display error is user's input format is incorect
        if (EmployeeName > 5)
        {
            Console.WriteLine("Error: Input is incorrect.");
            Console.Read();
            Environment.Exit(0);

        }
        else
        {
            Console.WriteLine("Employee Name: " + stringArray1[EmployeeName] + ".");
            Console.ReadLine();
        }

        //create integer array
        int[] intArray1 = { 5612, 545154, 746, 15484, 5464, 8954 };

        //prompt user to enter a number (0-5) to print corresponding index from the the array
        Console.WriteLine("Please enter equipment bin number (0-5) to find corresponding part number.");
        int PartNum = Convert.ToInt16(Console.ReadLine());

        //IfElse Statement to display error is user's input format is incorect
        if (PartNum > 5)
        {
            Console.WriteLine("Error: Input is incorrect.");
            Console.Read();
            Environment.Exit(0);

        }
        else
        {
            Console.WriteLine("Part Number: " + intArray1[PartNum] + ".");
            Console.ReadLine();
        }

        //create string list
        List<string> stringList1 = new List<string>();

        //populate string list
        stringList1.Add("Professor");
        stringList1.Add("A Last Names");
        stringList1.Add("B Last Names");
        stringList1.Add("C Last Names");
        stringList1.Add("D Last Names");
        stringList1.Add("E Last Names");

        //Ask user for input
        Console.WriteLine("Enter folder number (0-5) to receive correlating folder category");
        int GradedPaperCategory = Convert.ToInt16(Console.ReadLine());

        //input error message & exit
        if (GradedPaperCategory > 5)
        {
            Console.WriteLine("Error:Input is incorrect");
            Console.ReadLine();
            Environment.Exit(0);
        }
        //print Graded Paper Category
        else
        {
            Console.WriteLine("The category of the selected graded papers is: " + stringList1[GradedPaperCategory]);
        }

        Console.ReadLine();
    }   
} 

