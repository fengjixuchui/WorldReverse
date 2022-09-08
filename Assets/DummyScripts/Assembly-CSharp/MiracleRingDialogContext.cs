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

public sealed class MiracleRingDialogContext : BaseDialogContext // TypeDefIndex: 29204
{
	// Fields
	private MonoMiracleRingDialog _dialogMono; // 0x178
	private Action _callBackWhenInToDialog; // 0x180
	private Action _callBackWhenBackToBagPage; // 0x188
	private Action<MonoQuantityWidget, ItemType, ulong> _callBackSetNum; // 0x190
	private Action<ItemType, ulong> _unselectFromDestroyDialog; // 0x198
	private Action _generateCurrentShowState; // 0x1A0
	private Action _showQuantityAtBagItem; // 0x1A8
	private Action<MonoQuantityWidget> _onNumChangeAtBagItem; // 0x1B0
	private readonly Dictionary<ItemType, Dictionary<ulong, BagPageContext.MiracleRingItemInfo>> _pickedItemDict; // 0x1B8
	private List<BagItemSlot> _checkScrollList; // 0x1C0
	private int _currItemIndex; // 0x1C8
	private bool _isCheckState; // 0x1CC
	private bool _isLookingDetail; // 0x1CD
	private JoystickShowState _joyState; // 0x1D0
	private uint _miracleProgress; // 0x1D4
	private uint _miracleMaxValue; // 0x1D8

	// Properties
	public bool isLookingDetail { /* [XID] */ /* 0x0000000189BA8FB0-0x0000000189BA8FD0 */ get => default; /* [XID] */ /* 0x0000000189BB0720-0x0000000189BB0740 */ set {} } // 0x0000000183C3FE20-0x0000000183C3FED0 0x0000000183C40630-0x0000000183C406E0
	public JoystickShowState joyState { /* [XID] */ /* 0x0000000189BB7AA0-0x0000000189BB7AC0 */ get => default; /* [XID] */ /* 0x0000000189BBF0C0-0x0000000189BBF0E0 */ set {} } // 0x0000000183C44D10-0x0000000183C44DB0 0x0000000183C43FC0-0x0000000183C44080
	public bool isCheckState { /* [XID] */ /* 0x0000000189BC6D90-0x0000000189BC6DB0 */ get => default; } // 0x0000000183C43F10-0x0000000183C43FC0 

	// Nested types
	public enum JoystickShowState // TypeDefIndex: 29205
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
	public MiracleRingDialogContext() {} // Dummy constructor
	public MiracleRingDialogContext(Action inDialogCallBack, Action quitDialogCallBack, Action<MonoQuantityWidget, ItemType, ulong> callBackSetNum, Action<ItemType, ulong> unselectFromDestroyDialog, Action generateCurrentShowState, Action showQuantityAtBagItem, Action<MonoQuantityWidget> onNumChangeAtBagItem, Dictionary<ItemType, Dictionary<ulong, BagPageContext.MiracleRingItemInfo>> destroyDict) {} // 0x0000000183C45530-0x0000000183C45760

