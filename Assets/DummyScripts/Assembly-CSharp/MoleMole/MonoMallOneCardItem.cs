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
	public class MonoMallOneCardItem : MonoMallBaseItem // TypeDefIndex: 31053
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _itemText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemInfo01Text; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemInfo02Text; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemInfo03Text; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _itemInfo04Text; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _priceText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tipBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _activeBtnContainer; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtnContainer; // 0x80
		private ItemConfig _itemConfig; // 0x88
		private ShopItem _itemData; // 0x90
		private ShopType _shopType; // 0x98
	
		// Constructors
		public MonoMallOneCardItem() {} // 0x0000000184295D80-0x0000000184295E50
	
		// Methods
		// [XID] // 0x00000001898B1BF0-0x00000001898B1C10
		public void InitItem(ShopItem itemData, ShopType type, List<ShopMaterial> shopMaterialsList) {} // 0x0000000184294A00-0x0000000184294AF0
		// [XID] // 0x00000001898B9810-0x00000001898B9830
		public override void Refresh() {} // 0x0000000184294E90-0x0000000184294F30
		// [XID] // 0x00000001898C0C30-0x00000001898C0C50
		public void SetupItem() {} // 0x0000000184294F30-0x0000000184295D80
		// [XID] // 0x00000001898C8490-0x00000001898C84B0
		public void OnTip() {} // 0x0000000184294D80-0x0000000184294E90
		// [XID] // 0x00000001898CFEE0-0x00000001898CFF00
		public void OnItemClick() {} // 0x0000000184294C80-0x0000000184294D80
		// [XID] // 0x00000001898D7490-0x00000001898D74B0
		public void OnFetchClick() {} // 0x0000000184294AF0-0x0000000184294C80
	}
}
