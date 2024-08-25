using System;
using Hometask_sem_2;

namespace Hometask_sem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Неявное приведение");
            Bits bit = new(80);
            Bits bitByte = new((byte)60);
            Bits bitInt = new((int)70);
            Bits bitLong = new((long)80);

            Console.WriteLine(bit);
            Console.WriteLine(bitByte);
            Console.WriteLine(bitInt);
            Console.WriteLine(bitLong);
            Console.WriteLine("----------");


            Console.WriteLine("Явное приведение");
            bit = (Bits)257;
            byte bByte = 255;
            int cInt = 2147483647;
            long dlong = 9223372036854775807;

            Console.WriteLine(bit.Value);
            bit = (Bits)bByte;
            Console.WriteLine(bit.Value);
            bit = (Bits)cInt;
            Console.WriteLine(bit.Value);
            bit = (Bits)dlong;
            Console.WriteLine(bit.Value);


        }
    }
}
