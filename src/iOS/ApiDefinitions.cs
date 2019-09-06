using ObjCRuntime;
    // @interface SbtScannerInfo : NSObject
    [Protocol]
        // -(void)dealloc;
        [Export("dealloc")]

        // -(void)setScannerID:(int)scannerID;
        [Export("setScannerID:")]

        // -(void)setConnectionType:(int)connectionType;
        [Export("setConnectionType:")]

        // -(void)setAutoCommunicationSessionReestablishment:(BOOL)enable;
        [Export("setAutoCommunicationSessionReestablishment:")]

        // -(void)setActive:(BOOL)active;
        [Export("setActive:")]

        // -(void)setAvailable:(BOOL)available;
        [Export("setAvailable:")]

        // -(void)setScannerName:(NSString *)scannerName;
        [Export("setScannerName:")]

        // -(void)setScannerModel:(int)scannerModel;
        [Export("setScannerModel:")]

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
        [Export("firmwareVersion", ArgumentSemantic.Retain)]

        // @property (retain, nonatomic) NSString * mFD;
        [Export("mFD", ArgumentSemantic.Retain)]

        // @property (retain, nonatomic) NSString * serialNo;
        [Export("serialNo", ArgumentSemantic.Retain)]

        // @property (retain, nonatomic) NSString * scannerModelString;
        [Export("scannerModelString", ArgumentSemantic.Retain)]

    // @interface FirmwareUpdateEvent : NSObject
    [BaseType(typeof(NSObject))]
        // @property (retain, nonatomic) SbtScannerInfo * scannerInfo;
        [Export("scannerInfo", ArgumentSemantic.Retain)]

        // @property (readonly) int maxRecords;
        [Export("maxRecords")]

        // @property (readonly) int swComponent;
        [Export("swComponent")]

        // @property (readonly) int currentRecord;
        [Export("currentRecord")]

        // @property (readonly) int size;
        [Export("size")]

        // @property (readonly) SBT_FW_UPDATE_RESULT status;
        [Export("status")]

        // -(instancetype)initWithScannerInfo:(SbtScannerInfo *)_scannerInfo withRecords:(int)_maxRecords withSWComponenet:(int)_swComponent withCurrentRecord:(int)_currentRecord withStatus:(SBT_FW_UPDATE_RESULT)_status;
        [Export("initWithScannerInfo:withRecords:withSWComponenet:withCurrentRecord:withStatus:")]

    // @protocol ISbtSdkApiDelegate <NSObject>
    [Protocol, Model]
        // @required -(void)sbtEventScannerAppeared:(SbtScannerInfo *)availableScanner;
        [Abstract]

        // @required -(void)sbtEventScannerDisappeared:(int)scannerID;
        [Abstract]

        // @required -(void)sbtEventCommunicationSessionEstablished:(SbtScannerInfo *)activeScanner;
        [Abstract]

        // @required -(void)sbtEventCommunicationSessionTerminated:(int)scannerID;
        [Abstract]

        // @required -(void)sbtEventBarcode:(NSString *)barcodeData barcodeType:(int)barcodeType fromScanner:(int)scannerID;
        [Abstract]

        // @required -(void)sbtEventBarcodeData:(NSData *)barcodeData barcodeType:(int)barcodeType fromScanner:(int)scannerID;
        [Abstract]

        // @required -(void)sbtEventFirmwareUpdate:(FirmwareUpdateEvent *)fwUpdateEventObj;
        [Abstract]

        // @required -(void)sbtEventImage:(NSData *)imageData fromScanner:(int)scannerID;
        [Abstract]

        // @required -(void)sbtEventVideo:(NSData *)videoFrame fromScanner:(int)scannerID;
        [Abstract]
    // @protocol ISbtSdkApi <NSObject>
    [Protocol, Model]
        // @required -(SBT_RESULT)sbtSetDelegate:(id<ISbtSdkApiDelegate>)delegate;
        [Abstract]

        // @required -(NSString *)sbtGetVersion;
        [Abstract]
        //[Verify(MethodToProperty)]
        string Version { get; }

        // @required -(SBT_RESULT)sbtSetOperationalMode:(int)operationalMode;
        [Abstract]

        // @required -(SBT_RESULT)sbtSubsribeForEvents:(int)sdkEventsMask;
        [Abstract]

        // @required -(SBT_RESULT)sbtUnsubsribeForEvents:(int)sdkEventsMask;
        [Abstract]

        // @required -(SBT_RESULT)sbtGetAvailableScannersList:(NSMutableArray **)availableScannersList;
        //[Abstract]
        [Export("sbtGetAvailableScannersList:"), Internal]
        /// <param name="availableScannersList">ScannerInfo[] availableScannersList</param>

        // @required -(SBT_RESULT)sbtGetActiveScannersList:(NSMutableArray **)activeScannersList;
        //[Abstract]
        [Export("sbtGetActiveScannersList:"), Internal]
        /// <param name="activeScannersList">ScannerInfo[] activeScannersList</param>

        // @required -(SBT_RESULT)sbtEstablishCommunicationSession:(int)scannerID;
        [Abstract]

        // @required -(SBT_RESULT)sbtTerminateCommunicationSession:(int)scannerID;
        [Abstract]

        // @required -(SBT_RESULT)sbtEnableAvailableScannersDetection:(BOOL)enable;
        [Abstract]

        // @required -(SBT_RESULT)sbtEnableAutomaticSessionReestablishment:(BOOL)enable forScanner:(int)scannerID;
        [Abstract]

        // @required -(SBT_RESULT)sbtExecuteCommand:(int)opCode aInXML:(NSString *)inXML aOutXML:(NSMutableString **)outXML forScanner:(int)scannerID;
        [Abstract]

        //// @required -(SBT_RESULT)sbtLedControl:(BOOL)enable aLedCode:(int)ledCode forScanner:(int)scannerID;
        //[Abstract]

        //// @required -(SBT_RESULT)sbtBeepControl:(int)beepCode forScanner:(int)scannerID;
        //[Abstract]

        // @required -(void)sbtSetBTAddress:(NSString *)btAdd;
        [Abstract]

        // @required -(UIImage *)sbtGetPairingBarcode:(BARCODE_TYPE)barcodeType withComProtocol:(STC_COM_PROTOCOL)comProtocol withSetDefaultStatus:(SETDEFAULT_STATUS)setDefaultsStatus withBTAddress:(NSString *)btAddress withImageFrame:(CGRect)imageFrame;
        [Abstract]

    // @interface SbtSdkFactory : NSObject
    [BaseType(typeof(NSObject))]
        // +(id<ISbtSdkApi>)createSbtSdkApiInstance;
        [Static]
        //[Verify(MethodToProperty)]
        ISbtSdkApi CreateInstance();
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