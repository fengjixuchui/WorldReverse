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

public sealed class HideandSeekRewardDialogContext : BaseDialogContext // TypeDefIndex: 30116
{
	// Fields
	private MonoHideandSeekRewardDialog _pageMono; // 0x178
	private ActivityInfo activityInfo; // 0x180
	private List<RewardItemConfig> _tempRewardList; // 0x188
	private ActivityHideAndSeekBasicConfig _config; // 0x190
	private List<ActivityScoreStruct> scoreConfigList; // 0x198
	private List<ActivityWatcherStruct> activityWatcherList; // 0x1A0
	private TABTYPE curTab; // 0x1A8

	// Nested types
	private enum TABTYPE // TypeDefIndex: 30117
	{
		NONE = 0,
		SCORE = 1,
		WATCHER = 2
	}

	// Constructors
	public HideandSeekRewardDialogContext() {} // 0x0000000182A3A2A0-0x0000000182A3A3E0

	// Methods
	// [XID] // 0x0000000189917050-0x0000000189917070
	public override void SetupView() {} // 0x0000000182A3A1D0-0x0000000182A3A2A0
	// [XID] // 0x000000018991E750-0x000000018991E770
	public override void ClearView() {} // 0x0000000182A37D60-0x0000000182A37EB0
	// [XID] // 0x0000000189925FB0-0x0000000189925FD0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182A3A000-0x0000000182A3A120
	// [XID] // 0x000000018992D5A0-0x000000018992D5C0
	private void UpdateActivity(uint activityId) {} // 0x0000000182A39D30-0x0000000182A39DE0
	// [XID] // 0x0000000189934AF0-0x0000000189934B10
	private void Refresh(bool setup) {} // 0x0000000182A36F00-0x0000000182A37300
	// [XID] // 0x000000018993C5C0-0x000000018993C5E0
	private void RefreshScoreItem(Transform trans, int index) {} // 0x0000000182A38D80-0x0000000182A393D0
	// [XID] // 0x0000000189943C30-0x0000000189943C50
	private void ReceiveScoreReward(uint scoreID) {} // 0x0000000182A38C60-0x0000000182A38D80
	// [XID] // 0x000000018994B130-0x000000018994B150
	private void RefreshTaskItem(Transform trans, int index) {} // 0x0000000182A38380-0x0000000182A38930
	// [XID] // 0x0000000189952B60-0x0000000189952B80
	private void ReceiveTargetReward(uint watcherID) {} // 0x0000000182A37980-0x0000000182A37AA0
	// [XID] // 0x000000018995A090-0x000000018995A0B0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000182A37EB0-0x0000000182A38100
	// [XID] // 0x0000000189961AA0-0x0000000189961AC0
	protected override void BindViewCallbacks() {} // 0x0000000182A37670-0x0000000182A37980
	// [XID] // 0x0000000189969170-0x0000000189969190
	protected override void PostSetupView() {} // 0x0000000182A3A120-0x0000000182A3A1D0
	// [XID] // 0x0000000189970C30-0x0000000189970C50
	protected override void BindRedPoints() {} // 0x0000000182A37530-0x0000000182A37670
	// [XID] // 0x0000000189978590-0x00000001899785B0
	private void OnBtnScoreClick() {} // 0x0000000182A37300-0x0000000182A374D0
	// [XID] // 0x000000018997F690-0x000000018997F6B0
	private void OnBtnWatcherClick() {} // 0x0000000182A381B0-0x0000000182A38380
	// [XID] // 0x0000000189986FE0-0x0000000189987000
	private void OnBtnCloseClick() {} // 0x0000000182A38100-0x0000000182A381B0
	// [XID] // 0x000000018998EAD0-0x000000018998EAF0
	private void SetupWatcherList() {} // 0x0000000182A39430-0x0000000182A39900
	// [XID] // 0x00000001899966B0-0x00000001899966D0
	private int CompareWatcherStruct(ActivityWatcherStruct xData, ActivityWatcherStruct yData) => default; // 0x0000000182A37C10-0x0000000182A37D60
	// [XID] // 0x000000018999E190-0x000000018999E1B0
	private void SetupScoreList() {} // 0x0000000182A38930-0x0000000182A38C00
	// [XID] // 0x00000001899A5B50-0x00000001899A5B70
	private int CompareScore(ActivityScoreStruct xData, ActivityScoreStruct yData) => default; // 0x0000000182A39960-0x0000000182A39AD0
	// [XID] // 0x00000001899AD250-0x00000001899AD270
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x0000000182A39E70-0x0000000182A3A000
	// [XID] // 0x00000001899B4A30-0x00000001899B4A50
	private void UpdateWatcherButtonByIndex(int index) {} // 0x0000000182A37AA0-0x0000000182A37C10
	// [XID] // 0x00000001899BC150-0x00000001899BC170
	private void UpdateScoreButtonByIndex(int index) {} // 0x0000000182A39AD0-0x0000000182A39CD0
}

