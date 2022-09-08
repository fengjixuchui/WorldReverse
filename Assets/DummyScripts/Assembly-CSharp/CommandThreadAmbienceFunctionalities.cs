/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadAmbienceFunctionalities : CommandThreadFunctionalities<SharedAmbienceFunctionalities> // TypeDefIndex: 11239
{
	// Fields
	private const string PERSISTENT_SYNC_NAME = "Persistent Stage"; // Metadata: 0x00AE9506
	private readonly CTTreeRustle _treeRustle; // 0x20
	private readonly PositionReminder _positionReminder; // 0x28
	private readonly AmbientPositionedEvents _positionedEvents; // 0x30
	private readonly CTDynamicRegistration _dynamicRegistration; // 0x38
	private readonly CTArea2DAmbience _area2DAmbience; // 0x40
	private readonly CTDynamicRay _dynamicRay; // 0x48
	private readonly SyncId _persistentSync; // 0x50

	// Constructors
	public CommandThreadAmbienceFunctionalities() {} // Dummy constructor
	public CommandThreadAmbienceFunctionalities(CommandThreadContext context, SharedAmbienceFunctionalities shared) {} // 0x0000000182FB8050-0x0000000182FB8210

	// Methods
	// [XID] // 0x00000001899C4D30-0x00000001899C4D50
	public override void Init() {} // 0x0000000182FB6F00-0x0000000182FB7100
	// [XID] // 0x00000001897C2780-0x00000001897C27A0
	public override void Tick(float deltaTime) {} // 0x0000000182FB7100-0x0000000182FB7400
	// [XID] // 0x00000001897B2F50-0x00000001897B2F70
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000182FB7770-0x0000000182FB7820
	// [XID] // 0x00000001897BAAD0-0x00000001897BAAF0
	public override void ExitHomeWorld() {} // 0x0000000182FB78C0-0x0000000182FB7960
	// [XID] // 0x00000001899E27C0-0x00000001899E27E0
	public override void ExitGameWorld() {} // 0x0000000182FB7820-0x0000000182FB78C0
	// [XID] // 0x00000001899E9DF0-0x00000001899E9E10
	public override void CreateLevel() {} // 0x0000000182FB6560-0x0000000182FB6600
	// [XID] // 0x00000001899F15D0-0x00000001899F15F0
	public override void EnterLevel() {} // 0x0000000182FB7660-0x0000000182FB7770
	// [XID] // 0x00000001899F8E70-0x00000001899F8E90
	public override void ExitLevel() {} // 0x0000000182FB6DE0-0x0000000182FB6F00
	// [XID] // 0x0000000189A00430-0x0000000189A00450
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000182FB7E30-0x0000000182FB7EE0
	// [XID] // 0x0000000189886D80-0x0000000189886DA0
	public override void Destroy() {} // 0x0000000182FB6A60-0x0000000182FB6B60
	// [XID] // 0x0000000189A0F1C0-0x0000000189A0F1E0
	public AudioPostedEventStatus PostPersistentStageEvent(uint eventId) => default; // 0x0000000182FB7400-0x0000000182FB7560
	// [XID] // 0x0000000189A16840-0x0000000189A16860
	public void StopAllPersistentStageEvents() {} // 0x0000000182FB6C40-0x0000000182FB6D30
	// [XID] // 0x0000000189A1DCE0-0x0000000189A1DD00
	public void RegisterForPositionReminder(IMonoAudioDispositioned mono) {} // 0x0000000182FB66C0-0x0000000182FB6780
	// [XID] // 0x0000000189A25350-0x0000000189A25370
	public void UnregisterPositionReminder(IMonoAudioDispositioned mono) {} // 0x0000000182FB7CC0-0x0000000182FB7D80
	// [XID] // 0x0000000189A2C980-0x0000000189A2C9A0
	public void StartPositionedEventsRotation() {} // 0x0000000182FB7D80-0x0000000182FB7E30
	// [XID] // 0x0000000189A34060-0x0000000189A34080
	public void StopPositionedEventsRotation() {} // 0x0000000182FB7EE0-0x0000000182FB7F90
	// [XID] // 0x0000000189A3B730-0x0000000189A3B750
	public void AddDynamicAmbientObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000182FB7960-0x0000000182FB7AF0
	// [XID] // 0x0000000189A43300-0x0000000189A43320
	public void RemoveDynamicAmbientObject(int id) {} // 0x0000000182FB6600-0x0000000182FB66C0
	// [XID] // 0x0000000189A4A7B0-0x0000000189A4A7D0
	public void InstantiateDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000182FB7AF0-0x0000000182FB7C10
	// [XID] // 0x0000000189874E30-0x0000000189874E50
	public void AdjustDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000182FB6780-0x0000000182FB68A0
	// [XID] // 0x0000000189A59830-0x0000000189A59850
	public void RecycleDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000182FB6440-0x0000000182FB6560
	// [XID] // 0x0000000189631A80-0x0000000189631AA0
	public void DebugStartDynamicRay() {} // 0x0000000182FB6D30-0x0000000182FB6DE0
	// [XID] // 0x0000000189A68EF0-0x0000000189A68F10
	public void DebugStopDynamicRay() {} // 0x0000000182FB7C10-0x0000000182FB7CC0
	// [XID] // 0x0000000189A701C0-0x0000000189A701E0
	private void TickCameraPitchRtpc() {} // 0x0000000182FB7560-0x0000000182FB7660
	// [XID] // 0x0000000189A77A40-0x0000000189A77A60
	private uint GetCameraPtichRptcKey() => default; // 0x0000000182FB6B60-0x0000000182FB6C40
	// [XID] // 0x00000001897F2DE0-0x00000001897F2E00
	private float GetCameraPitchAngle() => default; // 0x0000000182FB68A0-0x0000000182FB6A60
	// [XID] // 0x0000000189A86AE0-0x0000000189A86B00
	public void DynamicRayDebug(RayInfo[] rayInfos) {} // 0x0000000182FB7F90-0x0000000182FB8050
}

