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

public sealed class InLevelGachaPageContext : BasePageContext // TypeDefIndex: 29801
{
	// Fields
	private MonoInLevelGachaPage _pageMono; // 0x190
	private GameObject _gachaMaterialPrefab; // 0x198
	private const string GACHA_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0FF95
	private uint _gachaMaterialHandler; // 0x1A0
	private GameObject _curGachaPanelObj; // 0x1A8
	private Dictionary<int, int> _tabIndex2GachaIndex; // 0x1B0
	private int curTabIndex; // 0x1B8
	private uint _curGachaPageHandler; // 0x1BC
	public const uint STAR_GLITTER_SUB_TAB_ID = 2; // Metadata: 0x00B0FFBE
	private InLevelGachaGroupContext _gachaContext; // 0x1C0
	public readonly string DefaultPanelPath; // 0x1D0

	// Properties
	public bool NeedSecrecyCheck { /* [XID] */ /* 0x000000018979FB30-0x000000018979FB70 */ get; /* [XID] */ /* 0x00000001897A9F40-0x00000001897A9F80 */ set; } // 0x00000001817AB490-0x00000001817AB4F0 0x00000001817A9EB0-0x00000001817A9F20
	public bool NeedSecrecyHint { /* [XID] */ /* 0x00000001897B5270-0x00000001897B52B0 */ get; /* [XID] */ /* 0x00000001897BFFD0-0x00000001897C0010 */ set; } // 0x00000001817AA6F0-0x00000001817AA750 0x00000001817AB240-0x00000001817AB2B0

	// Constructors
	public InLevelGachaPageContext() {} // Dummy constructor
	public InLevelGachaPageContext(InLevelGachaGroupContext gachaContext) {} // 0x00000001817AD760-0x00000001817AD900

	// Methods
	// [XID] // 0x00000001897CA350-0x00000001897CA370
	public override void SetupView() {} // 0x00000001817AD630-0x00000001817AD760
	// [XID] // 0x00000001897D19B0-0x00000001897D19D0
	public override void SetActive(bool enable) {} // 0x00000001817AD560-0x00000001817AD630
	// [XID] // 0x00000001897D97D0-0x00000001897D97F0
	public override void ClearView() {} // 0x00000001817A95E0-0x00000001817A97B0
	// [XID] // 0x00000001897E0B90-0x00000001897E0BB0
	protected override void BindViewCallbacks() {} // 0x00000001817A8EB0-0x00000001817A9220
	// [XID] // 0x00000001897E81F0-0x00000001897E8210
	private void CheckSecrecyRes() {} // 0x00000001817A9F20-0x00000001817AA1D0
	// [XID] // 0x00000001897EFF10-0x00000001897EFF30
	private void CheckSecrecyHintDialog() {} // 0x00000001817A8CA0-0x00000001817A8E00
	// [XID] // 0x00000001897F76A0-0x00000001897F76C0
	private void EndGache() {} // 0x00000001817AD4A0-0x00000001817AD560
	// [XID] // 0x00000001897FED90-0x00000001897FEDB0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001817AD3C0-0x00000001817AD4A0
	// [XID] // 0x0000000189806510-0x0000000189806530
	private void InitMenuTab() {} // 0x00000001817ACE20-0x00000001817AD160
	// [XID] // 0x000000018980DC10-0x000000018980DC30
	private bool IsGachaPoolValid(GachaDataInfo info) => default; // 0x00000001817A97B0-0x00000001817A9990
	// [XID] // 0x0000000189815350-0x0000000189815370
	private void SetupTab(MonoImgTab tab, GachaDataInfo config) {} // 0x00000001817AA910-0x00000001817AABC0
	// [XID] // 0x000000018981CD50-0x000000018981CD70
	private void OnGachaDetail() {} // 0x00000001817A9220-0x00000001817A9410
	// [XID] // 0x0000000189824190-0x00000001898241B0
	private void InitLimitInfo() {} // 0x00000001817AC8E0-0x00000001817ACA30
	// [XID] // 0x000000018982BC20-0x000000018982BC40
	private void OnGachaRecord() {} // 0x00000001817A9990-0x00000001817A9B80
	// [XID] // 0x0000000189833190-0x00000001898331B0
	private void OnExchangeClick() {} // 0x00000001817ACD40-0x00000001817ACE20
	// [XID] // 0x000000018983A640-0x000000018983A660
	private void OnTabClicked(int index) {} // 0x00000001817AA1D0-0x00000001817AA460
	// [XID] // 0x0000000189841C20-0x0000000189841C40
	private int GetFirstValidIndex() => default; // 0x00000001817ABE90-0x00000001817ABFB0
	// [XID] // 0x0000000189849130-0x0000000189849150
	private int GetPreviousValidIndex(int index) => default; // 0x00000001817A9B80-0x00000001817A9DA0
	// [XID] // 0x00000001898508F0-0x0000000189850910
	private int GetNextValidIndex(int index) => default; // 0x00000001817ABBC0-0x00000001817ABDD0
	// [XID] // 0x0000000189857CA0-0x0000000189857CC0
	private void OnPrevious() {} // 0x00000001817ACC90-0x00000001817ACD40
	// [XID] // 0x000000018985ED90-0x000000018985EDB0
	private void OnNext() {} // 0x00000001817A8E00-0x00000001817A8EB0
	// [XID] // 0x0000000189866590-0x00000001898665B0
	private void RefreshTabSelected() {} // 0x00000001817AD1F0-0x00000001817AD3C0
	// [XID] // 0x000000018986DE90-0x000000018986DEB0
	private string GetGachaPrefabPath(GachaDataInfo config) => default; // 0x00000001817A9410-0x00000001817A9500
	// [XID] // 0x0000000189875260-0x0000000189875280
	private string GetGachaTabName(GachaDataInfo config) => default; // 0x00000001817ABFB0-0x00000001817AC070
	// [XID] // 0x000000018987CE50-0x000000018987CE70
	private void RefreshContentView() {} // 0x00000001817AB4F0-0x00000001817ABBC0
	// [XID] // 0x0000000189883DD0-0x0000000189883DF0
	private void OnPanelUpDetail(string textMapId) {} // 0x00000001817AA460-0x00000001817AA6F0
	// [XID] // 0x000000018988B470-0x000000018988B490
	private void InitAllPages() {} // 0x00000001817ACA30-0x00000001817ACC30
	// [XID] // 0x0000000189892BF0-0x0000000189892C10
	private void InitCurPage() {} // 0x00000001817ABDD0-0x00000001817ABE90
	// [XID] // 0x000000018989A290-0x000000018989A2B0
	private ShopMaterial GetCostMaterial() => default; // 0x00000001817A9500-0x00000001817A95E0
	// [XID] // 0x00000001898A14D0-0x00000001898A14F0
	private ShopMaterial GetCrystalMaterial() => default; // 0x00000001817A8AF0-0x00000001817A8C10
	// [XID] // 0x00000001898A8D40-0x00000001898A8D60
	private void InitCrystal() {} // 0x00000001817AC070-0x00000001817AC8E0
	// [XID] // 0x00000001898B06C0-0x00000001898B06E0
	private void GachaOnce() {} // 0x00000001817AB3D0-0x00000001817AB490
	// [XID] // 0x00000001898B7CD0-0x00000001898B7CF0
	private void GachaTenTimes() {} // 0x00000001817AB310-0x00000001817AB3D0
	// [XID] // 0x00000001898BF300-0x00000001898BF320
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001817AAC20-0x00000001817AB240
}

