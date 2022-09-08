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
	public class MonoCookingItemTip : MonoItemTip // TypeDefIndex: 30408
	{
		// Fields
		private const string BAG_SLOT_PREFAB_ROOT = "ART/UI/Menus/Widget/BagItemSlotSmall"; // Metadata: 0x00B10CCF
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _cookNeedRoot; // 0x218
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarIconRoot; // 0x220
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _upImg; // 0x228
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _canUpImg; // 0x230
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needDesc; // 0x238
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _replaceBtn; // 0x240
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _count; // 0x248
		private List<MonoItemSlot> _cookNeedList; // 0x250
		private MonoAvatarIcon _avatarIcon; // 0x258
		private GameObject _bagSlotPrefab; // 0x260
		private List<string> _tempDescList; // 0x268
	
		// Properties
		public UnityEngine.UI.Text count { /* [XID] */ /* 0x0000000189928EE0-0x0000000189928F00 */ get => default; } // 0x0000000184BB9A30-0x0000000184BB9AE0 
		public Button replaceBtn { /* [XID] */ /* 0x0000000189930470-0x0000000189930490 */ get => default; } // 0x0000000184BB9AE0-0x0000000184BB9BA0 
		public MonoAvatarIcon avatarIcon { /* [XID] */ /* 0x0000000189972420-0x0000000189972440 */ get => default; } // 0x0000000184BB9870-0x0000000184BB9A30 
	
		// Constructors
		public MonoCookingItemTip() {} // 0x0000000184BB9780-0x0000000184BB9870
	
		// Methods
		// [XID] // 0x0000000189937940-0x0000000189937960
		protected override void OnDestroy() {} // 0x0000000184BB8030-0x0000000184BB8200
		// [XID] // 0x000000018993F430-0x000000018993F450
		public void UpdateCookRecipeItem(MaterialItem item) {} // 0x0000000184BB8AD0-0x0000000184BB91F0
		// [XID] // 0x0000000189946A20-0x0000000189946A40
		public void UpdateCookingItem(CookRecipeData recipeData) {} // 0x0000000184BB91F0-0x0000000184BB9780
		// [IDTag] // 0x000000018994E0C0-0x000000018994E100
		// [XID] // 0x000000018994E0C0-0x000000018994E100
		private void UpdateEffectDesc(string[] descList) {} // 0x0000000184BB7A70-0x0000000184BB7D50
		// [IDTag] // 0x0000000189958990-0x00000001899589D0
		// [XID] // 0x0000000189958990-0x00000001899589D0
		private void UpdateEffectDesc(List<string> descList) {} // 0x0000000184BB7D50-0x0000000184BB8030
		// [XID] // 0x0000000189963380-0x00000001899633A0
		private void UpdateCookNeedList(IdCountConfig[] needList) {} // 0x0000000184BB7400-0x0000000184BB7A70
		// [XID] // 0x000000018996A6E0-0x000000018996A700
		public void SetAvatarIcon(AvatarExcelConfig avatarData, bool isUp = false /* Metadata: 0x00B10CCD */, bool canUp = false /* Metadata: 0x00B10CCE */) {} // 0x0000000184BB8200-0x0000000184BB84F0
		// [XID] // 0x0000000189979C00-0x0000000189979C20
		public void UpdateCompoundItem(uint compoundId) {} // 0x0000000184BB84F0-0x0000000184BB8AD0
	}
}
