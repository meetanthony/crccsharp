using System;

namespace CRC
{
    public static class CrcTest
    {
        public static bool Test()
        {
            var results = Crc.CheckAll();

            var good = true;
            foreach (var result in results)
            {
                if (result.IsRight == false)
                {
                    System.Console.WriteLine(result.Parameter.Name);
                    good = false;
                }
            }
            return good;
        }
    }
}
