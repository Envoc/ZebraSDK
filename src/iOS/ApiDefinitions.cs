using ObjCRuntime;using CoreGraphics;using Foundation;using System;using System.Runtime.InteropServices;using UIKit;namespace Zebra{
    // @interface SbtScannerInfo : NSObject
    [Protocol]    [BaseType(typeof(NSObject))]    interface ScannerInfo    {
        // -(void)dealloc;
        [Export("dealloc")]        void Dealloc();

        // -(void)setScannerID:(int)scannerID;
        [Export("setScannerID:")]        void SetScannerID(int scannerID);

        // -(void)setConnectionType:(int)connectionType;
        [Export("setConnectionType:")]        void SetConnectionType(int connectionType);

        // -(void)setAutoCommunicationSessionReestablishment:(BOOL)enable;
        [Export("setAutoCommunicationSessionReestablishment:")]        void SetAutoCommunicationSessionReestablishment(bool enable);

        // -(void)setActive:(BOOL)active;
        [Export("setActive:")]        void SetActive(bool active);

        // -(void)setAvailable:(BOOL)available;
        [Export("setAvailable:")]        void SetAvailable(bool available);

        // -(void)setScannerName:(NSString *)scannerName;
        [Export("setScannerName:")]        void SetScannerName(string scannerName);

        // -(void)setScannerModel:(int)scannerModel;
        [Export("setScannerModel:")]        void SetScannerModel(int scannerModel);

        // -(int)getScannerID;
        [Export("getScannerID")]
        //[Verify(MethodToProperty)]
        int ScannerID { get; }

        // -(int)getConnectionType;
        [Export("getConnectionType")]
        //[Verify(MethodToProperty)]
        ConnectionType ConnectionType { get; }

        // -(BOOL)getAutoCommunicationSessionReestablishment;
        [Export("getAutoCommunicationSessionReestablishment")]
        //[Verify(MethodToProperty)]
        bool AutoCommunicationSessionReestablishment { get; }

        // -(BOOL)isActive;
        [Export("isActive")]
        //[Verify(MethodToProperty)]
        bool IsActive { get; }

        // -(BOOL)isAvailable;
        [Export("isAvailable")]
        //[Verify(MethodToProperty)]
        bool IsAvailable { get; }

        // -(NSString *)getScannerName;
        [Export("getScannerName")]
        //[Verify(MethodToProperty)]
        string ScannerName { get; }

        // -(int)getScannerModel;
        [Export("getScannerModel")]
        //[Verify(MethodToProperty)]
        DeviceModel ScannerModel { get; }

        // @property (retain, nonatomic) NSString * firmwareVersion;
        [Export("firmwareVersion", ArgumentSemantic.Retain)]        string FirmwareVersion { get; set; }

        // @property (retain, nonatomic) NSString * mFD;
        [Export("mFD", ArgumentSemantic.Retain)]        string MFD { get; set; }

        // @property (retain, nonatomic) NSString * serialNo;
        [Export("serialNo", ArgumentSemantic.Retain)]        string SerialNo { get; set; }

        // @property (retain, nonatomic) NSString * scannerModelString;
        [Export("scannerModelString", ArgumentSemantic.Retain)]        string ScannerModelString { get; set; }    }

    // @interface FirmwareUpdateEvent : NSObject
    [BaseType(typeof(NSObject))]    interface FirmwareUpdateEvent    {
        // @property (retain, nonatomic) SbtScannerInfo * scannerInfo;
        [Export("scannerInfo", ArgumentSemantic.Retain)]        ScannerInfo ScannerInfo { get; set; }

        // @property (readonly) int maxRecords;
        [Export("maxRecords")]        int MaxRecords { get; }

        // @property (readonly) int swComponent;
        [Export("swComponent")]        int SwComponent { get; }

        // @property (readonly) int currentRecord;
        [Export("currentRecord")]        int CurrentRecord { get; }

        // @property (readonly) int size;
        [Export("size")]        int Size { get; }

        // @property (readonly) SBT_FW_UPDATE_RESULT status;
        [Export("status")]        FirmwareUpdateResult Status { get; }

        // -(instancetype)initWithScannerInfo:(SbtScannerInfo *)_scannerInfo withRecords:(int)_maxRecords withSWComponenet:(int)_swComponent withCurrentRecord:(int)_currentRecord withStatus:(SBT_FW_UPDATE_RESULT)_status;
        [Export("initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:")]        IntPtr Constructor(ScannerInfo _scannerInfo, int _maxRecords, int _swComponent, int _currentRecord, FirmwareUpdateResult _status);    }

    // @protocol ISbtSdkApiDelegate <NSObject>
    [Protocol, Model]    [BaseType(typeof(NSObject))]    interface SbtSdkApiDelegate    {
        // @required -(void)sbtEventScannerAppeared:(SbtScannerInfo *)availableScanner;
        [Abstract]        [Export("sbtEventScannerAppeared:")]        void EventScannerAppeared(ScannerInfo availableScanner);

        // @required -(void)sbtEventScannerDisappeared:(int)scannerID;
        [Abstract]        [Export("sbtEventScannerDisappeared:")]        void EventScannerDisappeared(int scannerID);

        // @required -(void)sbtEventCommunicationSessionEstablished:(SbtScannerInfo *)activeScanner;
        [Abstract]        [Export("sbtEventCommunicationSessionEstablished:")]        void EventCommunicationSessionEstablished(ScannerInfo activeScanner);

        // @required -(void)sbtEventCommunicationSessionTerminated:(int)scannerID;
        [Abstract]        [Export("sbtEventCommunicationSessionTerminated:")]        void EventCommunicationSessionTerminated(int scannerID);

        // @required -(void)sbtEventBarcode:(NSString *)barcodeData barcodeType:(int)barcodeType fromScanner:(int)scannerID;
        [Abstract]        [Export("sbtEventBarcode:barcodeType:fromScanner:")]        void EventBarcode(string barcodeData, BarcodeType barcodeType, int scannerID);

        // @required -(void)sbtEventBarcodeData:(NSData *)barcodeData barcodeType:(int)barcodeType fromScanner:(int)scannerID;
        [Abstract]        [Export("sbtEventBarcodeData:barcodeType:fromScanner:")]        void EventBarcodeData(NSData barcodeData, BarcodeType barcodeType, int scannerID);

        // @required -(void)sbtEventFirmwareUpdate:(FirmwareUpdateEvent *)fwUpdateEventObj;
        [Abstract]        [Export("sbtEventFirmwareUpdate:")]        void EventFirmwareUpdate(FirmwareUpdateEvent fwUpdateEventObj);

        // @required -(void)sbtEventImage:(NSData *)imageData fromScanner:(int)scannerID;
        [Abstract]        [Export("sbtEventImage:fromScanner:")]        void EventImage(NSData imageData, int scannerID);

        // @required -(void)sbtEventVideo:(NSData *)videoFrame fromScanner:(int)scannerID;
        [Abstract]        [Export("sbtEventVideo:fromScanner:")]        void EventVideo(NSData videoFrame, int scannerID);    }
    // @protocol ISbtSdkApi <NSObject>
    [Protocol, Model]    [BaseType(typeof(NSObject))]    interface SbtSdkApi    {
        // @required -(SBT_RESULT)sbtSetDelegate:(id<ISbtSdkApiDelegate>)delegate;
        [Abstract]        [Export("sbtSetDelegate:")]        SbtResult SbtSetDelegate(ISbtSdkApiDelegate @delegate);

        // @required -(NSString *)sbtGetVersion;
        [Abstract]        [Export("sbtGetVersion")]
        //[Verify(MethodToProperty)]
        string Version { get; }

        // @required -(SBT_RESULT)sbtSetOperationalMode:(int)operationalMode;
        [Abstract]        [Export("sbtSetOperationalMode:")]        SbtResult SetOperationalMode(OperationalMode operationalMode);

        // @required -(SBT_RESULT)sbtSubsribeForEvents:(int)sdkEventsMask;
        [Abstract]        [Export("sbtSubsribeForEvents:")]        SbtResult SubsribeForEvents(EventType sdkEventsMask);

        // @required -(SBT_RESULT)sbtUnsubsribeForEvents:(int)sdkEventsMask;
        [Abstract]        [Export("sbtUnsubsribeForEvents:")]        SbtResult UnsubsribeForEvents(EventType sdkEventsMask);

        // @required -(SBT_RESULT)sbtGetAvailableScannersList:(NSMutableArray **)availableScannersList;
        //[Abstract]
        [Export("sbtGetAvailableScannersList:"), Internal]
        /// <param name="availableScannersList">ScannerInfo[] availableScannersList</param>        SbtResult GetAvailableScannersList(ref IntPtr availableScannersList);

        // @required -(SBT_RESULT)sbtGetActiveScannersList:(NSMutableArray **)activeScannersList;
        //[Abstract]
        [Export("sbtGetActiveScannersList:"), Internal]
        /// <param name="activeScannersList">ScannerInfo[] activeScannersList</param>        SbtResult GetActiveScannersList(ref IntPtr activeScannersList);

        // @required -(SBT_RESULT)sbtEstablishCommunicationSession:(int)scannerID;
        [Abstract]        [Export("sbtEstablishCommunicationSession:")]        SbtResult EstablishCommunicationSession(int scannerID);

        // @required -(SBT_RESULT)sbtTerminateCommunicationSession:(int)scannerID;
        [Abstract]        [Export("sbtTerminateCommunicationSession:")]        SbtResult TerminateCommunicationSession(int scannerID);

        // @required -(SBT_RESULT)sbtEnableAvailableScannersDetection:(BOOL)enable;
        [Abstract]        [Export("sbtEnableAvailableScannersDetection:")]        SbtResult EnableAvailableScannersDetection(bool enable);

        // @required -(SBT_RESULT)sbtEnableAutomaticSessionReestablishment:(BOOL)enable forScanner:(int)scannerID;
        [Abstract]        [Export("sbtEnableAutomaticSessionReestablishment:forScanner:")]        SbtResult EnableAutomaticSessionReestablishment(bool enable, int scannerID);

        // @required -(SBT_RESULT)sbtExecuteCommand:(int)opCode aInXML:(NSString *)inXML aOutXML:(NSMutableString **)outXML forScanner:(int)scannerID;
        [Abstract]        [Export("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]        SbtResult ExecuteCommand(OperationCode opCode, string inXML, out string outXML, int scannerID);

        //// @required -(SBT_RESULT)sbtLedControl:(BOOL)enable aLedCode:(int)ledCode forScanner:(int)scannerID;
        //[Abstract]        //[Export("sbtLedControl:aLedCode:forScanner:")]        //SbtResult LedControl(bool enable, LedCode ledCode, int scannerID);

        //// @required -(SBT_RESULT)sbtBeepControl:(int)beepCode forScanner:(int)scannerID;
        //[Abstract]        //[Export("sbtBeepControl:forScanner:")]        //SbtResult BeepControl(Beepcode beepCode, int scannerID);

        // @required -(void)sbtSetBTAddress:(NSString *)btAdd;
        [Abstract]        [Export("sbtSetBTAddress:")]        void SetBTAddress(string bluetoothAddress);

        // @required -(UIImage *)sbtGetPairingBarcode:(BARCODE_TYPE)barcodeType withComProtocol:(STC_COM_PROTOCOL)comProtocol withSetDefaultStatus:(SETDEFAULT_STATUS)setDefaultsStatus withBTAddress:(NSString *)btAddress withImageFrame:(CGRect)imageFrame;
        [Abstract]        [Export("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]        UIImage GetPairingBarcode(BarcodeType barcodeType, ComProtocol comProtocol, DefaultStatus defaultStatus, string bluetoothAddress, CGRect imageFrame);    }

    // @interface SbtSdkFactory : NSObject
    [BaseType(typeof(NSObject))]    interface SbtSdkFactory    {
        // +(id<ISbtSdkApi>)createSbtSdkApiInstance;
        [Static]        [Export("createSbtSdkApiInstance")]
        //[Verify(MethodToProperty)]
        ISbtSdkApi CreateInstance();    }    public interface ISbtSdkApi { }
    //{
    //    SbtResult GetAvailableScannersList(out IScannerInfo[] availableScannersList);
    //}

    public interface ISbtSdkApiDelegate { }

    //public interface IScannerInfo : INativeObject { }

    //public partial class SbtSdkApi
    //{
    //    public SbtResult GetAvailableScannersList(out IScannerInfo[] availableScannersList)
    //    {
    //        NSMutableArray availableReaders = new NSMutableArray();
    //        IntPtr availableHandle = availableReaders.Handle;
    //        var result = GetAvailableScannersList(ref availableHandle);
    //        availableReaders = Runtime.GetNSObject<NSMutableArray>(availableHandle);

    //        //availableScannersList = NSArray.FromArray<ScannerInfo>(availableReaders);
    //        availableScannersList = NSArray.ArrayFromHandle<IScannerInfo>(availableHandle);

    //        return result;
    //    }
    //}
}