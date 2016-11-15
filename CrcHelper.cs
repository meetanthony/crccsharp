using System;

namespace CRC
{
    public static class CrcHelper
    {
        #region internal

        #region reverseBits

        /*internal static byte ReverseBits(byte b)
        {
            byte newValue = 0;

            for (int i = 7; i >= 0; i--)
            {
                newValue |= (byte)((b & 1) << i);
                b >>= 1;
            }
            return newValue;
        }

        internal static ushort ReverseBits(ushort us)
        {
            ushort newValue = 0;

            for (int i = 15; i >= 0; i--)
            {
                newValue |= (ushort)((us & 1) << i);
                us >>= 1;
            }
            return newValue;
        }

        internal static uint ReverseBits(uint ui)
        {
            uint newValue = 0;

            for (int i = 31; i >= 0; i--)
            {
                newValue |= (ui & 1) << i;
                ui >>= 1;
            }
            return newValue;
        }*/

        internal static ulong ReverseBits(ulong ul, int valueLength)
        {
            ulong newValue = 0;

            for (int i = valueLength - 1; i >= 0; i--)
            {
                newValue |= (ul & 1) << i;
                ul >>= 1;
            }

            return newValue;
        }

        #endregion reverseBits

        #region ToBigEndian

        internal static byte[] ToBigEndianBytes(UInt32 value)
        {
            var result = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(result);

            return result;
        }

        internal static byte[] ToBigEndianBytes(UInt16 value)
        {
            var result = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(result);

            return result;
        }

        internal static byte[] ToBigEndianBytes(UInt64 value)
        {
            var result = BitConverter.GetBytes(value);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(result);

            return result;
        }

        #endregion ToBigEndian

        #region FromBigEndian

        internal static UInt16 FromBigToUInt16(byte[] buffer, int start)
        {
            return (ushort)(buffer[start] << 8 | buffer[start + 1]);
        }

        internal static UInt32 FromBigToUInt32(byte[] buffer, int start)
        {
            return (uint)(buffer[start] << 24 | buffer[start + 1] << 16 | buffer[start + 2] << 8 | buffer[start + 3]);
        }

        internal static UInt64 FromBigToUInt64(byte[] buffer, int start)
        {
            ulong result = 0;
            for (int i = 0; i < 8; i++)
            {
                result |= ((ulong)buffer[i]) << (64 - 8 * (i + 1));
            }

            return result;
        }

        #endregion FromBigEndian

        #endregion internal

        #region public

        /// <summary>
        /// Use this method for convert hash from byte array to UInt16 value.
        /// </summary>
        public static ushort ToUInt16(byte[] hash)
        {
            return FromBigToUInt16(hash, 0);
        }

        /// <summary>
        /// Use this method for convert hash from byte array to UInt32 value.
        /// </summary>
        public static uint ToUInt32(byte[] hash)
        {
            return FromBigToUInt32(hash, 0);
        }

        #endregion public

        public static ulong FromBigEndian(byte[] hashBytes, int hashSize)
        {
            ulong result = 0;
            for (int i = 0; i < 8; i++)
            {
                result |= ((ulong)hashBytes[i]) << (64 - 8 * (i + 1));
            }

            return result;
        }
    }
}