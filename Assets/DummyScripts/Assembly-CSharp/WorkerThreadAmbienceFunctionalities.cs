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

public sealed class WorkerThreadAmbienceFunctionalities : WorkerThreadFunctionalities<SharedAmbienceFunctionalities> // TypeDefIndex: 11257
{
	// Fields
	private readonly WTTreeRustle _treeRustle; // 0x20
	private readonly WTDynamicRegistration _dynamicRegistration; // 0x28
	private readonly WTArea2DAmbience _area2DAmbience; // 0x30
	private SyncId _persistentStageSyncId; // 0x38

	// Properties
	public WTArea2DAmbience area2DAmbience { /* [XID] */ /* 0x00000001896DB9C0-0x00000001896DB9E0 */ get => default; } // 0x0000000183FAF9E0-0x0000000183FAFA80 

	// Constructors
	public WorkerThreadAmbienceFunctionalities() {} // Dummy constructor
	public WorkerThreadAmbienceFunctionalities(WorkerThreadContext context, SharedAmbienceFunctionalities shared) {} // 0x0000000183FAFE20-0x0000000183FAFF10

	// Methods
	// [XID] // 0x00000001896E31C0-0x00000001896E31E0
	public override void Init() {} // 0x0000000183FAF620-0x0000000183FAF6D0
	// [XID] // 0x0000000189690D00-0x0000000189690D20
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000183FAF6D0-0x0000000183FAF860
	// [XID] // 0x00000001896F16F0-0x00000001896F1710
	public override void Destroy() {} // 0x0000000183FAF4D0-0x0000000183FAF570
	// [XID] // 0x0000000189AAC380-0x0000000189AAC3A0
	public void SetPersistentStageSync(SyncId syncId) {} // 0x0000000183FAF340-0x0000000183FAF410
	// [XID] // 0x0000000189B1BB20-0x0000000189B1BB40
	public void PostPersistentStageEvent(uint eventId) {} // 0x0000000183FAF860-0x0000000183FAF9E0
	// [XID] // 0x0000000189708220-0x0000000189708240
	public void StartTreeRustle(float detectRadius, List<Vector3[]> treesInBlocks, uint rtpcId, uint eventId, SyncId syncId) {} // 0x0000000183FAFCC0-0x0000000183FAFE20
	// [XID] // 0x000000018970FC30-0x000000018970FC50
	public void StopTreeRustle() {} // 0x0000000183FAF570-0x0000000183FAF620
	// [XID] // 0x00000001899F04E0-0x00000001899F0500
	public void AddDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000183FAFA80-0x0000000183FAFC10
	// [XID] // 0x000000018971E7E0-0x000000018971E800
	public void RemoveDynamicObject(int id) {} // 0x0000000183FAF410-0x0000000183FAF4D0
	// [XID] // 0x0000000189725FC0-0x0000000189725FE0
	public void ClearDynamicObjects() {} // 0x0000000183FAFC10-0x0000000183FAFCC0
}

