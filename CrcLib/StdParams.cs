using System.Collections.Generic;

namespace CrcLib;

public static class StdParams
{
    public static readonly Dictionary<Algorithms, Parameters> StandartParameters = new()
    {
        #region CRC-8

        {Algorithms.Crc8           , new Parameters("CRC-8", 8, 0x7, 0x0, false, false, 0x0, 0xF4)},
        {Algorithms.Crc8Cdma2000   , new Parameters("CRC-8/CDMA2000", 8, 0x9B, 0xFF, false, false, 0x0, 0xDA)},
        {Algorithms.Crc8Darc       , new Parameters("CRC-8/DARC", 8, 0x39, 0x0, true, true, 0x0, 0x15)},
        {Algorithms.Crc8DvbS2      , new Parameters("CRC-8/DVB-S2", 8, 0xD5, 0x0, false, false, 0x0, 0xBC)},
        {Algorithms.Crc8Ebu        , new Parameters("CRC-8/EBU", 8, 0x1D, 0xFF, true, true, 0x0, 0x97)},
        {Algorithms.Crc8ICode      , new Parameters("CRC-8/I-CODE", 8, 0x1D, 0xFD, false, false, 0x0, 0x7E)},
        {Algorithms.Crc8Itu        , new Parameters("CRC-8/ITU", 8, 0x7, 0x0, false, false, 0x55, 0xA1)},
        {Algorithms.Crc8Maxim      , new Parameters("CRC-8/MAXIM", 8, 0x31, 0x0, true, true, 0x0, 0xA1)},
        {Algorithms.Crc8Rohc       , new Parameters("CRC-8/ROHC", 8, 0x7, 0xFF, true, true, 0x0, 0xD0)},
        {Algorithms.Crc8Wcdma      , new Parameters("CRC-8/WCDMA", 8, 0x9B, 0x0, true, true, 0x0, 0x25)},

        #endregion CRC-8

        #region CRC-10

        {Algorithms.Crc10          , new Parameters("CRC-10", 10, 0x233, 0x0, false, false, 0x0, 0x199)},
        {Algorithms.Crc10Cdma2000  , new Parameters("CRC-10/CDMA2000", 10, 0x3D9, 0x3FF, false, false, 0x0, 0x233)},

        #endregion CRC-10

        #region CRC-11

        {Algorithms.Crc11          , new Parameters("CRC-11", 11, 0x385, 0x1A, false, false, 0x0, 0x5A3)},

        #endregion CRC-11

        #region CRC-12

        {Algorithms.Crc123Gpp      , new Parameters("CRC-12/3GPP", 12, 0x80F, 0x0, false, true, 0x0, 0xDAF)},
        {Algorithms.Crc12Cdma2000  , new Parameters("CRC-12/CDMA2000", 12, 0xF13, 0xFFF, false, false, 0x0, 0xD4D)},
        {Algorithms.Crc12Dect      , new Parameters("CRC-12/DECT", 12, 0x80F, 0x0, false, false, 0x0, 0xF5B)},

        #endregion CRC-12

        #region CRC-13

        {Algorithms.Crc13Bbc       , new Parameters("CRC-13/BBC", 13, 0x1CF5, 0x0, false, false, 0x0, 0x4FA)},

        #endregion CRC-13

        #region CRC-14

        {Algorithms.Crc14Darc      , new Parameters("CRC-14/DARC", 14, 0x805, 0x0, true, true, 0x0, 0x82D)},

        #endregion CRC-14

        #region CRC-15

        {Algorithms.Crc15          , new Parameters("CRC-15", 15, 0x4599, 0x0, false, false, 0x0, 0x59E)},
        {Algorithms.Crc15Mpt1327   , new Parameters("CRC-15/MPT1327", 15, 0x6815, 0x0, false, false, 0x1, 0x2566)},

        #endregion CRC-15

        #region CRC-16

        {Algorithms.Crc16CcittFalse, new Parameters("CRC-16/CCITT-FALSE", 16, 0x1021, 0xFFFF, false, false, 0x0, 0x29B1)},
        {Algorithms.Crc16Arc       , new Parameters("CRC-16/ARC", 16, 0x8005, 0x0, true, true, 0x0, 0xBB3D)},
        {Algorithms.Crc16AugCcitt  , new Parameters("CRC-16/AUG-CCITT", 16, 0x1021, 0x1D0F, false, false, 0x0, 0xE5CC)},
        {Algorithms.Crc16Buypass   , new Parameters("CRC-16/BUYPASS", 16, 0x8005, 0x0, false, false, 0x0, 0xFEE8)},
        {Algorithms.Crc16Cdma2000  , new Parameters("CRC-16/CDMA2000", 16, 0xC867, 0xFFFF, false, false, 0x0, 0x4C06)},
        {Algorithms.Crc16Dds110    , new Parameters("CRC-16/DDS-110", 16, 0x8005, 0x800D, false, false, 0x0, 0x9ECF)},
        {Algorithms.Crc16DectR     , new Parameters("CRC-16/DECT-R", 16, 0x589, 0x0, false, false, 0x1, 0x7E)},
        {Algorithms.Crc16DectX     , new Parameters("CRC-16/DECT-X", 16, 0x589, 0x0, false, false, 0x0, 0x7F)},
        {Algorithms.Crc16Dnp       , new Parameters("CRC-16/DNP", 16, 0x3D65, 0x0, true, true, 0xFFFF, 0xEA82)},
        {Algorithms.Crc16En13757   , new Parameters("CRC-16/EN-13757", 16, 0x3D65, 0x0, false, false, 0xFFFF, 0xC2B7)},
        {Algorithms.Crc16Genibus   , new Parameters("CRC-16/GENIBUS", 16, 0x1021, 0xFFFF, false, false, 0xFFFF, 0xD64E)},
        {Algorithms.Crc16Maxim     , new Parameters("CRC-16/MAXIM", 16, 0x8005, 0x0, true, true, 0xFFFF, 0x44C2)},
        {Algorithms.Crc16Mcrf4Xx   , new Parameters("CRC-16/MCRF4XX", 16, 0x1021, 0xFFFF, true, true, 0x0, 0x6F91)},
        {Algorithms.Crc16Riello    , new Parameters("CRC-16/RIELLO", 16, 0x1021, 0xB2AA, true, true, 0x0, 0x63D0)},
        {Algorithms.Crc16T10Dif    , new Parameters("CRC-16/T10-DIF", 16, 0x8BB7, 0x0, false, false, 0x0, 0xD0DB)},
        {Algorithms.Crc16Teledisk  , new Parameters("CRC-16/TELEDISK", 16, 0xA097, 0x0, false, false, 0x0, 0xFB3)},
        {Algorithms.Crc16Tms37157  , new Parameters("CRC-16/TMS37157", 16, 0x1021, 0x89EC, true, true, 0x0, 0x26B1)},
        {Algorithms.Crc16Usb       , new Parameters("CRC-16/USB", 16, 0x8005, 0xFFFF, true, true, 0xFFFF, 0xB4C8)},
        {Algorithms.CrcA           , new Parameters("CRC-A", 16, 0x1021, 0xC6C6, true, true, 0x0, 0xBF05)},
        {Algorithms.Crc16Kermit    , new Parameters("CRC-16/KERMIT", 16, 0x1021, 0x0, true, true, 0x0, 0x2189)},
        {Algorithms.Crc16Modbus    , new Parameters("CRC-16/MODBUS", 16, 0x8005, 0xFFFF, true, true, 0x0, 0x4B37)},
        {Algorithms.Crc16X25       , new Parameters("CRC-16/X-25", 16, 0x1021, 0xFFFF, true, true, 0xFFFF, 0x906E)},
        {Algorithms.Crc16Xmodem    , new Parameters("CRC-16/XMODEM", 16, 0x1021, 0x0, false, false, 0x0, 0x31C3)},

        #endregion CRC-16

        #region CRC-24

        {Algorithms.Crc24          , new Parameters("CRC-24", 24, 0x864CFB, 0xB704CE, false, false, 0x0, 0x21CF02)},
        {Algorithms.Crc24FlexrayA  , new Parameters("CRC-24/FLEXRAY-A", 24, 0x5D6DCB, 0xFEDCBA, false, false, 0x0, 0x7979BD)},
        {Algorithms.Crc24FlexrayB  , new Parameters("CRC-24/FLEXRAY-B", 24, 0x5D6DCB, 0xABCDEF, false, false, 0x0, 0x1F23B8)},

        #endregion CRC-24

        #region CRC-31

        {Algorithms.Crc31Philips   , new Parameters("CRC-31/PHILIPS", 31, 0x4C11DB7, 0x7FFFFFFF, false, false, 0x7FFFFFFF, 0xCE9E46C)},

        #endregion CRC-31

        #region CRC-32

        {Algorithms.Crc32          , new Parameters("CRC-32", 32, 0x04C11DB7, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xCBF43926)},
        {Algorithms.Crc32Bzip2     , new Parameters("CRC-32/BZIP2", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0xFFFFFFFF, 0xFC891918)},
        {Algorithms.Crc32C         , new Parameters("CRC-32C", 32, 0x1EDC6F41, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xE3069283)},
        {Algorithms.Crc32D         , new Parameters("CRC-32D", 32, 0xA833982B, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0x87315576)},
        {Algorithms.Crc32Jamcrc    , new Parameters("CRC-32/JAMCRC", 32, 0x04C11DB7, 0xFFFFFFFF, true, true, 0x00000000, 0x340BC6D9)},
        {Algorithms.Crc32Mpeg2     , new Parameters("CRC-32/MPEG-2", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0x00000000, 0x0376E6E7)},
        {Algorithms.Crc32Posix     , new Parameters("CRC-32/POSIX", 32, 0x04C11DB7, 0x00000000, false, false, 0xFFFFFFFF, 0x765E7680)},
        {Algorithms.Crc32Q         , new Parameters("CRC-32Q", 32, 0x814141AB, 0x00000000, false, false, 0x00000000, 0x3010BF7F)},
        {Algorithms.Crc32Xfer      , new Parameters("CRC-32/XFER", 32, 0x000000AF, 0x00000000, false, false, 0x00000000, 0xBD0BE338)},

        #endregion CRC-32

        #region CRC-40

        {Algorithms.Crc40Gsm       , new Parameters("CRC-40/GSM", 40, 0x4820009, 0x0, false, false, 0xFFFFFFFFFF, 0xD4164FC646)},

        #endregion CRC-40

        #region CRC-64

        {Algorithms.Crc64          , new Parameters("CRC-64",64, 0x42F0E1EBA9EA3693, 0x00000000, false, false, 0x00000000, 0x6C40DF5F0B497347)},
        {Algorithms.Crc64We        , new Parameters("CRC-64/WE", 64, 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, false, false, 0xFFFFFFFFFFFFFFFF,0x62EC59E3F1A4F00A)},
        {Algorithms.Crc64Xz        , new Parameters("CRC-64/XZ", 64, 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, true, true, 0xFFFFFFFFFFFFFFFF,0x995DC9BBDF1939FA)}

        #endregion CRC-64
    };
}