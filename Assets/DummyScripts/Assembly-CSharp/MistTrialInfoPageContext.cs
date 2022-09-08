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

public sealed class MistTrialInfoPageContext : BasePageContext // TypeDefIndex: 30194
{
	// Fields
	private MonoMistTrialInfoPage _pageMono; // 0x190
	private List<MonoBtnTab> _monoTabList; // 0x198
	private readonly List<string> TabTextList; // 0x1A0
	private TabState _tabState; // 0x1A8
	private ActivityMistTrialLevelDataExcelConfig _levelConfig; // 0x1B0
	private SimpleSafeUInt32[] _monsterIdList; // 0x1B8
	private RepeatedMessageField<MistTrialMissionInfo> watcherInfoList; // 0x1C0
	private List<RewardItemConfig> rewardList; // 0x1C8
	private bool _isLeftRegion; // 0x1D0

	// Nested types
	public enum TabState // TypeDefIndex: 30195
	{
		Watcher = 0,
		Monster = 1,
		Count = 2
	}

	// Constructors
	public MistTrialInfoPageContext() {} // 0x0000000182EE2830-0x0000000182EE2A00

	// Methods
	// [XID] // 0x0000000189915550-0x0000000189915570
	public override void SetupView() {} // 0x0000000182EE2750-0x0000000182EE2830
	// [XID] // 0x000000018991CFA0-0x000000018991CFC0
	public override void ClearView() {} // 0x0000000182EDFFD0-0x0000000182EE00D0
	// [XID] // 0x0000000189924810-0x0000000189924830
	protected override void BindViewCallbacks() {} // 0x0000000182EDFBC0-0x0000000182EDFCE0
	// [XID] // 0x000000018992BDC0-0x000000018992BDE0
	private void Refresh() {} // 0x0000000182EDFB10-0x0000000182EDFBC0
	// [XID] // 0x00000001899332F0-0x0000000189933310
	private void RefreshLeftTab() {} // 0x0000000182EE1430-0x0000000182EE1560
	// [XID] // 0x000000018993AE80-0x000000018993AEA0
	private void InitMenu(Transform trans, int index) {} // 0x0000000182EE0B80-0x0000000182EE0E10
	// [XID] // 0x0000000189941EF0-0x0000000189941F10
	private void OnTabClick(int index) {} // 0x0000000182EE19C0-0x0000000182EE1DB0
	// [XID] // 0x00000001899499D0-0x00000001899499F0
	private void RefreshRightMonster() {} // 0x0000000182EE1560-0x0000000182EE1610
	// [XID] // 0x00000001899513E0-0x0000000189951400
	private void RefreshFactorScroll() {} // 0x0000000182EE0E10-0x0000000182EE0FC0
	// [XID] // 0x0000000189958A30-0x0000000189958A50
	private void InitFactorItem(Transform trans, int index) {} // 0x0000000182EE2080-0x0000000182EE2320
	// [XID] // 0x0000000189960070-0x0000000189960090
	private void RefreshMonsterScroll() {} // 0x0000000182EE00D0-0x0000000182EE0220
	// [XID] // 0x0000000189967B10-0x0000000189967B30
	private void InitMonsterItem(Transform trans, int index) {} // 0x0000000182EE1610-0x0000000182EE1960
	// [XID] // 0x000000018996ECD0-0x000000018996ECF0
	private void RefreshRightWatcher() {} // 0x0000000182EE1DB0-0x0000000182EE2080
	// [XID] // 0x00000001899768D0-0x00000001899768F0
	private void InitWatcherListRow(Transform trans, int index) {} // 0x0000000182EE0FC0-0x0000000182EE1430
	// [XID] // 0x000000018997DCF0-0x000000018997DD10
	private void InitRewardItem(Transform trans, int index) {} // 0x0000000182EE0360-0x0000000182EE0630
	// [XID] // 0x00000001899856A0-0x00000001899856C0
	private void OnBtnCloseClick() {} // 0x0000000182EE0220-0x0000000182EE02D0
	// [XID] // 0x000000018998D470-0x000000018998D490
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182EE0690-0x0000000182EE0B20
	// [XID] // 0x0000000189994EF0-0x0000000189994F10
	private void ChangeRegion(bool toRight) {} // 0x0000000182EE2320-0x0000000182EE2750
	// [XID] // 0x000000018999C7D0-0x000000018999C7F0
	private void RefreshPS4Btn() {} // 0x0000000182EDFCE0-0x0000000182EDFFD0
}

