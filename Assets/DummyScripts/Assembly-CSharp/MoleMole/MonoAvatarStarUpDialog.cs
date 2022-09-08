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
	public class MonoAvatarStarUpDialog : MonoUIProxy // TypeDefIndex: 30447
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _freeClickButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoStarRate _starRate; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRateAfter; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currLevelLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currMaxLevelLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _postLevelLable; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _postMaxLevelLabel; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoGridScroller _propertyChangeContainer; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _needMaterialContainer; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _tipsGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoNeedLabel _scoinCostLabel; // 0x98
		private const string ITEM_SLOT_PATH = "ART/UI/Menus/Widget/BagItemSlot"; // Metadata: 0x00B11069
		private MonoBagProxySlot _itemSlotPrefab; // 0xA0
		private uint _itemSlotHandler; // 0xA8
		private List<PropertyChange> _propertyChangeList; // 0xB0
		private List<uint> _unlockSkillGroupList; // 0xB8
		private List<Tuple<BagItemSlot, uint>> _costItemList; // 0xC0
	
		// Properties
		public Button freeClickButton { /* [XID] */ /* 0x000000018977E4A0-0x000000018977E4C0 */ get => default; } // 0x000000018422BB90-0x000000018422BC30 
		public Button closeButton { /* [XID] */ /* 0x0000000189785BD0-0x0000000189785BF0 */ get => default; } // 0x000000018422B910-0x000000018422BAF0 
		public Button cancleButton { /* [XID] */ /* 0x000000018978D330-0x000000018978D350 */ get => default; } // 0x000000018422B730-0x000000018422B910 
		public Button useButton { /* [XID] */ /* 0x0000000189794690-0x00000001897946B0 */ get => default; } // 0x000000018422BF60-0x000000018422C140 
		public Button gotoButton { /* [XID] */ /* 0x000000018979CB20-0x000000018979CB40 */ get => default; } // 0x000000018422BC30-0x000000018422BE10 
		public bool showTipsGrp { /* [XID] */ /* 0x00000001897A3F80-0x00000001897A3FA0 */ set {} } // 0x000000018422C300-0x000000018422C400
		public bool showButtonGrp { /* [XID] */ /* 0x00000001897AB500-0x00000001897AB520 */ set {} } // 0x000000018422C1F0-0x000000018422C300
		public MonoNeedLabel scoinCostLabel { /* [XID] */ /* 0x00000001897B32F0-0x00000001897B3310 */ get => default; } // 0x000000018422BEB0-0x000000018422BF60 
		public MonoStarRate currStar { /* [XID] */ /* 0x00000001897CA210-0x00000001897CA230 */ get => default; } // 0x000000018422BAF0-0x000000018422BB90 
		public MonoStarRate postStar { /* [XID] */ /* 0x00000001897D18B0-0x00000001897D18D0 */ get => default; } // 0x000000018422BE10-0x000000018422BEB0 
		public List<PropertyChange> propertyChanges { /* [XID] */ /* 0x00000001897D96D0-0x00000001897D96F0 */ set {} } // 0x000000018422C140-0x000000018422C1F0
		public List<uint> unlockSkillGroupList { /* [XID] */ /* 0x00000001897E0A50-0x00000001897E0A70 */ set {} } // 0x000000018422C400-0x000000018422C4B0
	
		// Constructors
		public MonoAvatarStarUpDialog() {} // 0x000000018422B640-0x000000018422B730
	
		// Methods
		// [XID] // 0x00000001897BB210-0x00000001897BB230
		protected override void OnDestroy() {} // 0x000000018422AEF0-0x000000018422AFE0
		// [XID] // 0x00000001897C29F0-0x00000001897C2A10
		public void SetLevel(uint currLevel, uint currMaxLevel, uint postMaxLevel) {} // 0x000000018422AFE0-0x000000018422B180
		// [XID] // 0x00000001897E8110-0x00000001897E8130
		public void Setup(AvatarDataItem avatarData, AvatarPromoteExcelConfig currBreakConfig, AvatarPromoteExcelConfig postBreakConfig) {} // 0x000000018422B180-0x000000018422B640
		// [XID] // 0x00000001897EFDB0-0x00000001897EFDD0
		private void ShowPropertyChange() {} // 0x000000018422A2C0-0x000000018422A460
		// [XID] // 0x00000001897F75A0-0x00000001897F75C0
		private void RefreshPropertyItem(Transform trans, int index) {} // 0x000000018422A760-0x000000018422AB30
		// [XID] // 0x00000001897FECB0-0x00000001897FECD0
		private void OnItemSlotPrefabLoaded(ulong hash, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x000000018422A460-0x000000018422A580
		// [XID] // 0x00000001898063F0-0x0000000189806410
		private void ShowCostMaterial() {} // 0x000000018422AD40-0x000000018422AEF0
		// [XID] // 0x000000018980DA90-0x000000018980DAB0
		private void RefreshItemSlot(Transform trans, int index) {} // 0x000000018422AB30-0x000000018422AD40
		// [XID] // 0x0000000189815270-0x0000000189815290
		private void OnCostMaterialClicked(int index) {} // 0x000000018422A5E0-0x000000018422A760
	}
}
