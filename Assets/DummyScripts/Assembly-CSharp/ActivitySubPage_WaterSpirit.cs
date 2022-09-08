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

public sealed class ActivitySubPage_WaterSpirit : BaseSubPageContext // TypeDefIndex: 30282
{
	// Fields
	private MonoActivityWaterSpirit _pageMono; // 0x178
	private uint _activityID; // 0x180
	private ActivityInfo _curActivityInfo; // 0x188
	private ShopMaterial _shopMaterial; // 0x190
	private GameObject _shopMaterialPrefab; // 0x198
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B10933
	private uint _shopMaterialHandler; // 0x1A0
	private readonly uint ACTIVITY_REWARD_ID; // 0x1A4
	private readonly uint COIN_CONSUME_NUM; // 0x1A8
	private readonly uint QUEST_ID_BEGIN; // 0x1AC
	private readonly uint QUEST_ID_END; // 0x1B0
	private readonly uint MP_PLAY_ID; // 0x1B4
	private uint _totalRegionSearchNum; // 0x1B8
	private bool _shouldChallengeGrpShow; // 0x1BC
	private bool _shouldChallengeBossShow; // 0x1BD
	private List<IdCountStrConfig> _possibleRewardList; // 0x1C0
	private bool _isMpPlayOpen; // 0x1C8
	private uint _resinConsumeNum; // 0x1CC
	private string _currExploreProgress; // 0x1D0
	private string _currExploreName; // 0x1D8
	private bool _isAllRegionFinished; // 0x1E0
	private string _beginQuestName; // 0x1E8
	private string _finalQuestName; // 0x1F0

	// Properties
	private string currExploreProgress { /* [XID] */ /* 0x000000018975D760-0x000000018975D780 */ get => default; } // 0x00000001818B8D70-0x00000001818B8E20 
	private string currExploreName { /* [XID] */ /* 0x0000000189764DB0-0x0000000189764DD0 */ get => default; } // 0x00000001818BB480-0x00000001818BB530 

	// Constructors
	public ActivitySubPage_WaterSpirit() {} // Dummy constructor
	public ActivitySubPage_WaterSpirit(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x00000001818BBCE0-0x00000001818BC0B0

	// Methods
	// [XID] // 0x0000000189730B00-0x0000000189730B20
	public override void SetupView() {} // 0x00000001818BB7D0-0x00000001818BBCE0
	// [XID] // 0x0000000189738430-0x0000000189738450
	public override void ClearView() {} // 0x00000001818B8030-0x00000001818B8130
	// [XID] // 0x0000000189740170-0x0000000189740190
	protected override void BindViewCallbacks() {} // 0x00000001818B7E20-0x00000001818B8030
	// [XID] // 0x0000000189747520-0x0000000189747540
	protected override void OnEnable() {} // 0x00000001818BB5C0-0x00000001818BB680
	// [XID] // 0x000000018974EC70-0x000000018974EC90
	public override bool OnNotify(Notify ntf) => default; // 0x00000001818BB680-0x00000001818BB7D0
	// [XID] // 0x0000000189756380-0x00000001897563A0
	protected override void BindRedPoints() {} // 0x00000001818B7CE0-0x00000001818B7E20
	// [XID] // 0x000000018976C810-0x000000018976C830
	private void ResetData() {} // 0x00000001818BAA70-0x00000001818BABA0
	// [XID] // 0x0000000189773CB0-0x0000000189773CD0
	private void RefreshData() {} // 0x00000001818B8390-0x00000001818B8B80
	// [XID] // 0x000000018977B360-0x000000018977B380
	private void RefreshView() {} // 0x00000001818B9870-0x00000001818BA310
	// [XID] // 0x0000000189782EA0-0x0000000189782EC0
	private void OnClickDetailBtn() {} // 0x00000001818BB1E0-0x00000001818BB420
	// [XID] // 0x000000018978A330-0x000000018978A350
	private void OnClickedGotoBtn() {} // 0x00000001818B8220-0x00000001818B8390
	// [XID] // 0x0000000189791B90-0x0000000189791BB0
	private void OnClickedChallengeExploreBtn() {} // 0x00000001818BAC40-0x00000001818BAE60
	// [XID] // 0x0000000189799170-0x0000000189799190
	private void OnClickedChallengeBossBtn() {} // 0x00000001818B8B80-0x00000001818B8D70
	// [XID] // 0x00000001897A1070-0x00000001897A1090
	private void RefreshRewardBagItem(Transform trans, int index) {} // 0x00000001818BA370-0x00000001818BA660
	// [XID] // 0x00000001897A86E0-0x00000001897A8700
	private void IFixDataRefreshPost() {} // 0x00000001818BABA0-0x00000001818BAC40
	// [XID] // 0x00000001897B00E0-0x00000001897B0100
	private void SetJoyPadButtonText() {} // 0x00000001818BAFB0-0x00000001818BB1E0
	// [XID] // 0x00000001897B7E10-0x00000001897B7E30
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001818B8E80-0x00000001818B9870
	// [XID] // 0x00000001897BFEB0-0x00000001897BFED0
	public override void OnParentFocusChangeed(bool focusOnSubPage) {} // 0x00000001818BA660-0x00000001818BAA70
	// [XID] // 0x00000001897C7760-0x00000001897C7780
	private void SelectScrollState(int index, bool focusOnSubPage) {} // 0x00000001818BAE60-0x00000001818BAFB0
}

