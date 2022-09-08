/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExAcbDebug // TypeDefIndex: 7235
{
	// Nested types
	public struct AcbInfo // TypeDefIndex: 7236
	{
		// Fields
		public string name; // 0x00
		public uint size; // 0x08
		public uint version; // 0x0C
		public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
		public float volume; // 0x14
		public int numCues; // 0x18
	}

	private struct AcbInfoForMarshaling // TypeDefIndex: 7237
	{
		// Fields
		public IntPtr namePtr; // 0x00
		public uint size; // 0x08
		public uint version; // 0x0C
		public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
		public float volume; // 0x14
		public int numCues; // 0x18

		// Methods
		public void Convert(out AcbInfo x) {
			x = default;
		} // 0x000000018775C300-0x000000018775C310
	}

	// Methods
	public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo) {
		acbInfo = default;
		return default;
	} // 0x0000000187764FD0-0x0000000187765130
	private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo); // 0x0000000187765130-0x0000000187765260
}

