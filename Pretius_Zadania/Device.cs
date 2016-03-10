using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretius_Zadania
{
    public static class Device
    {

        public static string GetSerial(byte[] array)
        {
           string ret =  Encoding.UTF8.GetString(array);
           return ret;
        }



        public static float[] ReadInputs()
        {
            float[] tab = null;


            return tab;
        }

        public static void SetOutputs(float[] outputValues)
        {
            for (int i = 0; i < outputValues.Length; i++)
            {
                int a = i + 1;
                Console.WriteLine(string.Format("Wyjście {0}: {1}", a, outputValues[i]));
            }
        }
    }
}
