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

public sealed class MallPageContext : BasePageContext // TypeDefIndex: 29195
{
	// Fields
	private List<MonoBtnTab> _pageTabList; // 0x190
	private GameObject _curPanelObj; // 0x198
	private MonoMallBasePanel _curPanelMono; // 0x1A0
	private uint _curPanelHandle; // 0x1A8
	private int _curPageTabIndex; // 0x1AC
	private State _pageState; // 0x1B0
	private MonoMallPage _pageMono; // 0x1B8
	private List<ShopMaterial> _shopMaterialsList; // 0x1C0
	private ShopType _initShowType; // 0x1C8
	private uint _initSubTabId; // 0x1CC
	private ShopData _curShopData; // 0x1D0
	private List<uint> _curShopTypeList; // 0x1D8
	private AsyncJob _loadEntranceJob; // 0x1E0

	// Nested types
	private enum State // TypeDefIndex: 29196
	{
		Init = 0,
		LoadingPanel = 1,
		Loaded = 2,
		Destroy = 3
	}

	// Constructors
	public MallPageContext() {} // Dummy constructor
	public MallPageContext(List<uint> typeList, ShopType type = ShopType.SHOP_TYPE_NONE /* Metadata: 0x00B0EDB4 */, uint subTabId = 0 /* Metadata: 0x00B0EDB8 */) {} // 0x000000018318D780-0x000000018318D910

