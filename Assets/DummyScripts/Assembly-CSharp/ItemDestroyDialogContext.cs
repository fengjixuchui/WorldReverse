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

public sealed class ItemDestroyDialogContext : BaseDialogContext // TypeDefIndex: 29172
{
	// Fields
	private MonoItemDestroyDialog _dialogMono; // 0x178
	private Action _callBackWhenInToDialog; // 0x180
	private Action _callBackWhenBackToBagPage; // 0x188
	private Action<MonoQuantityWidget, ItemType, ulong> _callBackSetNum; // 0x190
	private Action<ItemType, ulong> _unselectFromDestroyDialog; // 0x198
	private Action _generateCurrentDestroyShowState; // 0x1A0
	private Action _showQuantityAtBagItem; // 0x1A8
	private Action<MonoQuantityWidget> _onNumChangeAtBagItem; // 0x1B0
	private readonly Dictionary<ItemType, Dictionary<ulong, BagPageContext.DestroyItemInfo>> _ref_destroyDic; // 0x1B8
	public const int ITEM_MAX_LIMIT = 100; // Metadata: 0x00B0ED2A
	private List<BagItemSlot> _checkScrollList; // 0x1C0
	private int _currItemIndex; // 0x1C8
	private bool _isCheckState; // 0x1CC
	private bool _isLookingDetail; // 0x1CD
	private JoystickShowState _joyState; // 0x1D0

	// Properties
	public bool isLookingDetail { /* [XID] */ /* 0x0000000189ABD310-0x0000000189ABD330 */ get => default; /* [XID] */ /* 0x0000000189AC4D40-0x0000000189AC4D60 */ set {} } // 0x0000000180DD3B90-0x0000000180DD3C40 0x0000000180DD4190-0x0000000180DD4240
	public JoystickShowState joyState { /* [XID] */ /* 0x0000000189ACC3C0-0x0000000189ACC3E0 */ get => default; /* [XID] */ /* 0x0000000189AD3F20-0x0000000189AD3F40 */ set {} } // 0x0000000180DD87B0-0x0000000180DD8850 0x0000000180DD7A20-0x0000000180DD7AE0
	public bool isCheckState { /* [XID] */ /* 0x0000000189ADB9E0-0x0000000189ADBA00 */ get => default; } // 0x0000000180DD7970-0x0000000180DD7A20 

	// Nested types
	public enum JoystickShowState // TypeDefIndex: 29173
	{
		None = 0,
		UnselectNum0 = 1,
		Unselect = 2,
		Select = 3,
		CheckSelect = 4,
		CheckUnselect = 5,
		Detail = 6
	}

	// Constructors
	public ItemDestroyDialogContext() {} // Dummy constructor
	public ItemDestroyDialogContext(Action inDialogCallBack, Action quitDialogCallBack, Action<MonoQuantityWidget, ItemType, ulong> callBackSetNum, Action<ItemType, ulong> unselectFromDestroyDialog, Action generateCurrentDestroyShowState, Action showQuantityAtBagItem, Action<MonoQuantityWidget> onNumChangeAtBagItem, Dictionary<ItemType, Dictionary<ulong, BagPageContext.DestroyItemInfo>> destroyDict) {} // 0x0000000180DD8E50-0x0000000180DD9000

