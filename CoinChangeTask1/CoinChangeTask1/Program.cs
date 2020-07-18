using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinChangeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers;
            int coinsCount;
            int[] arrayOfCoins;
            Console.Write("Please enter number of players :- ");
            try
            {
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());  //get input for any number of player
            }
            catch (Exception ex)
            {
                numberOfPlayers = 0;
            }
            Console.WriteLine("Please enter number of coins count:- "); //get input of coins count
            try
            {
                coinsCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                coinsCount = 0;
            }
                

            if (numberOfPlayers > 0 && coinsCount > 0) //if both values are satisfied then 
            {
                arrayOfCoins = new int[coinsCount];         //create array with size of total coins
                if (IsMultiplier(coinsCount, numberOfPlayers))      //check total coins are multiplier with number of player
                {
                    for (int i = 0; i < coinsCount; i++)            
                    {
                        try
                        {
                            Console.Write(">>");
                            arrayOfCoins[i] = Convert.ToInt32(Console.ReadLine()); //getting values from console and assign it to array
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Not allowed");    //if any errors then it will throw exception
                            Console.ReadLine();
                            break;
                        }
                    }

                    if (arrayOfCoins.Length > 0) //if coin array value greater then 0 then it will call play game
                    {   
                        //Console.WriteLine(String.Join(Environment.NewLine, arrayOfCoins.Select(s => s.ToString())));
                                            
                        PlayGame(arrayOfCoins, numberOfPlayers);

                    }
                    else
                    {
                        Console.WriteLine("Coin array is empty, please run it again");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Coin count must be a multiplier of no. of players");
                }
                
            }
            else
            {
                Console.WriteLine("Please run again, you entered wrong value");
            }

            Console.ReadLine();
        }

       
        public static bool IsMultiplier(int x, int n)
        {
            return (x % n) == 0;    //for checking condition of multiplier
        }

        public static void PlayGame(int[] array, int numberOfPlayers)
        {
            int[] playerArray = new int[numberOfPlayers];       //created array with size of total player
            int k = array.Length - 1;
            int j =0;
            for(int i=0; i != k+1; i++, j++){
                if (j == playerArray.Length)            //check if player array is reset or not
                {
                    j = 0;          //if it is then index j is reseed
                }
                if (array[i] > array[k])        //compare value of coins with extreme nearest index of array
                {
                    playerArray[j] += array[i];     //and if it then sum with player index of coins array
                }
                else
                {
                    playerArray[j] += array[k]; // otherwise it will sum
                    i--;    
                    k--;
                }
            }

            int maximumValue = playerArray[0]; //first value of player array which is having total coins of each player
            int maximumValuedPlayer = 0;    //initialize maximumValuePlayer with 0
            int counter = 0;
            for (int z = 0; z < playerArray.Length; z++) //looping through each element of player array and find maximum value with index
            {
                counter++;
                if(playerArray[z]> maximumValue){
                    maximumValue = playerArray[z];
                    maximumValuedPlayer = z;
                }

            }
            maximumValuedPlayer += counter;
            Console.WriteLine("The Winner is " + maximumValuedPlayer + " Player and Coins are " + maximumValue); //here printing winner player
        }
    }
}
//Thank you