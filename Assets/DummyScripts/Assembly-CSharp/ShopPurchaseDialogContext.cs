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

public sealed class ShopPurchaseDialogContext : BaseDialogContext // TypeDefIndex: 29298
{
	// Fields
	private MonoShopPurchaseDialog _dialogMono; // 0x178
	private uint _curNum; // 0x180
	private uint _maxNum; // 0x184
	private ShopItem _shopItem; // 0x188
	private MonoPurchaseItem _monoPurchaseItem; // 0x190
	private ShopType _shopType; // 0x198
	private List<ShopMaterial> _shopMaterialsList; // 0x1A0
	private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B0F581
	private uint _shopMaterialHandler; // 0x1A8
	private GameObject _shopMaterialPrefab; // 0x1B0
	private bool _lockByShop; // 0x1B8
	private string _lockReason; // 0x1C0
	private List<uint> _groupItemID; // 0x1C8
	private bool _materialEnough; // 0x1D0
	private float _clickStartTime; // 0x1D4
	private MonoMultiClickButton _multiPlusBtn; // 0x1D8
	private MonoMultiClickButton _multiMinusBtn; // 0x1E0

	// Properties
	public uint curNum { /* [XID] */ /* 0x00000001895EA550-0x00000001895EA570 */ set {} } // 0x00000001822FE330-0x00000001822FE3E0
	public uint maxNum { /* [XID] */ /* 0x00000001895F19B0-0x00000001895F19D0 */ set {} } // 0x00000001822FF0F0-0x00000001822FF1A0
	public ShopItem shopItem { /* [XID] */ /* 0x00000001895F93D0-0x00000001895F93F0 */ set {} } // 0x00000001822FD200-0x00000001822FD2B0
	public ShopType shopType { /* [XID] */ /* 0x0000000189600A20-0x0000000189600A40 */ set {} } // 0x00000001822FC690-0x00000001822FC740
	public List<ShopMaterial> shopMaterialsList { /* [XID] */ /* 0x0000000189608340-0x0000000189608360 */ set {} } // 0x00000001822FE3E0-0x00000001822FE490

	// Constructors
	public ShopPurchaseDialogContext() {} // Dummy constructor
	public ShopPurchaseDialogContext(ShopItem shopItem, List<uint> groupItemID = null) {} // 0x0000000182300230-0x0000000182300370

	// Methods
	// [XID] // 0x000000018960FCA0-0x000000018960FCC0
	public override void SetupView() {} // 0x00000001822FFC90-0x0000000182300230
	// [XID] // 0x0000000189616F80-0x0000000189616FA0
	public void SetChooseOne() {} // 0x00000001822FD760-0x00000001822FDA60
	// [XID] // 0x000000018961EB00-0x000000018961EB20
	public void SetLockByShopSetting(bool lockByShop, string lockReason) {} // 0x00000001822FDB50-0x00000001822FDC20
	// [XID] // 0x0000000189625F00-0x0000000189625F20
	private void SetTips() {} // 0x00000001822FE6B0-0x00000001822FE920
	// [XID] // 0x000000018962D8C0-0x000000018962D8E0
	private void RefreshText() {} // 0x00000001822FE490-0x00000001822FE6B0
	// [XID] // 0x0000000189635440-0x0000000189635460
	public override void ClearView() {} // 0x00000001822FD110-0x00000001822FD200
	// [XID] // 0x000000018963CB20-0x000000018963CB40
	protected override void BindViewCallbacks() {} // 0x00000001822FCB00-0x00000001822FCDF0
	// [XID] // 0x0000000189644160-0x0000000189644180
	public override bool OnNotify(Notify ntf) => default; // 0x00000001822FF940-0x00000001822FFA40
	// [XID] // 0x000000018964B910-0x000000018964B930
	private void OnClickIcon() {} // 0x00000001822FD5D0-0x00000001822FD6B0
	// [XID] // 0x00000001896530A0-0x00000001896530C0
	private void Cancel() {} // 0x00000001822FD6B0-0x00000001822FD760
	// [XID] // 0x000000018965A760-0x000000018965A780
	private void OnExchange() {} // 0x00000001822FEC50-0x00000001822FEE00
	// [XID] // 0x0000000189661D90-0x0000000189661DB0
	private void SetLongPress() {} // 0x00000001822FD2B0-0x00000001822FD5D0
	// [XID] // 0x0000000189669970-0x0000000189669990
	private void OnPlusBtnClick() {} // 0x00000001822FC740-0x00000001822FC920
	// [XID] // 0x00000001896714A0-0x00000001896714C0
	private void OnMinusBtnClick() {} // 0x00000001822FC920-0x00000001822FCB00
	// [XID] // 0x0000000189678D60-0x0000000189678D80
	private void RefreshNumBtn() {} // 0x00000001822FFA40-0x00000001822FFC90
	// [XID] // 0x00000001896804B0-0x00000001896804D0
	private void OnSliderValueChange(float value) {} // 0x00000001822FEAC0-0x00000001822FEC50
	// [XID] // 0x0000000189687F70-0x0000000189687F90
	private string GetBuyCostString(ShopItem selectItem, uint num) => default; // 0x00000001822FC390-0x00000001822FC690
	// [XID] // 0x000000018968F9D0-0x000000018968F9F0
	private void RefreshShopItem(uint buyNum) {} // 0x00000001822FF230-0x00000001822FF940
	// [XID] // 0x00000001896973D0-0x00000001896973F0
	private void RefreshMaterials() {} // 0x00000001822FCDF0-0x00000001822FD110
	// [XID] // 0x000000018969E920-0x000000018969E940
	private void SetRefreshTime() {} // 0x00000001822FE920-0x00000001822FEAC0
	// [XID] // 0x00000001896A5910-0x00000001896A5930
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001822FDC20-0x00000001822FE2D0
	// [XID] // 0x00000001896AD190-0x00000001896AD1B0
	private uint GetChangeValueBaseOnMinMax() => default; // 0x00000001822FEE00-0x00000001822FF090
}

