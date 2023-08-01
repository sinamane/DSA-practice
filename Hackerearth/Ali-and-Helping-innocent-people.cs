/*
Problem Statement:
https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/cartag-948c2b02/

*/


using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
     string tag = Console.ReadLine();
     List<string> vowels = new List<string>{"A", "E", "I", "O", "U", "Y"};

      int pairOne = Convert.ToInt32(tag[0].ToString()) + Convert.ToInt32(tag[1].ToString());
      int pairTwo = Convert.ToInt32(tag[3].ToString()) + Convert.ToInt32(tag[4].ToString());
      int pairThree = Convert.ToInt32(tag[4].ToString()) + Convert.ToInt32(tag[5].ToString());
      int pairFour = Convert.ToInt32(tag[7].ToString()) + Convert.ToInt32(tag[8].ToString());


        if(vowels.Contains(tag[2].ToString()))
        {
            Console.WriteLine("invalid");
        }
        else if(pairOne % 2 == 0 && pairTwo % 2 == 0 && pairThree % 2 == 0 && pairFour % 2 == 0)
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }
  }


}