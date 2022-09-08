/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class PinYinCache // TypeDefIndex: 28637
{
	// Fields
	private const string CACHE_FILE_PATH = "Data/pinyinCache"; // Metadata: 0x00B0DA5B
	private static Dictionary<string, IList<string>> _cache; // 0x00

	// Methods
	// [XID] // 0x000000018994B390-0x000000018994B3B0
	private static void LoadCacheFile() {} // 0x0000000183E14240-0x0000000183E145C0
	// [IDTag] // 0x0000000189952D40-0x0000000189952D80
	// [XID] // 0x0000000189952D40-0x0000000189952D80
	public static IList<string> GetPinyins(string text) => default; // 0x0000000183E13D30-0x0000000183E13E40
	// [XID] // 0x000000018995D460-0x000000018995D480
	public static bool Cache(string text) => default; // 0x0000000183E145C0-0x0000000183E147F0
	[DebuggerHidden] // 0x0000000189964B50-0x0000000189964BA0
	// [IDTag] // 0x0000000189964B50-0x0000000189964BA0
	// [XID] // 0x0000000189964B50-0x0000000189964BA0
	private static IEnumerable<string> GetPinyins(char[] chineseString, bool onlyInitial, int fromIndex = 0 /* Metadata: 0x00B0DA57 */) => default; // 0x0000000183E13E40-0x0000000183E13F90
	// [IDTag] // 0x00000001899725A0-0x00000001899725E0
	// [XID] // 0x00000001899725A0-0x00000001899725E0
	private static IEnumerable<string> GetPinyins(char c, bool onlyInitial) => default; // 0x0000000183E13F90-0x0000000183E14240
}

