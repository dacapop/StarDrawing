using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StarDrawing
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int iLineNum = 0;

            Console.WriteLine("Enter total line number : ");
            try
            {
                iLineNum = Convert.ToInt16(Console.ReadLine());

                if(iLineNum < 5)
                {
                    Console.WriteLine("total line number cannot less than 5");
                }
                else if(iLineNum%2 == 0)
                {
                    Console.WriteLine("total line number cannot be an even number");
                }
                else
                {
                    Star myStar = new Star(iLineNum);
                    myStar.DrawMyStar();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exit with error : " + ex.Message);
            }
        }
    }
}
