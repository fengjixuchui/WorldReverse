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

public sealed class BPGradePurchaseDialogContext : BaseDialogContext // TypeDefIndex: 28911
{
	// Fields
	private MonoBPGradePurchaseDialog _dialogMono; // 0x178
	private List<BattlePassRewardExcelConfig> _bpRewardList; // 0x180
	private Dictionary<uint, uint> _tempRewardItemDic; // 0x188
	private List<SimpleItemStruct> _itemShowList; // 0x190
	private uint _curBpLevel; // 0x198
	private uint _tarBpLevel; // 0x19C
	private uint _maxLevel; // 0x1A0
	private uint _buyLevelCost; // 0x1A4
	private MaterialGrpWidgetContext _materialWidget; // 0x1A8

	// Constructors
	public BPGradePurchaseDialogContext() {} // 0x00000001830992F0-0x00000001830993C0

	// Methods
	// [XID] // 0x0000000189627670-0x0000000189627690
	public override void SetupView() {} // 0x0000000183098FD0-0x00000001830992F0
	// [XID] // 0x000000018962F170-0x000000018962F190
	protected override void BindViewCallbacks() {} // 0x0000000183096C30-0x0000000183096F50
	// [XID] // 0x0000000189636B30-0x0000000189636B50
	private void RefreshBPRewardList() {} // 0x00000001830986B0-0x00000001830988E0
	// [XID] // 0x000000018963E060-0x000000018963E080
	private uint GetFirstUpShowLevel(uint curLevel) => default; // 0x00000001830988E0-0x0000000183098AB0
	// [XID] // 0x00000001896459F0-0x0000000189645A10
	private void RefreshPurchaseView() {} // 0x0000000183098AB0-0x0000000183098E70
	// [XID] // 0x000000018964D200-0x000000018964D220
	private void RefreshRewardItem(Transform trans, int index) {} // 0x00000001830975B0-0x0000000183097820
	// [XID] // 0x00000001896549A0-0x00000001896549C0
	private void RefreshItemShowList() {} // 0x0000000183096F50-0x00000001830975B0
	// [XID] // 0x000000018965C090-0x000000018965C0B0
	private RewardItemConfig GetFirstRewardItemConfig(uint rewardId) => default; // 0x0000000183098E70-0x0000000183098F70
	// [XID] // 0x0000000189663750-0x0000000189663770
	private void OnQuantityWidgetValueChange(MonoQuantityWidget widget) {} // 0x00000001830981C0-0x00000001830982A0
	// [XID] // 0x000000018966B090-0x000000018966B0B0
	private void OnOKBtnClick() {} // 0x0000000183097910-0x0000000183097AF0
	// [XID] // 0x0000000189672C90-0x0000000189672CB0
	private void OnCloseBtnClick() {} // 0x0000000183096B70-0x0000000183096C30
	// [XID] // 0x000000018967A390-0x000000018967A3B0
	private void SetupShopMaterialWidget() {} // 0x0000000183096970-0x0000000183096AC0
	// [XID] // 0x0000000189681BE0-0x0000000189681C00
	private void CloseShopMaterialWidget() {} // 0x00000001830985F0-0x00000001830986B0
	// [XID] // 0x0000000189689670-0x0000000189689690
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183097AF0-0x00000001830981C0
	// [XID] // 0x00000001896912B0-0x00000001896912D0
	private void OnSelectRewardStateChange(Transform trans, bool isSelect) {} // 0x00000001830984C0-0x00000001830985F0
	// [XID] // 0x0000000189698A60-0x0000000189698A80
	private void ShowRewardItemDetail() {} // 0x00000001830982A0-0x00000001830984C0
}

