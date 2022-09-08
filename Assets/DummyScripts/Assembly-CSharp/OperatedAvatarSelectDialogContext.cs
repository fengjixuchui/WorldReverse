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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OperatedAvatarSelectDialogContext : BaseDialogContext // TypeDefIndex: 29221
{
	// Fields
	private MonoOperatedAvatarSelectDialog _dialogMono; // 0x178
	private List<uint> _avatarIDList; // 0x180
	private List<AvatarEntity> _avatarList; // 0x188
	private Action<int, ulong> _callback; // 0x190
	private int _selectedIndex; // 0x198
	private int _minUseCount; // 0x19C
	private int _maxUseCount; // 0x1A0
	private int _useCount; // 0x1A4
	private ItemUseTarget _targetType; // 0x1A8
	private uint _itemID; // 0x1AC
	private ItemType _itemType; // 0x1B0
	private int _typeIndex; // 0x1B4
	private bool _showSatiation; // 0x1B8
	private bool _addHpItem; // 0x1B9

	// Properties
	public ItemUseTarget targetType { /* [XID] */ /* 0x0000000189952C60-0x0000000189952C80 */ set {} } // 0x0000000181858E30-0x0000000181858EE0
	public int maxUseCount { /* [XID] */ /* 0x000000018995A210-0x000000018995A230 */ set {} } // 0x000000018185BEE0-0x000000018185BF90
	public uint itemID { /* [XID] */ /* 0x0000000189961C40-0x0000000189961C60 */ set {} } // 0x000000018185BE30-0x000000018185BEE0
	public ItemType itemType { /* [XID] */ /* 0x00000001899692D0-0x00000001899692F0 */ set {} } // 0x000000018185C060-0x000000018185C110
	public int typeIndex { /* [XID] */ /* 0x0000000189970D70-0x0000000189970D90 */ set {} } // 0x000000018185C110-0x000000018185C1C0
	public Action<int, ulong> callback { /* [XID] */ /* 0x00000001899786B0-0x00000001899786D0 */ set {} } // 0x000000018185A7D0-0x000000018185A880

	// Constructors
	public OperatedAvatarSelectDialogContext() {} // 0x000000018185D720-0x000000018185D850

	// Methods
	// [XID] // 0x000000018997F7D0-0x000000018997F7F0
	public override void SetupView() {} // 0x000000018185D160-0x000000018185D4B0
	// [XID] // 0x0000000189987120-0x0000000189987140
	public override void UpdateView() {} // 0x000000018185D4B0-0x000000018185D720
	// [XID] // 0x000000018998EBF0-0x000000018998EC10
	protected override void BindViewCallbacks() {} // 0x0000000181859F40-0x000000018185A220
	// [XID] // 0x00000001899967D0-0x00000001899967F0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018185C5D0-0x000000018185CED0
	// [XID] // 0x000000018999E2F0-0x000000018999E310
	private void RefreshAvatarIcon(Transform trans, int index) {} // 0x00000001818591C0-0x0000000181859950
	// [XID] // 0x00000001899A5CB0-0x00000001899A5CD0
	private void RefreshSatiationData(AvatarDataItem dataItem, MonoAvatarIcon avatarIcon, bool forceRefresh = false /* Metadata: 0x00B0EE49 */) {} // 0x0000000181859D90-0x0000000181859F40
	// [XID] // 0x00000001899AD370-0x00000001899AD390
	private bool IsPreShowAddHp(int index) => default; // 0x000000018185B880-0x000000018185B9D0
	// [XID] // 0x00000001899B4BD0-0x00000001899B4BF0
	private bool IsAddHpBagItem() => default; // 0x000000018185B060-0x000000018185B400
	// [XID] // 0x00000001899BC290-0x00000001899BC2B0
	private float PreShowAddHpRatio(int index) => default; // 0x0000000181859950-0x0000000181859D90
	// [XID] // 0x00000001899C3CD0-0x00000001899C3CF0
	private float GetSBuffAddAD(uint buffID, BaseEntity avatarEntity) => default; // 0x000000018185A880-0x000000018185AFD0
	// [XID] // 0x00000001899CB3D0-0x00000001899CB3F0
	private void Use() {} // 0x000000018185B6D0-0x000000018185B880
	// [XID] // 0x00000001899D2900-0x00000001899D2920
	public void DoUse() {} // 0x000000018185A650-0x000000018185A7D0
	// [XID] // 0x00000001899DA010-0x00000001899DA030
	public void TryShowUseMessage() {} // 0x0000000181858EE0-0x00000001818591C0
	// [XID] // 0x00000001899E1910-0x00000001899E1930
	public void TryShowUseEffect() {} // 0x000000018185BA30-0x000000018185BE30
	// [XID] // 0x00000001899E8E80-0x00000001899E8EA0
	private void OnSlotClicked(int index, bool checkLifeState = true /* Metadata: 0x00B0EE4A */) {} // 0x000000018185A490-0x000000018185A650
	// [XID] // 0x00000001899F0800-0x00000001899F0820
	private void UpdateSlot(int index, bool isSelected) {} // 0x000000018185C3C0-0x000000018185C5D0
	// [XID] // 0x00000001899F7E40-0x00000001899F7E60
	private bool CheckLifeState(int index) => default; // 0x000000018185A220-0x000000018185A390
	// [XID] // 0x00000001899FF4F0-0x00000001899FF510
	private bool CheckSatiationState(int index) => default; // 0x000000018185CFD0-0x000000018185D160
	// [XID] // 0x0000000189A06D30-0x0000000189A06D50
	private void CalSatiationData() {} // 0x000000018185C220-0x000000018185C330
	// [XID] // 0x0000000189A0E420-0x0000000189A0E440
	private void ShowTips(string tips) {} // 0x000000018185BF90-0x000000018185C060
	// [XID] // 0x0000000189A159C0-0x0000000189A159E0
	private void IncreaseUseCount() {} // 0x000000018185CED0-0x000000018185CFD0
	// [XID] // 0x0000000189A1CE80-0x0000000189A1CEA0
	private void DecreaseUseCount() {} // 0x000000018185A390-0x000000018185A490
	// [XID] // 0x0000000189A243C0-0x0000000189A243E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018185B460-0x000000018185B6D0
}