	// Methods
	// [XID] // 0x0000000189BCEA40-0x0000000189BCEA60
	public override void SetupView() {} // 0x0000000183C451F0-0x0000000183C45530
	// [XID] // 0x0000000189BD5D20-0x0000000189BD5D40
	protected override void BindViewCallbacks() {} // 0x0000000183C406E0-0x0000000183C409D0
	// [XID] // 0x0000000189BDD9B0-0x0000000189BDD9D0
	private void OnStartClicked() {} // 0x0000000183C41D00-0x0000000183C42000
	// [XID] // 0x00000001895EA590-0x00000001895EA5B0
	private void OnCheckButtonClicked() {} // 0x0000000183C3FED0-0x0000000183C3FF80
	// [XID] // 0x00000001895F1A10-0x00000001895F1A30
	private void RefreshCheckScrollList() {} // 0x0000000183C409D0-0x0000000183C40DA0
	// [XID] // 0x00000001895F93F0-0x00000001895F9410
	private void InitScrollView() {} // 0x0000000183C44160-0x0000000183C44360
	// [XID] // 0x0000000189600A40-0x0000000189600A60
	private void CheckScrollOnChangeCallBack(Transform trans, int index) {} // 0x0000000183C445D0-0x0000000183C449A0
	// [XID] // 0x0000000189608360-0x0000000189608380
	private void ScrollItemSelect(int index) {} // 0x0000000183C449A0-0x0000000183C44A90
	// [XID] // 0x000000018960FCE0-0x000000018960FD00
	private void OnScrollItemClicked(int index) {} // 0x0000000183C43D50-0x0000000183C43E40
	// [XID] // 0x0000000189616FC0-0x0000000189616FE0
	private void ShowQuantityAtCheckItem() {} // 0x0000000183C44360-0x0000000183C445D0
	// [XID] // 0x000000018961EB40-0x000000018961EB60
	private void OnScrollItemMinusClicked(int index) {} // 0x0000000183C436D0-0x0000000183C43950
	// [XID] // 0x0000000189625F40-0x0000000189625F60
	private void SetCurrentSelect(bool active) {} // 0x0000000183C44AF0-0x0000000183C44D10
	// [XID] // 0x000000018962D900-0x000000018962D920
	private void OnNumChangeAtCheckItem(MonoQuantityWidget quantityWidget) {} // 0x0000000183C42B10-0x0000000183C42D00
	// [XID] // 0x0000000189635480-0x00000001896354A0
	private void OnNumChangeAtBagItem(MonoQuantityWidget quantityWidget) {} // 0x0000000183C41C30-0x0000000183C41D00
	// [XID] // 0x000000018963CB60-0x000000018963CB80
	private bool CheckMaxNum(uint maxNum) => default; // 0x0000000183C3FF80-0x0000000183C40040
	// [XID] // 0x00000001896441A0-0x00000001896441C0
	public void OnQuitDialog() {} // 0x0000000183C43E40-0x0000000183C43F10
	// [XID] // 0x000000018964B950-0x000000018964B970
	private void ShowCheck() {} // 0x0000000183C43950-0x0000000183C43BE0
	// [XID] // 0x00000001896530E0-0x0000000189653100
	private void HideCheck() {} // 0x0000000183C44F80-0x0000000183C451F0
	// [XID] // 0x000000018965A7A0-0x000000018965A7C0
	private void CreateDestroySourceAndTargetList(List<BagItemSlot> sourceScrollList, List<BagItemSlot> targetScrollList) {} // 0x0000000183C41160-0x0000000183C41C30
	// [XID] // 0x0000000189661DD0-0x0000000189661DF0
	public void ShowTips() {} // 0x0000000183C43BE0-0x0000000183C43D50
	// [XID] // 0x00000001896699B0-0x00000001896699D0
	public void ShowQuantity(uint minNum, uint maxNum, uint curNum) {} // 0x0000000183C44DB0-0x0000000183C44F80
	// [XID] // 0x00000001896714E0-0x0000000189671500
	public void RefreshItemNum() {} // 0x0000000183C401A0-0x0000000183C40630
	// [XID] // 0x0000000189678DA0-0x0000000189678DC0
	public bool IsItemReachMax() => default; // 0x0000000183C42D00-0x0000000183C42DB0
	// [XID] // 0x00000001896804F0-0x0000000189680510
	public uint CalculateCurrentItemNum() => default; // 0x0000000183C40E90-0x0000000183C410D0
	// [XID] // 0x0000000189687FD0-0x0000000189687FF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183C42140-0x0000000183C42B10
	// [XID] // 0x000000018968F9F0-0x000000018968FA10
	private void ToNextSlot() {} // 0x0000000183C3FD10-0x0000000183C3FE20
	// [XID] // 0x00000001896973F0-0x0000000189697410
	private void ToPrevSlot() {} // 0x0000000183C42000-0x0000000183C420E0
	// [XID] // 0x000000018969E940-0x000000018969E960
	private void ToNextRow() {} // 0x0000000183C42DB0-0x0000000183C42F80
	// [XID] // 0x00000001896A5930-0x00000001896A5950
	private void ToPrevRow() {} // 0x0000000183C40040-0x0000000183C401A0
	// [XID] // 0x00000001896AD1B0-0x00000001896AD1D0
	private void ShowDetail() {} // 0x0000000183C3FBC0-0x0000000183C3FD10
	// [XID] // 0x00000001896B47C0-0x00000001896B47E0
	public void SetJoyStickShowState(JoystickShowState state) {} // 0x0000000183C42F80-0x0000000183C436D0
	// [XID] // 0x00000001896BBA90-0x00000001896BBAB0
	public bool CanJoyStickChangeItemNum() => default; // 0x0000000183C44080-0x0000000183C44160
	// [XID] // 0x00000001896C2F10-0x00000001896C2F30
	public bool GenerateCurrentCheckState(out JoystickShowState state) {
		state = default;
		return default;
	} // 0x0000000183C40DA0-0x0000000183C40E90
}

