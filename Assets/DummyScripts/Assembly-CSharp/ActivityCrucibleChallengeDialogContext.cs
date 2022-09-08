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

public sealed class ActivityCrucibleChallengeDialogContext : BaseDialogContext // TypeDefIndex: 29503
{
	// Fields
	private MonoActivityCrucibleChallengeDialog _dialogMono; // 0x178
	private List<CrucibleAchievement> crucibleAchievementList; // 0x180
	private List<RewardItemConfig> _tempRewardList; // 0x188
	private int _slotItemIndex; // 0x190

	// Constructors
	public ActivityCrucibleChallengeDialogContext() {} // 0x00000001835801F0-0x0000000183580300

	// Methods
	// [XID] // 0x00000001896BD090-0x00000001896BD0B0
	public override void SetupView() {} // 0x00000001835800C0-0x00000001835801F0
	// [XID] // 0x00000001896C4510-0x00000001896C4530
	protected override void BindViewCallbacks() {} // 0x000000018357DE70-0x000000018357DF80
	// [XID] // 0x00000001896CBBB0-0x00000001896CBBD0
	private void Refresh() {} // 0x000000018357DA40-0x000000018357DE70
	// [XID] // 0x00000001896D2E90-0x00000001896D2EB0
	private void RefreshRowSelectState(RectTransform trans, bool selected) {} // 0x000000018357E330-0x000000018357E580
	// [XID] // 0x00000001896DAA20-0x00000001896DAA40
	private int CompareCrucibleAchievementStruct(CrucibleAchievement xData, CrucibleAchievement yData) => default; // 0x000000018357FDC0-0x000000018357FEF0
	// [XID] // 0x00000001896E2190-0x00000001896E21B0
	private void RefreshAchievementRow(Transform trans, int index) {} // 0x000000018357E9B0-0x000000018357EEA0
	// [XID] // 0x00000001896E96B0-0x00000001896E96D0
	private void ReceiveTargetReward(uint achievementID) {} // 0x000000018357DF80-0x000000018357E0E0
	// [XID] // 0x00000001896F08F0-0x00000001896F0910
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018357E0E0-0x000000018357E330
	// [XID] // 0x00000001896F8100-0x00000001896F8120
	public override bool OnNotify(Notify ntf) => default; // 0x000000018357FFE0-0x00000001835800C0
	// [XID] // 0x00000001896FFA60-0x00000001896FFA80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018357F4A0-0x000000018357FBB0
	// [XID] // 0x00000001897070F0-0x0000000189707110
	private void ToRight() {} // 0x000000018357FBB0-0x000000018357FDC0
	// [XID] // 0x000000018970E970-0x000000018970E990
	private void ToLeft() {} // 0x000000018357EF30-0x000000018357F140
	// [XID] // 0x0000000189715DD0-0x0000000189715DF0
	private void RefreshCurrentSlotItem(MonoInvestigationListRow row, bool prev) {} // 0x000000018357E580-0x000000018357E9B0
	// [XID] // 0x000000018971D810-0x000000018971D830
	private void ClearCurrentItem() {} // 0x000000018357F140-0x000000018357F440
}

