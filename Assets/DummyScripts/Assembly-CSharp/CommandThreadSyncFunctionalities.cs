/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadSyncFunctionalities : CommandThreadFunctionalities<SharedSyncFunctionalities> // TypeDefIndex: 11440
{
	// Fields
	private readonly AudioEcoSyncTicker _ecoSyncTicker; // 0x20
	private readonly AudioEmitterTicker _emitterTicker; // 0x28
	private readonly AudioLossTicker _lossTicker; // 0x30
	private readonly AudioRooTicker _rooTicker; // 0x38
	private readonly AudioSyncTicker _syncTicker; // 0x40
	private int _workerReportedSyncsCount; // 0x48

	// Properties
	public int workerReportedSyncsCount { /* [XID] */ /* 0x000000018973CAB0-0x000000018973CAD0 */ get => default; } // 0x0000000183A5B030-0x0000000183A5B0D0 

	// Constructors
	public CommandThreadSyncFunctionalities() {} // Dummy constructor
	public CommandThreadSyncFunctionalities(CommandThreadContext context, SharedSyncFunctionalities shared) {} // 0x0000000183A5B460-0x0000000183A5B590

	// Methods
	// [XID] // 0x00000001896FAC70-0x00000001896FAC90
	public override void Init() {} // 0x0000000183A59110-0x0000000183A591B0
	// [XID] // 0x0000000189702280-0x00000001897022A0
	public override void Tick(float deltaTime) {} // 0x0000000183A591B0-0x0000000183A59520
	// [XID] // 0x00000001897099C0-0x00000001897099E0
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000183A5A7B0-0x0000000183A5A860
	// [XID] // 0x00000001897114B0-0x00000001897114D0
	public override void ExitHomeWorld() {} // 0x0000000183A5AC60-0x0000000183A5AD00
	// [XID] // 0x0000000189718980-0x00000001897189A0
	public override void ExitGameWorld() {} // 0x0000000183A5A930-0x0000000183A5A9D0
	// [XID] // 0x00000001897ACDF0-0x00000001897ACE10
	public override void CreateLevel() {} // 0x0000000183A58D20-0x0000000183A58DC0
	// [XID] // 0x0000000189727880-0x00000001897278A0
	public override void EnterLevel() {} // 0x0000000183A5A710-0x0000000183A5A7B0
	// [XID] // 0x00000001898B0340-0x00000001898B0360
	public override void ExitLevel() {} // 0x0000000183A59070-0x0000000183A59110
	// [XID] // 0x0000000189736530-0x0000000189736550
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000183A5B300-0x0000000183A5B3B0
	// [XID] // 0x000000018973E340-0x000000018973E360
	public override void Destroy() {} // 0x0000000183A58DC0-0x0000000183A58E60
	// [XID] // 0x0000000189745610-0x0000000189745630
	public void Stop() {} // 0x0000000183A58BF0-0x0000000183A58D20
	// [XID] // 0x000000018974D110-0x000000018974D130
	public void UnregisterSync(SyncId syncId) {} // 0x0000000183A58E60-0x0000000183A58F70
	// [XID] // 0x00000001897E9920-0x00000001897E9940
	public void RegisterWildSync(SyncId syncId) {} // 0x0000000183A5A9D0-0x0000000183A5AAE0
	// [XID] // 0x000000018975B950-0x000000018975B970
	public void RegisterAutoSync(SyncId syncId, Transform t, bool @static, bool occEnabled) {} // 0x0000000183A5AAE0-0x0000000183A5AC60
	// [XID] // 0x0000000189763380-0x00000001897633A0
	public void UnregisterAutoSync(SyncId syncId) {} // 0x0000000183A5AF10-0x0000000183A5B030
	// [XID] // 0x000000018976AB10-0x000000018976AB30
	public void ImpelTickAutoSync(SyncId syncId) {} // 0x0000000183A59D30-0x0000000183A59E20
	// [IDTag] // 0x00000001897720D0-0x0000000189772110
	// [XID] // 0x00000001897720D0-0x0000000189772110
	public void UpdateSyncTransform(SyncId syncId, Transform t) {} // 0x0000000183A59E20-0x0000000183A59FF0
	// [IDTag] // 0x000000018977C680-0x000000018977C6C0
	// [XID] // 0x000000018977C680-0x000000018977C6C0
	public void UpdateSyncTransform(SyncId syncId, Vector3 position, Quaternion rotaion) {} // 0x0000000183A59FF0-0x0000000183A5A170
	// [IDTag] // 0x0000000189786F40-0x0000000189786F80
	// [XID] // 0x0000000189786F40-0x0000000189786F80
	public void SetRtpcValue(uint hashId, float value, SyncId syncId) {} // 0x0000000183A59520-0x0000000183A59660
	// [IDTag] // 0x0000000189791510-0x0000000189791550
	// [XID] // 0x0000000189791510-0x0000000189791550
	public void SetRtpcValue(uint hashId, float value) {} // 0x0000000183A59660-0x0000000183A59760
	// [XID] // 0x000000018979C590-0x000000018979C5B0
	public void SetSwitch(uint nameId, uint valueId, SyncId syncId) {} // 0x0000000183A5B1C0-0x0000000183A5B300
	// [XID] // 0x00000001897A3AD0-0x00000001897A3AF0
	public void SetState(uint nameId, uint valueId) {} // 0x0000000183A58F70-0x0000000183A59070
	// [XID] // 0x00000001899703C0-0x00000001899703E0
	public void AddEcoSync(ReusedAudioSync ecoSync) {} // 0x0000000183A5A860-0x0000000183A5A930
	// [XID] // 0x00000001897B2B50-0x00000001897B2B70
	public void RegisterRearwardObstructionOcclusion(MonoAudioRearwardObstructionOcclusion mono) {} // 0x0000000183A5AE40-0x0000000183A5AF10
	// [XID] // 0x00000001897BA620-0x00000001897BA640
	public void SetObstructionOcclusion(SyncId syncId, float obstructionLevel, float occlusionLevel) {} // 0x0000000183A59BD0-0x0000000183A59D30
	// [XID] // 0x00000001897AFE30-0x00000001897AFE50
	public void SetMultiPosition(SyncId syncId, Vector3[] offsets, Vector3 rootPosition, Quaternion rootRotation, Vector3 rootScale, AkMultiPositionType multiPositionType) {} // 0x0000000183A5A170-0x0000000183A5A390
	// [IDTag] // 0x00000001897C9C80-0x00000001897C9CC0
	// [XID] // 0x00000001897C9C80-0x00000001897C9CC0
	public void SpawnEventEmitter(string configName, AudioEmitterMovement movement, object requester) {} // 0x0000000183A5A5B0-0x0000000183A5A710
	// [IDTag] // 0x00000001897D4460-0x00000001897D44A0
	// [XID] // 0x00000001897D4460-0x00000001897D44A0
	public void SpawnEventEmitter(string configName, AudioEmitterMovement movement, AudioEmitterLifetime lifetime, object requester) {} // 0x0000000183A5A390-0x0000000183A5A5B0
	// [XID] // 0x00000001897DEB80-0x00000001897DEBA0
	public void AddToLossMonitor(SyncId syncId) {} // 0x0000000183A5AD00-0x0000000183A5AE40
	// [XID] // 0x00000001897E65B0-0x00000001897E65D0
	public void RemoveFromLossMonitor(SyncId syncId) {} // 0x0000000183A5B0D0-0x0000000183A5B1C0
	// [XID] // 0x00000001897EE0E0-0x00000001897EE100
	private AudioPositionArray BuildPositionArray(Vector3[] offsets, Vector3 rootPosition, Quaternion rootRotation, Vector3 rootScale) => default; // 0x0000000183A59760-0x0000000183A59BD0
	// [XID] // 0x00000001897F5840-0x00000001897F5860
	public void UpdateWorkerSyncsCountInfo(int count) {} // 0x0000000183A5B3B0-0x0000000183A5B460
}

