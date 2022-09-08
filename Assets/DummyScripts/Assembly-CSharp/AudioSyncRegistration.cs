/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AudioSyncRegistration // TypeDefIndex: 11439
{
	// Fields
	private readonly WorkerThreadContext _context; // 0x10
	private readonly HashSet<ulong> _constantSyncs; // 0x18
	private readonly OnUnregisterSyncCallback _callback; // 0x20

	// Properties
	public int totalSyncsCount { /* [XID] */ /* 0x00000001896C0FE0-0x00000001896C1000 */ get => default; } // 0x0000000183C1F720-0x0000000183C1F7E0 

	// Constructors
	public AudioSyncRegistration() {} // Dummy constructor
	public AudioSyncRegistration(WorkerThreadContext context, OnUnregisterSyncCallback callback) {} // 0x0000000183C1FAE0-0x0000000183C1FBA0

	// Methods
	// [XID] // 0x0000000189B158A0-0x0000000189B158C0
	public void RegisterSync(SyncId syncId) {} // 0x0000000183C1F7E0-0x0000000183C1F930
	// [XID] // 0x00000001895EFF40-0x00000001895EFF60
	public void UnregisterSync(SyncId syncId) {} // 0x0000000183C1F3F0-0x0000000183C1F560
	// [IDTag] // 0x00000001896D7320-0x00000001896D7360
	// [XID] // 0x00000001896D7320-0x00000001896D7360
	public bool QueryIfSyncIsRegistered(SyncId syncId) => default; // 0x0000000183C1FA00-0x0000000183C1FAE0
	// [IDTag] // 0x00000001896E1A60-0x00000001896E1AA0
	// [XID] // 0x00000001896E1A60-0x00000001896E1AA0
	public bool QueryIfSyncIsRegistered(ulong gameObjectId) => default; // 0x0000000183C1F930-0x0000000183C1FA00
	// [XID] // 0x00000001896EBE50-0x00000001896EBE70
	public void UpdateSyncTransform(SyncId syncId, Vector3 position, Quaternion rotation) {} // 0x0000000183C1F560-0x0000000183C1F720
}

