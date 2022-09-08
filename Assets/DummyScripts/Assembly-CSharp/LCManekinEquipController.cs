/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCManekinEquipController : LCAvatarEquipController // TypeDefIndex: 11746
{
	// Fields
	private Dictionary<ulong, ulong> _realGuid2FakeGuid; // 0x168
	private ulong curEquipGuid; // 0x170

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189ACA5B0-0x0000000189ACA5D0 */ get => default; } // 0x000000018165F730-0x000000018165F7D0 

	// Constructors
	public LCManekinEquipController() {} // 0x000000018165F690-0x000000018165F730

	// Methods
	// [XID] // 0x0000000189B14160-0x0000000189B14180
	public override void Init() {} // 0x000000018165EE00-0x000000018165EEB0
	// [XID] // 0x000000018969F5E0-0x000000018969F600
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018165F5D0-0x000000018165F690
	// [XID] // 0x00000001896A6980-0x00000001896A69A0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018165E5A0-0x000000018165E670
	// [XID] // 0x0000000189B38FB0-0x0000000189B38FD0
	public override void Destroy() {} // 0x000000018165E670-0x000000018165E730
	// [XID] // 0x00000001896B56C0-0x00000001896B56E0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x000000018165E890-0x000000018165E970
	// [XID] // 0x00000001896BC9A0-0x00000001896BC9C0
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x000000018165F230-0x000000018165F3A0
	// [XID] // 0x00000001896C3EE0-0x00000001896C3F00
	public override void PickUpItem(uint runtimeID) {} // 0x000000018165F520-0x000000018165F5D0
	// [XID] // 0x00000001896CB370-0x00000001896CB390
	public override void AttachCurEquip() {} // 0x000000018165E230-0x000000018165E2E0
	// [XID] // 0x0000000189B5ED30-0x0000000189B5ED50
	protected override GadgetEntity CreateEquip(uint entityId, ulong guid, uint itemId, uint ownerRuntimeID, uint campID, TargetType campType, bool anyncLoad = true /* Metadata: 0x00AEA787 */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x000000018165EEB0-0x000000018165F1D0
	// [XID] // 0x0000000189B6D950-0x0000000189B6D970
	protected override bool DetachItemFromEquipBar(ulong guid) => default; // 0x000000018165E360-0x000000018165E5A0
	// [XID] // 0x0000000189B74F70-0x0000000189B74F90
	protected override void OnAvatarEquipChanged(ulong avatarGuid, ulong equipGuid, EquipType equipType, EvtAvatarEquipChanged.OP op) {} // 0x000000018165E970-0x000000018165ED90
}

