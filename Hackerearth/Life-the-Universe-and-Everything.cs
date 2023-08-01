/*
Problem Statement:
https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/life-the-universe-and-everything/

*/
using System;

public class Program{
    public static void Main(){

        FindAnswerToLife();
    }

    public static void FindAnswerToLife()
    {
        while(true)
        {
            int num = int.Parse(Console.ReadLine());

            if(num == 42) break;

            Console.WriteLine(num);
        }
      
    }


}