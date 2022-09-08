/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRApplications // TypeDefIndex: 6221
	{
		// Fields
		internal _AddApplicationManifest AddApplicationManifest; // 0x00
		internal _RemoveApplicationManifest RemoveApplicationManifest; // 0x08
		internal _IsApplicationInstalled IsApplicationInstalled; // 0x10
		internal _GetApplicationCount GetApplicationCount; // 0x18
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex; // 0x20
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId; // 0x28
		internal _LaunchApplication LaunchApplication; // 0x30
		internal _LaunchTemplateApplication LaunchTemplateApplication; // 0x38
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType; // 0x40
		internal _LaunchDashboardOverlay LaunchDashboardOverlay; // 0x48
		internal _CancelApplicationLaunch CancelApplicationLaunch; // 0x50
		internal _IdentifyApplication IdentifyApplication; // 0x58
		internal _GetApplicationProcessId GetApplicationProcessId; // 0x60
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum; // 0x68
		internal _GetApplicationPropertyString GetApplicationPropertyString; // 0x70
		internal _GetApplicationPropertyBool GetApplicationPropertyBool; // 0x78
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64; // 0x80
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch; // 0x88
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch; // 0x90
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType; // 0x98
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType; // 0xA0
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes; // 0xA8
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType; // 0xB0
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments; // 0xB8
		internal _GetStartingApplication GetStartingApplication; // 0xC0
		internal _GetTransitionState GetTransitionState; // 0xC8
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck; // 0xD0
		internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum; // 0xD8
		internal _IsQuitUserPromptRequested IsQuitUserPromptRequested; // 0xE0
		internal _LaunchInternalProcess LaunchInternalProcess; // 0xE8
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId; // 0xF0
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary); // TypeDefIndex: 6222; 0x0000000186475140-0x0000000186475400
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath); // TypeDefIndex: 6223; 0x00000001864840F0-0x0000000186484350
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsApplicationInstalled(string pchAppKey); // TypeDefIndex: 6224; 0x0000000186481210-0x0000000186481470
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetApplicationCount(); // TypeDefIndex: 6225; 0x0000000186478830-0x00000001864789A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6226; 0x0000000186478B80-0x0000000186478D50
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6227; 0x0000000186478F30-0x0000000186479100
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _LaunchApplication(string pchAppKey); // TypeDefIndex: 6228; 0x0000000186481D80-0x0000000186481FE0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys); // TypeDefIndex: 6229; 0x0000000186482A60-0x0000000186482DB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs); // TypeDefIndex: 6230; 0x0000000186481920-0x0000000186481BD0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey); // TypeDefIndex: 6231; 0x0000000186482190-0x00000001864823F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _CancelApplicationLaunch(string pchAppKey); // TypeDefIndex: 6232; 0x0000000186475BD0-0x0000000186475E30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey); // TypeDefIndex: 6233; 0x0000000186480A30-0x0000000186480BF0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetApplicationProcessId(string pchAppKey); // TypeDefIndex: 6234; 0x0000000186479660-0x00000001864798C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error); // TypeDefIndex: 6235; 0x000000018647AEE0-0x000000018647B070
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError); // TypeDefIndex: 6236; 0x0000000186479FB0-0x000000018647A3A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 6237; 0x0000000186479AB0-0x0000000186479DA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 6238; 0x000000018647A590-0x000000018647A880
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch); // TypeDefIndex: 6239; 0x00000001864847F0-0x0000000186484AB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetApplicationAutoLaunch(string pchAppKey); // TypeDefIndex: 6240; 0x0000000186478430-0x0000000186478690
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType); // TypeDefIndex: 6241; 0x0000000186484C50-0x0000000186484F00
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6242; 0x000000018647D380-0x000000018647D670
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer); // TypeDefIndex: 6243; 0x000000018647AA40-0x000000018647AD30
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer); // TypeDefIndex: 6244; 0x000000018647B230-0x000000018647B520
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs); // TypeDefIndex: 6245; 0x00000001864792E0-0x00000001864794B0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6246; 0x000000018647F040-0x000000018647F2F0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationTransitionState _GetTransitionState(); // TypeDefIndex: 6247; 0x000000018647F490-0x000000018647F600
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey); // TypeDefIndex: 6248; 0x0000000186482F60-0x00000001864831C0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state); // TypeDefIndex: 6249; 0x000000018647B6D0-0x000000018647B860
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _IsQuitUserPromptRequested(); // TypeDefIndex: 6250; 0x0000000186481610-0x0000000186481780
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory); // TypeDefIndex: 6251; 0x00000001864825A0-0x0000000186482890
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate uint _GetCurrentSceneProcessId(); // TypeDefIndex: 6252; 0x000000018647D050-0x000000018647D1C0
	}
}
