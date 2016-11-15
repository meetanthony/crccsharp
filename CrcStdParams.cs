using System.Collections.Generic;

namespace CRC
{
    public enum CrcAlgorithms
    {
        Undefined,
        Crc8,
        Crc8Cdma2000,
        Crc8Darc,
        Crc8DvbS2,
        Crc8Ebu,
        Crc8ICode,
        Crc8Itu,
        Crc8Maxim,
        Crc8Rohc,
        Crc8Wcdma,
        Crc16CcittFalse,
        Crc16Arc,
        Crc16AugCcitt,
        Crc16Buypass,
        Crc16Cdma2000,
        Crc16Dds110,
        Crc16DectR,
        Crc16DectX,
        Crc16Dnp,
        Crc16En13757,
        Crc16Genibus,
        Crc16Maxim,
        Crc16Mcrf4Xx,
        Crc16Riello,
        Crc16T10Dif,
        Crc16Teledisk,
        Crc16Tms37157,
        Crc16Usb,
        CrcA,
        Crc16Kermit,
        Crc16Modbus,
        Crc16X25,
        Crc16Xmodem,
        Crc32,
        Crc32Bzip2,
        Crc32C,
        Crc32D,
        Crc32Jamcrc,
        Crc32Mpeg2,
        Crc32Posix,
        Crc32Q,
        Crc32Xfer,
        Crc40Gsm,
        Crc64,
        Crc64We,
        Crc64Xz,
        Crc24,
        Crc24FlexrayA,
        Crc24FlexrayB,
        Crc31Philips,
        Crc10,
        Crc10Cdma2000,
        Crc11,
        Crc123Gpp,
        Crc12Cdma2000,
        Crc12Dect,
        Crc13Bbc,
        Crc14Darc,
        Crc15,
        Crc15Mpt1327
    }

