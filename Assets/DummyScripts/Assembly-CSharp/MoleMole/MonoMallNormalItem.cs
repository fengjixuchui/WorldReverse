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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMallNormalItem : MonoMallBaseItem // TypeDefIndex: 31051
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _itemIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _itemImage; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemAddInfoText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _activeBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _needObj; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _discountTagObj; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _discountTagText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _remainTimeTagObj; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _remainTimeTagText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _offShelfTagObj; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _offShelfTagText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _commonObj; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _commonLabelText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _commonLabelImage; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _discountObj; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _discountLabelText; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _discountOriLabelText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _discountLabelImage; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rechargeObj; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rechargeLabelText; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rechargeOffer1Obj; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rechargeOffer1LableText; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rechargeOffer1NumText; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rechargeOffer2Obj; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rechargeOffer2LableText; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rechargeOffer2NumText; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tips; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _warningColor; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _imageGrayScaleMat; // 0x138
		private ShopItem _itemData; // 0x140
		private ShopType _shopType; // 0x148
		private ImageType _imageType; // 0x14C
		private List<ShopMaterial> _shopMaterialsList; // 0x150
		private string _recommendIconName; // 0x158
		public double _orderWeight; // 0x160
		private bool _fromPackage; // 0x168
		private bool _itemSoldOut; // 0x169
	
		// Properties
		public MonoUIContainer tipsContainer { /* [XID] */ /* 0x0000000189813840-0x0000000189813860 */ get => default; } // 0x00000001842948F0-0x00000001842949A0 
	
		// Nested types
		public enum ImageType // TypeDefIndex: 31052
		{
			Icon = 0,
			Image = 1
		}
	
		// Constructors
		public MonoMallNormalItem() {} // 0x0000000184294790-0x00000001842948F0
	
		// Methods
		// [XID] // 0x000000018981B3F0-0x000000018981B410
		public void InitItem(ShopItem itemData, ShopType type, List<ShopMaterial> shopMaterialsList, ImageType imageType = ImageType.Icon /* Metadata: 0x00B11E57 */, string iconName = null, bool fromPackage = false /* Metadata: 0x00B11E5B */) {} // 0x0000000184292DC0-0x0000000184292F20
		// [XID] // 0x00000001898229E0-0x0000000189822A00
		public void SetupItem() {} // 0x0000000184293FE0-0x0000000184294790
		// [XID] // 0x000000018982A390-0x000000018982A3B0
		public override void Refresh() {} // 0x0000000184293D70-0x0000000184293FE0
		// [XID] // 0x0000000189831650-0x0000000189831670
		public void OnTips() {} // 0x00000001842939C0-0x0000000184293B00
		// [XID] // 0x0000000189838D00-0x0000000189838D20
		private void InitType(ShopItem itemData, bool fromPackage) {} // 0x0000000184292530-0x0000000184292BE0
		// [XID] // 0x00000001898403E0-0x0000000189840400
		private void ShowLimitSpecialInfo() {} // 0x00000001842934E0-0x00000001842939C0
		// [XID] // 0x00000001898479B0-0x00000001898479D0
		private void ShowOffer() {} // 0x00000001842921B0-0x0000000184292530
		// [XID] // 0x000000018984F120-0x000000018984F140
		private void ShowSpecialInfo() {} // 0x0000000184293B00-0x0000000184293D70
		// [XID] // 0x0000000189856220-0x0000000189856240
		private void ShowLimitNormalInfo() {} // 0x0000000184291BA0-0x00000001842921B0
		// [XID] // 0x000000018985D5D0-0x000000018985D5F0
		private void ShowItemTime() {} // 0x0000000184292F20-0x00000001842934E0
		// [XID] // 0x0000000189864F70-0x0000000189864F90
		private void OnItemClick() {} // 0x0000000184292C40-0x0000000184292DC0
	}
}
