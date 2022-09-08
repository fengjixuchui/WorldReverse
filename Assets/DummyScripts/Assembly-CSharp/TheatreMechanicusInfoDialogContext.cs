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

public sealed class TheatreMechanicusInfoDialogContext : BaseDialogContext // TypeDefIndex: 29959
{
	// Fields
	private MonoMechanicusInfoDialog _dialogMono; // 0x178
	private List<string> _menuTabListStr; // 0x180
	private int _curSelectedMenuTabIndex; // 0x188
	private List<InBattleMechanicusMonsterInfo> _monsterList; // 0x190
	private List<InBattleMechanicusBuildingInfo> _player1BuildingList; // 0x198
	private List<InBattleMechanicusBuildingInfo> _player2BuildingList; // 0x1A0
	private int _curSelectedBuildingList1Index; // 0x1A8
	private int _curSelectedBuildingList2Index; // 0x1AC
	private bool _isSingleMode; // 0x1B0
	private List<InBattleMechanicusCardInfo> _cardList; // 0x1B8
	private List<MechanicusWatcherExcelConfig> _challengeList; // 0x1C0
	private const int PAGE_STATE_DEFAULT = 0; // Metadata: 0x00B1035E
	private const int PAGE_STATE_ENEMY = 1; // Metadata: 0x00B10362
	private const int PAGE_STATE_MAP = 2; // Metadata: 0x00B10366
	private const int PAGE_STATE_PLAYER = 3; // Metadata: 0x00B1036A
	private const int PAGE_STATE_BUFF = 4; // Metadata: 0x00B1036E
	private const int PAGE_STATE_CHALLENGE = 5; // Metadata: 0x00B10372
	private int _curSelectedEnemyIndex; // 0x1C8
	private int _curSelectedChallengeIndex; // 0x1CC
	private int _curSelectedBuffIndex; // 0x1D0
	private int _curSelectedDualPlayerListIndex; // 0x1D4
	private List<GameObject> _entranceList; // 0x1D8
	private List<GameObject> _exitList; // 0x1E0

	// Properties
	public int curSelectedMenuTabIndex { /* [XID] */ /* 0x0000000189AE19F0-0x0000000189AE1A10 */ get => default; } // 0x00000001846EB7A0-0x00000001846EB840 

	// Constructors
	public TheatreMechanicusInfoDialogContext() {} // 0x00000001846F16A0-0x00000001846F19A0

