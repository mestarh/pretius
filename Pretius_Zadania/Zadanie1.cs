using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretius_Zadania
{
    public class Zadanie1
    {

        public string SerialNumberHex;

        public uint DeviceType;

        public uint DeviceModel;

        public float wej1, wej2, wej3, wej4;

        public float wyj1, wyj2, wyj3, wyj4, wyj5, wyj6, wyj7, wyj8;
        public Zadanie1(string _serialNumber)
        {
            SerialNumberHex = _serialNumber;
            HexToBinary(SerialNumberHex);
        }
        public byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        bool GetBit(byte thebyte, int position)
        {
            return (1 == ((thebyte >> position) & 1));
        }

        public void HexToBinary(string hexValue)
        {
            string binaryString1 = string.Empty;
            byte[] bytes = FromHex(hexValue);

            for (int i = 0; i < 4; i++)
            {
                int bit = Convert.ToInt32(GetBit(bytes[0], i));

                binaryString1 += bit.ToString();
            }

           
            DeviceType = Convert.ToUInt32(binaryString1);

            string binaryString2 = string.Empty;
            for (int i = 4; i < 8; i++)
            {
                int bit = Convert.ToInt32(GetBit(bytes[0], i));
                binaryString2 += bit.ToString();
            }
            DeviceModel = Convert.ToUInt32(binaryString2);
        }
    }
}
