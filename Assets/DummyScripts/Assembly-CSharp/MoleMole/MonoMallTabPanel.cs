/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMallTabPanel : MonoMallBasePanel // TypeDefIndex: 31057
	{
		// Fields
		public MonoGridScroller tabScroller; // 0x30
		public GameObject oneContainerObj; // 0x38
		public GameObject colContainerObj; // 0x40
		public GameObject itemContainerObj; // 0x48
		public Transform oneContainer; // 0x50
		public Transform threeContainer; // 0x58
		public Transform itemsContainer; // 0x60
		public MonoGridScroller _itemsColScroller; // 0x68
		public MonoGridScroller _itemsScroller; // 0x70
		public GameObject containerPrefab; // 0x78
		public GameObject itemPrefab; // 0x80
		public GameObject hcoinCardPrefab; // 0x88
		public GameObject resinCardPrefab; // 0x90
		public MonoMaxContentSizeFitter _maxSizeFitter; // 0x98
		private int _curPanelTabIndex; // 0xA0
		private List<ShopmallRecommendConfig> _recomConfigList; // 0xA8
		private List<MonoMallBtnTab> _tabList; // 0xB0
		private List<MonoMallBaseItem> _itemSlots; // 0xB8
		private List<ShopItem> _validGoodsIndexList; // 0xC0
		private List<ShopmallSubTabExcelConfig> _subTabConfig; // 0xC8
		private List<uint> _tabIDs; // 0xD0
	
		// Constructors
		public MonoMallTabPanel() {} // 0x000000018429AF00-0x000000018429B0D0
	
		// Methods
		// [XID] // 0x0000000189959FB0-0x0000000189959FD0
		public override void InitPanel(ShopData data, List<ShopMaterial> list, MallPageContext context) {} // 0x00000001842988F0-0x0000000184298AB0
		// [XID] // 0x00000001899619E0-0x0000000189961A00
		private bool IsRecommendPanel() => default; // 0x0000000184299060-0x0000000184299120
		// [XID] // 0x0000000189969090-0x00000001899690B0
		private void InitNormalPanel(uint subTabId) {} // 0x0000000184298380-0x0000000184298640
		// [XID] // 0x0000000189970AD0-0x0000000189970AF0
		private void InitRecommendPanel(int index) {} // 0x0000000184299480-0x0000000184299790
		// [XID] // 0x00000001899784D0-0x00000001899784F0
		public void OnDestroy() {} // 0x000000018429AD80-0x000000018429AE60
		// [XID] // 0x000000018997F5D0-0x000000018997F5F0
		public override void RefreshPanel() {} // 0x000000018429AE60-0x000000018429AF00
		// [XID] // 0x0000000189986F20-0x0000000189986F40
		public override void ClearPanel() {} // 0x0000000184297C70-0x0000000184297D20
		// [XID] // 0x000000018998E9D0-0x000000018998E9F0
		private void InitCurPanel(bool showAnim = true /* Metadata: 0x00B11E64 */) {} // 0x0000000184299120-0x0000000184299420
		// [XID] // 0x0000000189996610-0x0000000189996630
		private void ClearCurPanel() {} // 0x00000001842977E0-0x0000000184297970
		// [XID] // 0x000000018999E070-0x000000018999E090
		private void InitOnePanel() {} // 0x0000000184299ED0-0x000000018429A8E0
		// [XID] // 0x00000001899A5AD0-0x00000001899A5AF0
		private void InitThreePanel() {} // 0x0000000184297540-0x00000001842977E0
		// [XID] // 0x00000001899AD130-0x00000001899AD150
		private void InitColPanel(Transform container, int index) {} // 0x00000001842999C0-0x0000000184299D80
		// [XID] // 0x00000001899B4990-0x00000001899B49B0
		private void InitItemsPanel() {} // 0x0000000184296BB0-0x0000000184297290
		// [XID] // 0x00000001899BC060-0x00000001899BC080
		private void InitItemPanelItem(Transform trans, int i) {} // 0x0000000184298AB0-0x0000000184298D40
		// [XID] // 0x00000001899C3B50-0x00000001899C3B70
		private ShopItem GetShopItem(ShopmallRecommendConfig config, int i) => default; // 0x0000000184298D40-0x0000000184299060
		// [XID] // 0x00000001899CB1B0-0x00000001899CB1D0
		private bool HasShopItem(ShopmallRecommendConfig config) => default; // 0x0000000184298640-0x00000001842988F0
		// [XID] // 0x00000001899D26C0-0x00000001899D26E0
		public override int GetCurTabIndex() => default; // 0x0000000184298270-0x0000000184298310
		// [XID] // 0x00000001899D9E10-0x00000001899D9E30
		private void InitTabs(int initTabIndex = 0 /* Metadata: 0x00B11E65 */) {} // 0x0000000184299790-0x00000001842999C0
		// [XID] // 0x00000001899E1670-0x00000001899E1690
		private ShopmallRecommendConfig GetTabShopConfig(int i) => default; // 0x0000000184297290-0x00000001842974E0
		// [XID] // 0x00000001899E8D20-0x00000001899E8D40
		private void InitTab(Transform trans, int i) {} // 0x0000000184297970-0x0000000184297C70
		// [XID] // 0x00000001899F06A0-0x00000001899F06C0
		private void OnTabClicked(int index) {} // 0x0000000184297FA0-0x0000000184298270
		// [XID] // 0x00000001899F7CA0-0x00000001899F7CC0
		private void OnItemSelectorChange(Transform trans, int i) {} // 0x000000018429A8E0-0x000000018429AD80
		// [XID] // 0x00000001899FF310-0x00000001899FF330
		private void OnSelectorChange(Transform trans, int index) {} // 0x0000000184297D20-0x0000000184297F10
		// [XID] // 0x0000000189A06B30-0x0000000189A06B50
		private void BindSubTabRPShow(ShopmallSubTabExcelConfig config, Transform trans) {} // 0x0000000184299D80-0x0000000184299ED0
	}
}
