using System;
namespace Zebra
{
    public enum Led
    {
        RedOn = 47,
        RedOff = 48,
        GreenOn = 43,
        GreenOff = 42,
        YellowOn = 45,
        YellowOff = 46
    }

    //TODO: Figure out how to add these methods to the binding project
    //  Right now they have to be added to the consuming project.
    /*
    public enum Symbology
    {
        UPC_A = 1,
        UPC_E = 2,
        UPC_E1 = 12,
        EAN_8_JAN_8 = 4,
        EAN_13_JAN_13 = 3,
        BOOKLAND_EAN = 83,
        CODE_128 = 8,
        UCC_EAN_128 = 14,
        CODE_39 = 0,
        CODE_93 = 9,
        CODE_11 = 10,
        INTERLEAVED_2_OF_5 = 6,
        DISCRETE_2_OF_5 = 5,
        CHINESE_2_OF_5 = 408,
        CODABAR = 7,
        MSI = 11,
        DATAMATRIXQR = 292,
        PDF = 15,
        ISBT_128 = 84
    }

    public static class ScannerExtensions
    {
        public static bool SetSymbologies(this ISbtSdkApi sdk, int scannerId, params Symbology[] symbologies)
        {
            bool isSuccess = true;

            const string template = "<inArgs><scannerID>{0}</scannerID><cmdArgs><arg-xml><attrib_list><attribute><id>{1}</id><datatype>F</datatype><value>{2}</value></attribute></attrib_list></arg-xml></cmdArgs></inArgs>";

            foreach (int sym in Enum.GetValues(typeof(Symbology)))
            {
                var command = string.Format(template, scannerId, sym, "False");
                var result = sdk.ExecuteCommand(OperationCode.RsmAttrSet, command, out _, scannerId);
            }

            foreach (int sym in symbologies)
            {
                var command = string.Format(template, scannerId, sym, "True");
                var result = sdk.ExecuteCommand(OperationCode.RsmAttrSet, command, out _, scannerId);
                isSuccess &= result == SbtResult.Success;
            }

            return isSuccess;
        }

        public static SbtResult SetLed(this ISbtSdkApi sdk, Led led, int scannerId)
        {
            int ledInt = (int)led;

            const string template = "<inArgs><scannerID>{0}</scannerID><cmdArgs><arg-int>{1}</arg-int></cmdArgs></inArgs>";

            var command = string.Format(template, scannerId, ledInt);

            return sdk.ExecuteCommand(OperationCode.SetAction, command, out _, scannerId);
        }

        public static (SbtResult, ScannerInfo[]) GetActiveScanners(this ISbtSdkApi sdk)
            => getScanners((ptr) => (sdk.GetActiveScannersList(ref ptr), ptr));

        public static (SbtResult, ScannerInfo[]) GetAvailableScanners(this ISbtSdkApi sdk)
            => getScanners((ptr) => (sdk.GetAvailableScannersList(ref ptr), ptr));

        private static (SbtResult, ScannerInfo[]) getScanners(Func<IntPtr, (SbtResult, IntPtr)> action)
        {
            var availableReaders = new NSMutableArray();
            var availableHandle = availableReaders.Handle;

            (SbtResult result, IntPtr handle) = action(availableHandle);

            var scanners = NSArray.ArrayFromHandle<ScannerInfo>(handle);

            return (result, scanners);
        }
    }
    */
}