using System;
using System.Security.Cryptography;

namespace CrcLib;

public class Crc : HashAlgorithm
{
    #region private fields

    private readonly ulong _mask;

    private readonly ulong[] _table = new ulong[256];

    private ulong _currentValue;

    #endregion private fields

    #region ctors

    public Crc(Parameters parameters)
    {
        Parameters = parameters;

        _mask = ulong.MaxValue >> (64 - parameters.HashSize);

        Init();
    }

    #endregion ctors

    #region public props

    public override int HashSize => Parameters.HashSize;

    public Parameters Parameters { get; }

    #endregion public props

    #region public methods

    public UInt64 ComputeHashUInt64(byte[] buffer, int offset = 0, int count = -1)
    {
        if (count == -1)
            count = buffer.Length - offset;
        var hashBytes = ComputeHash(buffer, offset, count);
        var hash = BitConverter.ToUInt64(hashBytes, 0);
        return hash;
    }

    public UInt64[] GetTable()
    {
        var res = new UInt64[_table.Length];
        Array.Copy(_table, res, _table.Length);
        return res;
    }

    public override void Initialize()
    {
        _currentValue = Parameters.RefIn ? Helper.ReverseBits(Parameters.Init, HashSize) : Parameters.Init;
    }

    #endregion public methods

    #region protected methods

    protected override void HashCore(byte[] array, int ibStart, int cbSize)
    {
        _currentValue = ComputeCrc(_currentValue, array, ibStart, cbSize);
    }

    protected override byte[] HashFinal()
    {
        if (Parameters.RefIn ^ Parameters.RefOut)
            _currentValue = Helper.ReverseBits(_currentValue, HashSize);

        var xoredResult = _currentValue ^ Parameters.XorOut;

        return BitConverter.GetBytes(xoredResult);
    }

    #endregion protected methods

    #region private methods

    private void Init()
    {
        CreateTable();
        Initialize();
    }

    #region Main functions

    private ulong ComputeCrc(ulong init, byte[] data, int offset, int length)
    {
        ulong crc = init;

        if (Parameters.RefIn)
        {
            for (int i = offset; i < offset + length; i++)
            {
                crc = _table[(crc ^ data[i]) & 0xFF] ^ (crc >> 8);
                crc &= _mask;
            }
        }
        else
        {
            int toRight = HashSize - 8;
            toRight = toRight < 0 ? 0 : toRight;
            for (int i = offset; i < offset + length; i++)
            {
                crc = _table[((crc >> toRight) ^ data[i]) & 0xFF] ^ (crc << 8);
                crc &= _mask;
            }
        }

        return crc;
    }

    private void CreateTable()
    {
        for (int i = 0; i < _table.Length; i++)
            _table[i] = CreateTableEntry(i);
    }

    private ulong CreateTableEntry(int index)
    {
        ulong r = (ulong)index;

        if (Parameters.RefIn)
            r = Helper.ReverseBits(r, HashSize);
        else if (HashSize > 8)
            r <<= (HashSize - 8);

        ulong lastBit = 1ul << (HashSize - 1);

        for (int i = 0; i < 8; i++)
        {
            if ((r & lastBit) != 0)
                r = (r << 1) ^ Parameters.Poly;
            else
                r <<= 1;
        }

        if (Parameters.RefIn)
            r = Helper.ReverseBits(r, HashSize);

        return r & _mask;
    }

    #endregion Main functions

    #endregion private methods
}