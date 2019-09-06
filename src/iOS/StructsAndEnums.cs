using System;namespace Zebra{    public enum SbtResult : uint    {        Success = 0,        Failure = 1,        ScannerNotAvailable = 2,        ScannerNotActive = 3,        InvalidParams = 4,        ResponseTimeout = 5,        OpcodeNotSupported = 6,        ScannerNoSupport = 7,        BtaddressNotSet = 8,        ScannerNotConnectStc = 9    }

    //[Verify(InferredFromMemberPrefix)]
    public enum OperationalMode : uint    {        Mfi = 1,        Btle = 2,        All = 3    }

    //[Verify(InferredFromMemberPrefix)]
    public enum ConnectionType : uint    {        Invalid = 0,        Mfi = 1,        Btle = 2    }

    //[Verify(InferredFromMemberPrefix)]
    [Flags]    public enum EventType : uint    {        Barcode = (1),        Image = (1 << 1),        Video = (1 << 2),        ScannerAppearance = (1 << 3),        ScannerDisappearance = (1 << 4),        SessionEstablishment = (1 << 5),        SessionTermination = (1 << 6),        RawData = (1 << 7)    }

    //[Verify(InferredFromMemberPrefix)]
    public enum DeviceModel : uint    {        Invalid = 0,        SsiRfd8500 = 1,        SsiCs4070 = 2,        SsiLi3678 = 3,        SsiDs3678 = 4,        SsiDs8178 = 5,        SsiDs2278 = 6,        SsiGeneric = 7,        RfidRfd8500 = 8    }

    //[Verify(InferredFromMemberPrefix)]
    public enum LedCode : uint    {        Red = 0,        Green = 1,        Yellow = 2,        Amber = 3,        Blue = 4    }

    //[Verify(InferredFromMemberPrefix)]
    public enum Beepcode : uint    {        ShortHigh1 = 0,        ShortHigh2 = 1,        ShortHigh3 = 2,        ShortHigh4 = 3,        ShortHigh5 = 4,        ShortLow1 = 5,        ShortLow2 = 6,        ShortLow3 = 7,        ShortLow4 = 8,        ShortLow5 = 9,        LongHigh1 = 10,        LongHigh2 = 11,        LongHigh3 = 12,        LongHigh4 = 13,        LongHigh5 = 14,        LongLow1 = 15,        LongLow2 = 16,        LongLow3 = 17,        LongLow4 = 18,        LongLow5 = 19,        FastWarble = 20,        SlowWarble = 21,        Mix1HighLow = 22,        Mix2LowHigh = 23,        Mix3HighLowHigh = 24,        Mix4LowHighLow = 25    }

    //[Verify(InferredFromMemberPrefix)]
    public enum OperationCode    {        DevicePullTrigger = 2011,        DeviceReleaseTrigger = 2012,        DeviceScanDisable = 2013,        DeviceScanEnable = 2014,        DeviceCaptureImage = 3000,        DeviceCaptureBarcode = 3500,        DeviceCaptureVideo = 4000,        RsmAttrGetall = 5000,        RsmAttrGet = 5001,        RsmAttrGetOffset = 5003,        RsmAttrSet = 5004,        RsmAttrStore = 5005,        SetAction = 6000,        StartNewFirmware = 5014,        UpdateFirmware = 5016,        UpdateFirmwareFromPlugin = 5017,        DeviceSetParameterDefaults = 2015,        DeviceSetParameters = 2016,        DeviceSetParameterPersistance = 2017,        DeviceAbortUpdateFirmware = 2001,        DeviceAbortMacropdf = 2000,        DeviceAimOff = 2002,        DeviceAimOn = 2003,        DeviceEnterLowPowerMode = 2004,        DeviceFlushMacropdf = 2005,        DeviceGetParameters = 2007,        DeviceGetScannerCapabilities = 2008,        DeviceLedOff = 2009,        DeviceLedOn = 2010,        DeviceBeepControl = 2018,        RebootScanner = 2019,        DeviceAbortImageXfer = 3001,        RsmAttrGetnext = 5002,        GetDeviceTopology = 5006,        RefreshTopology = 5007,        GetDeviceTopologyEx = 5008,        RsmGetPcktsize = 5011,        UpdateAttribMetaFile = 5015,        DeviceVibrationFeedback = 2020,        ErrorOpcode = -1    }    public enum FirmwareUpdateResult : uint    {        Success = 0,        Failure = 1    }    public enum ComProtocol : uint    {        StcSsiMfi = 0,        StcSsiBle = 1,        SbtSsiHid = 2,        NoComProtocol = 3    }    public enum DefaultStatus : uint    {        Yes = 0,        No = 1    }    public enum BarcodeType    {        CODE_128 = 0x03,        PDF417 = 0x11,        QR_CODE = 0x1c    }}