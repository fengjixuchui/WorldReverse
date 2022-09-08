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

public sealed class ActivityExtraTaskDialog : BaseDialogContext // TypeDefIndex: 29508
{
	// Fields
	private MonoActivityExtraTaskDialog _dialogMono; // 0x178
	private ActivityInfo activityInfo; // 0x180
	private int curSelectItemIndex; // 0x188
	private List<MonoTaskListRow> taskItemList; // 0x190
	private List<RewardItemConfig> _rewardList; // 0x198

	// Constructors
	public ActivityExtraTaskDialog() {} // 0x0000000181D11520-0x0000000181D11630

	// Methods
	// [XID] // 0x00000001897A7110-0x00000001897A7130
	public override void SetupView() {} // 0x0000000181D11440-0x0000000181D11520
	// [XID] // 0x00000001897AEAC0-0x00000001897AEAE0
	protected override void BindViewCallbacks() {} // 0x0000000181D0ED50-0x0000000181D0EE50
	// [XID] // 0x00000001897B6950-0x00000001897B6970
	private void Refresh() {} // 0x0000000181D0E760-0x0000000181D0EAE0
	// [XID] // 0x00000001897BE790-0x00000001897BE7B0
	private void RefreshExtraTask(MonoActivityExtraTaskItem monoTaskItem, AsterPhase stage) {} // 0x0000000181D10C40-0x0000000181D11270
	// [XID] // 0x00000001897C5EA0-0x00000001897C5EC0
	public void SetupTaskList(MonoActivityExtraTaskItem monoTaskItem, AsterPhase stage, SimpleSafeUInt32[] taskList) {} // 0x0000000181D10A20-0x0000000181D10C40
	// [XID] // 0x00000001897CD640-0x00000001897CD660
	private void RefreshQuestItem(MonoTaskListRow taskItem, uint subQuestId, bool isOpen) {} // 0x0000000181D0EE50-0x0000000181D0F280
	// [XID] // 0x00000001897D4C00-0x00000001897D4C20
	private void RefreshQuestItemLittle(Transform trans, int index) {} // 0x0000000181D10050-0x0000000181D10320
	// [XID] // 0x00000001897DC320-0x00000001897DC340
	private void RefreshQuestItemMid(Transform trans, int index) {} // 0x0000000181D0FA50-0x0000000181D0FD20
	// [XID] // 0x00000001897E3C30-0x00000001897E3C50
	private void RefreshQuestItemLarge(Transform trans, int index) {} // 0x0000000181D10400-0x0000000181D106D0
	// [XID] // 0x00000001897EB8A0-0x00000001897EB8C0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000181D0F280-0x0000000181D0F500
	// [XID] // 0x00000001897F3180-0x00000001897F31A0
	private void OnTaskPositionClick(uint subQuestId) {} // 0x0000000181D0EAE0-0x0000000181D0ED50
	// [XID] // 0x00000001897FA9F0-0x00000001897FAA10
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181D0FD80-0x0000000181D0FEA0
	// [XID] // 0x0000000189801FC0-0x0000000189801FE0
	private void PreItem() {} // 0x0000000181D106D0-0x0000000181D109C0
	// [XID] // 0x0000000189809430-0x0000000189809450
	private void NextItem() {} // 0x0000000181D0F730-0x0000000181D0FA50
	// [XID] // 0x0000000189810C40-0x0000000189810C60
	private void SetupForJoypad() {} // 0x0000000181D11270-0x0000000181D11440
	// [XID] // 0x00000001898186F0-0x0000000189818710
	private void OnConfirm() {} // 0x0000000181D0F590-0x0000000181D0F730
	// [XID] // 0x000000018981FFC0-0x000000018981FFE0
	private void RefreshButtonState() {} // 0x0000000181D0FEA0-0x0000000181D10050
}

