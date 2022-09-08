/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class CommandLine // TypeDefIndex: 10523
	{
		// Fields
		private static readonly Dictionary<string, string> _argSet; // 0x00
		private static readonly string[] _args; // 0x08
		private static float _dpi; // 0x10
		private static int _inputWidth; // 0x14
		private static int _inputHeight; // 0x18
		private static int _inputMobile; // 0x1C
		private static string _deviceInfo; // 0x20
		private static int _languageType; // 0x28
		private static string _ip; // 0x30
		private static string _deviceName; // 0x38
		private static string _systemVersion; // 0x40
		private static int _inputMode; // 0x48
		private static string _sdkParamter; // 0x50
		private static string _graphicSetting; // 0x58
		private static readonly string dpiKey; // 0x60
		private static readonly string inputWidthKey; // 0x68
		private static readonly string inputHeightKey; // 0x70
		private static readonly string inputMobileKey; // 0x78
		private static readonly string deviceInfoKey; // 0x80
		private static readonly string languageTypeKey; // 0x88
		private static readonly string ipKey; // 0x90
		private static readonly string deviceNameKey; // 0x98
		private static readonly string systemVersionKey; // 0xA0
		private static readonly string inputModeKey; // 0xA8
		private static readonly string sdkParamterKey; // 0xB0
		private static readonly string graphicSettingKey; // 0xB8
	
		// Properties
		public static string command { get; /* [XID] */ /* 0x00000001899992C0-0x0000000189999300 */ private set; } // 0x00000001868FB010-0x00000001868FB0A0 0x00000001868FC2B0-0x00000001868FC340
		public static float dpi { /* [XID] */ /* 0x00000001899A3C00-0x00000001899A3C20 */ get; } // 0x00000001868FB320-0x00000001868FB460 
		public static int inputWidth { /* [XID] */ /* 0x00000001899AB6B0-0x00000001899AB6D0 */ get; } // 0x00000001868FBB40-0x00000001868FBC80 
		public static int inputHeight { /* [XID] */ /* 0x00000001897A9940-0x00000001897A9960 */ get; } // 0x00000001868FB780-0x00000001868FB8C0 
		public static bool isCloudGame { /* [XID] */ /* 0x00000001899BA280-0x00000001899BA2A0 */ get; } // 0x00000001868FBDC0-0x00000001868FBF00 
		public static int inputMobile { /* [XID] */ /* 0x00000001899C1D20-0x00000001899C1D40 */ get; } // 0x00000001868FB8C0-0x00000001868FBA00 
		public static int inputMode { /* [XID] */ /* 0x00000001899C9180-0x00000001899C91A0 */ get; } // 0x00000001868FBA00-0x00000001868FBB40 
		public static string deviceInfo { /* [XID] */ /* 0x00000001897C87B0-0x00000001897C87D0 */ get; } // 0x00000001868FB0A0-0x00000001868FB1E0 
		public static int languageType { /* [XID] */ /* 0x00000001899D8090-0x00000001899D80B0 */ get; } // 0x00000001868FBF00-0x00000001868FC030 
		public static string ip { /* [XID] */ /* 0x00000001899DF6A0-0x00000001899DF6C0 */ get; } // 0x00000001868FBC80-0x00000001868FBDC0 
		public static string deviceName { /* [XID] */ /* 0x00000001899E7230-0x00000001899E7250 */ get; } // 0x00000001868FB1E0-0x00000001868FB320 
		public static string systemVersion { /* [XID] */ /* 0x00000001899EE670-0x00000001899EE690 */ get; } // 0x00000001868FC170-0x00000001868FC2B0 
		public static string sdkParamter { /* [XID] */ /* 0x00000001897FBC60-0x00000001897FBC80 */ get; } // 0x00000001868FC030-0x00000001868FC170 
		public static string graphicSetting { /* [XID] */ /* 0x0000000189803170-0x0000000189803190 */ get; } // 0x00000001868FB460-0x00000001868FB780 
	
		// Constructors
		static CommandLine() {} // 0x00000001868FAC70-0x00000001868FB010
	
		// Methods
		// [XID] // 0x0000000189A04CE0-0x0000000189A04D00
		public static bool GetArg(string key, out string result) {
			result = default;
			return default;
		} // 0x00000001868F9FF0-0x00000001868FA170
		// [XID] // 0x0000000189A0C350-0x0000000189A0C370
		public static bool GetBoolArg(string key, out bool result) {
			result = default;
			return default;
		} // 0x00000001868FA170-0x00000001868FA360
		// [XID] // 0x00000001897A22C0-0x00000001897A22E0
		public static bool GetIntArg(string key, out int result) {
			result = default;
			return default;
		} // 0x00000001868FA600-0x00000001868FA7D0
		// [XID] // 0x0000000189A1AEF0-0x0000000189A1AF10
		public static bool GetFloatArg(string key, out float result) {
			result = default;
			return default;
		} // 0x00000001868FA430-0x00000001868FA600
		// [XID] // 0x0000000189811D20-0x0000000189811D40
		private static void ParseArgs(string[] args) {} // 0x00000001868FA7D0-0x00000001868FAC70
		// [XID] // 0x000000018984D3E0-0x000000018984D400
		private static void AddArg(string key, string value) {} // 0x00000001868F9D20-0x00000001868F9FF0
		// [XID] // 0x00000001898544D0-0x00000001898544F0
		public static Dictionary<string, string> GetCommandLineContent() => default; // 0x00000001868FA360-0x00000001868FA430
	}
}
