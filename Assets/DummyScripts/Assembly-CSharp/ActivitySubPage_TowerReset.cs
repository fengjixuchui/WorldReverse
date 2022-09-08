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

public sealed class ActivitySubPage_TowerReset : BaseSubPageContext // TypeDefIndex: 29428
{
	// Fields
	private const uint TOWER_DUNGEON_ID = 45; // Metadata: 0x00B0F7D3
	private uint _activityId; // 0x178
	private MonoActivityTowerResetSubPage _pageMono; // 0x180
	private List<RewardItemConfig> _rewardList; // 0x188

	// Properties
	public static bool towerResetSubPageOpened { /* [XID] */ /* 0x00000001896F6CE0-0x00000001896F6D20 */ get; /* [XID] */ /* 0x00000001897011B0-0x00000001897011F0 */ private set; } // 0x0000000182B27D00-0x0000000182B27D60 0x0000000182B29AC0-0x0000000182B29B20

	// Constructors
	public ActivitySubPage_TowerReset() {} // Dummy constructor
	public ActivitySubPage_TowerReset(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000182B29DD0-0x0000000182B29EC0

	// Methods
	// [XID] // 0x000000018970B9C0-0x000000018970B9E0
	public override void SetupView() {} // 0x0000000182B29BF0-0x0000000182B29DD0
	// [XID] // 0x0000000189713290-0x00000001897132B0
	protected override void BindViewCallbacks() {} // 0x0000000182B27D60-0x0000000182B27F70
	// [XID] // 0x000000018971AA50-0x000000018971AA70
	protected override void OnEnable() {} // 0x0000000182B29B20-0x0000000182B29BF0
	// [XID] // 0x0000000189721DD0-0x0000000189721DF0
	private void Refresh() {} // 0x0000000182B27680-0x0000000182B27BF0
	// [XID] // 0x00000001897294A0-0x00000001897294C0
	private void InitRewardItem(Transform trans, int index) {} // 0x0000000182B28360-0x0000000182B285B0
	// [XID] // 0x0000000189730C80-0x0000000189730CA0
	private List<RewardItemConfig> GetAllRewardItemList(uint floorIndex, uint levelIndex, bool isFinishedEntranceFloor) => default; // 0x0000000182B28D30-0x0000000182B294E0
	// [XID] // 0x00000001897385B0-0x00000001897385D0
	private void AddRewardItemCount(Dictionary<uint, uint> rewardDict, RewardExcelConfig rewardConfig) {} // 0x0000000182B28730-0x0000000182B28980
	// [XID] // 0x0000000189740350-0x0000000189740370
	private void GetEntranceFloorAndLevelIndex(out uint entranceFloorIndex, out uint entranceLevelIndex) {
		entranceFloorIndex = default;
		entranceLevelIndex = default;
	} // 0x0000000182B28980-0x0000000182B28D30
	// [XID] // 0x00000001897476E0-0x0000000189747700
	private void OnClickDescBtn() {} // 0x0000000182B27BF0-0x0000000182B27D00
	// [XID] // 0x000000018974EDF0-0x000000018974EE10
	private void OnClickInfoBtn() {} // 0x0000000182B29950-0x0000000182B29AC0
	// [XID] // 0x00000001897564E0-0x0000000189756500
	private void OnClickGotoBtn() {} // 0x0000000182B285B0-0x0000000182B28730
	// [XID] // 0x000000018975D960-0x000000018975D980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182B29540-0x0000000182B298F0
	// [XID] // 0x0000000189764EB0-0x0000000189764ED0
	private void FocusOnSubPage(bool focusOnSubPage) {} // 0x0000000182B27F70-0x0000000182B28270
}

