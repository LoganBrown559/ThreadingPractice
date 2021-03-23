using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    public class FindPiThread
    {
        int darts;
        int dartsLanded { get; set; }
        double randThrows;
        System.Random ranNum = new System.Random();

        public FindPiThread(int darts_to_throw)
        {
            darts = darts_to_throw;
            randThrows = ranNum.Next(0, 1);
        }


        public void throwDarts()
        {
            double x = randThrows;
            double y = ranNum.Next(0, 1);

        }
    }
}
