/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarEntity : CharacterEntity, IAutoAllocRecycle // TypeDefIndex: 19855
{
	// Fields
	public ulong guid; // 0x4E8
	public bool isSupporting; // 0x4F0
	private FixedStack<bool> _activeStack; // 0x4F8
	private List<uint> _childrenRuntimeIds; // 0x500
	private List<uint> _descendantsRuntimeIds; // 0x508
	private bool _attackModeAuto; // 0x510

	// Properties
	public bool IsAttackModeAuto { /* [XID] */ /* 0x00000001898CD140-0x00000001898CD160 */ get => default; } // 0x0000000182584DF0-0x0000000182584EA0 

	// Constructors
	public AvatarEntity() {} // 0x0000000182588940-0x00000001825889D0

	// Methods
	// [XID] // 0x000000018982A9B0-0x000000018982A9D0
	public override EntityType GetTokenEntityType() => default; // 0x0000000182588430-0x00000001825884F0
	// [XID] // 0x0000000189831E00-0x0000000189831E20
	protected override void InitAuthority() {} // 0x0000000182585C70-0x0000000182585E40
	// [XID] // 0x0000000189839400-0x0000000189839420
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFCF60 */, bool runtimeIDChange = false /* Metadata: 0x00AFCF64 */) {} // 0x0000000182586260-0x0000000182586360
	// [XID] // 0x0000000189840A10-0x0000000189840A30
	private void CheckOwnerAndChildrenValid() {} // 0x00000001825881B0-0x0000000182588350
	// [XID] // 0x0000000189847F20-0x0000000189847F40
	public override void Clear(ClearReason clearReason = ClearReason.Invalid /* Metadata: 0x00AFCF65 */) {} // 0x0000000182585F90-0x0000000182586090
	// [XID] // 0x000000018984F660-0x000000018984F680
	public override void SetLightDeactive() {} // 0x0000000182588760-0x0000000182588830
	// [XID] // 0x0000000189856840-0x0000000189856860
	public bool IsAppearred() => default; // 0x0000000182585AB0-0x0000000182585BB0
	// [XID] // 0x000000018985DB10-0x000000018985DB30
	public uint GetUid() => default; // 0x00000001825858E0-0x00000001825859D0
	// [XID] // 0x00000001898655D0-0x00000001898655F0
	public override void DoRevive() {} // 0x0000000182587020-0x0000000182587190
	// [XID] // 0x000000018986CA30-0x000000018986CA50
	public bool IsInAnimatorTag(AvatarData.AvatarTagGroup tagGroup) => default; // 0x0000000182586360-0x0000000182586630
	// [XID] // 0x0000000189873EC0-0x0000000189873EE0
	public override Vector3 GetAbsolutePosition() => default; // 0x0000000182585490-0x0000000182585670
	// [XID] // 0x000000018987B980-0x000000018987B9A0
	public override Vector3 GetRelativePosition() => default; // 0x0000000182585240-0x0000000182585420
	// [XID] // 0x0000000189882B10-0x0000000189882B30
	public override Vector3 GetEulerAngles() => default; // 0x0000000182587B20-0x0000000182587E50
	// [XID] // 0x000000018988A250-0x000000018988A270
	public override Quaternion GetRotation() => default; // 0x0000000182584C70-0x0000000182584DF0
	// [XID] // 0x0000000189891700-0x0000000189891720
	public override List<uint> GetChildrenRuntimeIds() => default; // 0x0000000182588100-0x00000001825881B0
	// [XID] // 0x0000000189899070-0x0000000189899090
	public override void AddChild(uint childRuntimeID) {} // 0x00000001825879F0-0x0000000182587B20
	// [XID] // 0x00000001898A01F0-0x00000001898A0210
	public override void RemoveChild(uint childRuntimeID) {} // 0x00000001825840B0-0x00000001825841A0
	// [XID] // 0x00000001898A79D0-0x00000001898A79F0
	public override void ClearChildren() {} // 0x00000001825885B0-0x0000000182588660
	// [XID] // 0x00000001898AF4D0-0x00000001898AF4F0
	public override void AddDescendants(uint childRuntimeID) {} // 0x0000000182587FD0-0x0000000182588100
	// [XID] // 0x00000001898B68F0-0x00000001898B6910
	public override void RemoveDescendants(uint childRuntimeID) {} // 0x0000000182586710-0x0000000182586800
	// [XID] // 0x00000001898BE100-0x00000001898BE120
	public override void ClearDescendants(bool destroyDescendants = false /* Metadata: 0x00AFCF69 */) {} // 0x00000001825849A0-0x0000000182584C70
	// [XID] // 0x00000001898C5990-0x00000001898C59B0
	public override void DestroyLocalDescendants() {} // 0x0000000182585000-0x0000000182585240
	// [XID] // 0x00000001898D49F0-0x00000001898D4A10
	public void SwitchAttackModeAuto(bool value) {} // 0x0000000182587F20-0x0000000182587FD0
	// [XID] // 0x00000001898DC410-0x00000001898DC430
	public void SwitchAttackMode(bool value) {} // 0x0000000182586AF0-0x0000000182586CE0
	// [XID] // 0x00000001898E3E20-0x00000001898E3E40
	public override void OnClientDisconnect() {} // 0x00000001825859D0-0x0000000182585AB0
	// [XID] // 0x00000001898EB970-0x00000001898EB990
	public override bool IsDisablePause() => default; // 0x00000001825857C0-0x0000000182585860
	// [XID] // 0x00000001898F3160-0x00000001898F3180
	public override bool ShouldCollectEntityToken() => default; // 0x0000000182584010-0x00000001825840B0
	// [XID] // 0x00000001898FA820-0x00000001898FA840
	protected override void SyncBalanceTickAnimatorTickState(bool isTickableDirty) {} // 0x0000000182586F30-0x0000000182587020
	// [XID] // 0x0000000189902370-0x0000000189902390
	public override bool ShouldUseSyncReadyOnCreatedSkillObject() => default; // 0x0000000182588350-0x0000000182588430
	// [XID] // 0x00000001899099A0-0x00000001899099C0
	public override void OnSetComponentEnableDirty() {} // 0x00000001825884F0-0x00000001825885B0
	// [XID] // 0x00000001899110B0-0x00000001899110D0
	public override bool ShouldConsiderComponentEnableWhenAccumulateBudget() => default; // 0x0000000182584EA0-0x0000000182584F40
	// [XID] // 0x0000000189918C90-0x0000000189918CB0
	public void HandleCacheCmd(Dictionary<int, List<BaseCommand>> cmdDic) {} // 0x0000000182586800-0x0000000182586A20
	// [XID] // 0x0000000189920350-0x0000000189920370
	private void HandleCacheCmdInternal(ActorCommandType cmdType, List<BaseCommand> cmdList) {} // 0x0000000182586D40-0x0000000182586E30
	// [XID] // 0x0000000189927B70-0x0000000189927B90
	private void HandleAttach(List<BaseCommand> cmdList) {} // 0x0000000182585E40-0x0000000182585F90
	// [XID] // 0x000000018992F3A0-0x000000018992F3C0
	public void SpawnAttach(string attachName) {} // 0x00000001825844A0-0x00000001825845F0
	// [XID] // 0x00000001899366F0-0x0000000189936710
	public void UnspawnAttach(string attachName) {} // 0x00000001825847E0-0x0000000182584930
	// [XID] // 0x000000018993E2D0-0x000000018993E2F0
	public override void SetAnimatorTrigger(int id) {} // 0x00000001825845F0-0x00000001825847E0
	// [XID] // 0x00000001899458E0-0x0000000189945900
	public override void OnEntityReady() {} // 0x0000000182586E30-0x0000000182586F30
	// [IDTag] // 0x000000018994CD10-0x000000018994CD50
	// [XID] // 0x000000018994CD10-0x000000018994CD50
	public override void SetActive(bool active, bool deepIfInactive = false /* Metadata: 0x00AFCF6A */, bool withGameObj = true /* Metadata: 0x00AFCF6B */, bool isLightActive = false /* Metadata: 0x00AFCF6C */, bool playDefault = true /* Metadata: 0x00AFCF6D */) {} // 0x00000001825878C0-0x00000001825879F0
	// [IDTag] // 0x0000000189957520-0x0000000189957560
	// [XID] // 0x0000000189957520-0x0000000189957560
	public void SetActive(bool active, bool deepIfInactive = false /* Metadata: 0x00AFCF6E */, bool withGameObj = true /* Metadata: 0x00AFCF6F */, bool isLightActive = false /* Metadata: 0x00AFCF70 */, bool playDefault = true /* Metadata: 0x00AFCF71 */, int activeReason = 0 /* Metadata: 0x00AFCF72 */, bool popActiveStack = false /* Metadata: 0x00AFCF76 */) {} // 0x0000000182587390-0x00000001825878C0
	[BlackList] // 0x0000000189962190-0x00000001899621D0
	// [XID] // 0x0000000189962190-0x00000001899621D0
	public override void AutoAllocTypeFields() {} // 0x00000001825841A0-0x0000000182584240
	[BlackList] // 0x000000018996C530-0x000000018996C570
	// [XID] // 0x000000018996C530-0x000000018996C570
	public override void AutoRecycleTypeFields() {} // 0x0000000182584240-0x0000000182584310
	[BlackList] // 0x0000000189976E70-0x0000000189976EB0
	// [XID] // 0x0000000189976E70-0x0000000189976EB0
	public override void ReturnToObjectPool() {} // 0x00000001825888A0-0x0000000182588940
}

