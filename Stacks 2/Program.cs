using System;

namespace Pop_Top_Peek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[0]; //Creates an array that will be acting as a stack.

            string insertString = "Hello"; //Creates a string that will then be added to the array.
            stringArray = push(stringArray, insertString); //Initiates the push method and sets stringArray to the array that gets returned.
            insertString = "This value is in the middle.";
            stringArray = push(stringArray, insertString);
            insertString = "This value is on top.";
            stringArray = push(stringArray, insertString);

            stringArray = pop(stringArray); //Initiates the pop method and sets stringArray to the array that gets returned.

            peek(stringArray); //Initiates the peek method.





            Console.WriteLine(); //Creates a space in the console to seperate what outputs next.
            foreach (var item in stringArray) //Outputs the remaining items in the array.
            {
                Console.WriteLine(item);
            }
        }



        static string[] push(string[] pushArray, string insertString) //Defines the push method.
        {
            string[] tempArray = new string[pushArray.Length + 1]; //Creates a new temporary array with a length one higher than pushArray.

            tempArray[0] = insertString; //sets the first value to insertString.
            for (int i = 0; i < pushArray.Length; i++) //Loops through the following code for the length of pushArray.
            {
                tempArray[i + 1] = pushArray[i]; //Sets the next value in tempArray to the current value in pushArray. 
            }
            return tempArray; //returns tempArray.
        }

        static string[] pop(string[] popArray) //Defines the pop method.
        {
            Console.WriteLine(popArray[0]); //Outputs the item at the beginning of the array.

            string[] tempArray = new string[popArray.Length - 1]; //Creates a new temporary array with a length one lower than pushArray.

            for (int i = 0; i < tempArray.Length; i++) //Loops through the following code for the length of tempArray.
            {
                tempArray[i] = popArray[i + 1]; //Sets the current value in tempArray to the next value in popArray
            }
            return tempArray; //Returns tempArray.
        }

        static void peek(string[] peekArray) //Defines the peek method.
        {
            Console.WriteLine(peekArray[0]); //Outputs the item at the beginning of the array.
        }
    }
}