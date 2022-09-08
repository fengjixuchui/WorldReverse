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

public class AudioCombinedSwitches : IEnumerator<AudioCombinedSwitches.Switch> // TypeDefIndex: 10938
{
	// Fields
	private const int DEFAULT_CAPACITY = 4; // Metadata: 0x00AE8AE0
	private Switch[] _switches; // 0x10
	private int _nextIndex; // 0x18
	private int _enumIndex; // 0x1C

	// Properties
	object IEnumerator.Current { /* [XID] */ /* 0x000000018979A410-0x000000018979A430 */ get => default; } // 0x00000001850C2E80-0x00000001850C2F40 
	public Switch Current { /* [XID] */ /* 0x0000000189A15550-0x0000000189A15570 */ get => default; } // 0x00000001850C3050-0x00000001850C3130 

	// Nested types
	public struct Switch // TypeDefIndex: 10939
	{
		// Properties
		public uint key { /* [XID] */ /* 0x00000001897E4E70-0x00000001897E4EB0 */ get; /* [XID] */ /* 0x00000001897EF940-0x00000001897EF980 */ set; } // 0x00000001850BF7E0-0x00000001850BF840 0x00000001850BF960-0x00000001850BF9C0
		public uint value { /* [XID] */ /* 0x00000001897FA430-0x00000001897FA470 */ get; /* [XID] */ /* 0x0000000189804780-0x00000001898047C0 */ set; } // 0x00000001850BF900-0x00000001850BF960 0x00000001850BF840-0x00000001850BF900
	}

	// Constructors
	public AudioCombinedSwitches(int capacity) {} // 0x00000001850C2F40-0x00000001850C2FE0
	public AudioCombinedSwitches() {} // 0x00000001850C2FE0-0x00000001850C3050

	// Methods
	// [XID] // 0x0000000189A24070-0x0000000189A24090
	public AudioCombinedSwitches Add(uint key, uint value) => default; // 0x00000001850C2B60-0x00000001850C2D30
	// [XID] // 0x00000001897A9A20-0x00000001897A9A40
	public void Clear() {} // 0x00000001850C2A80-0x00000001850C2B60
	// [XID] // 0x00000001897B1260-0x00000001897B1280
	public bool MoveNext() => default; // 0x00000001850C2D30-0x00000001850C2DE0
	// [XID] // 0x0000000189AE60E0-0x0000000189AE6100
	public void Reset() {} // 0x00000001850C2DE0-0x00000001850C2E80
	// [XID] // 0x00000001897C0F10-0x00000001897C0F30
	public void Dispose() {} // 0x00000001850C29E0-0x00000001850C2A80
	// [XID] // 0x00000001897C88B0-0x00000001897C88D0
	private void Expand() {} // 0x00000001850C28E0-0x00000001850C29E0
}

