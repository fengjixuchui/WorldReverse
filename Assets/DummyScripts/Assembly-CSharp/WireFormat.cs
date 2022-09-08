/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class WireFormat // TypeDefIndex: 26476
{
	// Fields
	private const int TagTypeBits = 3; // Metadata: 0x00B0C344
	private const uint TagTypeMask = 7; // Metadata: 0x00B0C348

	// Nested types
	public enum WireType : uint // TypeDefIndex: 26477
	{
		Varint = 0,
		Fixed64 = 1,
		LengthDelimited = 2,
		StartGroup = 3,
		EndGroup = 4,
		Fixed32 = 5
	}

	// Methods
	// [XID] // 0x0000000189B21E80-0x0000000189B21EA0
	public static WireType GetTagWireType(uint tag) => default; // 0x0000000182EE4AC0-0x0000000182EE4B60
	// [XID] // 0x0000000189B29460-0x0000000189B29480
	public static int GetTagFieldNumber(uint tag) => default; // 0x0000000182EE4A20-0x0000000182EE4AC0
	// [XID] // 0x0000000189B30920-0x0000000189B30940
	public static uint MakeTag(int fieldNumber, WireType wireType) => default; // 0x0000000182EE4B60-0x0000000182EE4C10
}

