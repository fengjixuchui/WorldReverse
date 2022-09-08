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

public sealed class DungeonRewardDialogContext : BaseDialogContext // TypeDefIndex: 28945
{
	// Fields
	private MonoDungeonRewardDialog _dialogMono; // 0x178
	private List<uint> _floorList; // 0x180
	private List<TowerLevelExcelConfig> _levelList; // 0x188
	private Dictionary<uint, uint> _levelToFloorDic; // 0x190
	private List<TowerStarReward> _periodicList; // 0x198
	private uint _currStarCount; // 0x1A0
	private uint _nextPassLevelId; // 0x1A4
	private List<RewardItemConfig> _tempRewardList; // 0x1A8
	private int _currItemIndex; // 0x1B0
	private int _currFirstPassRowIndex; // 0x1B4
	private int _currPeriodicRowIndex; // 0x1B8

	// Constructors
	public DungeonRewardDialogContext() {} // Dummy constructor
	public DungeonRewardDialogContext(List<uint> floorList) {} // 0x0000000183680BE0-0x0000000183680CD0

	// Methods
	// [XID] // 0x000000018964FEC0-0x000000018964FEE0
	public override void SetupView() {} // 0x0000000183680A80-0x0000000183680BE0
	// [XID] // 0x0000000189657780-0x00000001896577A0
	protected override void BindViewCallbacks() {} // 0x000000018367E160-0x000000018367E2D0
	// [XID] // 0x000000018965EDE0-0x000000018965EE00
	private void RefreshLevelList() {} // 0x000000018367FF50-0x0000000183680260
	// [XID] // 0x0000000189666500-0x0000000189666520
	private void RefreshFirstPassView() {} // 0x0000000183680260-0x0000000183680680
	// [XID] // 0x000000018966DD00-0x000000018966DD20
	private void RefreshPassRewardScroller(Transform trans, int index) {} // 0x0000000183680680-0x0000000183680A20
	// [XID] // 0x0000000189675B20-0x0000000189675B40
	private void RefreshPeriodicView() {} // 0x000000018367E2D0-0x000000018367E6A0
	// [XID] // 0x000000018967D3B0-0x000000018967D3D0
	private void RefreshPeriodicRewardList() {} // 0x000000018367E6A0-0x000000018367E8B0
	// [XID] // 0x0000000189684A80-0x0000000189684AA0
	private void RefreshPeriodicRewardScroller(Transform trans, int index) {} // 0x000000018367FAC0-0x000000018367FEC0
	// [XID] // 0x000000018968C650-0x000000018968C670
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018367E8B0-0x000000018367EB10
	// [XID] // 0x00000001896940A0-0x00000001896940C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018367F270-0x000000018367F8D0
	// [XID] // 0x000000018969B630-0x000000018969B650
	private void RefreshCurrentItem(MonoDungeonRewardRow row, bool prev) {} // 0x000000018367EB10-0x000000018367EEB0
	// [XID] // 0x00000001896A2D90-0x00000001896A2DB0
	private void ClearCurrentItem() {} // 0x000000018367EF40-0x000000018367F210
	// [XID] // 0x00000001896AA260-0x00000001896AA280
	private void ClickCurrentItem(MonoDungeonRewardRow row) {} // 0x000000018367F8D0-0x000000018367FAC0
}

