using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretius_Zadania
{
    public class Output
    {


        public float Value;
        float MinValue = 0;
        float MaxValue = 30;
        float Step = 0.1f;
        public Output(float value)
        {

            if (value < MinValue)
            {
                Value = MinValue;
            }
            else if (value > MaxValue)
            {
                Value = MaxValue;
            }
            else
            {
                Value = (float)Math.Round(value,1);
            }
        }
    }
}
