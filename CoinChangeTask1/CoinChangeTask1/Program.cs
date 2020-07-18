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
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                numberOfPlayers = 0;
            }
            Console.WriteLine("Please enter number of coins count:- ");
            try
            {
                coinsCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                coinsCount = 0;
            }
                

            if (numberOfPlayers > 0 && coinsCount > 0)
            {
                arrayOfCoins = new int[coinsCount];
                if (IsMultiplier(coinsCount, numberOfPlayers))
                {
                    for (int i = 0; i < coinsCount; i++)
                    {
                        try
                        {
                            Console.Write(">>");
                            arrayOfCoins[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Not allowed");
                            Console.ReadLine();
                            break;
                        }
                    }

                    if (arrayOfCoins.Length > 0)
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
            return (x % n) == 0;
        }

        public static void PlayGame(int[] array, int numberOfPlayers)
        {
            int[] playerArray = new int[numberOfPlayers];
            int k = array.Length - 1;
            int j =0;
            for(int i=0; i != k+1; i++, j++){
                if (j == playerArray.Length)
                {
                    j = 0;
                }
                if (array[i] > array[k])
                {
                    playerArray[j] += array[i];
                }
                else
                {
                    playerArray[j] += array[k];
                    i--;
                    k--;
                }
            }

            int maximumValue = playerArray[0];
            int maximumValuedPlayer = 0;

            for (int z = 0; z < playerArray.Length; z++)
            {
                if(playerArray[z]> maximumValue){
                    maximumValue = playerArray[z];
                    maximumValuedPlayer = z;
                }
            }

            Console.WriteLine("The Winner is " + maximumValuedPlayer + " Player and Coins are " + maximumValue);
        }
    }
}
