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

public sealed class ItemPurchaseDialogContext : BaseDialogContext // TypeDefIndex: 28950
{
	// Fields
	private MonoItemPurchaseDialog _dialogMono; // 0x178
	private BagItemSlot _itemSlot; // 0x180
	private List<KeyValuePair<uint, uint>> _currRewardIdList; // 0x188
	private List<string> _currRewardName; // 0x190
	private MaterialExcelConfig _materialExcelConfig; // 0x198
	private int _selectedOptionIndex; // 0x1A0
	private uint _selecetedNum; // 0x1A4
	private uint _maxNum; // 0x1A8
	private MonoMultiClickButton _multiPlusBtn; // 0x1B0
	private MonoMultiClickButton _multiMinusBtn; // 0x1B8
	private float _clickStartTime; // 0x1C0

	// Constructors
	public ItemPurchaseDialogContext() {} // Dummy constructor
	public ItemPurchaseDialogContext(BagItemSlot itemSlot) {} // 0x0000000183A93B80-0x0000000183A93C70

	// Methods
	// [XID] // 0x00000001897623E0-0x0000000189762400
	public override void SetupView() {} // 0x0000000183A93AB0-0x0000000183A93B80
	// [XID] // 0x0000000189769A00-0x0000000189769A20
	private void Refresh() {} // 0x0000000183A90B90-0x0000000183A91280
	// [XID] // 0x0000000189771030-0x0000000189771050
	private void RefreshCurrRewardIdList(string[] paramList) {} // 0x0000000183A919E0-0x0000000183A91D20
	// [XID] // 0x00000001897788C0-0x00000001897788E0
	private void RefreshSelectItem(Transform trans, int index) {} // 0x0000000183A92440-0x0000000183A92840
	// [XID] // 0x000000018977FE80-0x000000018977FEA0
	private void OnItemClick(int index) {} // 0x0000000183A920D0-0x0000000183A923E0
	// [XID] // 0x0000000189787720-0x0000000189787740
	private void CheckSelectedIndex() {} // 0x0000000183A92EA0-0x0000000183A930E0
	// [XID] // 0x000000018978ED50-0x000000018978ED70
	private void RefreshTip(int index) {} // 0x0000000183A930E0-0x0000000183A933F0
	// [XID] // 0x00000001897964C0-0x00000001897964E0
	private void ResetSlider() {} // 0x0000000183A90A40-0x0000000183A90B90
	// [XID] // 0x000000018979E610-0x000000018979E630
	private void SetLongPress() {} // 0x0000000183A91D20-0x0000000183A92040
	// [XID] // 0x00000001897A5DD0-0x00000001897A5DF0
	private void OnPlusBtnClick() {} // 0x0000000183A91410-0x0000000183A915C0
	// [XID] // 0x00000001897AD340-0x00000001897AD360
	private void OnMinusBtnClick() {} // 0x0000000183A915C0-0x0000000183A91770
	// [XID] // 0x00000001897B53D0-0x00000001897B53F0
	private void RefreshNumBtn() {} // 0x0000000183A93860-0x0000000183A93AB0
	// [XID] // 0x00000001897BD020-0x00000001897BD040
	private uint GetChangeValueBaseOnMinMax() => default; // 0x0000000183A93570-0x0000000183A93800
	// [XID] // 0x00000001897C43A0-0x00000001897C43C0
	protected override void BindViewCallbacks() {} // 0x0000000183A91770-0x0000000183A919E0
	// [XID] // 0x00000001897CBBC0-0x00000001897CBBE0
	private void OnSliderValueChange(float value) {} // 0x0000000183A933F0-0x0000000183A93570
	// [XID] // 0x00000001897D34F0-0x00000001897D3510
	private void OnConfirmBtnClick() {} // 0x0000000183A91280-0x0000000183A91410
	// [XID] // 0x00000001897DAF70-0x00000001897DAF90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183A92840-0x0000000183A92EA0
}

