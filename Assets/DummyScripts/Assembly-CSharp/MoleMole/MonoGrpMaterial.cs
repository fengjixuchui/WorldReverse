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
	public class MonoGrpMaterial : MonoUIProxy // TypeDefIndex: 31046
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _materialsContainer; // 0x40
		private uint _shopMaterialHandler; // 0x48
		private GameObject _shopMaterialPrefab; // 0x50
		private const string SHOP_MAT_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B11E2E
	
		// Constructors
		public MonoGrpMaterial() {} // 0x0000000184081F90-0x0000000184082000
	
		// Methods
		// [XID] // 0x00000001896A6E70-0x00000001896A6E90
		public void InitShopMaterials(List<ShopMaterial> shopMaterials) {} // 0x0000000184081AA0-0x0000000184081DB0
		// [XID] // 0x00000001896AE440-0x00000001896AE460
		public void OnDisable() {} // 0x0000000184081EB0-0x0000000184081F90
	}
}