	// Methods
	// [XID] // 0x0000000189AE91A0-0x0000000189AE91C0
	public override void SetupView() {} // 0x00000001846F12A0-0x00000001846F16A0
	// [XID] // 0x0000000189AF0F90-0x0000000189AF0FB0
	public override void ClearView() {} // 0x00000001846EA0D0-0x00000001846EA3A0
	// [XID] // 0x0000000189AF8410-0x0000000189AF8430
	protected override void BindViewCallbacks() {} // 0x00000001846E99F0-0x00000001846E9BC0
	// [XID] // 0x0000000189AFFB20-0x0000000189AFFB40
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846ECBF0-0x00000001846ECF70
	// [XID] // 0x0000000189B070D0-0x0000000189B070F0
	private void OnDefaultPageConfirmClick() {} // 0x00000001846E90C0-0x00000001846E9620
	// [XID] // 0x0000000189B0E8D0-0x0000000189B0E8F0
	private bool HandleChallengeInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846ED100-0x00000001846ED4B0
	// [XID] // 0x0000000189B15CC0-0x0000000189B15CE0
	private void SetCurChallenge(int index) {} // 0x00000001846F0C90-0x00000001846F0FA0
	// [XID] // 0x0000000189B1D3D0-0x0000000189B1D3F0
	private bool HandleBuffInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846EFCE0-0x00000001846F0090
	// [XID] // 0x0000000189B24C50-0x0000000189B24C70
	private void SetCurBuff(int index) {} // 0x00000001846EF1B0-0x00000001846EF4C0
	// [XID] // 0x0000000189B2C0C0-0x0000000189B2C0E0
	private bool HandlePlayerInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846E82B0-0x00000001846E8DD0
	// [XID] // 0x0000000189B336B0-0x0000000189B336D0
	private bool HandleMapInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846F0FA0-0x00000001846F12A0
	// [XID] // 0x0000000189B3AF90-0x0000000189B3AFB0
	private bool HandleEnemyInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001846EADC0-0x00000001846EB460
	// [XID] // 0x0000000189B42750-0x0000000189B42770
	private void SetCurDualBuilding(int index) {} // 0x00000001846EDFD0-0x00000001846EE510
	// [XID] // 0x0000000189B4A290-0x0000000189B4A2B0
	private void SetCurSingleBuilding(int index) {} // 0x00000001846E8DD0-0x00000001846E90C0
	// [XID] // 0x0000000189B51A70-0x0000000189B51A90
	private void SetCurSelectEnemy(int index) {} // 0x00000001846F06E0-0x00000001846F09D0
	// [XID] // 0x0000000189B591F0-0x0000000189B59210
	private void InitMenuTabScroller() {} // 0x00000001846EDDF0-0x00000001846EDFD0
	// [XID] // 0x0000000189B60AC0-0x0000000189B60AE0
	private void InitMenuTab(Transform trans, int index) {} // 0x00000001846F09D0-0x00000001846F0C90
	// [XID] // 0x0000000189B68170-0x0000000189B68190
	private void OnMenuTabClick(int index, bool force = false /* Metadata: 0x00B1035D */) {} // 0x00000001846EA860-0x00000001846EAB00
	// [XID] // 0x0000000189B6F510-0x0000000189B6F530
	private void ChangeToPageByIndex(int index) {} // 0x00000001846EAB00-0x00000001846EAC00
	// [XID] // 0x0000000189B76B90-0x0000000189B76BB0
	private void CloseAllSubPage() {} // 0x00000001846EF4C0-0x00000001846EF680
	// [XID] // 0x0000000189B7E120-0x0000000189B7E140
	private void SetRowItemWidth(MonoGridScroller scroller) {} // 0x00000001846ED4B0-0x00000001846ED810
	// [XID] // 0x0000000189B85D00-0x0000000189B85D20
	private void RefreshEnemyPage() {} // 0x00000001846EED50-0x00000001846EF1B0
	// [XID] // 0x0000000189B8CD30-0x0000000189B8CD50
	private void InitEnemyScroller(Transform trans, int index) {} // 0x00000001846E9620-0x00000001846E99F0
	// [XID] // 0x0000000189B94520-0x0000000189B94540
	private void RefreshMapPage() {} // 0x00000001846EBD00-0x00000001846ECB90
	// [XID] // 0x0000000189B9BBD0-0x0000000189B9BBF0
	private void RefreshPlayerPage() {} // 0x00000001846E9BC0-0x00000001846EA0D0
	// [XID] // 0x0000000189BA3350-0x0000000189BA3370
	private void RefreshSinglePlayerList(InBattleMechanicusPlayerInfo playerInfo) {} // 0x00000001846EB460-0x00000001846EB7A0
	// [XID] // 0x0000000189BAA690-0x0000000189BAA6B0
	private void InitPlayer1Scroller(Transform trans, int index) {} // 0x00000001846EB840-0x00000001846EBD00
	// [XID] // 0x0000000189BB1CF0-0x0000000189BB1D10
	private void InitPlayer2Scroller(Transform trans, int index) {} // 0x00000001846EA3A0-0x00000001846EA860
	// [XID] // 0x0000000189BB90D0-0x0000000189BB90F0
	private void OnPlayerScroller1ItemClick(int index) {} // 0x00000001846F00F0-0x00000001846F0220
	// [XID] // 0x0000000189BC0E80-0x0000000189BC0EA0
	private void OnPlayerScroller2ItemClick(int index) {} // 0x00000001846EAC00-0x00000001846EAD30
	// [XID] // 0x0000000189BC8590-0x0000000189BC85B0
	private void ShowBuildingTipsDialog(uint buildingId, uint level) {} // 0x00000001846ECFD0-0x00000001846ED100
	// [XID] // 0x0000000189BCFE30-0x0000000189BCFE50
	private void RefreshDualPlayerList(InBattleMechanicusPlayerInfo player1Info, InBattleMechanicusPlayerInfo player2Info) {} // 0x00000001846ED8E0-0x00000001846EDDF0
	// [XID] // 0x0000000189BD7430-0x0000000189BD7450
	private void RefreshBuffPage() {} // 0x00000001846EF8E0-0x00000001846EFCE0
	// [XID] // 0x0000000189BDEF50-0x0000000189BDEF70
	private void InitBuffScroller(Transform trans, int index) {} // 0x00000001846EE510-0x00000001846EED50
	// [XID] // 0x00000001895EBC00-0x00000001895EBC20
	private string GetCardIconNameByType(MechanicusCardType type) => default; // 0x00000001846ED810-0x00000001846ED8E0
	// [XID] // 0x00000001895F2FA0-0x00000001895F2FC0
	private void RefreshChallengePage() {} // 0x00000001846EF680-0x00000001846EF8E0
	// [XID] // 0x00000001895FA7E0-0x00000001895FA800
	private void InitChallengeScroller(Transform trans, int index) {} // 0x00000001846F0220-0x00000001846F06E0
}

