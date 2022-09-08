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

public sealed class BPRewardDialogContext : BaseDialogContext // TypeDefIndex: 28914
{
	// Fields
	private MonoBPRewardDialog _dialogMono; // 0x178
	private List<BPRewardSelectStruct> _toSelectRewardList; // 0x180
	private List<BattlePassRewardTakeOption> _readyRewardList; // 0x188
	private bool _isSimple; // 0x190
	private int _curSelectedIndex; // 0x194
	private bool _isWeapon; // 0x198
	private List<uint> _currRewardIdList; // 0x1A0
	private List<uint> _currItemIdList; // 0x1A8
	private int _selectedOptionIndex; // 0x1B0
	private int _selectedRewardRowIndex; // 0x1B4
	private List<RewardItemConfig> _tempRewardList; // 0x1B8

	// Constructors
	public BPRewardDialogContext() {} // Dummy constructor
	public BPRewardDialogContext(List<BPRewardSelectStruct> toSelectList, List<BattlePassRewardTakeOption> readyList = null) {} // 0x00000001832C1CF0-0x00000001832C1E30

	// Methods
	// [XID] // 0x00000001896BFE70-0x00000001896BFE90
	public override void SetupView() {} // 0x00000001832C1A80-0x00000001832C1CF0
	// [XID] // 0x00000001896C7770-0x00000001896C7790
	protected override void BindViewCallbacks() {} // 0x00000001832BE6C0-0x00000001832BE930
	// [XID] // 0x00000001896CEF10-0x00000001896CEF30
	private void RefreshSelectView() {} // 0x00000001832BFB10-0x00000001832C01F0
	// [XID] // 0x00000001896D6310-0x00000001896D6330
	private void RefreshCurrRewardIdList(string[] paramList) {} // 0x00000001832BE930-0x00000001832BEB10
	// [XID] // 0x00000001896DD930-0x00000001896DD950
	private void RefreshCurrItemIdList(string[] paramList) {} // 0x00000001832C1010-0x00000001832C11F0
	// [XID] // 0x00000001896E4FE0-0x00000001896E5000
	private void RefreshRewardSelectItem(Transform trans, int index) {} // 0x00000001832BEE50-0x00000001832BF300
	// [XID] // 0x00000001896EC480-0x00000001896EC4A0
	private void RefreshCardRewardItem(Transform trans, int index) {} // 0x00000001832C1620-0x00000001832C1770
	// [XID] // 0x00000001896F3C50-0x00000001896F3C70
	private void OnCardItemClick(int index) {} // 0x00000001832C09D0-0x00000001832C0F50
	// [XID] // 0x00000001896FB3C0-0x00000001896FB3E0
	private MonoItemSlot GetSelectRewardSlot(MonoBPRewardCard cardItem, int index) => default; // 0x00000001832C13D0-0x00000001832C1620
	// [XID] // 0x0000000189702B50-0x0000000189702B70
	private void RefreshWeaponSelectItem(Transform trans, int index) {} // 0x00000001832BEB10-0x00000001832BEE50
	// [XID] // 0x000000018970A290-0x000000018970A2B0
	private void OnWeaponItemClick(int index) {} // 0x00000001832BF430-0x00000001832BF7D0
	// [XID] // 0x0000000189711D70-0x0000000189711D90
	private void OnOKBtnClick() {} // 0x00000001832BF830-0x00000001832BFB10
	// [XID] // 0x00000001897191B0-0x00000001897191D0
	private void OnNextBtnClick() {} // 0x00000001832BE420-0x00000001832BE6C0
	// [XID] // 0x0000000189720870-0x0000000189720890
	private void OnCancelBtnClick() {} // 0x00000001832BE2E0-0x00000001832BE420
	// [XID] // 0x0000000189727E20-0x0000000189727E40
	private void OnForceGetBtnClick() {} // 0x00000001832BF390-0x00000001832BF430
	// [XID] // 0x000000018972F460-0x000000018972F480
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001832C01F0-0x00000001832C03B0
	// [XID] // 0x0000000189736EA0-0x0000000189736EC0
	private void MoveSelectRewardToIndex(int index) {} // 0x00000001832C0F50-0x00000001832C1010
	// [XID] // 0x000000018973EA60-0x000000018973EA80
	private void MoveRewardSlotToIndex(int index) {} // 0x00000001832C17D0-0x00000001832C1A80
	// [XID] // 0x0000000189745D20-0x0000000189745D40
	private void ShowRewardItemDetail() {} // 0x00000001832C06D0-0x00000001832C09D0
	// [XID] // 0x000000018974D810-0x000000018974D830
	private void OnInputCommonMenuUpEvent() {} // 0x00000001832C11F0-0x00000001832C13D0
	// [XID] // 0x0000000189754E70-0x0000000189754E90
	private void OnInputConfirmEvent() {} // 0x00000001832C03B0-0x00000001832C06D0
}

