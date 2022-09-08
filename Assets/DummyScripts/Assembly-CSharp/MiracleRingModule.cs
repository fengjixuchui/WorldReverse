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

public sealed class MiracleRingModule : BaseModule // TypeDefIndex: 21566
{
	// Fields
	private MiracleRingDataNotify _miracleRingDataNotify; // 0x10
	public const int MiracleRingMaterialId = 220021; // Metadata: 0x00AFF958

	// Properties
	public bool IsUsingMiracleRing { /* [XID] */ /* 0x0000000189AC7F70-0x0000000189AC7F90 */ get => default; } // 0x0000000183FB1CA0-0x0000000183FB1D60 
	public uint gadgetEntityId { /* [XID] */ /* 0x0000000189ACF5F0-0x0000000189ACF610 */ get => default; } // 0x0000000183FB1520-0x0000000183FB15D0 
	public uint gadgetId { /* [XID] */ /* 0x0000000189AD73C0-0x0000000189AD73E0 */ get => default; } // 0x0000000183FB1FE0-0x0000000183FB20F0 

	// Constructors
	public MiracleRingModule() {} // 0x0000000183FB2D20-0x0000000183FB2DA0

	// Methods
	// [XID] // 0x0000000189ADEEB0-0x0000000189ADEED0
	public override bool OnPacket(Packet packet) => default; // 0x0000000183FB15D0-0x0000000183FB17C0
	// [XID] // 0x0000000189AE6780-0x0000000189AE67A0
	private void OnMiracleRingDataNotify(MiracleRingDataNotify notify) {} // 0x0000000183FB2B00-0x0000000183FB2C70
	// [XID] // 0x0000000189AEE0A0-0x0000000189AEE0C0
	private void OnMiracleRingTakeRewardRsp(MiracleRingTakeRewardRsp rsp) {} // 0x0000000183FB2240-0x0000000183FB23A0
	// [XID] // 0x0000000189AF57F0-0x0000000189AF5810
	private void OnUseMiracleRingRsp(UseMiracleRingRsp rsp) {} // 0x0000000183FB29A0-0x0000000183FB2B00
	// [XID] // 0x0000000189AFCC90-0x0000000189AFCCB0
	private void OnMiracleRingDeliverItemRsp(MiracleRingDeliverItemRsp rsp) {} // 0x0000000183FB1E80-0x0000000183FB1FE0
	// [XID] // 0x0000000189B04400-0x0000000189B04420
	private void OnMiracleRingDropResultNotify(MiracleRingDropResultNotify notify) {} // 0x0000000183FB2C70-0x0000000183FB2D20
	// [XID] // 0x0000000189B0BC50-0x0000000189B0BC70
	private void OnMiracleRingDestroyNotify(MiracleRingDestroyNotify notify) {} // 0x0000000183FB20F0-0x0000000183FB2240
	// [XID] // 0x0000000189B13240-0x0000000189B13260
	private void ShowItemList(RepeatedMessageField<ItemParam> itemParams) {} // 0x0000000183FB2420-0x0000000183FB26C0
	// [XID] // 0x0000000189B1A9E0-0x0000000189B1AA00
	public void RequestUseMiracleRing(Vector3 pos, Vector3 rot) {} // 0x0000000183FB1990-0x0000000183FB1CA0
	// [XID] // 0x0000000189B21FD0-0x0000000189B21FF0
	public void RequestUnUseMiracleRing() {} // 0x0000000183FB2720-0x0000000183FB2850
	// [XID] // 0x0000000189B295C0-0x0000000189B295E0
	public override void ClearOnDisconnect() {} // 0x0000000183FB2900-0x0000000183FB29A0
	// [XID] // 0x0000000189B30B10-0x0000000189B30B30
	public override void ClearOnLevelDestroy() {} // 0x0000000183FB17C0-0x0000000183FB1860
	// [XID] // 0x0000000189B381F0-0x0000000189B38210
	public override void ClearOnBackHome() {} // 0x0000000183FB1D60-0x0000000183FB1E00
	// [XID] // 0x0000000189B3FC40-0x0000000189B3FC60
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000183FB1860-0x0000000183FB1990
	// [XID] // 0x0000000189B473F0-0x0000000189B47410
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000183FB2850-0x0000000183FB2900
}