    public static class CrcStdParams
    {
        public static readonly Dictionary<CrcAlgorithms, Parameters> StandartParameters = new Dictionary
            <CrcAlgorithms, Parameters>()
        {
            //CRC-8
            {CrcAlgorithms.Crc8           , new Parameters("CRC-8", 8, 0x7, 0x0, false, false, 0x0, 0xF4)},
            {CrcAlgorithms.Crc8Cdma2000   , new Parameters("CRC-8/CDMA2000", 8, 0x9B, 0xFF, false, false, 0x0, 0xDA)},
            {CrcAlgorithms.Crc8Darc       , new Parameters("CRC-8/DARC", 8, 0x39, 0x0, true, true, 0x0, 0x15)},
            {CrcAlgorithms.Crc8DvbS2      , new Parameters("CRC-8/DVB-S2", 8, 0xD5, 0x0, false, false, 0x0, 0xBC)},
            {CrcAlgorithms.Crc8Ebu        , new Parameters("CRC-8/EBU", 8, 0x1D, 0xFF, true, true, 0x0, 0x97)},
            {CrcAlgorithms.Crc8ICode      , new Parameters("CRC-8/I-CODE", 8, 0x1D, 0xFD, false, false, 0x0, 0x7E)},
            {CrcAlgorithms.Crc8Itu        , new Parameters("CRC-8/ITU", 8, 0x7, 0x0, false, false, 0x55, 0xA1)},
            {CrcAlgorithms.Crc8Maxim      , new Parameters("CRC-8/MAXIM", 8, 0x31, 0x0, true, true, 0x0, 0xA1)},
            {CrcAlgorithms.Crc8Rohc       , new Parameters("CRC-8/ROHC", 8, 0x7, 0xFF, true, true, 0x0, 0xD0)},
            {CrcAlgorithms.Crc8Wcdma      , new Parameters("CRC-8/WCDMA", 8, 0x9B, 0x0, true, true, 0x0, 0x25)},

            //CRC-10
            {CrcAlgorithms.Crc10          , new Parameters("CRC-10", 10, 0x233, 0x0, false, false, 0x0, 0x199)},
            {CrcAlgorithms.Crc10Cdma2000  , new Parameters("CRC-10/CDMA2000", 10, 0x3D9, 0x3FF, false, false, 0x0, 0x233)},

            //CRC-11
            {CrcAlgorithms.Crc11          , new Parameters("CRC-11", 11, 0x385, 0x1A, false, false, 0x0, 0x5A3)},

            //CRC-12
            {CrcAlgorithms.Crc123Gpp      , new Parameters("CRC-12/3GPP", 12, 0x80F, 0x0, false, true, 0x0, 0xDAF)},
            {CrcAlgorithms.Crc12Cdma2000  , new Parameters("CRC-12/CDMA2000", 12, 0xF13, 0xFFF, false, false, 0x0, 0xD4D)},
            {CrcAlgorithms.Crc12Dect      , new Parameters("CRC-12/DECT", 12, 0x80F, 0x0, false, false, 0x0, 0xF5B)},

            //CRC-13
            {CrcAlgorithms.Crc13Bbc       , new Parameters("CRC-13/BBC", 13, 0x1CF5, 0x0, false, false, 0x0, 0x4FA)},

            //CRC-14
            {CrcAlgorithms.Crc14Darc      , new Parameters("CRC-14/DARC", 14, 0x805, 0x0, true, true, 0x0, 0x82D)},

            //CRC-15
            {CrcAlgorithms.Crc15          , new Parameters("CRC-15", 15, 0x4599, 0x0, false, false, 0x0, 0x59E)},
            {CrcAlgorithms.Crc15Mpt1327   , new Parameters("CRC-15/MPT1327", 15, 0x6815, 0x0, false, false, 0x1, 0x2566)},

            //CRC-16
            {CrcAlgorithms.Crc16CcittFalse, new Parameters("CRC-16/CCITT-FALSE", 16, 0x1021, 0xFFFF, false, false, 0x0, 0x29B1)},
            {CrcAlgorithms.Crc16Arc       , new Parameters("CRC-16/ARC", 16, 0x8005, 0x0, true, true, 0x0, 0xBB3D)},
            {CrcAlgorithms.Crc16AugCcitt  , new Parameters("CRC-16/AUG-CCITT", 16, 0x1021, 0x1D0F, false, false, 0x0, 0xE5CC)},
            {CrcAlgorithms.Crc16Buypass   , new Parameters("CRC-16/BUYPASS", 16, 0x8005, 0x0, false, false, 0x0, 0xFEE8)},
            {CrcAlgorithms.Crc16Cdma2000  , new Parameters("CRC-16/CDMA2000", 16, 0xC867, 0xFFFF, false, false, 0x0, 0x4C06)},
            {CrcAlgorithms.Crc16Dds110    , new Parameters("CRC-16/DDS-110", 16, 0x8005, 0x800D, false, false, 0x0, 0x9ECF)},
            {CrcAlgorithms.Crc16DectR     , new Parameters("CRC-16/DECT-R", 16, 0x589, 0x0, false, false, 0x1, 0x7E)},
            {CrcAlgorithms.Crc16DectX     , new Parameters("CRC-16/DECT-X", 16, 0x589, 0x0, false, false, 0x0, 0x7F)},
            {CrcAlgorithms.Crc16Dnp       , new Parameters("CRC-16/DNP", 16, 0x3D65, 0x0, true, true, 0xFFFF, 0xEA82)},
            {CrcAlgorithms.Crc16En13757   , new Parameters("CRC-16/EN-13757", 16, 0x3D65, 0x0, false, false, 0xFFFF, 0xC2B7)},
            {CrcAlgorithms.Crc16Genibus   , new Parameters("CRC-16/GENIBUS", 16, 0x1021, 0xFFFF, false, false, 0xFFFF, 0xD64E)},
            {CrcAlgorithms.Crc16Maxim     , new Parameters("CRC-16/MAXIM", 16, 0x8005, 0x0, true, true, 0xFFFF, 0x44C2)},
            {CrcAlgorithms.Crc16Mcrf4Xx   , new Parameters("CRC-16/MCRF4XX", 16, 0x1021, 0xFFFF, true, true, 0x0, 0x6F91)},
            {CrcAlgorithms.Crc16Riello    , new Parameters("CRC-16/RIELLO", 16, 0x1021, 0xB2AA, true, true, 0x0, 0x63D0)},
            {CrcAlgorithms.Crc16T10Dif    , new Parameters("CRC-16/T10-DIF", 16, 0x8BB7, 0x0, false, false, 0x0, 0xD0DB)},
            {CrcAlgorithms.Crc16Teledisk  , new Parameters("CRC-16/TELEDISK", 16, 0xA097, 0x0, false, false, 0x0, 0xFB3)},
            {CrcAlgorithms.Crc16Tms37157  , new Parameters("CRC-16/TMS37157", 16, 0x1021, 0x89EC, true, true, 0x0, 0x26B1)},
            {CrcAlgorithms.Crc16Usb       , new Parameters("CRC-16/USB", 16, 0x8005, 0xFFFF, true, true, 0xFFFF, 0xB4C8)},
            {CrcAlgorithms.CrcA           , new Parameters("CRC-A", 16, 0x1021, 0xC6C6, true, true, 0x0, 0xBF05)},
            {CrcAlgorithms.Crc16Kermit    , new Parameters("CRC-16/KERMIT", 16, 0x1021, 0x0, true, true, 0x0, 0x2189)},
            {CrcAlgorithms.Crc16Modbus    , new Parameters("CRC-16/MODBUS", 16, 0x8005, 0xFFFF, true, true, 0x0, 0x4B37)},
            {CrcAlgorithms.Crc16X25       , new Parameters("CRC-16/X-25", 16, 0x1021, 0xFFFF, true, true, 0xFFFF, 0x906E)},
            {CrcAlgorithms.Crc16Xmodem    , new Parameters("CRC-16/XMODEM", 16, 0x1021, 0x0, false, false, 0x0, 0x31C3)},

            //CRC-24
            {CrcAlgorithms.Crc24          , new Parameters("CRC-24", 24, 0x864CFB, 0xB704CE, false, false, 0x0, 0x21CF02)},
            {CrcAlgorithms.Crc24FlexrayA  , new Parameters("CRC-24/FLEXRAY-A", 24, 0x5D6DCB, 0xFEDCBA, false, false, 0x0, 0x7979BD)},
            {CrcAlgorithms.Crc24FlexrayB  , new Parameters("CRC-24/FLEXRAY-B", 24, 0x5D6DCB, 0xABCDEF, false, false, 0x0, 0x1F23B8)},

            //CRC-31
            {CrcAlgorithms.Crc31Philips   , new Parameters("CRC-31/PHILIPS", 31, 0x4C11DB7, 0x7FFFFFFF, false, false, 0x7FFFFFFF, 0xCE9E46C)},

            //CRC-32
            {CrcAlgorithms.Crc32          , new Parameters("CRC-32", 32, 0x04C11DB7, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xCBF43926)},
            {CrcAlgorithms.Crc32Bzip2     , new Parameters("CRC-32/BZIP2", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0xFFFFFFFF, 0xFC891918)},
            {CrcAlgorithms.Crc32C         , new Parameters("CRC-32C", 32, 0x1EDC6F41, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0xE3069283)},
            {CrcAlgorithms.Crc32D         , new Parameters("CRC-32D", 32, 0xA833982B, 0xFFFFFFFF, true, true, 0xFFFFFFFF, 0x87315576)},
            {CrcAlgorithms.Crc32Jamcrc    , new Parameters("CRC-32/JAMCRC", 32, 0x04C11DB7, 0xFFFFFFFF, true, true, 0x00000000, 0x340BC6D9)},
            {CrcAlgorithms.Crc32Mpeg2     , new Parameters("CRC-32/MPEG-2", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0x00000000, 0x0376E6E7)},
            {CrcAlgorithms.Crc32Posix     , new Parameters("CRC-32/POSIX", 32, 0x04C11DB7, 0x00000000, false, false, 0xFFFFFFFF, 0x765E7680)},
            {CrcAlgorithms.Crc32Q         , new Parameters("CRC-32Q", 32, 0x814141AB, 0x00000000, false, false, 0x00000000, 0x3010BF7F)},
            {CrcAlgorithms.Crc32Xfer      , new Parameters("CRC-32/XFER", 32, 0x000000AF, 0x00000000, false, false, 0x00000000, 0xBD0BE338)},

            //CRC-40
            {CrcAlgorithms.Crc40Gsm       , new Parameters("CRC-40/GSM", 40, 0x4820009, 0x0, false, false, 0xFFFFFFFFFF, 0xD4164FC646)},

            //CRC-64
            {CrcAlgorithms.Crc64          , new Parameters("CRC-64",64, 0x42F0E1EBA9EA3693, 0x00000000, false, false, 0x00000000, 0x6C40DF5F0B497347)},
            {CrcAlgorithms.Crc64We        , new Parameters("CRC-64/WE", 64, 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, false, false, 0xFFFFFFFFFFFFFFFF,0x62EC59E3F1A4F00A)},
            {CrcAlgorithms.Crc64Xz        , new Parameters("CRC-64/XZ", 64, 0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, true, true, 0xFFFFFFFFFFFFFFFF,0x995DC9BBDF1939FA)}
        };
    }
}