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

public sealed class HomeWorldShopPageContext : ShopPageContext // TypeDefIndex: 29156
{
	// Fields
	private MonoActivityShopPage _homeWorldPageMono; // 0x230
	private Dictionary<uint, List<ShopItem>> _shopTabItemDic; // 0x238
	private List<uint> _shopTabIndexList; // 0x240
	private bool _shopDataUpdated; // 0x248
	private int _selectedTabIndex; // 0x24C
	private List<ShopItem> _rawShopItemList; // 0x250
	private List<MonoBtnTab> _tabMonoBtns; // 0x258
	private bool _joypadFocusTab; // 0x260

	// Constructors
	public HomeWorldShopPageContext() {} // 0x00000001824EB220-0x00000001824EB3A0

	// Methods
	// [XID] // 0x00000001897CA410-0x00000001897CA430
	public override void SetupView() {} // 0x00000001824EAFB0-0x00000001824EB220
	// [XID] // 0x00000001897D1A50-0x00000001897D1A70
	private void ClearItemSelectState() {} // 0x00000001824E96F0-0x00000001824E9870
	// [XID] // 0x00000001897D98D0-0x00000001897D98F0
	private void SelectCurrentSelectedItem() {} // 0x00000001824EAAA0-0x00000001824EAB50
	// [XID] // 0x00000001897E0C50-0x00000001897E0C70
	private void SetJoypadFocusTab(bool focus) {} // 0x00000001824E9900-0x00000001824E9CB0
	// [XID] // 0x00000001897E8290-0x00000001897E82B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001824E9D10-0x00000001824E9F80
	// [XID] // 0x00000001897EFFB0-0x00000001897EFFD0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001824EABE0-0x00000001824EAFB0
	// [XID] // 0x00000001897F7740-0x00000001897F7760
	private void UpdateTabs() {} // 0x00000001824E9170-0x00000001824E9430
	// [XID] // 0x00000001897FEE30-0x00000001897FEE50
	private void InitTabScroller(Transform trans, int index) {} // 0x00000001824E9430-0x00000001824E96F0
	// [XID] // 0x00000001898065B0-0x00000001898065D0
	private void OnTabSelected(int index) {} // 0x00000001824EA6B0-0x00000001824EAAA0
	// [XID] // 0x000000018980DCD0-0x000000018980DCF0
	protected override void SetRefreshTime(ShopItem shopItem) {} // 0x00000001824EA000-0x00000001824EA6B0
}

