/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Internal;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	internal static class Logger // TypeDefIndex: 3965
	{
		// Fields
		private static List<string> __screenLog; // 0x00
		private static GUIText _guiText; // 0x08
		private static bool _logToScreen; // 0x10
	
		// Properties
		private static List<string> screenLog { get; } // 0x00000001852FF950-0x00000001852FF9F0 
		private static LogLevelFlags logLevel { get; } // 0x00000001852FF860-0x00000001852FF950 
		public static bool logToScreen { get; set; } // 0x00000001852FF9F0-0x00000001852FFC20
	
		// Methods
		public static void LogErrorEditor(object msg) {} // 0x00000001852FD6F0-0x00000001852FD760
		public static void LogErrorEditor(object msg, bool requiredThreadSafety) {} // 0x00000001852FD5C0-0x00000001852FD6F0
		public static void Log(object msg) {} // 0x00000001852FF7F0-0x00000001852FF860
		public static void Log(object msg, bool requiredThreadSafety) {} // 0x00000001852FF660-0x00000001852FF7F0
		public static void LogWarning(object msg) {} // 0x00000001852FF3B0-0x00000001852FF420
		public static void LogWarning(object msg, bool requiredThreadSafety) {} // 0x00000001852FF420-0x00000001852FF660
		public static void LogError(object msg) {} // 0x00000001852FD8E0-0x00000001852FD950
		public static void LogError(object msg, bool requiredThreadSafety) {} // 0x00000001852FD950-0x00000001852FEA50
		private static void LogNow(object msg, bool requireThreadSafety) {} // 0x00000001852FEA50-0x00000001852FEC00
		private static void LogWarningNow(object msg, bool requireThreadSafety) {} // 0x00000001852FF230-0x00000001852FF3B0
		private static void LogErrorNow(object msg, bool requireThreadSafety) {} // 0x00000001852FD760-0x00000001852FD8E0
		private static bool IsLoggingAllowed(LogLevel logLevel) => default; // 0x00000001852FD4D0-0x00000001852FD5C0
		private static void LogToScreen(object msg) {} // 0x00000001852FEC00-0x00000001852FF230
	}
}
