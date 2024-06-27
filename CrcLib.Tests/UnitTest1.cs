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
        foreach (var algorithm in Enum.GetValues(typeof(Algorithms)))
        {
            yield return new [] { algorithm };
        }
    }

    [Theory]
    [MemberData(nameof(EnumAlgorithms))]
    public void CheckAlgorithm(Algorithms algorithm)
    {
        var parameters = StdParams.StandartParameters[algorithm];

        Crc crc = new Crc(parameters);

        Assert.True(IsRight(crc));
    }
}