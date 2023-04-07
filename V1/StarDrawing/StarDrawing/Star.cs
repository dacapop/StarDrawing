using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarDrawing
{
    internal class Star
    {
        private int iMaxLine = 0;

        public Star(int maxLine)
        {
            this.iMaxLine = maxLine;
        }

        public void DrawMyStar()
        {
            for (int i=1; i<=iMaxLine; i++)
            {
                ArrayList alRes = GetStarPosition(i, iMaxLine);

                for(int j=1; j<=((2*iMaxLine)+1); j++)
                {
                    if (alRes.Contains(j))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("");
            }
        }

        public ArrayList GetStarPosition(int iLineNum, int iMaxLine)
        {
            ArrayList alResult = new ArrayList();
            double dMedian = Math.Ceiling(Convert.ToDouble(iMaxLine) / 2);

            int v1 = (iMaxLine + 2) - iLineNum;
            alResult.Add(v1);

            if (iLineNum > 1)
            {
                int v2 = v1 + (2 * (iLineNum - 1));
                alResult.Add(v2);

                if (iLineNum == dMedian)
                {
                    alResult.Add(1);
                    alResult.Add((2 * iMaxLine) + 1);
                }
                else if(iLineNum == dMedian + 1)
                {
                    alResult.Add(iMaxLine+1);
                }   
            }

            return (alResult);
        }
    }
}
