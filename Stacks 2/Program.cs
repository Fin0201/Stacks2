using System;
using System.Collections.Generic;

namespace Pop_Top_Peek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>(); //Creates a list that will be acting as a stack.

            string insertString = "Hello"; //Creates a string that will then be added to the list.
            push(stringList, insertString); //Initiates the push method.
            insertString = "This value is in the middle.";
            push(stringList, insertString);
            insertString = "This value is on top.";
            push(stringList, insertString);

            peek(stringList); //Initiates the peek method.

            pop(stringList); //Initiates the pop method.





            Console.WriteLine(); //Creates a space in the console to seperate what outputs next.
            foreach (var item in stringList) //Outputs the remaining items in the list.
            {
                Console.WriteLine(item);
            }
        }



        static void push(List<string> popList, string insertString) //Defines the push method.
        {
            popList.Insert(0, insertString); //Adds the string into the beginning of the list.
        }

        static void peek(List<string> peekList) //Defines the peek method.
        {
            Console.WriteLine(peekList[0]); //Outputs the item at the beginning of the list.
        }

        static void pop(List<string> popList) //Defines the pop method.
        {
            Console.WriteLine(popList[0]); //Outputs the item at the beginning of the list.
            popList.RemoveAt(0); //Removes the item at the beginning of the list
        }
    }
}