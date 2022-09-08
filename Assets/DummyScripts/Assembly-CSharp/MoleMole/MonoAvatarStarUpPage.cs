/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarStarUpPage : MonoUIProxy // TypeDefIndex: 30987
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoGridScroller _propertyChangeContainer; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _needMaterialContainer; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _materialContainerRoot; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _curLevelDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLimitDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRate; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _elementName; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarName; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _delayTime; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _cannotStarUpTips; // 0x90
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x98
		private List<PropertyChange> _propertyChangeList; // 0xA0
		private List<uint> _unlockSkillGroupList; // 0xA8
		private List<FightPropType> _briefInfo; // 0xB0
		private AvatarDataItem _avatarData; // 0xB8
		private List<Tuple<BagItemSlot, uint>> _costItemList; // 0xC0
		private MonoBagProxySlot _itemSlotPrefab; // 0xC8
		private uint _itemSlotHandler; // 0xD0
		private const string SHOP_MATERIAL_ITEM_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B11B6B
		private const string ITEM_SLOT_PATH = "ART/UI/Menus/Widget/BagItemSlot"; // Metadata: 0x00B11B94
		private GameObject _sCoinLabel; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0xE0
		public GameObject restrictionTips; // 0xE8
		public UnityEngine.UI.Text restrictionText; // 0xF0
	
		// Properties
		public Transform coinRoot { /* [XID] */ /* 0x00000001897C2970-0x00000001897C2990 */ get => default; } // 0x000000018422E160-0x000000018422E210 
		public MonoShopMaterial sCoinLabel { /* [XID] */ /* 0x00000001897CA130-0x00000001897CA150 */ get => default; } // 0x000000018422E540-0x000000018422E740 
		public Button starUpButton { /* [XID] */ /* 0x00000001897D95B0-0x00000001897D95D0 */ get => default; } // 0x000000018422E7E0-0x000000018422E910 
		public Button closeButton { /* [XID] */ /* 0x00000001897E09F0-0x00000001897E0A10 */ get => default; } // 0x000000018422E030-0x000000018422E160 
		public MonoNeedLabel starUpNeedLabel { /* [XID] */ /* 0x00000001897E8090-0x00000001897E80B0 */ get => default; } // 0x000000018422E910-0x000000018422EA20 
		public MonoStarRate starRate { /* [XID] */ /* 0x00000001897EFCD0-0x00000001897EFCF0 */ get => default; } // 0x000000018422E740-0x000000018422E7E0 
		public MonoGridScroller needMaterialContainer { /* [XID] */ /* 0x00000001897FEBF0-0x00000001897FEC10 */ get => default; } // 0x000000018422E4A0-0x000000018422E540 
		public UnityEngine.UI.Text levelLimitDesc { /* [XID] */ /* 0x0000000189806330-0x0000000189806350 */ get => default; } // 0x000000018422E360-0x000000018422E400 
		public List<PropertyChange> propertyChanges { /* [XID] */ /* 0x000000018980D990-0x000000018980D9B0 */ set {} } // 0x000000018422EB80-0x000000018422EC30
		public List<uint> unlockSkillGroupList { /* [XID] */ /* 0x00000001898151B0-0x00000001898151D0 */ set {} } // 0x000000018422EC30-0x000000018422ECE0
		public UnityEngine.UI.Text elementName { /* [XID] */ /* 0x000000018985EBD0-0x000000018985EBF0 */ get => default; } // 0x000000018422E2C0-0x000000018422E360 
		public UnityEngine.UI.Text avatarName { /* [XID] */ /* 0x0000000189866350-0x0000000189866370 */ get => default; } // 0x000000018422DE30-0x000000018422DED0 
		public GameObject cannotStarUpTips { /* [XID] */ /* 0x000000018986DC80-0x000000018986DCA0 */ get => default; } // 0x000000018422DF80-0x000000018422E030 
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x0000000189874F70-0x0000000189874F90 */ get => default; } // 0x000000018422EA20-0x000000018422EAD0 
		public GameObject materialContainerRoot { /* [XID] */ /* 0x000000018987CCB0-0x000000018987CCD0 */ get => default; } // 0x000000018422E400-0x000000018422E4A0 
		public float delayTime { /* [XID] */ /* 0x0000000189883C50-0x0000000189883C70 */ get => default; } // 0x000000018422E210-0x000000018422E2C0 
		public List<FightPropType> briefInfo { /* [XID] */ /* 0x000000018988B2F0-0x000000018988B310 */ get => default; /* [XID] */ /* 0x0000000189892A30-0x0000000189892A50 */ set {} } // 0x000000018422DED0-0x000000018422DF80 0x000000018422EAD0-0x000000018422EB80
	
		// Constructors
		public MonoAvatarStarUpPage() {} // 0x000000018422DD10-0x000000018422DE30
	
		// Methods
		// [XID] // 0x00000001897D1810-0x00000001897D1830
		protected override void OnDestroy() {} // 0x000000018422D330-0x000000018422D4A0
		// [XID] // 0x00000001897F7500-0x00000001897F7520
		public void SetLevel(uint currLevel, uint currMaxLevel, uint postMaxLevel) {} // 0x000000018422D4A0-0x000000018422D6B0
		// [XID] // 0x000000018981CBE0-0x000000018981CC00
		private void ShowPropertyChange() {} // 0x000000018422C4B0-0x000000018422C650
		// [XID] // 0x0000000189823FF0-0x0000000189824010
		private void RefreshPropertyChangeItem(Transform trans, int index) {} // 0x000000018422CDA0-0x000000018422D170
		// [XID] // 0x000000018982BA30-0x000000018982BA50
		public void SetProperty(AvatarDataItem avatarData) {} // 0x000000018422D6B0-0x000000018422D850
		// [XID] // 0x0000000189833030-0x0000000189833050
		private void RefreshPropertyItem(Transform trans, int index) {} // 0x000000018422C950-0x000000018422CB90
		// [XID] // 0x000000018983A4C0-0x000000018983A4E0
		public void Setup(AvatarDataItem avatarData, AvatarPromoteExcelConfig currBreakConfig, AvatarPromoteExcelConfig postBreakConfig) {} // 0x000000018422D850-0x000000018422DD10
		// [XID] // 0x0000000189841A60-0x0000000189841A80
		private void OnItemSlotPrefabLoaded(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x000000018422C650-0x000000018422C770
		// [XID] // 0x0000000189848F70-0x0000000189848F90
		private void ShowCostMaterial() {} // 0x000000018422D170-0x000000018422D330
		// [XID] // 0x0000000189850750-0x0000000189850770
		private void RefreshItemSlot(Transform trans, int index) {} // 0x000000018422CB90-0x000000018422CDA0
		// [XID] // 0x0000000189857B00-0x0000000189857B20
		private void OnCostMaterialClicked(int index) {} // 0x000000018422C7D0-0x000000018422C950
	}
}
