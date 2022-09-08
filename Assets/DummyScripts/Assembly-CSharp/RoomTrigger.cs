/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class RoomTrigger // TypeDefIndex: 11416
{
	// Fields
	public static ulong INVALID_TRIGGER_ID; // 0x00
	public SyncId syncId; // 0x10
	public ulong roomId; // 0x28
	public RoomTriggerType type; // 0x30

	// Constructors
	protected RoomTrigger() {} // Dummy constructor
	public RoomTrigger(SyncId syncId, ulong roomId) {} // 0x0000000182E17D10-0x0000000182E17DE0
	static RoomTrigger() {} // 0x0000000182E17CB0-0x0000000182E17D10

	// Methods
	// [XID] // 0x0000000189BD89E0-0x0000000189BD8A00
	public virtual bool SampleAt(Vector3 position) => default; // 0x0000000182E17BF0-0x0000000182E17CB0
}

