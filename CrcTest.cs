using System;

namespace CRC
{
    public static class CrcTest
    {
        public static void Test()
        {
            foreach (var p in CrcStdParams.StandartParameters.Values)
            {
                var crc = new Crc(p);
                if (!crc.IsRight())
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
