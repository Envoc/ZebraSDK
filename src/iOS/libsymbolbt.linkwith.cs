using System;
using ObjCRuntime;

[assembly: LinkWith("libsymbolbt.a", LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "UIKit Foundation CoreGraphics CoreBluetooth ExternalAccessory QuartzCore CoreText")]