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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengePageContext : BasePageContext // TypeDefIndex: 30184
{
	// Fields
	private Dictionary<uint, List<ActivityArenaChallengeExcelConfig>> _arenaWatcherConfigDic; // 0x190
	private Dictionary<uint, ActivityArenaChallengeLevelInfoExcelConfig> _arenaLevelConfigDic; // 0x198
	private Dictionary<uint, ActivityWatcherInfo> _arenaWatcherInfoDic; // 0x1A0
	private MonoArenaChallengePage _pageMono; // 0x1A8
	private ActivityInfo _activityInfo; // 0x1B0
	private MonoGridScroller leftScroll; // 0x1B8
	private MonoGridScroller rightScroll; // 0x1C0
	private uint _curLevelId; // 0x1C8
	private uint _entityId; // 0x1CC
	private List<ActivityArenaChallengeExcelConfig> _watcherConfigList; // 0x1D0
	private bool _isLeftRegion; // 0x1D8

	// Constructors
	public ArenaChallengePageContext() {} // Dummy constructor
	public ArenaChallengePageContext(uint entityId) {} // 0x0000000181975550-0x00000001819756A0

	// Methods
	// [XID] // 0x0000000189A859C0-0x0000000189A859E0
	public override void SetupView() {} // 0x0000000181975260-0x0000000181975550
	// [XID] // 0x0000000189A8D2C0-0x0000000189A8D2E0
	public override void ClearView() {} // 0x0000000181971C00-0x0000000181971CE0
	// [XID] // 0x0000000189A947E0-0x0000000189A94800
	private void Refresh() {} // 0x0000000181971270-0x0000000181971330
	// [XID] // 0x0000000189A9C0E0-0x0000000189A9C100
	private void RefreshTitleAndDate() {} // 0x00000001819746F0-0x0000000181974860
	// [XID] // 0x0000000189AA37F0-0x0000000189AA3810
	private void RefreshLeftScroll() {} // 0x00000001819720B0-0x0000000181972230
	// [XID] // 0x0000000189AAAE50-0x0000000189AAAE70
	private void InitLeftScroll(Transform trans, int index) {} // 0x00000001819738C0-0x0000000181973F30
	// [XID] // 0x0000000189AB2820-0x0000000189AB2840
	private bool levelHasReward(uint levelId) => default; // 0x0000000181974300-0x0000000181974690
	// [XID] // 0x0000000189ABA350-0x0000000189ABA370
	private void AutoSelect() {} // 0x0000000181974DB0-0x0000000181975150
	// [XID] // 0x0000000189AC1C80-0x0000000189AC1CA0
	private void ClickLeftAndRefreshRight(uint levelId) {} // 0x00000001819732A0-0x00000001819738C0
	// [XID] // 0x0000000189AC9230-0x0000000189AC9250
	private void InitRightScroll(Transform trans, int index) {} // 0x00000001819722C0-0x0000000181972640
	// [XID] // 0x0000000189AD0CC0-0x0000000189AD0CE0
	private void SetRowHighLight(int index, bool highLighted) {} // 0x0000000181971CE0-0x0000000181971EB0
	// [XID] // 0x0000000189AD88C0-0x0000000189AD88E0
	protected override void BindViewCallbacks() {} // 0x0000000181971450-0x0000000181971650
	// [XID] // 0x0000000189AE0520-0x0000000189AE0540
	private void OnBtnReturnClick() {} // 0x0000000181972640-0x00000001819726F0
	// [XID] // 0x0000000189AE7A70-0x0000000189AE7A90
	private void OnBtnSelectDifficultyClick() {} // 0x0000000181973F30-0x0000000181974050
	// [XID] // 0x0000000189AEF7B0-0x0000000189AEF7D0
	private void OnBtnMonsterInfoClick() {} // 0x0000000181975150-0x0000000181975260
	// [XID] // 0x0000000189AF6CF0-0x0000000189AF6D10
	private void OnFetchButton(uint activityId, uint watcherId) {} // 0x0000000181971330-0x0000000181971450
	// [XID] // 0x0000000189AFE1C0-0x0000000189AFE1E0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181974C60-0x0000000181974DB0
	// [XID] // 0x0000000189B059F0-0x0000000189B05A10
	private void OnTakeWatcherRewardUpdateNotify(Notify ntf) {} // 0x0000000181974940-0x0000000181974C60
	// [XID] // 0x0000000189B0D140-0x0000000189B0D160
	private List<SimpleItemStruct> CreateSimpleItemStructListByRewardId(uint rewardId) => default; // 0x0000000181974100-0x0000000181974300
	// [XID] // 0x0000000189B14740-0x0000000189B14760
	private void RefreshPS4Btn() {} // 0x0000000181971650-0x0000000181971A10
	// [XID] // 0x0000000189B1BEF0-0x0000000189B1BF10
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181972750-0x0000000181973240
	// [XID] // 0x0000000189B23690-0x0000000189B236B0
	private void ActiveRightRegion() {} // 0x0000000181971A10-0x0000000181971C00
	// [XID] // 0x0000000189B2A8F0-0x0000000189B2A910
	private void ActiveLeftRegion() {} // 0x0000000181971EB0-0x00000001819720B0
}

