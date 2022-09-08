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

public sealed class WorkerThreadSyncFunctionalities : WorkerThreadFunctionalities<SharedSyncFunctionalities> // TypeDefIndex: 11443
{
	// Fields
	private readonly AudioRtpcCache _rtpcCache; // 0x20
	private readonly AudioStateCache _stateCache; // 0x28
	private readonly AudioSwitchCache _switchCache; // 0x30
	private readonly AudioPositionCache _positionCache; // 0x38
	private readonly AudioSyncRegistration _syncRegistration; // 0x40
	private readonly DelayedUnregistrationTicker _delayedUnregs; // 0x48

	// Constructors
	public WorkerThreadSyncFunctionalities() {} // Dummy constructor
	public WorkerThreadSyncFunctionalities(WorkerThreadContext context, SharedSyncFunctionalities shared) {} // 0x0000000182A5D450-0x0000000182A5D5D0

	// Methods
	// [XID] // 0x0000000189A29C60-0x0000000189A29C80
	public override void Init() {} // 0x0000000182A5B4D0-0x0000000182A5B570
	// [XID] // 0x0000000189A56900-0x0000000189A56920
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000182A5B570-0x0000000182A5B660
	// [XID] // 0x0000000189A65CE0-0x0000000189A65D00
	public override void Destroy() {} // 0x0000000182A5AE50-0x0000000182A5AF10
	// [XID] // 0x0000000189AF0B80-0x0000000189AF0BA0
	public void RegisterSync(SyncId syncId) {} // 0x0000000182A5D2F0-0x0000000182A5D450
	// [XID] // 0x0000000189831160-0x0000000189831180
	public void UnregisterSync(SyncId syncId) {} // 0x0000000182A5B120-0x0000000182A5B280
	// [XID] // 0x0000000189838960-0x0000000189838980
	public bool IsUnregistrationDelayed(SyncId syncId) => default; // 0x0000000182A5AF10-0x0000000182A5B000
	// [XID] // 0x0000000189A6D2F0-0x0000000189A6D310
	private void OnRealUnregisterSync(SyncId syncId) {} // 0x0000000182A5BFC0-0x0000000182A5C180
	// [XID] // 0x0000000189847520-0x0000000189847540
	public void PostStopAllEventOnSyncUnregister(SyncId syncId) {} // 0x0000000182A5C450-0x0000000182A5C5D0
	// [XID] // 0x000000018984EC40-0x000000018984EC60
	public void IncreaseUnregistrationPrevention(SyncId syncId) {} // 0x0000000182A5B000-0x0000000182A5B120
	// [XID] // 0x00000001899FD890-0x00000001899FD8B0
	public void DecreaseUnregistrationPrevention(SyncId syncId) {} // 0x0000000182A5BED0-0x0000000182A5BFC0
	// [XID] // 0x000000018985D0A0-0x000000018985D0C0
	public void UpdateSyncTransform(SyncId syncId, Vector3 position, Quaternion rotation) {} // 0x0000000182A5BC80-0x0000000182A5BED0
	// [IDTag] // 0x0000000189864B30-0x0000000189864B70
	// [XID] // 0x0000000189864B30-0x0000000189864B70
	public void UpdateSyncMultiTransform(ulong gameObjectId, AudioPositionArray positionArray, AkMultiPositionType multiPositionType) {} // 0x0000000182A5C5D0-0x0000000182A5C760
	// [IDTag] // 0x000000018986F060-0x000000018986F0A0
	// [XID] // 0x000000018986F060-0x000000018986F0A0
	public void UpdateSyncMultiTransform(SyncId syncId, AudioPositionArray positionArray, AkMultiPositionType multiPositionType) {} // 0x0000000182A5C760-0x0000000182A5C930
	// [IDTag] // 0x00000001898796D0-0x0000000189879710
	// [XID] // 0x00000001898796D0-0x0000000189879710
	public bool QueryIfGameObjectIsRegistered(SyncId syncId) => default; // 0x0000000182A5B940-0x0000000182A5BA30
	// [IDTag] // 0x0000000189883710-0x0000000189883750
	// [XID] // 0x0000000189883710-0x0000000189883750
	public bool QueryIfGameObjectIsRegistered(ulong gameObjectId) => default; // 0x0000000182A5B870-0x0000000182A5B940
	// [IDTag] // 0x000000018988DBB0-0x000000018988DBF0
	// [XID] // 0x000000018988DBB0-0x000000018988DBF0
	public void SetRtpcValue(uint hashId, float value, SyncId syncId) {} // 0x0000000182A5B740-0x0000000182A5B870
	// [IDTag] // 0x00000001898981E0-0x0000000189898220
	// [XID] // 0x00000001898981E0-0x0000000189898220
	public void SetRtpcValue(uint hashId, float value) {} // 0x0000000182A5B660-0x0000000182A5B740
	// [XID] // 0x00000001898A2870-0x00000001898A2890
	public void SetSwitch(uint hashId, uint value, SyncId syncId) {} // 0x0000000182A5D170-0x0000000182A5D2F0
	// [XID] // 0x0000000189639650-0x0000000189639670
	public void ClearSwitchCacheOnSync(SyncId syncId) {} // 0x0000000182A5C360-0x0000000182A5C450
	// [XID] // 0x0000000189A611F0-0x0000000189A61210
	public void SetState(uint hashId, uint value) {} // 0x0000000182A5B280-0x0000000182A5B3E0
	// [XID] // 0x0000000189770AE0-0x0000000189770B00
	public void GetEffectiveStates(Dictionary<uint, uint> map) {} // 0x0000000182A5CCB0-0x0000000182A5CD70
	// [XID] // 0x000000018967A0A0-0x000000018967A0C0
	public void GetEffectiveSwitchesOnGameObject(ulong gameObjectId, Dictionary<uint, uint> map) {} // 0x0000000182A5C280-0x0000000182A5C360
	// [XID] // 0x0000000189A92ED0-0x0000000189A92EF0
	public void MarkEventStartOnSync(EventInstance eventInstance) {} // 0x0000000182A5C180-0x0000000182A5C280
	// [XID] // 0x0000000189A9A9C0-0x0000000189A9A9E0
	public void MarkEventStopOnSync(EventInstance eventInstance) {} // 0x0000000182A5CD70-0x0000000182A5CE70
	// [XID] // 0x00000001897C1170-0x00000001897C1190
	public void SetObstructionOcclusion(SyncId syncId, float obstructionLevel, float occlusionLevel) {} // 0x0000000182A5BA30-0x0000000182A5BC80
	// [IDTag] // 0x00000001898DEE10-0x00000001898DEE50
	// [XID] // 0x00000001898DEE10-0x00000001898DEE50
	public bool TryGetCachePosition(SyncId syncId, out Vector3 position) {
		position = default;
		return default;
	} // 0x0000000182A5CE70-0x0000000182A5CF80
	// [IDTag] // 0x00000001898E9930-0x00000001898E9970
	// [XID] // 0x00000001898E9930-0x00000001898E9970
	public bool TryGetCachePosition(ulong gameObjectId, out Vector3 position) {
		position = default;
		return default;
	} // 0x0000000182A5CF80-0x0000000182A5D060
	// [IDTag] // 0x00000001898F3EA0-0x00000001898F3EE0
	// [XID] // 0x00000001898F3EA0-0x00000001898F3EE0
	public bool TryGetCacheDistanceSqrTo(SyncId syncId, Vector3 position, out float distanceSqr) {
		distanceSqr = default;
		return default;
	} // 0x0000000182A5CB60-0x0000000182A5CCB0
	// [IDTag] // 0x00000001898FE6E0-0x00000001898FE720
	// [XID] // 0x00000001898FE6E0-0x00000001898FE720
	public bool TryGetCacheDistanceSqrTo(ulong gameObjectId, Vector3 position, out float distanceSqr) {
		distanceSqr = default;
		return default;
	} // 0x0000000182A5CA40-0x0000000182A5CB60
	// [XID] // 0x0000000189A7C6C0-0x0000000189A7C6E0
	private void AddToLossMonitor(SyncId syncId) {} // 0x0000000182A5C930-0x0000000182A5CA40
	// [XID] // 0x0000000189AA1AC0-0x0000000189AA1AE0
	private void RemoveFromLossMonitor(SyncId syncId) {} // 0x0000000182A5D060-0x0000000182A5D170
	// [XID] // 0x0000000189918020-0x0000000189918040
	private void ReportTotalSyncsCount() {} // 0x0000000182A5B3E0-0x0000000182A5B4D0
}

