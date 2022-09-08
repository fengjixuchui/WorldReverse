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

public sealed class ActivityScoreRewardDialog : BaseDialogContext // TypeDefIndex: 29525
{
	// Fields
	private MonoActivityScoreRewardDialog _dialogMono; // 0x178
	private ActivityInfo activityInfo; // 0x180
	private List<RewardItemConfig> _tempRewardList; // 0x188
	private uint _activityID; // 0x190
	private SimpleSafeUInt32[] _scoreIDList; // 0x198
	private List<ActivityScoreStruct> scoreConfigList; // 0x1A0

	// Constructors
	public ActivityScoreRewardDialog() {} // Dummy constructor
	public ActivityScoreRewardDialog(uint activityID, SimpleSafeUInt32[] scoreIDList) {} // 0x00000001851AC470-0x00000001851AC5A0

	// Methods
	// [XID] // 0x0000000189A3BD90-0x0000000189A3BDB0
	public override void SetupView() {} // 0x00000001851AC390-0x00000001851AC470
	// [XID] // 0x0000000189A439E0-0x0000000189A43A00
	protected override void BindViewCallbacks() {} // 0x00000001851AAFD0-0x00000001851AB0E0
	// [XID] // 0x0000000189A4AE30-0x0000000189A4AE50
	private void SetupScoreList() {} // 0x00000001851AB330-0x00000001851AB5A0
	// [XID] // 0x0000000189A52550-0x0000000189A52570
	private void Refresh() {} // 0x00000001851AAD30-0x00000001851AAFD0
	// [XID] // 0x0000000189A59EA0-0x0000000189A59EC0
	private void RefreshScoreItem(Transform trans, int index) {} // 0x00000001851AB720-0x00000001851ABD10
	// [XID] // 0x0000000189A61670-0x0000000189A61690
	private void ReceiveScoreReward(uint scoreID) {} // 0x00000001851AB600-0x00000001851AB720
	// [XID] // 0x0000000189A695B0-0x0000000189A695D0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x00000001851AB0E0-0x00000001851AB330
	// [XID] // 0x0000000189A70920-0x0000000189A70940
	private int CompareScore(ActivityScoreStruct xData, ActivityScoreStruct yData) => default; // 0x00000001851ABD10-0x00000001851ABE80
	// [XID] // 0x0000000189A781D0-0x0000000189A781F0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001851AC2B0-0x00000001851AC390
	// [XID] // 0x0000000189A7F7E0-0x0000000189A7F800
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x00000001851AC170-0x00000001851AC2B0
	// [XID] // 0x0000000189A87500-0x0000000189A87520
	private void UpdateButtonByIndex(int index) {} // 0x00000001851ABE80-0x00000001851AC080
}

