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
                for (int i = 0; i < numberOfTrials; i++) //looping through number of trials
                {
                    int SeatNumber = 0;
                    int Value = 0;
                    Console.WriteLine("Enter seat number :-");
                    try
                    {
                        SeatNumber = Convert.ToInt32(Console.ReadLine()); // here we get seat number from console


                        if (SeatNumber % 12 == 1 || SeatNumber % 12 == 0)  //dividing SeatNumber with 12 because of it contains 12 Seat in one cabin
                        {
                            if (SeatNumber % 12 == 0)                       //if seatnumber is divided by 12 and value will 0 then
                            {
                                Value = SeatNumber - 11;                    //add 11 seat on it and it will be WS as image
                                Console.WriteLine(Value + " WS");
                            }
                            else
                            {
                                Value = SeatNumber + 11;        //if not then add 11 seats and show WS on image
                                Console.WriteLine(Value + " WS");
                            }
                        }
                        else if (SeatNumber % 12 == 6 || SeatNumber % 12 == 7) {        //as above condition it is also satisfied by divide with 6 and 7, according to them it will WS 
                            if (SeatNumber % 12 == 6)
                            {
                                Value = SeatNumber + 1;
                                Console.WriteLine(Value + " WS");
                            }
                            else
                            {
                                Value = SeatNumber - 1;
                                Console.WriteLine(Value + " WS");
                            }
                        }
                        else if (SeatNumber % 12 == 5 || SeatNumber % 12 == 8) //same as above condition but check with 5 and 8 
                        {
                            if (SeatNumber % 12 == 5)
                            {
                                Value = SeatNumber + 3;
                                Console.WriteLine(Value + " MS");
                            }
                            else
                            {
                                Value = SeatNumber - 3;
                                Console.WriteLine(Value + " MS");
                            }
                        }
                        else if (SeatNumber % 12 == 2 || SeatNumber % 12 == 11) ////same as above condition but check with 11 and 2
                        {
                            if (SeatNumber % 12 == 2)
                            {
                                Value = SeatNumber + 9;
                                Console.WriteLine(Value + " MS");
                            }
                            else
                            {
                                Value = SeatNumber - 9;
                                Console.WriteLine(Value + " MS");
                            }
                        }
                        else if (SeatNumber % 12 == 3 || SeatNumber % 12 == 10) ////same as above condition but check with 3 and 10
                        {

                            if (SeatNumber % 12 == 3)
                            {
                                Value = SeatNumber + 7;
                                Console.WriteLine(Value + " AS");
                            }
                            else
                            {
                                Value = SeatNumber - 7;
                                Console.WriteLine(Value + " AS");
                            }
                        }
                        else
                        {                                                   //if it is not then executes following condition and assign seat number as AS
                            if (SeatNumber % 12 == 4)
                            {
                                Value = SeatNumber + 5;
                                Console.WriteLine(Value + " AS");
                            }
                            else
                            {
                                Value = SeatNumber - 5;
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
