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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonEntryPageContext : BasePageContext // TypeDefIndex: 28994
{
	// Fields
	private MonoDungeonEntryPage _pageMono; // 0x190
	private uint _pointID; // 0x198
	private int _recommendDungeonIndex; // 0x19C
	private List<DungeonExcelConfig> _dungeonConfigList; // 0x1A0
	private List<IdCountStrConfig> _rewardList; // 0x1A8
	private List<uint> _trialAvatarList; // 0x1B0
	private int _selectedIndex; // 0x1B8
	private bool _selectedRefreshed; // 0x1BC
	private uint _currAvatarLevel; // 0x1C0
	private uint _currPlayerLevel; // 0x1C4
	private bool _currDungeonAvaliable; // 0x1C8
	private bool _isInitialized; // 0x1C9
	private bool _isCycleDungeonEntry; // 0x1CA
	private bool _isDailyRefreshCycleDungeonEntry; // 0x1CB
	private bool _isBossDungeonEntry; // 0x1CC
	private uint _bossRewardCost; // 0x1D0
	private GeneralDialogContext _generalDialog; // 0x1D8
	private bool _showRetain; // 0x1E0
	private float _lastUpdateTime; // 0x1E4
	private int _rewardRefreshTimeRecordSecond; // 0x1E8
	private ulong _nextSendReqTime; // 0x1F0
	private readonly uint _intervalTime; // 0x1F8
	private List<DungeonEntryInfo> _dungeonEntryInfos; // 0x200
	private static List<ElementType> _lackElementTypes; // 0x00
	private bool _canChallenge; // 0x208
	private bool _multiplayerMode; // 0x209
	private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x210

	// Nested types
	private struct DungeonEntryInfo // TypeDefIndex: 28995
	{
		// Fields
		public uint id; // 0x00
		public bool isPassed; // 0x04
		public uint startTime; // 0x08
		public uint endTime; // 0x0C
		public uint maxBossChestNum; // 0x10
		public uint openedBossChestNum; // 0x14
		public uint nextRefreshTime; // 0x18
		public WeeklyBossResinDiscountInfoStruct weeklyBossResinDiscount; // 0x1C
	}

	// Constructors
	public DungeonEntryPageContext() {} // Dummy constructor
	public DungeonEntryPageContext(uint pointID) {} // 0x0000000181EF5E40-0x0000000181EF5FF0
	static DungeonEntryPageContext() {} // 0x0000000181EF5DB0-0x0000000181EF5E40

	// Methods
	// [XID] // 0x00000001899B1D10-0x00000001899B1D30
	public override void SetupView() {} // 0x0000000181EF5AE0-0x0000000181EF5CC0
	// [XID] // 0x00000001899B9050-0x00000001899B9070
	public override void ClearView() {} // 0x0000000181EED3F0-0x0000000181EED540
	// [XID] // 0x00000001899C0910-0x00000001899C0930
	protected override void OnEnable() {} // 0x0000000181EF3EA0-0x0000000181EF3F50
	// [XID] // 0x00000001899C8160-0x00000001899C8180
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181EEF6E0-0x0000000181EF00B0
	// [XID] // 0x00000001899CFAE0-0x00000001899CFB00
	protected override void BindViewCallbacks() {} // 0x0000000181EED0F0-0x0000000181EED3F0
	// [XID] // 0x00000001899D6EF0-0x00000001899D6F10
	public override void UpdateView() {} // 0x0000000181EF5CC0-0x0000000181EF5DB0
	// [XID] // 0x00000001899DE480-0x00000001899DE4A0
	private void UpdateRewardRefreshTimeText(bool isForce) {} // 0x0000000181EF4500-0x0000000181EF4910
	// [XID] // 0x00000001899E6120-0x00000001899E6140
	protected override void RegisterHandlePacket() {} // 0x0000000181EF5A30-0x0000000181EF5AE0
	// [XID] // 0x00000001899ED510-0x00000001899ED530
	public override bool OnPacket(Packet packet) => default; // 0x0000000181EF4110-0x0000000181EF4490
	// [XID] // 0x00000001899F5080-0x00000001899F50A0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181EF3F50-0x0000000181EF4110
	// [XID] // 0x00000001899FC650-0x00000001899FC670
	private void OnScenePlayerListNotify() {} // 0x0000000181EF0880-0x0000000181EF0930
	// [XID] // 0x0000000189A03C40-0x0000000189A03C60
	private int DungeonSortOrder(DungeonEntryInfo dungeonInfo1, DungeonEntryInfo dungeonInfo2) => default; // 0x0000000181EF2620-0x0000000181EF2770
	// [XID] // 0x0000000189A0B150-0x0000000189A0B170
	private void Refresh(uint pointID, uint recommendDungeonID) {} // 0x0000000181EEC2E0-0x0000000181EEC810
	// [XID] // 0x0000000189A12A80-0x0000000189A12AA0
	private void RefreshDungeonEntryItem(Transform trans, int index) {} // 0x0000000181EF4F20-0x0000000181EF5880
	// [XID] // 0x0000000189A19CB0-0x0000000189A19CD0
	private void RefreshSelected(Transform currSelected, DungeonExcelConfig config) {} // 0x0000000181EECFD0-0x0000000181EED0F0
	// [XID] // 0x0000000189A21300-0x0000000189A21320
	private void RefreshTips(DungeonExcelConfig config, bool forceHidden) {} // 0x0000000181EEEEE0-0x0000000181EEF450
	// [XID] // 0x0000000189A28920-0x0000000189A28940
	private void OnDungeonEntryItemClicked(int index, bool force = false /* Metadata: 0x00B0E90E */) {} // 0x0000000181EF0DF0-0x0000000181EF2100
	// [XID] // 0x0000000189A2FF50-0x0000000189A2FF70
	private void CheckFleurFair(DungeonExcelConfig config) {} // 0x0000000181EEC870-0x0000000181EECF50
	// [XID] // 0x0000000189A37960-0x0000000189A37980
	private void RefreshRecommendElements(int index) {} // 0x0000000181EEE120-0x0000000181EEEEE0
	// [XID] // 0x0000000189A3F090-0x0000000189A3F0B0
	private void RefreshRewardList(uint rewardPreviewID) {} // 0x0000000181EF0930-0x0000000181EF0A30
	// [XID] // 0x0000000189A46750-0x0000000189A46770
	private void RefreshRewardBagItem(Transform trans, int index) {} // 0x0000000181EF0320-0x0000000181EF05E0
	// [XID] // 0x0000000189A4DF60-0x0000000189A4DF80
	private void RefreshTrialAvatarIcon(Transform trans, int index) {} // 0x0000000181EF4D10-0x0000000181EF4F20
	// [XID] // 0x0000000189A556D0-0x0000000189A556F0
	private void DoStart() {} // 0x0000000181EF3520-0x0000000181EF3B70
	// [XID] // 0x0000000189A5D050-0x0000000189A5D070
	private void OnStart() {} // 0x0000000181EF0B00-0x0000000181EF0CE0
	// [XID] // 0x0000000189A648F0-0x0000000189A64910
	private void ShowTips(string title, string desc) {} // 0x0000000181EF2330-0x0000000181EF2540
	// [XID] // 0x0000000189A6C110-0x0000000189A6C130
	private void CheckBossChestCount() {} // 0x0000000181EF0110-0x0000000181EF0320
	// [XID] // 0x0000000189A73880-0x0000000189A738A0
	private void MultiplayerDungeon(DungeonExcelConfig config, bool isPassed) {} // 0x0000000181EF5880-0x0000000181EF5A30
	// [XID] // 0x0000000189A7B3E0-0x0000000189A7B400
	private void CheckMultiplayer() {} // 0x0000000181EF2B30-0x0000000181EF2D00
	// [XID] // 0x0000000189A82AE0-0x0000000189A82B00
	private void HintMPInvite(DungeonExcelConfig config) {} // 0x0000000181EF05E0-0x0000000181EF0880
	// [XID] // 0x0000000189A8A490-0x0000000189A8A4B0
	private void ConfirmTeam(DungeonExcelConfig config, bool multiplayer = false /* Metadata: 0x00B0E90F */) {} // 0x0000000181EED7F0-0x0000000181EEDA50
	// [XID] // 0x0000000189A91C90-0x0000000189A91CB0
	private void CheckServerAnnounce(DungeonExcelConfig config, bool multiplayer = false /* Metadata: 0x00B0E910 */, bool bigWorldMultiplayer = false /* Metadata: 0x00B0E911 */) {} // 0x0000000181EEDA50-0x0000000181EEE050
	// [XID] // 0x0000000189A99760-0x0000000189A99780
	private void InitResinView() {} // 0x0000000181EF4910-0x0000000181EF4D10
	// [XID] // 0x0000000189AA07B0-0x0000000189AA07D0
	private void RefreshResinView() {} // 0x0000000181EED540-0x0000000181EED700
	// [XID] // 0x0000000189AA7DB0-0x0000000189AA7DD0
	private void InitDungeonEntryShow() {} // 0x0000000181EF2770-0x0000000181EF2B30
	// [XID] // 0x0000000189AAF8A0-0x0000000189AAF8C0
	private void OnDungeonEntryTipsClick(uint pointID) {} // 0x0000000181EF0CE0-0x0000000181EF0DF0
	// [XID] // 0x0000000189AB7150-0x0000000189AB7170
	private void OnAvatarIconClicked(uint configId) {} // 0x0000000181EEE050-0x0000000181EEE120
	// [XID] // 0x0000000189ABEBA0-0x0000000189ABEBC0
	private void OnDescriptionButton() {} // 0x0000000181EF3BD0-0x0000000181EF3CE0
	// [XID] // 0x0000000189AC6710-0x0000000189AC6730
	private void OnPreviewButton() {} // 0x0000000181EEF570-0x0000000181EEF680
	// [XID] // 0x0000000189ACDD80-0x0000000189ACDDA0
	private void CheckMatchState(DungeonExcelConfig config, bool isPassed) {} // 0x0000000181EF30B0-0x0000000181EF3520
	// [XID] // 0x0000000189AD5B40-0x0000000189AD5B60
	private void OnCancelMatchButton() {} // 0x0000000181EF2540-0x0000000181EF2620
	// [XID] // 0x0000000189ADD510-0x0000000189ADD530
	private void OnMultiPlayerButton() {} // 0x0000000181EF2100-0x0000000181EF2330
	// [XID] // 0x0000000189AE4C70-0x0000000189AE4C90
	private void PlayerMatchInfoUpdate() {} // 0x0000000181EF3CE0-0x0000000181EF3E10
	// [XID] // 0x0000000189AEC350-0x0000000189AEC370
	private void RefreshMatchTimeView() {} // 0x0000000181EF2D00-0x0000000181EF30B0
}