	// Methods
	// [XID] // 0x0000000189981550-0x0000000189981570
	public uint GetInitSubTabId() => default; // 0x000000018318BEB0-0x000000018318BF50
	// [XID] // 0x0000000189988D20-0x0000000189988D40
	public MonoMallPage GetMono() => default; // 0x0000000183189040-0x00000001831890F0
	// [XID] // 0x0000000189990580-0x00000001899905A0
	public void RefreshTypeList(List<uint> typeList) {} // 0x000000018318D490-0x000000018318D540
	// [XID] // 0x00000001899980F0-0x0000000189998110
	public override bool OnNotify(Notify ntf) => default; // 0x000000018318D120-0x000000018318D490
	// [XID] // 0x000000018999F810-0x000000018999F830
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018318CA80-0x000000018318CBE0
	// [XID] // 0x00000001899A7390-0x00000001899A73B0
	protected override void OnEnable() {} // 0x000000018318D070-0x000000018318D120
	// [XID] // 0x00000001899AECC0-0x00000001899AECE0
	public override void SetupView() {} // 0x000000018318D540-0x000000018318D6C0
	// [XID] // 0x00000001899B6020-0x00000001899B6040
	public override void UpdateView() {} // 0x000000018318D6C0-0x000000018318D780
	// [XID] // 0x00000001899BDD80-0x00000001899BDDA0
	protected override void BindViewCallbacks() {} // 0x0000000183189B20-0x0000000183189C80
	// [XID] // 0x00000001899C54A0-0x00000001899C54C0
	private void ResetJoypadBtns(ShopType shopType) {} // 0x000000018318BF50-0x000000018318C1A0
	// [XID] // 0x00000001899CCB70-0x00000001899CCB90
	private void CloseMall() {} // 0x000000018318B7E0-0x000000018318B8E0
	// [XID] // 0x00000001899D4190-0x00000001899D41B0
	public void Refresh(ShopType type) {} // 0x00000001831891E0-0x0000000183189360
	// [XID] // 0x00000001899DB780-0x00000001899DB7A0
	private void LoadPrefabByType(ShopmallEntranceType type) {} // 0x000000018318B310-0x000000018318B550
	// [XID] // 0x00000001899E2EA0-0x00000001899E2EC0
	private ShopData GetCurMallData() => default; // 0x0000000183189ED0-0x000000018318A060
	// [XID] // 0x00000001899EA590-0x00000001899EA5B0
	private ShopType GetCurShopType() => default; // 0x000000018318AA80-0x000000018318AB70
	// [XID] // 0x00000001899F2000-0x00000001899F2020
	private void InitCurrentPanel(ulong pathHash, bool loadSucceeded, uint handle, GameObject obj) {} // 0x0000000183188C70-0x0000000183189040
	// [XID] // 0x00000001899F9740-0x00000001899F9760
	private void UpdateRefreshTime(ShopData mallData) {} // 0x000000018318C240-0x000000018318C470
	// [XID] // 0x0000000189A00AA0-0x0000000189A00AC0
	private void ReinitMallData(ShopData mallData) {} // 0x000000018318A6D0-0x000000018318A820
	// [XID] // 0x0000000189A08380-0x0000000189A083A0
	private void RefreshMallData(ShopData mallData, bool refreshPanel) {} // 0x0000000183189D90-0x0000000183189ED0
	// [XID] // 0x0000000189A0F8A0-0x0000000189A0F8C0
	private void UpdateByMallData(ShopData mallData) {} // 0x00000001831890F0-0x00000001831891E0
	// [XID] // 0x0000000189A16E80-0x0000000189A16EA0
	private void UpdatePSStoreIcon(ShopData mallData) {} // 0x000000018318A430-0x000000018318A5E0
	// [XID] // 0x0000000189A1E540-0x0000000189A1E560
	private void UpdateDoubleTips(ShopData mallData) {} // 0x00000001831894A0-0x0000000183189800
	// [XID] // 0x0000000189A25C20-0x0000000189A25C40
	private void UpdateEmptyTips(ShopData mallData) {} // 0x000000018318CBE0-0x000000018318CD70
	// [XID] // 0x0000000189A2D080-0x0000000189A2D0A0
	private void UpdateNoPriceTips(ShopData mallData) {} // 0x0000000183189360-0x00000001831894A0
	// [XID] // 0x0000000189A34A80-0x0000000189A34AA0
	private void InitPageView() {} // 0x000000018318C1A0-0x000000018318C240
	// [XID] // 0x0000000189A3BE30-0x0000000189A3BE50
	private void InitTabs() {} // 0x000000018318C640-0x000000018318C980
	// [XID] // 0x0000000189A43A80-0x0000000189A43AA0
	private void InitTab(Transform trans, int i) {} // 0x000000018318A190-0x000000018318A430
	// [XID] // 0x0000000189A4AED0-0x0000000189A4AEF0
	private void OnSelectorChange(Transform trans, int index) {} // 0x000000018318A820-0x000000018318AA80
	// [XID] // 0x0000000189A525F0-0x0000000189A52610
	private void OnRegionChange(MonoRegionJoypadController.RegionInfo from, MonoRegionJoypadController.RegionInfo to) {} // 0x000000018318ABD0-0x000000018318AD60
	// [XID] // 0x0000000189A59F40-0x0000000189A59F60
	private void ResetMaterials(ShopData mallData) {} // 0x000000018318B8E0-0x000000018318BCE0
	// [XID] // 0x0000000189A61710-0x0000000189A61730
	private ShopMaterial GetCostMaterial(uint costId) => default; // 0x0000000183189C80-0x0000000183189D90
	// [XID] // 0x0000000189A69650-0x0000000189A69670
	public void RefreshShop() {} // 0x0000000183189800-0x0000000183189990
	// [XID] // 0x0000000189A709A0-0x0000000189A709C0
	private void OnTabClicked(int index) {} // 0x000000018318B050-0x000000018318B310
	// [XID] // 0x0000000189A78270-0x0000000189A78290
	private void ReleaseCurrentPanel() {} // 0x000000018318ADC0-0x000000018318AF30
	// [XID] // 0x0000000189A7F880-0x0000000189A7F8A0
	public override void ClearView() {} // 0x000000018318A5E0-0x000000018318A6D0
	// [XID] // 0x0000000189A87580-0x0000000189A875A0
	public override void OnDisconnect() {} // 0x000000018318CF70-0x000000018318D070
	// [XID] // 0x0000000189A8ED20-0x0000000189A8ED40
	private void OpenFeedback() {} // 0x000000018318BD40-0x000000018318BEB0
	// [XID] // 0x0000000189A96390-0x0000000189A963B0
	private void OpenPayInfo() {} // 0x000000018318CD70-0x000000018318CE80
	// [XID] // 0x0000000189A9D8E0-0x0000000189A9D900
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018318B5B0-0x000000018318B670
	// [XID] // 0x0000000189AA51D0-0x0000000189AA51F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018318B670-0x000000018318B780
	// [XID] // 0x0000000189AAC950-0x0000000189AAC970
	private void CheckHavePrice(ShopData shopData) {} // 0x000000018318C470-0x000000018318C640
	// [XID] // 0x0000000189AB4250-0x0000000189AB4270
	private void OnSDKGetProductListResponse(bool success) {} // 0x0000000183189990-0x0000000183189B20
	// [XID] // 0x0000000189ABBF50-0x0000000189ABBF70
	private void BindTabRPShow(ShopType shopType, Transform trans) {} // 0x000000018318A060-0x000000018318A190
}

