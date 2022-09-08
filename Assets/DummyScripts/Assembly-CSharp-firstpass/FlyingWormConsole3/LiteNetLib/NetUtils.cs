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

namespace FlyingWormConsole3.LiteNetLib
{
	public static class NetUtils // TypeDefIndex: 6964
	{
		// Fields
		private static readonly List<string> IpList; // 0x00
		private static readonly object DebugLogLock; // 0x08
	
		// Constructors
		static NetUtils() {} // 0x00000001863D0D20-0x00000001863D0DD0
	
		// Methods
		// [XID] // 0x000000018992B8E0-0x000000018992B900
		internal static int RelativeSequenceNumber(int number, int expected) => default; // 0x00000001863D0C50-0x00000001863D0D20
		// [XID] // 0x0000000189986A10-0x0000000189986A30
		internal static int GetDividedPacketsCount(int size, int mtu) => default; // 0x00000001863CFD40-0x00000001863CFE00
		// [XID] // 0x0000000189A599B0-0x0000000189A599D0
		public static void PrintInterfaceInfos() {} // 0x00000001863D05A0-0x00000001863D0C50
		// [XID] // 0x0000000189A611D0-0x0000000189A611F0
		public static void GetLocalIpList(List<string> targetList, LocalAddrType addrType) {} // 0x00000001863CFE00-0x00000001863D0320
		// [XID] // 0x0000000189A69160-0x0000000189A69180
		public static string GetLocalIp(LocalAddrType addrType) => default; // 0x00000001863D0320-0x00000001863D05A0
		// [XID] // 0x0000000189A673F0-0x0000000189A67410
		private static void DebugWriteLogic(ConsoleColor color, string str, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001863CF960-0x00000001863CFB70
		// [Conditional] // 0x0000000189A7F1A0-0x0000000189A7F200
		// [IDTag] // 0x0000000189A7F1A0-0x0000000189A7F200
		// [XID] // 0x0000000189A7F1A0-0x0000000189A7F200
		internal static void DebugWrite(string str, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001863CFB70-0x00000001863CFC50
		// [Conditional] // 0x0000000189A95D70-0x0000000189A95DE0
		// [IDTag] // 0x0000000189A95D70-0x0000000189A95DE0
		// [XID] // 0x0000000189A95D70-0x0000000189A95DE0
		internal static void DebugWrite(ConsoleColor color, string str, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001863CFC50-0x00000001863CFD40
		// [Conditional] // 0x0000000189AAA8A0-0x0000000189AAA910
		// [Conditional] // 0x0000000189AAA8A0-0x0000000189AAA910
		// [XID] // 0x0000000189AAA8A0-0x0000000189AAA910
		internal static void DebugWriteForce(ConsoleColor color, string str, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001863CF870-0x00000001863CF960
		// [Conditional] // 0x0000000189ABFE90-0x0000000189ABFF00
		// [Conditional] // 0x0000000189ABFE90-0x0000000189ABFF00
		// [XID] // 0x0000000189ABFE90-0x0000000189ABFF00
		internal static void DebugWriteError(string str, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001863CF790-0x00000001863CF870
	}
}
