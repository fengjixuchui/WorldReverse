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

public sealed class ActivityWatcherRewardDialog : BaseDialogContext // TypeDefIndex: 29529
{
	// Fields
	private MonoActivityWatcherRewardDialog _dialogMono; // 0x178
	private List<ActivityWatcherStruct> activityWatcherList; // 0x180
	private ActivityInfo activityInfo; // 0x188
	private List<RewardItemConfig> _tempRewardList; // 0x190
	private uint _activityID; // 0x198
	private SimpleSafeUInt32[] _watcherIDList; // 0x1A0

	// Constructors
	public ActivityWatcherRewardDialog() {} // Dummy constructor
	public ActivityWatcherRewardDialog(uint activityID, SimpleSafeUInt32[] watcherIDList) {} // 0x0000000183A87F90-0x0000000183A880C0

	// Methods
	// [XID] // 0x0000000189AC3620-0x0000000189AC3640
	public override void SetupView() {} // 0x0000000183A87E60-0x0000000183A87F90
	// [XID] // 0x0000000189ACACB0-0x0000000189ACACD0
	protected override void BindViewCallbacks() {} // 0x0000000183A86980-0x0000000183A86A90
	// [XID] // 0x0000000189AD2720-0x0000000189AD2740
	private void Refresh() {} // 0x0000000183A86790-0x0000000183A86980
	// [XID] // 0x0000000189ADA1B0-0x0000000189ADA1D0
	private void RefreshTaskItem(Transform trans, int index) {} // 0x0000000183A86F50-0x0000000183A87500
	// [XID] // 0x0000000189AE1A70-0x0000000189AE1A90
	private void ReceiveTargetReward(uint watcherID) {} // 0x0000000183A86A90-0x0000000183A86BB0
	// [XID] // 0x0000000189AE9220-0x0000000189AE9240
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000183A86D00-0x0000000183A86F50
	// [XID] // 0x0000000189AF1030-0x0000000189AF1050
	private void SetupWatcherList() {} // 0x0000000183A87560-0x0000000183A879E0
	// [XID] // 0x0000000189AF84D0-0x0000000189AF84F0
	private int CompareWatcherStruct(ActivityWatcherStruct xData, ActivityWatcherStruct yData) => default; // 0x0000000183A86BB0-0x0000000183A86D00
	// [XID] // 0x0000000189AFFBE0-0x0000000189AFFC00
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183A87D80-0x0000000183A87E60
	// [XID] // 0x0000000189B07190-0x0000000189B071B0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x0000000183A87C40-0x0000000183A87D80
	// [XID] // 0x0000000189B0E970-0x0000000189B0E990
	private void UpdateButtonByIndex(int index) {} // 0x0000000183A879E0-0x0000000183A87B50
}

