using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretius_Zadania
{
    public class Input
    {

        public float Value;
        float MinValue = -20;
        float MaxValue = 20;
        float Step = 0.1f;
        public Input(float value)
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
