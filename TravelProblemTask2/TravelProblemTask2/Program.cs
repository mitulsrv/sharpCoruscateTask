using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelProblemTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTrials = 0;
            int[] array;
            Console.WriteLine("Enter number of trials (ENTER INTEGER ONLY): -");
            try
            {
                numberOfTrials = Convert.ToInt32(Console.ReadLine()); //get number of input or you can say that trial
            }
            catch (Exception ex)
            {
                numberOfTrials = 0;  //if trial value is invalid then it will throw exception
            }
            if (numberOfTrials > 0) //if number of trial is greater then zero then we can do further processing
            {
                array = new int[numberOfTrials];
                Console.WriteLine("Enter seat number (ENTER INTEGER ONLY) :-");
                for (int k = 0; k < array.Length; k++)
                {
                    array[k] = Convert.ToInt32(Console.ReadLine()); // here we get seat number from console
                }

                    for (int i = 0; i < array.Length; i++) //looping through number of trials
                    {
                        int Value = 0;
                        
                        try
                        {
                            if (array[i] % 12 == 1 || array[i] % 12 == 0)  //dividing array[i] with 12 because of it contains 12 Seat in one cabin
                            {
                                if (array[i] % 12 == 0)                       //if array[i] is divided by 12 and value will 0 then
                                {
                                    Value = array[i] - 11;                    //add 11 seat on it and it will be WS as image
                                    Console.WriteLine(Value + " WS");
                                }
                                else
                                {
                                    Value = array[i] + 11;        //if not then add 11 seats and show WS on image
                                    Console.WriteLine(Value + " WS");
                                }
                            }
                            else if (array[i] % 12 == 6 || array[i] % 12 == 7)
                            {        //as above condition it is also satisfied by divide with 6 and 7, according to them it will WS 
                                if (array[i] % 12 == 6)
                                {
                                    Value = array[i] + 1;
                                    Console.WriteLine(Value + " WS");
                                }
                                else
                                {
                                    Value = array[i] - 1;
                                    Console.WriteLine(Value + " WS");
                                }
                            }
                            else if (array[i] % 12 == 5 || array[i] % 12 == 8) //same as above condition but check with 5 and 8 
                            {
                                if (array[i] % 12 == 5)
                                {
                                    Value = array[i] + 3;
                                    Console.WriteLine(Value + " MS");
                                }
                                else
                                {
                                    Value = array[i] - 3;
                                    Console.WriteLine(Value + " MS");
                                }
                            }
                            else if (array[i] % 12 == 2 || array[i] % 12 == 11) ////same as above condition but check with 11 and 2
                            {
                                if (array[i] % 12 == 2)
                                {
                                    Value = array[i] + 9;
                                    Console.WriteLine(Value + " MS");
                                }
                                else
                                {
                                    Value = array[i] - 9;
                                    Console.WriteLine(Value + " MS");
                                }
                            }
                            else if (array[i] % 12 == 3 || array[i] % 12 == 10) ////same as above condition but check with 3 and 10
                            {

                                if (array[i] % 12 == 3)
                                {
                                    Value = array[i] + 7;
                                    Console.WriteLine(Value + " AS");
                                }
                                else
                                {
                                    Value = array[i] - 7;
                                    Console.WriteLine(Value + " AS");
                                }
                            }
                            else
                            {                                                   //if it is not then executes following condition and assign seat number as AS
                                if (array[i] % 12 == 4)
                                {
                                    Value = array[i] + 5;
                                    Console.WriteLine(Value + " AS");
                                }
                                else
                                {
                                    Value = array[i] - 5;
                                    Console.WriteLine(Value + " AS");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Invalid input, run again");
                            Console.ReadKey();
                            break;
                        }
                    }
            }
            else
            {
                Console.WriteLine("Invalid input, run again");
            }

            Console.ReadLine();
        }
    }
}
