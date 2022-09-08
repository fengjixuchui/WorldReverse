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

public sealed class ActivityEffigyChallengePageContext : BasePageContext // TypeDefIndex: 28740
{
	// Fields
	private MonoActivityEffigyChallengePage _pageMono; // 0x190
	private ActivityInfo _activityInfo; // 0x198
	private EffigyDailyInfo _dailyInfo; // 0x1A0
	private EffigyChallengeExcelConfig _effigyChallengeConfig; // 0x1A8
	private uint _pointID; // 0x1B0
	private DungeonExcelConfig _dungeonConfig; // 0x1B8
	private float _scoreRatio; // 0x1C0
	private int _selLimitScore; // 0x1C4
	private Dictionary<uint, int> _limitExclusiveIdList; // 0x1C8
	private List<int> _selLimitList; // 0x1D0
	private int _lastDayInfoIndex; // 0x1D8
	private Color _posColor; // 0x1DC
	private Color _negColor; // 0x1EC
	private Dictionary<string, GameObject> _prefabDict; // 0x200
	private GameObject _curPrefab; // 0x208
	private List<uint> _difficultList; // 0x210
	private const string DROP_DOWN_NAME = "DropDown"; // Metadata: 0x00B0E64A

	// Constructors
	public ActivityEffigyChallengePageContext() {} // Dummy constructor
	public ActivityEffigyChallengePageContext(uint pointID) {} // 0x0000000183FFE180-0x0000000183FFE2C0

