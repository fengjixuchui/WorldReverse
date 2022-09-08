/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class NonAllocBitConverter // TypeDefIndex: 31795
{
	// Nested types
	private struct Int32BytesUnion // TypeDefIndex: 31796
	{
		// Fields
		public int value; // 0x00
		public byte b1; // 0x00
		public byte b2; // 0x01
		public byte b3; // 0x02
		public byte b4; // 0x03
	}

	private struct SingleBytesUnion // TypeDefIndex: 31797
	{
		// Fields
		public float value; // 0x00
		public byte b1; // 0x00
		public byte b2; // 0x01
		public byte b3; // 0x02
		public byte b4; // 0x03
	}

	private struct Int32SingleUnion // TypeDefIndex: 31798
	{
		// Fields
		public int iValue; // 0x00
		public float fValue; // 0x00
	}

	// Methods
	// [XID] // 0x00000001899BDA20-0x00000001899BDA40
	public static void GetBytes(float value, ref byte[] array) {} // 0x00000001833D2270-0x00000001833D23F0
	// [XID] // 0x00000001899C5140-0x00000001899C5160
	public static int ToInt32(float value) => default; // 0x00000001833D24A0-0x00000001833D2550
	// [XID] // 0x00000001899CC810-0x00000001899CC830
	public static float ToFloat(int value) => default; // 0x00000001833D23F0-0x00000001833D24A0
}

