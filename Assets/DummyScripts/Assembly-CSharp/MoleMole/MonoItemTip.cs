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
	public class MonoItemTip : MonoSpriteProxy // TypeDefIndex: 30418
	{
		// Fields
		private const string FOOD_QUALITY_BEST_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_DeliciousCooking"; // Metadata: 0x00B10E84
		private const string SUIT_LIST = "ART/UI/Menus/Widget/ItemTips_SuitList"; // Metadata: 0x00B10EB8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected Animator _animator; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _content; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _imgBg; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoModelRenderImage _modelImage; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _imgIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemName; // 0x48
		public GameObject goTxtRelic; // 0x50
		public UnityEngine.UI.Text txtRelic; // 0x58
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _costGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtItemType; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRate; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform _levelGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _levelLabel; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _basePropertyGroup; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _basePropertyName; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _basePropertyValue; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGroup[] _baseProperties; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected LabelGroup[] _txtAffix; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected LabelGroup _goldAffix; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtStory; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _setName; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text[] _setDesc; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _setDescGO; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _setRoot; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _subQualityBg; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subQualityText; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _subQualityRoot; // 0x108
		public UnityEngine.UI.Text LevelForRelic; // 0x110
		public GameObject StarAndLevel; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoStarRate _rankStar; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _rankName; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelAndStarRoot; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needLevelText; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _needLevelBg; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _needLevelRoot; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _limitedTimeText; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _limitedTimeRoot; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _highlightTipText; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _highlightTipRoot; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image _buffIcon; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _awakenLevelText; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _groupSourceList; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _sourceDescColor; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _targetDescColor; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _suitListRoot; // 0x198
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _sourceTitleKey; // 0x1A0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected MonoSimpleReusableList _quickUsePropList; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _lockContainer; // 0x1B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockBtn; // 0x1B8
		private LayoutGroup _layoutGroup; // 0x1C0
		private RectTransform _layoutRectTrans; // 0x1C8
		protected float _qualityType; // 0x1D0
		private GameObject _suitList; // 0x1D8
		private GameObject _foodBestImg; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _foodWorstMat; // 0x1E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _defaultMat; // 0x1F0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _nameCardPic; // 0x1F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _nameCardBgCanvas; // 0x200
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _nameCardTitleColor; // 0x208
	
		// Properties
		public MonoSimpleReusableList groupSourceList { /* [XID] */ /* 0x00000001898663F0-0x0000000189866410 */ get => default; } // 0x0000000184335650-0x0000000184335700 
		public MonoSimpleReusableList quickUsePropList { /* [XID] */ /* 0x000000018986DD20-0x000000018986DD40 */ get => default; } // 0x0000000184335800-0x00000001843358B0 
		public Toggle lockToggle { /* [XID] */ /* 0x00000001898750C0-0x00000001898750E0 */ get => default; } // 0x0000000184335700-0x0000000184335800 
		public bool showLockBtn { /* [XID] */ /* 0x000000018987CD30-0x000000018987CD50 */ set {} } // 0x0000000184335D40-0x0000000184335E30
		public bool showSourceTitleImg { /* [XID] */ /* 0x00000001898D5B90-0x00000001898D5BB0 */ set {} } // 0x0000000184335E30-0x0000000184336000
		public bool showCostGrp { /* [XID] */ /* 0x00000001898DD860-0x00000001898DD880 */ set {} } // 0x0000000184335C40-0x0000000184335D40
		public uint cost { /* [XID] */ /* 0x00000001898E5090-0x00000001898E50B0 */ set {} } // 0x0000000184335A60-0x0000000184335B30
		private int breakLevel { /* [XID] */ /* 0x0000000189937920-0x0000000189937940 */ set {} } // 0x0000000184331EA0-0x0000000184332020
		public bool showBackground { /* [XID] */ /* 0x000000018995D200-0x000000018995D220 */ set {} } // 0x0000000184335B30-0x0000000184335C40
		public GameObject suitList { /* [XID] */ /* 0x000000018998A350-0x000000018998A370 */ get => default; } // 0x00000001843358B0-0x0000000184335A60 
		public GameObject foodBestImg { /* [XID] */ /* 0x0000000189999950-0x0000000189999970 */ get => default; } // 0x0000000184335490-0x0000000184335650 
	
		// Constructors
		public MonoItemTip() {} // 0x00000001843352D0-0x0000000184335490
	
		// Methods
		// [XID] // 0x0000000189883CD0-0x0000000189883CF0
		protected void Awake() {} // 0x000000018432E9F0-0x000000018432EB20
		// [XID] // 0x000000018988B370-0x000000018988B390
		private void Start() {} // 0x0000000184334F70-0x0000000184335010
		// [XID] // 0x0000000189892AB0-0x0000000189892AD0
		private void OnDisable() {} // 0x0000000184332450-0x0000000184332540
		// [XID] // 0x000000018989A130-0x000000018989A150
		protected override void OnDestroy() {} // 0x0000000184332250-0x0000000184332450
		// [XID] // 0x00000001898A13F0-0x00000001898A1410
		public void UpdateLayout() {} // 0x00000001843351C0-0x00000001843352D0
		// [XID] // 0x00000001898A8C60-0x00000001898A8C80
		public void UpdateByItemSlot(BagItemSlot bagItemSlot) {} // 0x00000001843350E0-0x00000001843351C0
		// [XID] // 0x00000001898B05E0-0x00000001898B0600
		public void UpdateByItemInfo(BagItem bagItem, bool showSuitNum = false /* Metadata: 0x00B10E7A */) {} // 0x0000000184335010-0x00000001843350E0
		// [XID] // 0x00000001898B7BD0-0x00000001898B7BF0
		public void Refresh(BagItem bagItem, bool showSuitNum = false /* Metadata: 0x00B10E7B */) {} // 0x00000001843337F0-0x00000001843341B0
		// [XID] // 0x00000001898BF1A0-0x00000001898BF1C0
		private void RefreshLock(BagItem bagItem) {} // 0x0000000184331890-0x0000000184331C30
		// [XID] // 0x00000001898C6B40-0x00000001898C6B60
		public void HideLock() {} // 0x000000018432FC50-0x000000018432FDB0
		// [XID] // 0x00000001898CE120-0x00000001898CE140
		public static void RequestChangeLockState(ulong itemGuid, bool isLock) {} // 0x00000001843341B0-0x0000000184334510
		// [XID] // 0x00000001898EC900-0x00000001898EC920
		private void RefreshDisplayItem(DisplayItem displayItem) {} // 0x000000018432FDB0-0x00000001843304D0
		// [XID] // 0x00000001898F4310-0x00000001898F4330
		private void RefreshEquip(ReliquaryItem equipItem, bool showSuitNum = false /* Metadata: 0x00B10E7C */) {} // 0x0000000184330730-0x0000000184331730
		// [XID] // 0x00000001898FBAE0-0x00000001898FBB00
		private uint GetEquippedItemCountHasSameSetId(uint setId) => default; // 0x00000001843335C0-0x00000001843337F0
		// [XID] // 0x00000001899034D0-0x00000001899034F0
		private int GetNewRelicSetLevel(ReliquaryItem newRelic) => default; // 0x0000000184332020-0x0000000184332250
		// [XID] // 0x000000018990AA20-0x000000018990AA40
		private void RefreshWeapon(WeaponItem itemData) {} // 0x0000000184332670-0x00000001843333F0
		// [XID] // 0x00000001899126B0-0x00000001899126D0
		private void RefreshFurniture(FurnitureItem itemData) {} // 0x000000018432E4B0-0x000000018432E6B0
		// [XID] // 0x0000000189919F80-0x0000000189919FA0
		public void OnEnable() {} // 0x0000000184332540-0x0000000184332670
		// [XID] // 0x00000001899217C0-0x00000001899217E0
		private void RefreshNormalItem(BagItem itemData) {} // 0x000000018432ECF0-0x000000018432F0D0
		// [XID] // 0x0000000189928EC0-0x0000000189928EE0
		private void RefreshCookItem(MaterialExcelConfig materialConfig) {} // 0x00000001843333F0-0x00000001843335C0
		// [XID] // 0x0000000189930450-0x0000000189930470
		private void RefreshWidgetItem(BagItem bagItem) {} // 0x000000018432E6B0-0x000000018432E9F0
		// [XID] // 0x000000018993F410-0x000000018993F430
		private void SetLevelText(int currLevel, int maxLevel = -1 /* Metadata: 0x00B10E7D */, bool isRelic = false /* Metadata: 0x00B10E81 */) {} // 0x000000018432F4D0-0x000000018432F860
		// [XID] // 0x0000000189946A00-0x0000000189946A20
		private void Clear() {} // 0x000000018432F860-0x000000018432FC50
		// [XID] // 0x000000018994E0A0-0x000000018994E0C0
		private void SetAppendPropNum(uint propNum, bool active = true /* Metadata: 0x00B10E82 */) {} // 0x0000000184331730-0x0000000184331890
		// [XID] // 0x00000001899556E0-0x0000000189955700
		protected void SetRankLevelName(uint rankLevel) {} // 0x000000018432EB20-0x000000018432ECF0
		// [XID] // 0x0000000189964880-0x00000001899648A0
		public void SetUseLevel(uint useLevel, bool isEquip = false /* Metadata: 0x00B10E83 */) {} // 0x00000001843348D0-0x0000000184334C20
		// [XID] // 0x000000018996BF30-0x000000018996BF50
		public void SetDeleteDesc(string desc) {} // 0x00000001843347B0-0x00000001843348D0
		// [XID] // 0x0000000189973A20-0x0000000189973A40
		public void ShowDeleteDesc(bool show) {} // 0x0000000184334C20-0x0000000184334D10
		// [XID] // 0x000000018997B050-0x000000018997B070
		public void SetChooseOne(List<uint> groupItemID) {} // 0x0000000184334510-0x00000001843347B0
		// [XID] // 0x0000000189982B80-0x0000000189982BA0
		public void ShowHightlightTip(bool show) {} // 0x0000000184334D10-0x0000000184334E00
		// [XID] // 0x0000000189991C20-0x0000000189991C40
		public void ShowSuitList(bool show) {} // 0x0000000184334E00-0x0000000184334F70
		// [XID] // 0x00000001899A1020-0x00000001899A1040
		private void SetFoodQualityIcon(FoodQualityType type) {} // 0x00000001843304D0-0x0000000184330730
		// [XID] // 0x00000001899A8B30-0x00000001899A8B50
		private void RefreshNameCardItem(MaterialExcelConfig materialConfig) {} // 0x000000018432F0D0-0x000000018432F3A0
		// [XID] // 0x00000001899B0430-0x00000001899B0450
		private void ResetNameCard() {} // 0x0000000184331C30-0x0000000184331EA0
	}
}
