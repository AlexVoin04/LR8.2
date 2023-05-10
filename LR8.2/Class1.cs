using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8._2
{
    public class TaskAdditional
    {
        public double TheValueOfTheSineAndCosine(double gradus, int sinAndCos)
        {
            double radian = gradus * Math.PI / 180;
            double result = -99999999999;
            if (sinAndCos == 0)
            {
                result = Math.Sin(radian);
            }
            else if (sinAndCos == 1)
            {
                result = Math.Cos(radian);
            }
            else if (sinAndCos == 2)
            {
                result = Math.Tan(radian);
            }
            else if (sinAndCos == 3)
            {
                result = 1 / Math.Tan(radian);
            }
            return result;
        }

        
    }
}
