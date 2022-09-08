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

public sealed class ShopGiftPackageDialogContext : BaseDialogContext // TypeDefIndex: 29294
{
	// Fields
	private MonoShopGiftPackageDialog _dialogMono; // 0x178
	private uint _curNum; // 0x180
	private ShopItem _shopItem; // 0x188
	private ShopType _shopType; // 0x190
	private List<ShopMaterial> _shopMaterialsList; // 0x198
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F506
	private uint _shopMaterialHandler; // 0x1A0
	private GameObject _shopMaterialPrefab; // 0x1A8

	// Properties
	public uint curNum { /* [XID] */ /* 0x0000000189A159A0-0x0000000189A159C0 */ set {} } // 0x0000000183FD6050-0x0000000183FD6100
	public ShopItem shopItem { /* [XID] */ /* 0x0000000189A1CE60-0x0000000189A1CE80 */ set {} } // 0x0000000183FD5C10-0x0000000183FD5CC0
	public ShopType shopType { /* [XID] */ /* 0x0000000189A243A0-0x0000000189A243C0 */ set {} } // 0x0000000183FD5540-0x0000000183FD55F0
	public List<ShopMaterial> shopMaterialsList { /* [XID] */ /* 0x0000000189A2B860-0x0000000189A2B880 */ set {} } // 0x0000000183FD6100-0x0000000183FD61B0

	// Constructors
	public ShopGiftPackageDialogContext() {} // Dummy constructor
	public ShopGiftPackageDialogContext(ShopItem shopItem) {} // 0x0000000183FD67B0-0x0000000183FD68D0

	// Methods
	// [XID] // 0x0000000189A32EE0-0x0000000189A32F00
	public override void SetupView() {} // 0x0000000183FD64C0-0x0000000183FD67B0
	// [XID] // 0x0000000189A3A750-0x0000000189A3A770
	public override void ClearView() {} // 0x0000000183FD5B30-0x0000000183FD5C10
	// [XID] // 0x0000000189A420A0-0x0000000189A420C0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183FD63C0-0x0000000183FD64C0
	// [XID] // 0x0000000189A49650-0x0000000189A49670
	protected override void BindViewCallbacks() {} // 0x0000000183FD55F0-0x0000000183FD5810
	// [XID] // 0x0000000189A50FE0-0x0000000189A51000
	private void Cancel() {} // 0x0000000183FD5CC0-0x0000000183FD5D70
	// [XID] // 0x0000000189A58540-0x0000000189A58560
	private void OnExchange() {} // 0x0000000183FD61B0-0x0000000183FD62D0
	// [XID] // 0x0000000189A60000-0x0000000189A60020
	private string GetBuyCostString(ShopItem selectItem, uint num) => default; // 0x0000000183FD5240-0x0000000183FD5540
	// [XID] // 0x0000000189A67C60-0x0000000189A67C80
	private void RefreshMaterials() {} // 0x0000000183FD5810-0x0000000183FD5B30
	// [XID] // 0x0000000189A6F070-0x0000000189A6F090
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183FD5E60-0x0000000183FD5FF0
}

