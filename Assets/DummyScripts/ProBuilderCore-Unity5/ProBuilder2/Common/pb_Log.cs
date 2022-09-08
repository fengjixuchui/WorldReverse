/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_Log // TypeDefIndex: 3407
	{
		// Fields
		public const string DEFAULT_LOG_PATH = "ProBuilderLog.txt"; // Metadata: 0x00AC3C67
		private static Stack<pb_LogLevel> m_logStack; // 0x00
		private static pb_LogLevel m_LogLevel; // 0x08
		private static pb_LogOutput m_Output; // 0x0C
		private static string m_LogFilePath; // 0x10
	
		// Constructors
		static pb_Log() {} // 0x0000000186BA6390-0x0000000186BA6460
	
		// Methods
		public static void PushLogLevel(pb_LogLevel level) {} // 0x0000000186BA5FB0-0x0000000186BA6070
		public static void PopLogLevel() {} // 0x0000000186BA59A0-0x0000000186BA5A50
		public static void SetLogLevel(pb_LogLevel level) {} // 0x0000000186BA6100-0x0000000186BA6190
		public static void SetOutput(pb_LogOutput output) {} // 0x0000000186BA6190-0x0000000186BA6220
		public static void SetLogFile(string path) {} // 0x0000000186BA6070-0x0000000186BA6100
		public static void Debug<T>(T value) {}
		public static void Debug(string message) {} // 0x0000000186BA5500-0x0000000186BA5590
		public static void Debug(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000186BA5440-0x0000000186BA5500
		public static void Info(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000186BA58E0-0x0000000186BA59A0
		public static void Info(string message) {} // 0x0000000186BA5830-0x0000000186BA58E0
		public static void Warning(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000186BA62D0-0x0000000186BA6390
		public static void Warning(string message) {} // 0x0000000186BA6220-0x0000000186BA62D0
		public static void Error(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] values) {} // 0x0000000186BA56C0-0x0000000186BA5780
		public static void Error(string message) {} // 0x0000000186BA5780-0x0000000186BA5830
		public static void Watch<T, K>(T key, K value) {}
		private static void DoPrint(string message, LogType type) {} // 0x0000000186BA5590-0x0000000186BA56C0
		public static void PrintToFile(string message, string path) {} // 0x0000000186BA5B60-0x0000000186BA5FB0
		public static void ClearLogFile() {} // 0x0000000186BA5370-0x0000000186BA5440
		public static void PrintToConsole(string message, LogType type = LogType.Log /* Metadata: 0x00AC3C63 */) {} // 0x0000000186BA5A50-0x0000000186BA5B60
	}
}
