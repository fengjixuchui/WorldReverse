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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipModule : BaseModule // TypeDefIndex: 21474
{
	// Constructors
	public EquipModule() {} // 0x000000018189EDF0-0x000000018189EE70

	// Methods
	// [XID] // 0x0000000189AD8DF0-0x0000000189AD8E10
	public override bool OnPacket(Packet packet) => default; // 0x000000018189B4D0-0x000000018189B760
	// [XID] // 0x0000000189AE08C0-0x0000000189AE08E0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018189E970-0x000000018189EA90
	// [XID] // 0x0000000189AE7DB0-0x0000000189AE7DD0
	private void OnAvatarEquipChangeNotify(AvatarEquipChangeNotify notify) {} // 0x000000018189E7E0-0x000000018189E970
	// [XID] // 0x0000000189AEFAE0-0x0000000189AEFB00
	public void RefreshAvatarEquip(AvatarDataItem wearAvatarDataItem, ulong equipGuid, EquipType equipType, SceneWeaponInfo weaponInfo, SceneReliquaryInfo reliquaryInfo) {} // 0x000000018189C850-0x000000018189CD20
	// [XID] // 0x0000000189AF6FC0-0x0000000189AF6FE0
	public bool IsEquiped(ulong equipGuid) => default; // 0x000000018189C5D0-0x000000018189C850
	// [XID] // 0x0000000189AFE5D0-0x0000000189AFE5F0
	public ulong GetEquipedAvatar(ulong equipGuid) => default; // 0x000000018189BB70-0x000000018189BCC0
	// [XID] // 0x0000000189B05E40-0x0000000189B05E60
	public WeaponType GetSelectedAvatarWeaponType() => default; // 0x000000018189E310-0x000000018189E450
	// [XID] // 0x0000000189B0D5D0-0x0000000189B0D5F0
	public void StarUpSelectedAvatar() {} // 0x000000018189E450-0x000000018189E5C0
	// [XID] // 0x0000000189B14A10-0x0000000189B14A30
	public void UpgradeWeapon(ulong targetGuid, List<ulong> foodList, Dictionary<uint, int> weaponExpStoneDic) {} // 0x000000018189DF80-0x000000018189E310
	// [XID] // 0x0000000189B1C410-0x0000000189B1C430
	public void PromoteWeapon(ulong targetGuid) {} // 0x000000018189EA90-0x000000018189EB90
	// [XID] // 0x0000000189B23960-0x0000000189B23980
	public void UpgradeReliquary(ulong targetGuid, List<ulong> foodList, Dictionary<uint, int> reliquaryExpItemDic) {} // 0x000000018189DB60-0x000000018189DF80
	// [XID] // 0x0000000189B2AC60-0x0000000189B2AC80
	public void PromoteReliquary(ulong targetGuid, ulong foodGuid) {} // 0x000000018189ECC0-0x000000018189EDF0
	// [XID] // 0x0000000189B321C0-0x0000000189B321E0
	public void AwakenWeapon(ulong targetGuid, ulong foodGuid) {} // 0x000000018189EB90-0x000000018189ECC0
	// [XID] // 0x0000000189B39B50-0x0000000189B39B70
	public override void ClearOnLevelDestroy() {} // 0x000000018189B760-0x000000018189B800
	// [XID] // 0x0000000189B41370-0x0000000189B41390
	public override void ClearOnDisconnect() {} // 0x000000018189E6A0-0x000000018189E750
	// [XID] // 0x0000000189B48D00-0x0000000189B48D20
	private void OnWearEquipRsp(WearEquipRsp rsp) {} // 0x000000018189BCC0-0x000000018189BEE0
	// [XID] // 0x0000000189B50420-0x0000000189B50440
	private void OnTakeoffEquipRsp(TakeoffEquipRsp rsp) {} // 0x000000018189C0F0-0x000000018189C350
	// [XID] // 0x0000000189B57C10-0x0000000189B57C30
	private void OnAvatarBreakThroughRsp(AvatarPromoteRsp rsp) {} // 0x000000018189D290-0x000000018189D570
	// [XID] // 0x0000000189B5F620-0x0000000189B5F640
	private void OnWeaponUpgradeRsp(WeaponUpgradeRsp rsp) {} // 0x000000018189C3D0-0x000000018189C5D0
	// [XID] // 0x0000000189B66D40-0x0000000189B66D60
	private void OnWeaponPromoteRsp(WeaponPromoteRsp rsp) {} // 0x000000018189B150-0x000000018189B350
	// [XID] // 0x0000000189B6E0A0-0x0000000189B6E0C0
	private void OnWeaponAwakenRsp(WeaponAwakenRsp rsp) {} // 0x000000018189CD20-0x000000018189D010
	// [XID] // 0x0000000189B75850-0x0000000189B75870
	private void OnReliquaryUpgradeRsp(ReliquaryUpgradeRsp rsp) {} // 0x000000018189B970-0x000000018189BB70
	// [XID] // 0x0000000189B7CCF0-0x0000000189B7CD10
	private void OnReliquaryPromoteRsp(ReliquaryPromoteRsp rsp) {} // 0x000000018189D960-0x000000018189DB60
	// [XID] // 0x0000000189B84B90-0x0000000189B84BB0
	private void OnTipShow(Notify ntf) {} // 0x000000018189BEE0-0x000000018189C0F0
	// [XID] // 0x0000000189B8B940-0x0000000189B8B960
	private void OnTipClose(Notify ntf) {} // 0x000000018189B350-0x000000018189B450
	// [XID] // 0x0000000189B93130-0x0000000189B93150
	public void WearEquip(EquipType equipType, int selectedIndex) {} // 0x000000018189D010-0x000000018189D290
	// [XID] // 0x0000000189B9A680-0x0000000189B9A6A0
	public void TakeOffEquip(int selectedIndex, EquipType equipType) {} // 0x000000018189D7D0-0x000000018189D960
	// [XID] // 0x0000000189BA1E70-0x0000000189BA1E90
	public List<BagItemSlot> GetEquipBagList(EquipType equipType) => default; // 0x000000018189D5F0-0x000000018189D7D0
	// [XID] // 0x0000000189BA9260-0x0000000189BA9280
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018189B800-0x000000018189B970
	// [XID] // 0x0000000189BB09F0-0x0000000189BB0A10
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018189E5C0-0x000000018189E6A0
}

