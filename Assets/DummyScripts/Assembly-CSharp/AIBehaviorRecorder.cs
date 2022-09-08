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

public class AIBehaviorRecorder // TypeDefIndex: 20503
{
	// Fields
	public const int RECORD_FRAMES_COUNT = 300; // Metadata: 0x00AFDB66
	private Dictionary<uint, AIBehaviorRecordEntry> _behaviorRecord; // 0x10
	private Dictionary<uint, List<string>> _keyNotesThisFrame; // 0x18

	// Constructors
	public AIBehaviorRecorder() {} // 0x0000000181722910-0x00000001817229C0

	// Methods
	// [XID] // 0x000000018995EE90-0x000000018995EEB0
	public void Clear() {} // 0x0000000181722610-0x00000001817226E0
	// [XID] // 0x0000000189606490-0x00000001896064B0
	public void ClearNotes() {} // 0x00000001817226E0-0x0000000181722790
	// [XID] // 0x000000018996DA90-0x000000018996DAB0
	public void AddKeyNote(uint runtimeID, string note) {} // 0x0000000181722790-0x0000000181722910
	// [XID] // 0x0000000189BD4290-0x0000000189BD42B0
	public void AddFrameEndRecord(LCAIBeta ai, BaseEntity localAvatar) {} // 0x0000000181721790-0x0000000181722610
}

