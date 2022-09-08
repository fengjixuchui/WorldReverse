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

public sealed class RoomBoxTrigger : RoomTrigger // TypeDefIndex: 11417
{
	// Fields
	public Vector3 position; // 0x38
	public Quaternion rotation; // 0x44
	public Vector3 halfExtent; // 0x54
	private Matrix4x4 transform; // 0x60

	// Constructors
	public RoomBoxTrigger() {} // Dummy constructor
	public RoomBoxTrigger(SyncId syncId, ulong roomId, Vector3 position, Quaternion rotation, Vector3 size) {} // 0x000000018366AD20-0x000000018366AF80

	// Methods
	// [XID] // 0x00000001898D6FD0-0x00000001898D6FF0
	public override bool SampleAt(Vector3 position) => default; // 0x000000018366AAD0-0x000000018366AC90
}

