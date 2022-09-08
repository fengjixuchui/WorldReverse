/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTreasureHuntPageContext : BasePageContext // TypeDefIndex: 28760
{
	// Fields
	private uint _activityId; // 0x190
	private MonoActivityTreasureHuntPage _pageMono; // 0x198
	private ActivityInfo _activityInfo; // 0x1A0
	private TreasureMapActivityDetailInfo _activityDetailInfo; // 0x1A8
	public const int AREA_COUNT = 16; // Metadata: 0x00B0E665
	public const int CHALLENGE_COUNT = 2; // Metadata: 0x00B0E669
	private int _curSelectedAreaIndex; // 0x1B0
	private int _curActiveAreaIndex; // 0x1B4
	private int _curSelectedScrollIndex; // 0x1B8
	private ShopMaterial _shopMaterial; // 0x1BC
	private GameObject _shopMaterialPrefab; // 0x1C8
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0E66D
	private uint _shopMaterialHandler; // 0x1D0
	private int[] _scrollIndex; // 0x1D8
	private float[] _scrollTopRadio; // 0x1E0
	private float[] _scrollBottomRatio; // 0x1E8
	public static bool TreasureHuntPageOpened; // 0x00
	private MessagePushPageContext _pushPage; // 0x1F0

	// Constructors
	public ActivityTreasureHuntPageContext() {} // Dummy constructor
	public ActivityTreasureHuntPageContext(uint activityId) {} // 0x0000000184968C40-0x0000000184968DB0
	static ActivityTreasureHuntPageContext() {} // 0x0000000184968BE0-0x0000000184968C40

	// Methods
	// [XID] // 0x0000000189958BB0-0x0000000189958BD0
	public override void SetupView() {} // 0x0000000184968980-0x0000000184968BE0
	// [XID] // 0x0000000189960210-0x0000000189960230
	private void InitScrollRatio() {} // 0x0000000184965550-0x0000000184965AD0
	// [XID] // 0x0000000189967CB0-0x0000000189967CD0
	private void Refresh() {} // 0x0000000184964F00-0x0000000184965290
	// [XID] // 0x000000018996EEB0-0x000000018996EED0
	private void UpdateMaterialsList() {} // 0x0000000184966BB0-0x0000000184966DF0
	// [XID] // 0x0000000189976AB0-0x0000000189976AD0
	private void RefreshEntry(MonoActivityTreasureHuntButton entry, int areaIndex, bool isChallenge) {} // 0x00000001849662E0-0x0000000184966B20
	// [XID] // 0x000000018997DEF0-0x000000018997DF10
	private void UpdateScrollIndex() {} // 0x0000000184968040-0x0000000184968310
	// [XID] // 0x00000001899858D0-0x00000001899858F0
	private void SelectedQuestBtn(int index) {} // 0x0000000184967960-0x0000000184967A70
	// [XID] // 0x000000018998D610-0x000000018998D630
	private void SetSelectedBtnInteractable(bool interactable) {} // 0x0000000184965F30-0x0000000184966050
	// [XID] // 0x0000000189995050-0x0000000189995070
	private void OnClickQuestDetails(int index) {} // 0x0000000184968500-0x00000001849686A0
	// [XID] // 0x000000018999CA50-0x000000018999CA70
	private void ShowBonusRegionDetail() {} // 0x0000000184965290-0x00000001849654F0
	// [XID] // 0x00000001899A43E0-0x00000001899A4400
	private void RefreshCurrentSelectedDayEntry() {} // 0x00000001849683C0-0x0000000184968500
	// [XID] // 0x00000001899ABDC0-0x00000001899ABDE0
	private void ShowNormalRegionDetail() {} // 0x0000000184967A70-0x0000000184968040
	// [XID] // 0x00000001899B36F0-0x00000001899B3710
	private void ShowMap() {} // 0x0000000184966DF0-0x0000000184967080
	// [XID] // 0x00000001899BAAB0-0x00000001899BAAD0
	protected override void BindViewCallbacks() {} // 0x0000000184965C40-0x0000000184965DA0
	// [XID] // 0x00000001899C23D0-0x00000001899C23F0
	private void OnClickRuleDesc() {} // 0x0000000184965DA0-0x0000000184965F30
	// [XID] // 0x00000001899C9AC0-0x00000001899C9AE0
	public override void ClearView() {} // 0x00000001849661F0-0x00000001849662E0
	// [XID] // 0x00000001899D1370-0x00000001899D1390
	public override bool OnNotify(Notify ntf) => default; // 0x0000000184968860-0x0000000184968980
	// [XID] // 0x00000001899D8800-0x00000001899D8820
	private void UpdateActivity(uint activityID) {} // 0x0000000184968700-0x00000001849687D0
	// [XID] // 0x00000001899DFF30-0x00000001899DFF50
	protected override void BindRedPoints() {} // 0x0000000184965AD0-0x0000000184965C40
	// [XID] // 0x00000001899E7920-0x00000001899E7940
	private void RefreshEntryRedPoint() {} // 0x00000001849677A0-0x0000000184967960
	// [XID] // 0x00000001899EEE90-0x00000001899EEEB0
	private void CheckRemoveEntryRedPoints(uint index) {} // 0x0000000184966050-0x00000001849661F0
	// [XID] // 0x00000001899F67B0-0x00000001899F67D0
	private void SimulateClickEntryDetail(int index) {} // 0x0000000184967610-0x00000001849677A0
	// [XID] // 0x00000001899FDD30-0x00000001899FDD50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001849670E0-0x0000000184967500
}

