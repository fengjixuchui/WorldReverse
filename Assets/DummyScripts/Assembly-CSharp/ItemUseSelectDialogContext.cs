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

public sealed class ItemUseSelectDialogContext : BaseDialogContext // TypeDefIndex: 28952
{
	// Fields
	private MonoBPRewardDialog _dialogMono; // 0x178
	private BagItemSlot _itemSlot; // 0x180
	private List<uint> _currRewardIdList; // 0x188
	private List<uint> _currItemIdList; // 0x190
	private int _selectedOptionIndex; // 0x198
	private int _selectedRewardRowIndex; // 0x19C
	private bool _isWeapon; // 0x1A0
	private List<RewardItemConfig> _tempRewardList; // 0x1A8

	// Constructors
	public ItemUseSelectDialogContext() {} // Dummy constructor
	public ItemUseSelectDialogContext(BagItemSlot itemSlot) {} // 0x00000001830BE680-0x00000001830BE770

	// Methods
	// [XID] // 0x00000001897F9240-0x00000001897F9260
	public override void SetupView() {} // 0x00000001830BE4B0-0x00000001830BE680
	// [XID] // 0x0000000189800830-0x0000000189800850
	protected override void BindViewCallbacks() {} // 0x00000001830BB950-0x00000001830BBAE0
	// [XID] // 0x0000000189807EB0-0x0000000189807ED0
	private void RefreshSelectView() {} // 0x00000001830BC9B0-0x00000001830BCE60
	// [XID] // 0x000000018980F790-0x000000018980F7B0
	private void RefreshCurrRewardIdList(string[] paramList) {} // 0x00000001830BBAE0-0x00000001830BBCC0
	// [XID] // 0x0000000189816E60-0x0000000189816E80
	private void RefreshCurrItemIdList(string[] paramList) {} // 0x00000001830BDC20-0x00000001830BDE00
	// [XID] // 0x000000018981E6D0-0x000000018981E6F0
	private void RefreshRewardSelectItem(Transform trans, int index) {} // 0x00000001830BBFC0-0x00000001830BC430
	// [XID] // 0x0000000189825B90-0x0000000189825BB0
	private void RefreshCardRewardItem(Transform trans, int index) {} // 0x00000001830BE050-0x00000001830BE1A0
	// [XID] // 0x000000018982D2E0-0x000000018982D300
	private void OnCardItemClick(int index) {} // 0x00000001830BD4E0-0x00000001830BDB60
	// [XID] // 0x0000000189834A40-0x0000000189834A60
	private MonoItemSlot GetSelectRewardSlot(MonoBPRewardCard cardItem, int index) => default; // 0x00000001830BDE00-0x00000001830BE050
	// [XID] // 0x000000018983C130-0x000000018983C150
	private void RefreshWeaponSelectItem(Transform trans, int index) {} // 0x00000001830BBCC0-0x00000001830BBFC0
	// [XID] // 0x0000000189843720-0x0000000189843740
	private void OnWeaponItemClick(int index) {} // 0x00000001830BC4C0-0x00000001830BC7C0
	// [XID] // 0x000000018984AC80-0x000000018984ACA0
	private void OnOKBtnClick() {} // 0x00000001830BC820-0x00000001830BC9B0
	// [XID] // 0x0000000189851FC0-0x0000000189851FE0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001830BCE60-0x00000001830BD000
	// [XID] // 0x00000001898598A0-0x00000001898598C0
	private void MoveSelectRewardToIndex(int index) {} // 0x00000001830BDB60-0x00000001830BDC20
	// [XID] // 0x0000000189860A20-0x0000000189860A40
	private void MoveRewardSlotToIndex(int index) {} // 0x00000001830BE200-0x00000001830BE4B0
	// [XID] // 0x0000000189868150-0x0000000189868170
	private void ShowRewardItemDetail() {} // 0x00000001830BD1E0-0x00000001830BD4E0
	// [XID] // 0x000000018986F710-0x000000018986F730
	private void OnInputConfirmEvent() {} // 0x00000001830BD000-0x00000001830BD1E0
}