	// Methods
	// [XID] // 0x0000000189A963D0-0x0000000189A963F0
	public override void SetupView() {} // 0x0000000183FFDDE0-0x0000000183FFE180
	// [XID] // 0x0000000189A9D940-0x0000000189A9D960
	public override void ClearView() {} // 0x0000000183FF85D0-0x0000000183FF89B0
	// [XID] // 0x0000000189AA5230-0x0000000189AA5250
	protected override void BindRedPoints() {} // 0x0000000183FF7FE0-0x0000000183FF8120
	// [XID] // 0x0000000189AAC9F0-0x0000000189AACA10
	protected override void BindViewCallbacks() {} // 0x0000000183FF8120-0x0000000183FF84D0
	// [XID] // 0x0000000189AB42D0-0x0000000189AB42F0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183FFD570-0x0000000183FFD740
	// [XID] // 0x0000000189ABBFD0-0x0000000189ABBFF0
	protected override void OnEnable() {} // 0x0000000183FFD240-0x0000000183FFD2F0
	// [XID] // 0x0000000189AC37A0-0x0000000189AC37C0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000183FFBF70-0x0000000183FFC070
	// [XID] // 0x0000000189ACADD0-0x0000000189ACADF0
	private void RefreshView() {} // 0x0000000183FFA210-0x0000000183FFA850
	// [XID] // 0x0000000189AD2860-0x0000000189AD2880
	private void RefreshMenuItem(Transform trans, int index) {} // 0x0000000183FFCB90-0x0000000183FFD040
	// [XID] // 0x0000000189ADA290-0x0000000189ADA2B0
	private void OnTabButton(int dailyInfoIndex) {} // 0x0000000183FFB740-0x0000000183FFBAC0
	// [XID] // 0x0000000189AE1B70-0x0000000189AE1B90
	private void UpdateMainView(int dailyInfoIndex) {} // 0x0000000183FFD740-0x0000000183FFDDE0
	// [XID] // 0x0000000189AE9360-0x0000000189AE9380
	private void RefreshUpCharItem(Transform trans, int index) {} // 0x0000000183FF9D20-0x0000000183FF9F60
	// [XID] // 0x0000000189AF1110-0x0000000189AF1130
	private int difficultSortFunc(uint a, uint b) => default; // 0x0000000183FF7B90-0x0000000183FF7C90
	// [XID] // 0x0000000189AF8630-0x0000000189AF8650
	public static string GetEffigyDifficultyStr(EffigyDifficulty effigyDifficulty) => default; // 0x0000000183FFB450-0x0000000183FFB530
	// [XID] // 0x0000000189AFFCC0-0x0000000189AFFCE0
	private void UpdateDifficultView() {} // 0x0000000183FFC4B0-0x0000000183FFCB90
	// [XID] // 0x0000000189B07290-0x0000000189B072B0
	private void UpdatePostRestrictionInfo() {} // 0x0000000183FFC070-0x0000000183FFC300
	// [XID] // 0x0000000189B0EA90-0x0000000189B0EAB0
	private void RefreshRestrictionsItem(Transform trans, int index) {} // 0x0000000183FF8A90-0x0000000183FF8FC0
	// [XID] // 0x0000000189B15E20-0x0000000189B15E40
	public void OnRestrictionsValueChanged(int index, bool isOn) {} // 0x0000000183FFB0A0-0x0000000183FFB450
	// [XID] // 0x0000000189B1D550-0x0000000189B1D570
	private void CheckOtherLimitExclusiveId(int index, uint exclusiveId, bool interactable) {} // 0x0000000183FFA850-0x0000000183FFAB60
	// [XID] // 0x0000000189B24DF0-0x0000000189B24E10
	private void UpdateMagnificationText() {} // 0x0000000183FFAED0-0x0000000183FFB0A0
	// [XID] // 0x0000000189B2C2A0-0x0000000189B2C2C0
	private void OnDifficultyChanged(int dropIndex) {} // 0x0000000183FF84D0-0x0000000183FF85D0
	// [XID] // 0x0000000189B33830-0x0000000189B33850
	private void OnRewardButton() {} // 0x0000000183FFB530-0x0000000183FFB660
	// [XID] // 0x0000000189B3B130-0x0000000189B3B150
	private void OnDescButton() {} // 0x0000000183FFD0A0-0x0000000183FFD1B0
	// [XID] // 0x0000000189B42950-0x0000000189B42970
	private void CheckPrefabAnimaion() {} // 0x0000000183FFBAC0-0x0000000183FFBC90
	// [XID] // 0x0000000189B4A470-0x0000000189B4A490
	private void OnDifficultyButton() {} // 0x0000000183FF7CF0-0x0000000183FF7FE0
	// [XID] // 0x0000000189B51C10-0x0000000189B51C30
	private void OnBackButton() {} // 0x0000000183FFBC90-0x0000000183FFBF70
	// [XID] // 0x0000000189B59410-0x0000000189B59430
	private void OnChallengeButton() {} // 0x0000000183FF8FC0-0x0000000183FF9420
	// [XID] // 0x0000000189B60CA0-0x0000000189B60CC0
	private void CheckMultiplayer() {} // 0x0000000183FFC300-0x0000000183FFC4B0
	// [XID] // 0x0000000189B68390-0x0000000189B683B0
	private void CheckServerAnnounce(DungeonExcelConfig config, bool multiplayer = false /* Metadata: 0x00B0E647 */, bool bigWorldMultiplayer = false /* Metadata: 0x00B0E648 */) {} // 0x0000000183FF9720-0x0000000183FF9D20
	// [XID] // 0x0000000189B6F690-0x0000000189B6F6B0
	private void HintMPInvite(DungeonExcelConfig config) {} // 0x0000000183FFABC0-0x0000000183FFAE60
	// [XID] // 0x0000000189B76D10-0x0000000189B76D30
	private void ConfirmTeam(DungeonExcelConfig config, bool multiplayer = false /* Metadata: 0x00B0E649 */) {} // 0x0000000183FF9530-0x0000000183FF9720
	// [XID] // 0x0000000189B7E2A0-0x0000000189B7E2C0
	private void OnCancelMatchButton() {} // 0x0000000183FFB660-0x0000000183FFB740
	// [XID] // 0x0000000189B85EA0-0x0000000189B85EC0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183FF9FC0-0x0000000183FFA210
	// [XID] // 0x0000000189B8CF10-0x0000000189B8CF30
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000183FFD2F0-0x0000000183FFD430
	// [XID] // 0x0000000189B946C0-0x0000000189B946E0
	public override void OnJoypadUIModuleLostFocus(MonoJoypadUIModule focusModule) {} // 0x0000000183FFD430-0x0000000183FFD570
}

