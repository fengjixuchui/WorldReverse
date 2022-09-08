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

public sealed class ActivitySubPage_TreasureHunt : BaseSubPageContext // TypeDefIndex: 29430
{
	// Fields
	private uint _activityId; // 0x178
	public MonoActivityTreasureHuntSubPage _pageMono; // 0x180
	private ActivityInfo _activityInfo; // 0x188
	private TreasureMapActivityDetailInfo _activityDetailInfo; // 0x190
	private TreasureMapExcelConfig _treasureMapExcelConfig; // 0x198
	private ShopMaterial _shopMaterial; // 0x1A0
	private GameObject _shopMaterialPrefab; // 0x1A8
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F7D7
	private uint _shopMaterialHandler; // 0x1B0
	private List<IdCountStrConfig> _rewardItemList; // 0x1B8
	private bool _isShowBoxPicture; // 0x1C0
	public static bool TreasureHuntSubPageOpened; // 0x00
	public static string TREASURE_HUNT_COIN_PATH; // 0x08
	private MessagePushPageContext _pushPage; // 0x1C8
	public static readonly uint ShowTutorialId; // 0x10

	// Nested types
	public enum TutorialStatus // TypeDefIndex: 29431
	{
		MP = 1,
		ALL = 2
	}

	// Constructors
	public ActivitySubPage_TreasureHunt() {} // Dummy constructor
	public ActivitySubPage_TreasureHunt(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x00000001810F9710-0x00000001810F9830
	static ActivitySubPage_TreasureHunt() {} // 0x00000001810F9680-0x00000001810F9710

	// Methods
	// [XID] // 0x0000000189783000-0x0000000189783020
	public override void SetupView() {} // 0x00000001810F92F0-0x00000001810F9680
	// [XID] // 0x000000018978A4B0-0x000000018978A4D0
	protected override void OnEnable() {} // 0x00000001810F9250-0x00000001810F92F0
	// [XID] // 0x0000000189791CD0-0x0000000189791CF0
	private void Refresh() {} // 0x00000001810F5D70-0x00000001810F6770
	// [XID] // 0x00000001897992D0-0x00000001897992F0
	private void ShowDefaultImage(bool isDefault) {} // 0x00000001810F7D90-0x00000001810F7ED0
	// [XID] // 0x00000001897A1230-0x00000001897A1250
	private void TryShowMap() {} // 0x00000001810F7540-0x00000001810F7980
	// [XID] // 0x00000001897A8820-0x00000001897A8840
	private void RefreshRewardItem(Transform trans, int index) {} // 0x00000001810F7180-0x00000001810F74B0
	// [XID] // 0x00000001897B0240-0x00000001897B0260
	protected override void BindRedPoints() {} // 0x00000001810F6850-0x00000001810F69E0
	// [XID] // 0x00000001897B7F70-0x00000001897B7F90
	protected override void BindViewCallbacks() {} // 0x00000001810F69E0-0x00000001810F6BF0
	// [XID] // 0x00000001897C0090-0x00000001897C00B0
	private void OnClickRuleDesc() {} // 0x00000001810F6D10-0x00000001810F6EA0
	// [XID] // 0x00000001897C78C0-0x00000001897C78E0
	private void OnClickGoto() {} // 0x00000001810F8800-0x00000001810F8B70
	// [XID] // 0x00000001897CEB60-0x00000001897CEB80
	private void OnClickTreasureHunt() {} // 0x00000001810F7980-0x00000001810F7B50
	// [XID] // 0x00000001897D62A0-0x00000001897D62C0
	private void OnClickShop() {} // 0x00000001810F6F90-0x00000001810F7120
	// [XID] // 0x00000001897DDB80-0x00000001897DDBA0
	private void UpdateMaterialsList() {} // 0x00000001810F7B50-0x00000001810F7D90
	// [XID] // 0x00000001897E5470-0x00000001897E5490
	private void SelectReward(int index, bool focusOnParent) {} // 0x00000001810F6BF0-0x00000001810F6D10
	// [XID] // 0x00000001897ED010-0x00000001897ED030
	public override void ClearView() {} // 0x00000001810F6EA0-0x00000001810F6F90
	// [XID] // 0x00000001897F4830-0x00000001897F4850
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001810F7F30-0x00000001810F87A0
	// [XID] // 0x00000001897FC2F0-0x00000001897FC310
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x00000001810F8B70-0x00000001810F90E0
}

