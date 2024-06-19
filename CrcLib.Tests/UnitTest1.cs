using System;
using System.Collections.Generic;
using System.Text;

namespace CrcLib.Tests;

public class UnitTest1
{
    private static bool IsRight(Crc crc)
    {
        byte[] bytes = Encoding.ASCII.GetBytes("123456789");

        var hash = crc.ComputeHashUInt64(bytes, 0, bytes.Length);
        
        return hash == crc.Parameters.Check;
    }

    public static IEnumerable<object[]> EnumAlgorithms()
    {
        foreach (var number in Enum.GetValues(typeof(Algorithms)))
        {
            yield return new [] { number };
        }
    }

    [Theory]
    [MemberData(nameof(EnumAlgorithms))]
    public void CheckAll(Algorithms algorithm)
    {
        var parameters = StdParams.StandartParameters[algorithm];

        Crc crc = new Crc(parameters);

        Assert.True(IsRight(crc));
    }
}