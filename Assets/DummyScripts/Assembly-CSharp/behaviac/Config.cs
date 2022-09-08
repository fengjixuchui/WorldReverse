/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public static class Config // TypeDefIndex: 27556
	{
		// Fields
		private static bool m_bProfiling; // 0x00
		private static bool m_bIsLogging; // 0x01
		private static bool m_bIsLoggingFlush; // 0x02
		private static bool m_bIsSocketing; // 0x03
		private static bool m_bIsSocketBlocking; // 0x04
		private static ushort m_socketPort; // 0x06
		private static bool m_bIsHotReload; // 0x08
		private static bool m_bIsSuppressingNonPublicWarning; // 0x09
		private static bool m_bPreloadBehaviors; // 0x0A
	
		// Properties
		public static bool IsProfiling { get; set; } // 0x0000000186D80500-0x0000000186D80590 0x0000000186D80A30-0x0000000186D80AD0
		public static bool IsLoggingOrSocketing { get; } // 0x0000000186D803B0-0x0000000186D80470 
		public static bool IsLogging { get; set; } // 0x0000000186D80470-0x0000000186D80500 0x0000000186D80990-0x0000000186D80A30
		public static bool IsLoggingFlush { get; set; } // 0x0000000186D80320-0x0000000186D803B0 0x0000000186D808F0-0x0000000186D80990
		public static bool IsSocketing { get; set; } // 0x0000000186D80620-0x0000000186D806B0 0x0000000186D80B60-0x0000000186D80C00
		public static bool IsSocketBlocking { get; set; } // 0x0000000186D80590-0x0000000186D80620 0x0000000186D80AD0-0x0000000186D80B60
		public static ushort SocketPort { get; set; } // 0x0000000186D807D0-0x0000000186D80860 0x0000000186D80D20-0x0000000186D80DB0
		public static bool IsHotReload { get; set; } // 0x0000000186D80290-0x0000000186D80320 0x0000000186D80860-0x0000000186D808F0
		public static bool IsSuppressingNonPublicWarning { get; set; } // 0x0000000186D806B0-0x0000000186D80740 0x0000000186D80C00-0x0000000186D80C90
		public static bool PreloadBehaviors { get; set; } // 0x0000000186D80740-0x0000000186D807D0 0x0000000186D80C90-0x0000000186D80D20
	
		// Constructors
		static Config() {} // 0x0000000186D801B0-0x0000000186D80290
	
		// Methods
		public static void LogInfo() {} // 0x0000000186D80160-0x0000000186D801B0
	}
}
