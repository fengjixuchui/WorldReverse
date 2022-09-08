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

public sealed class TheatreMechanicusMainPage : BasePageContext // TypeDefIndex: 29964
{
	// Fields
	private MonoTheatreMechanicusMainPage _pageMono; // 0x190
	private List<MechanicusWatcherStruct> mechanicusWatcherList; // 0x198
	private List<RewardItemConfig> _tempRewardList; // 0x1A0
	private ActivityInfo activityInfo; // 0x1A8
	private List<MonoBtnTab> _pageTabList; // 0x1B0
	private GameObject _shopMaterialPrefab; // 0x1B8
	private List<MonoShopMaterial> _shopMaterialsList; // 0x1C0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B10376
	private uint _shopMaterialHandler; // 0x1C8
	private uint _curSequenceID; // 0x1CC
	private int _curSectionIndex; // 0x1D0
	private List<IdCountStrConfig> _rewardPreviewList; // 0x1D8
	private MessagePushPageContext _pushPage; // 0x1E0

	// Constructors
	public TheatreMechanicusMainPage() {} // 0x0000000182BD3D00-0x0000000182BD3E80

	// Methods
	// [XID] // 0x0000000189645870-0x0000000189645890
	public override void SetupView() {} // 0x0000000182BD3B70-0x0000000182BD3D00
	// [XID] // 0x000000018964D0A0-0x000000018964D0C0
	protected override void PostSetupView() {} // 0x0000000182BD3AB0-0x0000000182BD3B70
	// [XID] // 0x00000001896547C0-0x00000001896547E0
	protected override void BindViewCallbacks() {} // 0x0000000182BCFB30-0x0000000182BD0140
	// [XID] // 0x000000018965BED0-0x000000018965BEF0
	private void OnClickToPreTab() {} // 0x0000000182BCF720-0x0000000182BCF860
	// [XID] // 0x0000000189663520-0x0000000189663540
	private void OnClickToNextTab() {} // 0x0000000182BD1CA0-0x0000000182BD1E30
	// [XID] // 0x000000018966AEF0-0x000000018966AF10
	protected override void BindRedPoints() {} // 0x0000000182BCF9F0-0x0000000182BCFB30
	// [XID] // 0x0000000189672AF0-0x0000000189672B10
	private void CheckSectionRedPoint() {} // 0x0000000182BD0330-0x0000000182BD07A0
	// [XID] // 0x000000018967A230-0x000000018967A250
	private void Refresh() {} // 0x0000000182BCEEF0-0x0000000182BCF720
	// [XID] // 0x0000000189681A60-0x0000000189681A80
	private void RefreshItemIcon(Transform trans, int index) {} // 0x0000000182BD2550-0x0000000182BD2770
	// [XID] // 0x00000001896894D0-0x00000001896894F0
	private void OnClickTab(int index) {} // 0x0000000182BD0140-0x0000000182BD0210
	// [XID] // 0x0000000189691130-0x0000000189691150
	private void SetImageTabState(int index) {} // 0x0000000182BD21B0-0x0000000182BD2300
	// [XID] // 0x00000001896988E0-0x0000000189698900
	private void OnClickReturn() {} // 0x0000000182BD3870-0x0000000182BD3920
	// [XID] // 0x000000018969FD50-0x000000018969FD70
	private void OnClickBtnGadget() {} // 0x0000000182BD1E30-0x0000000182BD1F40
	// [XID] // 0x00000001896A6F90-0x00000001896A6FB0
	private void OnClickBtnHandBook() {} // 0x0000000182BD0BC0-0x0000000182BD0CD0
	// [XID] // 0x00000001896AE5F0-0x00000001896AE610
	private void OnClickBtnInfo() {} // 0x0000000182BD2940-0x0000000182BD2A50
	// [XID] // 0x00000001896B5E10-0x00000001896B5E30
	private void OnClickBtnInstruction() {} // 0x0000000182BCF860-0x0000000182BCF990
	// [XID] // 0x00000001896BCFD0-0x00000001896BCFF0
	private void OnClickBtnGoto() {} // 0x0000000182BD0CD0-0x0000000182BD1030
	// [XID] // 0x00000001896C4490-0x00000001896C44B0
	private void UpdateMaterialsList() {} // 0x0000000182BD1030-0x0000000182BD14E0
	// [XID] // 0x00000001896CBB10-0x00000001896CBB30
	private void UpdateMaterialCount() {} // 0x0000000182BD3920-0x0000000182BD3AB0
	// [XID] // 0x00000001896D2E10-0x00000001896D2E30
	protected override void OnEnable() {} // 0x0000000182BD3330-0x0000000182BD3460
	// [XID] // 0x00000001896DA9A0-0x00000001896DA9C0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182BD3700-0x0000000182BD3870
	// [XID] // 0x00000001896E20B0-0x00000001896E20D0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000182BD2300-0x0000000182BD2400
	// [XID] // 0x00000001896E95B0-0x00000001896E95D0
	private int CompareMechanicusWatcherStruct(MechanicusWatcherStruct xData, MechanicusWatcherStruct yData) => default; // 0x0000000182BD2400-0x0000000182BD2550
	// [XID] // 0x00000001896F0850-0x00000001896F0870
	private void RefreshWatchList(int sectionIndex) {} // 0x0000000182BD2AB0-0x0000000182BD32A0
	// [XID] // 0x00000001896F8000-0x00000001896F8020
	private void RefreshTaskItem(Transform trans, int index) {} // 0x0000000182BD14E0-0x0000000182BD1BE0
	// [XID] // 0x00000001896FF9E0-0x00000001896FFA00
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000182BD0890-0x0000000182BD0AE0
	// [XID] // 0x0000000189707030-0x0000000189707050
	private void OnClickItem(int index) {} // 0x0000000182BD2770-0x0000000182BD2940
	// [XID] // 0x000000018970E8B0-0x000000018970E8D0
	private void ReceiveTargetReward(uint watcherId) {} // 0x0000000182BD0210-0x0000000182BD0330
	// [XID] // 0x0000000189715D50-0x0000000189715D70
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transforn, JoypadSelectIndexResult selectResult) {} // 0x0000000182BD35C0-0x0000000182BD3700
	// [XID] // 0x000000018971D7B0-0x000000018971D7D0
	private void UpdateButtonByIndex(int index) {} // 0x0000000182BD1FA0-0x0000000182BD21B0
	// [XID] // 0x0000000189724B70-0x0000000189724B90
	public override void ClearView() {} // 0x0000000182BD07A0-0x0000000182BD0890
	// [XID] // 0x000000018972C3A0-0x000000018972C3C0
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000182BD3460-0x0000000182BD35C0
}

