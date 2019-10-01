# ZebraSDK
Xamarin Binding library for the Zebra Scanner 

## iOS
### Info.plist
Add the correct permissions:

    <!-- iOS 10+ -->
    <key>NSBluetoothPeripheralUsageDescription</key>
    <string>Allow communication with the scanner.</string>
    
    <!-- iOS 13+ -->
    <key>NSBluetoothAlwaysUsageDescription</key>
    <string>Allow communication with the scanner.</string>
    
Add supported accessories (optional):

    <key>UISupportedExternalAccessoryProtocols</key>
    <array>
      <string>com.zebra.scanner.SSI</string>
      <string>com.motorolasolutions.scanner</string>
      <string>com.motorolasolutions.CS4070_ssi</string>
    </array>

Add background modes (optional):

    <key>UIBackgroundModes</key>
    <array>
      <string>external-accessory</string>
      <string>bluetooth-central</string>
    </array>