	// Methods
	// [XID] // 0x0000000189AE3340-0x0000000189AE3360
	public override void SetupView() {} // 0x0000000180DD8C50-0x0000000180DD8E50
	// [XID] // 0x0000000189AEACB0-0x0000000189AEACD0
	protected override void BindViewCallbacks() {} // 0x0000000180DD4240-0x0000000180DD4530
	// [XID] // 0x0000000189AF2580-0x0000000189AF25A0
	private void OnDestroyButtonClicked() {} // 0x0000000180DD4530-0x0000000180DD46F0
	// [XID] // 0x0000000189AF9F40-0x0000000189AF9F60
	private void OnCheckButtonClicked() {} // 0x0000000180DD3C40-0x0000000180DD3CF0
	// [XID] // 0x0000000189B01450-0x0000000189B01470
	private void RefreshCheckScrollList() {} // 0x0000000180DD46F0-0x0000000180DD4AC0
	// [XID] // 0x0000000189B08960-0x0000000189B08980
	private void InitScrollView() {} // 0x0000000180DD7BC0-0x0000000180DD7DC0
	// [XID] // 0x0000000189B10380-0x0000000189B103A0
	private void CheckScrollOnChangeCallBack(Transform trans, int index) {} // 0x0000000180DD8030-0x0000000180DD8440
	// [XID] // 0x0000000189B174C0-0x0000000189B174E0
	private void ScrollItemSelect(int index) {} // 0x0000000180DD8440-0x0000000180DD8530
	// [XID] // 0x0000000189B1EDE0-0x0000000189B1EE00
	private void OnScrollItemClicked(int index) {} // 0x0000000180DD77B0-0x0000000180DD78A0
	// [XID] // 0x0000000189B26750-0x0000000189B26770
	private void ShowQuantityAtCheckItem() {} // 0x0000000180DD7DC0-0x0000000180DD8030
	// [XID] // 0x0000000189B2D960-0x0000000189B2D980
	private void OnScrollItemMinusClicked(int index) {} // 0x0000000180DD7130-0x0000000180DD73C0
	// [XID] // 0x0000000189B34D80-0x0000000189B34DA0
	private void SetCurrentSelect(bool active) {} // 0x0000000180DD8590-0x0000000180DD87B0
	// [XID] // 0x0000000189B3C610-0x0000000189B3C630
	private void OnNumChangeAtCheckItem(MonoQuantityWidget quantityWidget) {} // 0x0000000180DD64E0-0x0000000180DD66D0
	// [XID] // 0x0000000189B442B0-0x0000000189B442D0
	public void OnQuitDialog() {} // 0x0000000180DD78A0-0x0000000180DD7970
	// [XID] // 0x0000000189B4B9A0-0x0000000189B4B9C0
	private void ShowCheck() {} // 0x0000000180DD73C0-0x0000000180DD7650
	// [XID] // 0x0000000189B52F90-0x0000000189B52FB0
	private void HideCheck() {} // 0x0000000180DD8A00-0x0000000180DD8C50
	// [XID] // 0x0000000189B5A960-0x0000000189B5A980
	private void CreateDestroySourceAndTargetList(List<BagItemSlot> sourceScrollList, List<BagItemSlot> targetScrollList) {} // 0x0000000180DD4E20-0x0000000180DD58F0
	// [XID] // 0x0000000189B61DF0-0x0000000189B61E10
	public void ShowTips(bool showCanNotBeDestroyed = false /* Metadata: 0x00B0ED29 */) {} // 0x0000000180DD7650-0x0000000180DD77B0
	// [XID] // 0x0000000189B69A80-0x0000000189B69AA0
	public void ShowQuantity(uint minNum, uint maxNum, uint curNum) {} // 0x0000000180DD8850-0x0000000180DD8A00
	// [XID] // 0x0000000189B71020-0x0000000189B71040
	public void RefreshItemNum() {} // 0x0000000180DD3E50-0x0000000180DD4190
	// [XID] // 0x0000000189B78610-0x0000000189B78630
	public int CalculateCurrentItemNum() => default; // 0x0000000180DD4BB0-0x0000000180DD4D90
	// [XID] // 0x0000000189B7FBB0-0x0000000189B7FBD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000180DD5A30-0x0000000180DD64E0
	// [XID] // 0x0000000189B875E0-0x0000000189B87600
	private void ToNextSlot() {} // 0x0000000180DD3A80-0x0000000180DD3B90
	// [XID] // 0x0000000189B8E750-0x0000000189B8E770
	private void ToPrevSlot() {} // 0x0000000180DD58F0-0x0000000180DD59D0
	// [XID] // 0x0000000189B95C70-0x0000000189B95C90
	private void ToNextRow() {} // 0x0000000180DD66D0-0x0000000180DD68A0
	// [XID] // 0x0000000189B9D1B0-0x0000000189B9D1D0
	private void ToPrevRow() {} // 0x0000000180DD3CF0-0x0000000180DD3E50
	// [XID] // 0x0000000189BA4B50-0x0000000189BA4B70
	private void ShowDetail() {} // 0x0000000180DD3930-0x0000000180DD3A80
	// [XID] // 0x0000000189BABE90-0x0000000189BABEB0
	public void SetJoyStickShowState(JoystickShowState state) {} // 0x0000000180DD68A0-0x0000000180DD7130
	// [XID] // 0x0000000189BB3500-0x0000000189BB3520
	public bool CanJoyStickChangeItemNum() => default; // 0x0000000180DD7AE0-0x0000000180DD7BC0
	// [XID] // 0x0000000189BBAB40-0x0000000189BBAB60
	public bool GenerateCurrentCheckState(out JoystickShowState state) {
		state = default;
		return default;
	} // 0x0000000180DD4AC0-0x0000000180DD4BB0
}

