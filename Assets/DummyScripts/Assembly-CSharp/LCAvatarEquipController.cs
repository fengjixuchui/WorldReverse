/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCAvatarEquipController : LCBaseEquipController // TypeDefIndex: 11703
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189899E70-0x0000000189899E90 */ get => default; } // 0x000000018227A6D0-0x000000018227A770 

	// Constructors
	public LCAvatarEquipController() {} // 0x000000018227A670-0x000000018227A6D0

	// Methods
	// [XID] // 0x000000018973E320-0x000000018973E340
	public void InitEquips() {} // 0x00000001822796F0-0x0000000182279AE0
	// [XID] // 0x00000001897455F0-0x0000000189745610
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018227A5A0-0x000000018227A670
	// [XID] // 0x000000018974D0F0-0x000000018974D110
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001822776B0-0x0000000182277780
	// [XID] // 0x00000001898B77C0-0x00000001898B77E0
	public override void OnEntityReady() {} // 0x000000018227A240-0x000000018227A300
	// [XID] // 0x00000001898BEE00-0x00000001898BEE20
	public override void OnEnable() {} // 0x000000018227A180-0x000000018227A240
	// [XID] // 0x00000001899553E0-0x0000000189955400
	public override void Destroy() {} // 0x00000001822777E0-0x0000000182277A20
	// [XID] // 0x000000018995CB80-0x000000018995CBA0
	private void ReInitEquips() {} // 0x0000000182278F10-0x00000001822790B0
	// [XID] // 0x0000000189973630-0x0000000189973650
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001822787A0-0x0000000182278880
	// [XID] // 0x00000001897798A0-0x00000001897798C0
	protected override bool OnEvent(BaseEvent e) => default; // 0x000000018227A440-0x000000018227A5A0
	// [XID] // 0x0000000189781220-0x0000000189781240
	protected static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000182278880-0x0000000182278960
	// [XID] // 0x00000001899827A0-0x00000001899827C0
	protected override bool OnEventResolved(BaseEvent e) => default; // 0x000000018227A300-0x000000018227A440
	// [XID] // 0x0000000189A74A20-0x0000000189A74A40
	public ulong GetTakeEquipped() => default; // 0x0000000182279110-0x0000000182279300
	// [XID] // 0x0000000189A7C4D0-0x0000000189A7C4F0
	public ulong GetPutEquipped() => default; // 0x0000000182279E50-0x000000018227A040
	// [XID] // 0x000000018979F510-0x000000018979F530
	protected virtual void OnAvatarEquipChanged(ulong avatarGuid, ulong equipGuid, EquipType equipType, EvtAvatarEquipChanged.OP op) {} // 0x0000000182278960-0x0000000182278C10
	// [XID] // 0x00000001899330E0-0x0000000189933100
	protected override GadgetEntity CreateEquip(uint entityId, ulong guid, uint itemId, uint ownerRuntimeID, uint campID, TargetType campType, bool anyncLoad = true /* Metadata: 0x00AEA710 */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x0000000182278C80-0x0000000182278F10
	// [XID] // 0x0000000189B22F30-0x0000000189B22F50
	public override bool AttachItem(ulong guid, string equipPart = null, bool showSub = true /* Metadata: 0x00AEA711 */) => default; // 0x0000000182277E00-0x00000001822787A0
	// [XID] // 0x00000001897B6350-0x00000001897B6370
	public void OnTakeWeaponStyleChange(bool isTakeWeaponStyle) {} // 0x0000000182279300-0x00000001822795A0
	// [XID] // 0x00000001897BE0C0-0x00000001897BE0E0
	public bool ItemFromPutSlotToTakeSlot(ulong guid) => default; // 0x0000000182277A20-0x0000000182277CA0
	// [XID] // 0x000000018969B010-0x000000018969B030
	public bool ItemFromTakeSlotToPutSlot(ulong guid) => default; // 0x0000000182279BE0-0x0000000182279E50
	// [XID] // 0x00000001897CCD80-0x00000001897CCDA0
	public override void PickUpItem(uint runtimeID) {} // 0x000000018227A040-0x000000018227A180
	// [XID] // 0x00000001896D5BF0-0x00000001896D5C10
	public override void AttachCurEquip() {} // 0x0000000182277550-0x00000001822776B0
}

