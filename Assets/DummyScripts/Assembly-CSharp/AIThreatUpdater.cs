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

public sealed class AIThreatUpdater : BrainModuleBase // TypeDefIndex: 20447
{
	// Fields
	private Dictionary<uint, ThreatInfo> _candidateList; // 0x30
	private Dictionary<uint, ThreatInfo> _threatList; // 0x38
	private List<ThreatInfo> _disqualifiedCandidates; // 0x40
	private List<ThreatInfo> _disqualifiedThreats; // 0x48
	private ThreatInfo _topThreat; // 0x50
	private ThreatInfo _mainTarget; // 0x58
	private float _nextAUXScoreChangeTargetTime; // 0x60
	private bool _forceLeaveCombat; // 0x64
	private LCAIBeta _lcai; // 0x68
	private bool _ignoreLocalPlayer; // 0x70
	private float _expectedFrameTime; // 0x74
	public List<ThreatDebugLogInfo> debugList; // 0x78

	// Constructors
	public AIThreatUpdater() {} // Dummy constructor
	public AIThreatUpdater(LCAIBeta aiComponent, AIKnowledge knowledge) {} // 0x00000001812FFCF0-0x00000001812FFE30

	// Methods
	// [XID] // 0x000000018998A8C0-0x000000018998A8E0
	protected override void ClearInternal(BaseEntity.ClearReason reason) {} // 0x00000001812FA570-0x00000001812FA630
	// [XID] // 0x0000000189992160-0x0000000189992180
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x00000001812FA6B0-0x00000001812FA760
	// [XID] // 0x0000000189999F30-0x0000000189999F50
	protected override void UpdateComputeThreadInternal(float deltaTime) {} // 0x00000001812F9930-0x00000001812F9C00
	// [XID] // 0x00000001899A15B0-0x00000001899A15D0
	public void AddThreatByTauntMTC(uint runtimeID) {} // 0x00000001812FD7C0-0x00000001812FD920
	// [XID] // 0x00000001899A8FA0-0x00000001899A8FC0
	private void InternalAddThreat(ThreatInfo threatInfo, bool jobThread) {} // 0x00000001812F8D20-0x00000001812F9590
	// [XID] // 0x00000001899B0A50-0x00000001899B0A70
	private void InternalRemoveThreat(uint id) {} // 0x00000001812FE3A0-0x00000001812FE570
	// [XID] // 0x0000000189A180F0-0x0000000189A18110
	public void ExternalAddThreat(uint runtimeID, Vector3 pos, ThreatAddReason reason, float threatIncrementAmount, bool jobThread = false /* Metadata: 0x00AFDAB5 */) {} // 0x00000001812FD920-0x00000001812FDB40
	// [XID] // 0x00000001899BF7B0-0x00000001899BF7D0
	public void ExternalAddCandidate(uint runtimeID, Vector3 pos, ThreatAddReason reason, float temperatureIncrementAmount) {} // 0x00000001812F9710-0x00000001812F9930
	// [XID] // 0x00000001899C7110-0x00000001899C7130
	public void OnEnterCombatMTC() {} // 0x00000001812FE930-0x00000001812FECF0
	// [XID] // 0x00000001899CE630-0x00000001899CE650
	public void OnLeaveCombatMTC(List<ThreatDebugLogInfo> debugInfoList) {} // 0x00000001812FA0B0-0x00000001812FA260
	// [XID] // 0x00000001899D5D10-0x00000001899D5D30
	public void OnAvatarBecomeThreatMTC(uint avatarID, bool becomeThreat) {} // 0x00000001812F9590-0x00000001812F9710
	// [XID] // 0x00000001899DD160-0x00000001899DD180
	private void UpdateCandidateList() {} // 0x00000001812FC830-0x00000001812FCD00
	// [XID] // 0x00000001899E4D60-0x00000001899E4D80
	private void UpdateCandidateFromSensibles() {} // 0x00000001812FE570-0x00000001812FE930
	// [XID] // 0x00000001899EC1F0-0x00000001899EC210
	private bool CheckAvatarFootstep(AISensingKnowledge.SensibleInfo sensible) => default; // 0x00000001812FCD00-0x00000001812FCEF0
	// [XID] // 0x00000001899F3C50-0x00000001899F3C70
	private void ProcessSensible(AISensingKnowledge.SensibleInfo sensible, ThreatAddReason sourceType) {} // 0x00000001812FADB0-0x00000001812FB170
	// [XID] // 0x00000001899FB4D0-0x00000001899FB4F0
	private bool ValidateCandidate(ThreatInfo candidate) => default; // 0x00000001812FECF0-0x00000001812FEEE0
	// [XID] // 0x0000000189A02770-0x0000000189A02790
	private void UpdateThreatList() {} // 0x00000001812F9C80-0x00000001812FA0B0
	// [XID] // 0x0000000189A09F00-0x0000000189A09F20
	private bool ValidateThreat(ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) => default; // 0x00000001812FDB40-0x00000001812FE3A0
	// [XID] // 0x0000000189A11760-0x0000000189A11780
	private void SelectTarget() {} // 0x00000001812FEEE0-0x00000001812FF3F0
	// [XID] // 0x0000000189A18AD0-0x0000000189A18AF0
	private void UpdateAIKnowledges() {} // 0x00000001812FF3F0-0x00000001812FFCF0
	// [XID] // 0x0000000189A9BD70-0x0000000189A9BD90
	public void OnBeingHit(BaseEntity attacker) {} // 0x00000001812FB3C0-0x00000001812FB760
	// [IDTag] // 0x0000000189A27580-0x0000000189A275C0
	// [XID] // 0x0000000189A27580-0x0000000189A275C0
	public void HandleEvent(EvtAvatarChanged e) {} // 0x00000001812FD150-0x00000001812FD440
	// [IDTag] // 0x0000000189A319D0-0x0000000189A31A10
	// [XID] // 0x0000000189A319D0-0x0000000189A31A10
	public void HandleEvent(EvtAISoundBroadcast e) {} // 0x00000001812FCEF0-0x00000001812FD150
	// [IDTag] // 0x0000000189A3C140-0x0000000189A3C180
	// [XID] // 0x0000000189A3C140-0x0000000189A3C180
	public void HandleEvent(EvtAISoundAttraction e) {} // 0x00000001812FD440-0x00000001812FD7C0
	// [XID] // 0x0000000189A46A90-0x0000000189A46AB0
	public void ForceEnterCombat() {} // 0x00000001812FA7D0-0x00000001812FADB0
	// [XID] // 0x0000000189A4E250-0x0000000189A4E270
	public void ForceLeaveCombat() {} // 0x00000001812FC510-0x00000001812FC830
	// [XID] // 0x0000000189A55B00-0x0000000189A55B20
	private void CollectThreatListInfoInMainThread() {} // 0x00000001812FB760-0x00000001812FBAD0
	// [XID] // 0x0000000189A5D320-0x0000000189A5D340
	private void UpdateThreatAuxScoreSystem(ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) {} // 0x00000001812FB170-0x00000001812FB3C0
	// [XID] // 0x0000000189A64CC0-0x0000000189A64CE0
	private void DebugLogValidateThreat(ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo, ThreatRemoveReason removeReason) {} // 0x00000001812FA260-0x00000001812FA570
	// [XID] // 0x0000000189A01BA0-0x0000000189A01BC0
	private void DebugLogToServer(List<ThreatDebugLogInfo> debugInfoList) {} // 0x00000001812FBAD0-0x00000001812FC510
}

