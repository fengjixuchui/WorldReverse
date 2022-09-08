/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ScenePropEntity : GadgetEntity, IAutoAllocRecycle // TypeDefIndex: 19884
{
	// Fields
	protected bool _isSyncFromSever; // 0x558
	public long objId; // 0x560
	public bool isClientEntity; // 0x568
	private Action<long> removeCallback; // 0x570
	public Action onEntitySynced; // 0x578
	public bool needToBeDestroy; // 0x580
	private static readonly MassiveEntityTickBalanceProxy massiveEntitySharedBalanceTickProxy; // 0x00

	// Properties
	public bool IsSyncedFromServer { /* [XID] */ /* 0x00000001897CFF50-0x00000001897CFF70 */ get => default; /* [XID] */ /* 0x00000001897920C0-0x00000001897920E0 */ set {} } // 0x00000001817949D0-0x0000000181794A80 0x00000001817951B0-0x0000000181795260

	// Constructors
	public ScenePropEntity() {} // 0x0000000181796DB0-0x0000000181796E60
	static ScenePropEntity() {} // 0x0000000181796D30-0x0000000181796DB0

	// Methods
	// [XID] // 0x0000000189714B10-0x0000000189714B30
	protected void InitScenePropRequired() {} // 0x0000000181795F80-0x0000000181796040
	// [XID] // 0x000000018971C4E0-0x000000018971C500
	public override bool CanReuseEntity() => default; // 0x00000001817953A0-0x0000000181795440
	// [XID] // 0x00000001897239D0-0x00000001897239F0
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFCFEE */) {} // 0x0000000181795760-0x0000000181795840
	// [XID] // 0x000000018972B0D0-0x000000018972B0F0
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFCFF2 */, bool runtimeIDChange = false /* Metadata: 0x00AFCFF6 */) {} // 0x0000000181795C20-0x0000000181795D10
	// [XID] // 0x0000000189732860-0x0000000189732880
	public override void Clear(ClearReason clearReason = ClearReason.Invalid /* Metadata: 0x00AFCFF7 */) {} // 0x0000000181795AA0-0x0000000181795B60
	// [XID] // 0x0000000189739F80-0x0000000189739FA0
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x0000000181795040-0x0000000181795130
	// [XID] // 0x0000000189741B00-0x0000000189741B20
	public void Reset() {} // 0x00000001817952C0-0x00000001817953A0
	// [XID] // 0x0000000189749400-0x0000000189749420
	public void SetRemoveCallback(Action<long> action) {} // 0x00000001817959F0-0x0000000181795AA0
	// [XID] // 0x00000001897508C0-0x00000001897508E0
	public virtual void RealSetToBeRemoved() {} // 0x00000001817968A0-0x0000000181796970
	public override bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AFCFFB */, bool isRecoverFromServer = false /* Metadata: 0x00AFCFFC */) => default;
	// [XID] // 0x0000000189757DD0-0x0000000189757DF0
	protected override void InitAuthority() {} // 0x00000001817958E0-0x00000001817959F0
	// [XID] // 0x000000018975F890-0x000000018975F8B0
	public override long GetScenePropID() => default; // 0x0000000181796320-0x00000001817963D0
	// [XID] // 0x0000000189766D40-0x0000000189766D60
	public virtual float GetBoundsMagnitude() => default; // 0x0000000181796480-0x0000000181796530
	// [IDTag] // 0x000000018976E2A0-0x000000018976E2E0
	// [XID] // 0x000000018976E2A0-0x000000018976E2E0
	public virtual Vector3 GetHitPosition(Vector3 center, Vector3 extents) => default; // 0x0000000181795E30-0x0000000181795F80
	// [IDTag] // 0x0000000189778CC0-0x0000000189778D00
	// [XID] // 0x0000000189778CC0-0x0000000189778D00
	public virtual Vector3 GetHitPosition(Vector3 center, float radius) => default; // 0x0000000181795D10-0x0000000181795E30
	// [XID] // 0x00000001897833D0-0x00000001897833F0
	public override Transform GetAttachPoint(string name) => default; // 0x0000000181795440-0x0000000181795500
	// [XID] // 0x00000001897996F0-0x0000000189799710
	public void SyncFromServer(uint entityId, uint peerId, uint configId) {} // 0x0000000181794DD0-0x0000000181794FD0
	// [XID] // 0x00000001897A1500-0x00000001897A1520
	protected override void AllocateTickBalanceProxy() {} // 0x0000000181794A80-0x0000000181794BD0
	// [XID] // 0x00000001897A8D60-0x00000001897A8D80
	protected override void BindWithTickBalanceProxy(bool isStructureDirty, bool fromReady) {} // 0x0000000181796170-0x00000001817962A0
	// [XID] // 0x00000001897B0640-0x00000001897B0660
	public override bool ShouldSetTickableWhenEventsResolved() => default; // 0x0000000181795620-0x00000001817956C0
	// [XID] // 0x00000001897B8420-0x00000001897B8440
	protected override void RegisterTickBalanceProxy(bool considerAsReady) {} // 0x00000001817967F0-0x00000001817968A0
	// [XID] // 0x00000001897C04A0-0x00000001897C04C0
	public override void UnregisterTickBalanceProxy() {} // 0x00000001817956C0-0x0000000181795760
	// [XID] // 0x00000001897C7D70-0x00000001897C7D90
	protected override void DeallocTickBalanceProxy() {} // 0x0000000181796970-0x0000000181796A10
	// [XID] // 0x00000001897CF000-0x00000001897CF020
	public override bool IsDisablePause() => default; // 0x0000000181795580-0x0000000181795620
	// [XID] // 0x00000001897D6780-0x00000001897D67A0
	protected override void InternalUpdateTickable() {} // 0x0000000181795840-0x00000001817958E0
	// [XID] // 0x00000001897DDFB0-0x00000001897DDFD0
	protected override void OnSharedPositionDirty() {} // 0x00000001817965C0-0x0000000181796660
	[BlackList] // 0x00000001897E59E0-0x00000001897E5A20
	// [XID] // 0x00000001897E59E0-0x00000001897E5A20
	public override void AutoAllocTypeFields() {} // 0x0000000181794BD0-0x0000000181794C70
	[BlackList] // 0x00000001897F0560-0x00000001897F05A0
	// [XID] // 0x00000001897F0560-0x00000001897F05A0
	public override void AutoRecycleTypeFields() {} // 0x0000000181794C70-0x0000000181794D40
	[BlackList] // 0x00000001897FB030-0x00000001897FB070
	// [XID] // 0x00000001897FB030-0x00000001897FB070
	public override void ReturnToObjectPool() {} // 0x0000000181796C90-0x0000000181796D30
	// [XID] // 0x0000000189805250-0x0000000189805270
	protected virtual void InitMassiveProxy() {} // 0x0000000181796B80-0x0000000181796C20
	// [XID] // 0x000000018980C7B0-0x000000018980C7D0
	protected virtual void DestroyMassiveProxy() {} // 0x0000000181796A80-0x0000000181796B20
	// [XID] // 0x0000000189813F60-0x0000000189813F80
	protected virtual void SwitchScenePropId(long scenePropId) {} // 0x00000001817963D0-0x0000000181796480
}

