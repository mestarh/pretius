using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretius_Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1 dev = new Zadanie1("8F-8F-8F-8F-8F-8F-8F-8F");
            Input input1 = new Input(21);
            Input input2 = new Input(12);
            Input input3 = new Input(12.56f);
            Input input4 = new Input(8);

          
            float[] tab = new float[8];

            for (int i= 0; i < 8; i++)
            {
                Output output1 = new Output(3.57f+i);
                tab[i] = output1.Value;
            }




            Console.WriteLine(string.Format("Serial number: {0}", dev.SerialNumberHex));
            Console.WriteLine(string.Format("Serial number to string: {0}", Device.GetSerial(dev.FromHex(dev.SerialNumberHex))));
            Console.WriteLine(string.Format("Device Model: {0}", dev.DeviceModel));
            Console.WriteLine(string.Format("Device Type: {0}", dev.DeviceType));

            Console.WriteLine();
            Console.WriteLine(string.Format("Wejście 1: {0}", input1.Value));
            Console.WriteLine(string.Format("Wejście 2: {0}", input2.Value));
            Console.WriteLine(string.Format("Wejście 3: {0}", input3.Value));
            Console.WriteLine(string.Format("Wejście 4: {0}", input4.Value));
            Console.WriteLine();
            Device.SetOutputs(tab);

            Console.ReadLine();
        }
    }
}
