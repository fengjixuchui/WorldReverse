/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class ExternalResourcesLogger // TypeDefIndex: 7526
	{
		// Fields
		public static bool bEnabled; // 0x00
		private static readonly HashSet<string> _verboseLogAssetNames; // 0x08
	
		// Properties
		public static string verboseLogAssetName { /* [XID] */ /* 0x0000000189A69120-0x0000000189A69160 */ get; set; } // 0x0000000189BE23D0-0x0000000189BE2460 0x0000000189BE2460-0x0000000189BE24F0
	
		// Nested types
		private struct TemparoryStackTraceLogType : IDisposable // TypeDefIndex: 7527
		{
			// Fields
			private readonly LogType _logType; // 0x00
			private readonly StackTraceLogType _stackTraceLogType; // 0x04
	
			// Constructors
			public TemparoryStackTraceLogType(LogType logType, StackTraceLogType stackTraceLogType) {
				_logType = default;
				_stackTraceLogType = default;
			} // 0x0000000189C01550-0x0000000189C01560
	
			// Methods
			// [XID] // 0x0000000189AE4740-0x0000000189AE4760
			public void Dispose() {} // 0x0000000189C014A0-0x0000000189C01550
		}
	
		// Constructors
		static ExternalResourcesLogger() {} // 0x0000000189BE2310-0x0000000189BE23D0
	
		// Methods
		// [XID] // 0x0000000189A7B070-0x0000000189A7B090
		public static void AddToVerboseLogList(string assetPath) {} // 0x0000000189BE1530-0x0000000189BE1620
		// [XID] // 0x00000001896FDD90-0x00000001896FDDB0
		public static void RemoveFromVerboseLogList(string assetPath) {} // 0x0000000189BE20C0-0x0000000189BE21B0
		// [IDTag] // 0x0000000189A89F20-0x0000000189A89F60
		// [XID] // 0x0000000189A89F20-0x0000000189A89F60
		public static void LogFormat(string format, object arg0) {} // 0x0000000189BE1620-0x0000000189BE1730
		// [IDTag] // 0x0000000189A94430-0x0000000189A94470
		// [XID] // 0x0000000189A94430-0x0000000189A94470
		public static void LogFormat(string format, object arg0, object arg1) {} // 0x0000000189BE1730-0x0000000189BE1850
		// [IDTag] // 0x0000000189A9EB70-0x0000000189A9EBB0
		// [XID] // 0x0000000189A9EB70-0x0000000189A9EBB0
		public static void LogFormat(string format, object arg0, object arg1, object arg2) {} // 0x0000000189BE1BF0-0x0000000189BE1D30
		// [IDTag] // 0x0000000189AA9010-0x0000000189AA9050
		// [XID] // 0x0000000189AA9010-0x0000000189AA9050
		public static void LogFormat(string format, object arg0, object arg1, object arg2, object arg3) {} // 0x0000000189BE1850-0x0000000189BE1AE0
		// [IDTag] // 0x0000000189AB3C40-0x0000000189AB3C80
		// [XID] // 0x0000000189AB3C40-0x0000000189AB3C80
		public static void LogFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x0000000189BE1AE0-0x0000000189BE1BF0
		// [XID] // 0x0000000189AC62B0-0x0000000189AC62D0
		public static void Log(string message) {} // 0x0000000189BE1EA0-0x0000000189BE20C0
		// [XID] // 0x0000000189786F80-0x0000000189786FA0
		public static bool UsesVerboseLog(string assetPath) => default; // 0x0000000189BE21B0-0x0000000189BE2310
		// [XID] // 0x0000000189AD57F0-0x0000000189AD5810
		private static void LogMessageWithCommonPrefix(string message) {} // 0x0000000189BE1D30-0x0000000189BE1EA0
		// [XID] // 0x0000000189786FA0-0x0000000189786FC0
		private static void AddCommonPrefix(StringBuilder builder) {} // 0x0000000189BE13F0-0x0000000189BE1530
	}
}
