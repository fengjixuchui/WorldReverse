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

public sealed class TheatreMechanicusGearPage : BasePageContext // TypeDefIndex: 29954
{
	// Fields
	private MonoTheatreMechanicusGearPage _pageMono; // 0x190
	private List<uint> _openGearList; // 0x198
	private MechanicusInfo _mechanicusInfo; // 0x1A0
	private GameObject _shopMaterialPrefab; // 0x1A8
	private List<MonoShopMaterial> _shopMaterialsList; // 0x1B0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B10328
	private uint _shopMaterialHandler; // 0x1B8
	private uint _curSelectedGearID; // 0x1BC
	private int _selectedIndex; // 0x1C0

	// Constructors
	public TheatreMechanicusGearPage() {} // 0x000000018292B1B0-0x000000018292B2D0

	// Methods
	// [XID] // 0x00000001899C53E0-0x00000001899C5400
	public override void SetupView() {} // 0x000000018292ADB0-0x000000018292B1B0
	// [XID] // 0x00000001899CCA50-0x00000001899CCA70
	private int CompareMechanicusGear(uint xData, uint yData) => default; // 0x0000000182929610-0x0000000182929890
	// [XID] // 0x00000001899D40D0-0x00000001899D40F0
	private void UpdateMaterialsList() {} // 0x00000001829291B0-0x0000000182929460
	// [XID] // 0x00000001899DB660-0x00000001899DB680
	private void UpdateMaterialCount() {} // 0x000000018292AC20-0x000000018292ADB0
	// [XID] // 0x00000001899E2DC0-0x00000001899E2DE0
	protected override void OnEnable() {} // 0x000000018292A910-0x000000018292A9C0
	// [XID] // 0x00000001899EA4D0-0x00000001899EA4F0
	private void Refresh(uint gearID, uint level = 1 /* Metadata: 0x00B10324 */) {} // 0x0000000182928900-0x0000000182928B20
	// [XID] // 0x00000001899F1EA0-0x00000001899F1EC0
	private void RefreshGearItem(Transform trans, int index) {} // 0x0000000182929890-0x0000000182929BC0
	// [XID] // 0x00000001899F9660-0x00000001899F9680
	private void OnRowClick(int index) {} // 0x0000000182928D20-0x0000000182928F70
	// [XID] // 0x0000000189A00980-0x0000000189A009A0
	private void UpdateGearDetail(int index) {} // 0x0000000182929BC0-0x000000018292A820
	// [XID] // 0x0000000189A082C0-0x0000000189A082E0
	protected override void BindViewCallbacks() {} // 0x0000000182928B20-0x0000000182928D20
	// [XID] // 0x0000000189A0F780-0x0000000189A0F7A0
	private void OnClickReturn() {} // 0x000000018292AB70-0x000000018292AC20
	// [XID] // 0x0000000189A16D80-0x0000000189A16DA0
	private void OnClickBtnUnlock() {} // 0x0000000182929460-0x0000000182929550
	// [XID] // 0x0000000189A1E3E0-0x0000000189A1E400
	private void OnClickBtnUpgrade() {} // 0x0000000182929060-0x0000000182929150
	// [XID] // 0x0000000189A25AE0-0x0000000189A25B00
	public override bool OnNotify(Notify ntf) => default; // 0x000000018292A9C0-0x000000018292AB70
	// [XID] // 0x0000000189A2CF60-0x0000000189A2CF80
	public override void ClearView() {} // 0x0000000182928F70-0x0000000182929060
}

