/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExBeatSync // TypeDefIndex: 7028
{
	// Nested types
	public struct Info // TypeDefIndex: 7029
	{
		// Fields
		public IntPtr playerHn; // 0x00
		public uint playbackId; // 0x08
		public uint barCount; // 0x0C
		public uint beatCount; // 0x10
		public float beatProgress; // 0x14
		public float bpm; // 0x18
		public uint numBeats; // 0x1C
	}

	// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
	public delegate void CbFunc(ref Info info); // TypeDefIndex: 7030; 0x00000001877A2D60-0x00000001877A2EF0

	// Methods
	public static void SetCallback(CbFunc func) {} // 0x00000001877A4D00-0x00000001877A4D90
}

