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

public class AudioSyncPropertyEqualityComparer : IEqualityComparer<AudioSyncProperty> // TypeDefIndex: 11428
{
	// Nested types
	private struct UnionStruct // TypeDefIndex: 11429
	{
		// Fields
		public ulong value64; // 0x00
		public int low32; // 0x00
		public int high32; // 0x04
		public uint valueU32; // 0x08
		public int valueI32; // 0x08
	}

	// Constructors
	public AudioSyncPropertyEqualityComparer() {} // 0x0000000184248170-0x00000001842481D0

	// Methods
	// [XID] // 0x00000001898C6870-0x00000001898C6890
	public bool Equals(AudioSyncProperty x, AudioSyncProperty y) => default; // 0x0000000184247F70-0x0000000184248090
	// [XID] // 0x00000001898A86A0-0x00000001898A86C0
	public int GetHashCode(AudioSyncProperty obj) => default; // 0x0000000184248090-0x0000000184248170
}

