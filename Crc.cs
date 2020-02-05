using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CRC
{
    public class Crc : HashAlgorithm
    {
        private readonly ulong _mask;

        private readonly ulong[] _table = new ulong[256];

        private ulong _currentValue;

        public Crc(Parameters parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException("parameters");

            Parameters = parameters;

            _mask = ulong.MaxValue >> (64 - HashSize);

            Init();
        }

        public override bool CanTransformMultipleBlocks
        {
            get
            {
                return base.CanTransformMultipleBlocks;
            }
        }

        public override int HashSize { get { return Parameters.HashSize; } }

        public Parameters Parameters { get; private set; }

        public UInt64[] GetTable()
        {
            var res = new UInt64[_table.Length];
            Array.Copy(_table, res, _table.Length);
            return res;
        }

        public override void Initialize()
        {
            _currentValue = Parameters.RefOut ? CrcHelper.ReverseBits(Parameters.Init, HashSize) : Parameters.Init;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _currentValue = ComputeCrc(_currentValue, array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(_currentValue ^ Parameters.XorOut);
        }

        private void Init()
        {
            CreateTable();
            Initialize();
        }

        #region Main functions

        private ulong ComputeCrc(ulong init, byte[] data, int offset, int length)
        {
            ulong crc = init;

            if (Parameters.RefOut)
            {
                for (int i = offset; i < offset + length; i++)
                {
                    crc = (_table[(crc ^ data[i]) & 0xFF] ^ (crc >> 8));
                    crc &= _mask;
                }
            }
            else
            {
                int toRight = (HashSize - 8);
                toRight = toRight < 0 ? 0 : toRight;
                for (int i = offset; i < offset + length; i++)
                {
                    crc = (_table[((crc >> toRight) ^ data[i]) & 0xFF] ^ (crc << 8));
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
                r = CrcHelper.ReverseBits(r, HashSize);
            else if (HashSize > 8)
                r <<= (HashSize - 8);

            ulong lastBit = (1ul << (HashSize - 1));

            for (int i = 0; i < 8; i++)
            {
                if ((r & lastBit) != 0)
                    r = ((r << 1) ^ Parameters.Poly);
                else
                    r <<= 1;
            }

            if (Parameters.RefIn)
                r = CrcHelper.ReverseBits(r, HashSize);

            return r & _mask;
        }

        #endregion Main functions

        #region Test functions

        /// <summary>
        /// Проверить алгоритмы на корректность
        /// </summary>
        public static CheckResult[] CheckAll()
        {
            var parameters = CrcStdParams.StandartParameters;

            var result = new List<CheckResult>();
            foreach (var parameter in parameters)
            {
                Crc crc = new Crc(parameter.Value);

                result.Add(new CheckResult()
                {
                    Parameter = parameter.Value,
                    Table = crc.GetTable()
                });
            }

            return result.ToArray();
        }

        public bool IsRight()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("123456789");

            var hashBytes = ComputeHash(bytes, 0, bytes.Length);

            var hash = BitConverter.ToUInt64(hashBytes, 0);

            return hash == Parameters.Check;
        }

        public class CheckResult
        {
            public Parameters Parameter { get; set; }

            public ulong[] Table { get; set; }
        }

        #endregion Test functions
    }
}