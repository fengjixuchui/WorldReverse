/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class RecentEventPostRecords // TypeDefIndex: 11310
{
	// Fields
	private const int WINDOW_SIZE = 16; // Metadata: 0x00AE9717
	private static readonly CyclicBlock<List<uint>> _recordWindow; // 0x00
	private static readonly Dictionary<uint, uint> _queryTable; // 0x08
	private static readonly List<uint> _newRecordsThisFrame; // 0x10

	// Constructors
	static RecentEventPostRecords() {} // 0x00000001827C2E10-0x00000001827C2F90

	// Methods
	// [XID] // 0x000000018994DBC0-0x000000018994DBE0
	public static void StepOneFrame() {} // 0x00000001827C2C50-0x00000001827C2D10
	// [XID] // 0x00000001899551E0-0x0000000189955200
	public static void AddRecord(uint postId, uint playingId) {} // 0x00000001827C2740-0x00000001827C2860
	// [XID] // 0x00000001895E9DD0-0x00000001895E9DF0
	public static uint QueryPlayingId(uint postId) => default; // 0x00000001827C2D10-0x00000001827C2E10
	// [XID] // 0x00000001899642D0-0x00000001899642F0
	private static void RemoveOldestPostIdsFromQueryTable() {} // 0x00000001827C2860-0x00000001827C29F0
	// [XID] // 0x000000018996B930-0x000000018996B950
	private static void ShiftLastFrameIntoRecords() {} // 0x00000001827C29F0-0x00000001827C2C50
}

