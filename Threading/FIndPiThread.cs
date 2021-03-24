/*
 * 
 * Name: Logan Brown
 * Date: 2/23/2021
 * File: FindPiThread.cs
 * Description: Takes care of "throwing" darts and calculating if they are in the second quadrent of the imaginary circle
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    public class FindPiThread
    {
        int darts;
        public int dartsLanded { get; set; }
        System.Random ranNum = new System.Random();

        public FindPiThread(int darts_to_throw)
        {
            dartsLanded = 0;
            darts = darts_to_throw;
        }


        public void throwDarts()
        {
            double addedSquares;
            for (int i = 0; i < darts; i++)
            {
                double x = ranNum.NextDouble();
                double y = ranNum.NextDouble();

                addedSquares = (x * x) + (y * y);
                if(addedSquares < 1)
                {
                    dartsLanded += 1;
                }
            }
        }
    }
}
