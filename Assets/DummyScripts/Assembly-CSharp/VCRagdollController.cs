/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using RootMotion.Dynamics;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCRagdollController : VCBase // TypeDefIndex: 11936
{
	// Fields
	public GameObject _ragdollPrefab; // 0x108
	public QueueState queueState; // 0x110
	private float _lastHitTime; // 0x114
	private uint _lastHitIndex; // 0x118
	private Vector3 _lastRetreatDir; // 0x11C
	private StrikeType _lastHitStrikeType; // 0x128
	private VCStateLayerController _vcStateLayerController; // 0x130
	private PuppetMaster _pptMaster; // 0x138
	private GameObject _animBoneRoot; // 0x140
	private Animator _anim; // 0x148
	private Rigidbody _mainCharacterRB; // 0x150
	private FSMBase<RagdollMode> _fsm; // 0x158
	private ulong _resourcePath; // 0x160
	private uint _resourceHandle; // 0x168
	private AsyncJob _job; // 0x170
	private bool _useRagdollPool; // 0x180
	private bool _isUsingPoolPrefab; // 0x181

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898DCF50-0x00000001898DCF70 */ get => default; } // 0x0000000181A7D560-0x0000000181A7D600 
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public RagdollMode currentState { /* [XID] */ /* 0x00000001898E49F0-0x00000001898E4A10 */ get => default; } // 0x0000000181A7AFA0-0x0000000181A7B050 
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public RagdollMode nextState { /* [XID] */ /* 0x00000001898EC470-0x00000001898EC490 */ get => default; } // 0x0000000181A7AB50-0x0000000181A7AC00 

	// Nested types
	public enum QueueState // TypeDefIndex: 11937
	{
		Limited = 0,
		Active = 1
	}

	// Constructors
	public VCRagdollController() {} // 0x0000000181A7D4A0-0x0000000181A7D560

	// Methods
	// [XID] // 0x00000001898F3D00-0x00000001898F3D20
	public override void Init() {} // 0x0000000181A7ACC0-0x0000000181A7AEE0
	// [XID] // 0x00000001898FB230-0x00000001898FB250
	public override void PreInit() {} // 0x0000000181A7D1F0-0x0000000181A7D2A0
	// [XID] // 0x0000000189A509C0-0x0000000189A509E0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181A7A1E0-0x0000000181A7A2C0
	// [XID] // 0x0000000189B46BC0-0x0000000189B46BE0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181A7D2A0-0x0000000181A7D4A0
	// [XID] // 0x0000000189A6EAC0-0x0000000189A6EAE0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181A7B830-0x0000000181A7B900
	// [XID] // 0x0000000189919920-0x0000000189919940
	private void BeginState(RagdollMode state) {} // 0x0000000181A7BD30-0x0000000181A7C490
	// [XID] // 0x000000018994DC00-0x000000018994DC20
	private void EndState(RagdollMode state) {} // 0x0000000181A7CDF0-0x0000000181A7D0D0
	// [XID] // 0x00000001899288B0-0x00000001899288D0
	private void UpdateState(RagdollMode state) {} // 0x0000000181A7A2C0-0x0000000181A7A410
	// [XID] // 0x000000018992FD30-0x000000018992FD50
	private void TrySwtichRagdollMode(RagdollMode toState, float delay = 0.01f /* Metadata: 0x00AEAF6D */) {} // 0x0000000181A7C490-0x0000000181A7C580
	// [XID] // 0x000000018993C170-0x000000018993C190
	public void SetAttackedFinalPos(uint hitIndex, Vector3 dir, StrikeType strkieType) {} // 0x0000000181A7B140-0x0000000181A7B260
	// [XID] // 0x000000018993ED40-0x000000018993ED60
	public void OnDie() {} // 0x0000000181A7B260-0x0000000181A7B830
	// [XID] // 0x0000000189A76390-0x0000000189A763B0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181A7A560-0x0000000181A7A640
	// [XID] // 0x000000018994DB20-0x000000018994DB40
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000181A7C8E0-0x0000000181A7C9C0
	// [XID] // 0x0000000189955120-0x0000000189955140
	private bool CreateRagdollPrefab() => default; // 0x0000000181A7A640-0x0000000181A7AB50
	// [XID] // 0x0000000189A8CEE0-0x0000000189A8CF00
	public override void Destroy() {} // 0x0000000181A7A490-0x0000000181A7A560
	// [XID] // 0x0000000189A5FAF0-0x0000000189A5FB10
	private void ReleasePoolRagdoll() {} // 0x0000000181A79740-0x0000000181A79840
	// [XID] // 0x000000018996B830-0x000000018996B850
	private bool TryUsePoolRagdollPrefab() => default; // 0x0000000181A7CC80-0x0000000181A7CDF0
	// [XID] // 0x00000001899552C0-0x00000001899552E0
	private void ReturnPoolRagdollPrefab() {} // 0x0000000181A7CA80-0x0000000181A7CC80
	// [XID] // 0x0000000189A57E60-0x0000000189A57E80
	private void DestroyRagdoll() {} // 0x0000000181A7B900-0x0000000181A7BB20
	// [XID] // 0x00000001899DC740-0x00000001899DC760
	private void OnStateIDChangedCallback(EvtStateIDChanged evt) {} // 0x0000000181A798A0-0x0000000181A79AC0
	// [XID] // 0x0000000189989D50-0x0000000189989D70
	public void SetRagdollMode(RagdollMode toState, float delay = 0.01f /* Metadata: 0x00AEAF71 */) {} // 0x0000000181A7B050-0x0000000181A7B140
	// [XID] // 0x0000000189991670-0x0000000189991690
	private bool TryAcquireRagdollLimit() => default; // 0x0000000181A79AC0-0x0000000181A79C00
	// [XID] // 0x0000000189999160-0x0000000189999180
	private void ReleaseRagdollLimit() {} // 0x0000000181A7BC10-0x0000000181A7BD30
	// [XID] // 0x0000000189A94290-0x0000000189A942B0
	private bool IsUseRagdollPool() => default; // 0x0000000181A7D0D0-0x0000000181A7D1F0
	// [XID] // 0x0000000189989EB0-0x0000000189989ED0
	private void LoadRagdollResource() {} // 0x0000000181A7C5F0-0x0000000181A7C8E0
	// [XID] // 0x00000001899D51A0-0x00000001899D51C0
	private void TryRegistStateIdEvent() {} // 0x0000000181A7A090-0x0000000181A7A1E0
	// [XID] // 0x00000001899B70E0-0x00000001899B7100
	private void SetRagdollPrefab(ulong path, bool isSuccess, uint handle, GameObject prefab) {} // 0x0000000181A79C70-0x0000000181A7A090
	// [XID] // 0x00000001899BEB60-0x00000001899BEB80
	private bool IsRagdollInited() => default; // 0x0000000181A7AC00-0x0000000181A7ACC0
	// [XID] // 0x0000000189A85530-0x0000000189A85550
	private void OnRevived() {} // 0x0000000181A7C9C0-0x0000000181A7CA80
}

