using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballOffside
{
    class Program
    {

        static bool OffsidePosition(int[,] teams)
        {
            int nCounterRed = 0;
            int nCounterBlue = 0;

            int lhs = 0;
            int rhs = 0;

            bool flag = true;//left

            for (int i = 0; i < teams.GetLength(0); i++)
            {
                for (int j = 0; j < teams.GetLength(1); j++)
                {
                    if ((teams[i, j] < 50))
                    {
                        lhs++;
                    }
                    else if((teams[i, j] > 50))
                    {
                        rhs++;
                    }

                }
            }

            if(rhs>lhs)
            {
                flag = false;//right
            }

            //for (int i = 0; i < teams.GetLength(0); i++)
            //  {
            //      for (int j = 0; j < teams.GetLength(1); j++)
            //      {
            //           //arr[i, j]; dostupvam vseki element
            //           if(i==0)
            //          {
            //              if ((teams[i,j] < 20 || teams[i, j] == 20) || (teams[i, j] > 80 || teams[i, j] == 80)) //elementa e x
            //                  nCounterRed++;
            //          }
            //           else if(i==1)
            //          {
            //              if ((teams[i, j] < 20 || teams[i, j] == 20)|| (teams[i, j] > 80 || teams[i, j] == 80)) //elementa e x
            //                  nCounterBlue++;
            //          }
            //      }
            //  }

            if (flag)
            {
                for (int i = 0; i < teams.GetLength(0); i++)
                {
                    for (int j = 0; j < teams.GetLength(1); j++)
                    {
                        if (i == 0)
                        {
                            if (teams[i, j] < 20 || teams[i, j] == 20)
                                nCounterRed++;
                        }
                        else if (i == 1)
                        {
                            if (teams[i, j] < 20 || teams[i, j] == 20) 
                                nCounterBlue++;
                        }
                    }
                }
                if(nCounterBlue > nCounterRed - 1)
                {
                    return true;
                }

            }
            else
            {                
                for (int i = 0; i < teams.GetLength(0); i++)
                {
                    for (int j = 0; j < teams.GetLength(1); j++)
                    {
                        if (i == 0)
                        {
                            if (teams[i, j] > 80 || teams[i, j] == 80) 
                                nCounterRed++;
                        }
                        else if (i == 1)
                        {
                            if (teams[i, j] > 80 || teams[i, j] == 80) 
                                nCounterBlue++;
                        }
                    }
                }

                if (nCounterRed > nCounterBlue - 1)
                    return true;
            }
         

            return false; 
        }

       public static void Main(string[] args)
        {
          
            Console.WriteLine(
                OffsidePosition(new int[,] { {5, 20, 30, 40, 30, 50, 30, 50, 50, 60, 50} , //red
                {96, 20, 30, 25, 25, 40, 60, 70, 80, 70, 40}}));//blue
            Console.ReadKey(true);
        }
    }
}
