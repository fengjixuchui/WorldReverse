/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBagProxySlot : MonoSpriteProxy, IPointerClickHandler // TypeDefIndex: 30405
	{
		// Fields
		private const string MINUS_BUTTON_PATH = "ART/UI/TemplateUI/Btn_Minus"; // Metadata: 0x00B10B16
		private const string COUNT_DOWN_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_CountDown"; // Metadata: 0x00B10B35
		private const string FETCH_HINT_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_FetchHint"; // Metadata: 0x00B10B62
		private const string FOOD_QUALITY_BEST_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_DeliciousCooking"; // Metadata: 0x00B10B8F
		private const string EXTRA_BONUS_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_ExtraBonus"; // Metadata: 0x00B10BC3
		private const string ITEM_SLOT_MASK_PATH = "ART/UI/Menus/Widget/BagItemSlot_Mask"; // Metadata: 0x00B10BF1
		private const string QUICK_USE_BUFF_ICON_PATH = "ART/UI/Menus/Widget/BagItemSlot_QU_Buff"; // Metadata: 0x00B10C19
		private const string SUITICON_PATH = "ART/UI/Menus/Widget/BagItemSlot_RelicSuitIcon"; // Metadata: 0x00B10C44
		private const string REMAINING_TIME_PATH = "ART/UI/Menus/Widget/BagItemSlot_RemainingTime"; // Metadata: 0x00B10C75
		private const string FURNITURE_BLUEPRINT_ICON_NAME = "UI_Buff_Furniture_Blueprint"; // Metadata: 0x00B10CA6
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected Image _iconImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemName; // 0x38
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform _grpNum; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject[] _selectedImgs; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorBg; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorIcon; // 0x60
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _cdFillImg; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cdText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _markedGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _markIcon; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _markNum; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costText; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _quickUseBuffIconRoot; // 0x98
		private MonoBagProxyQuickUseBuffSlot _quickUseBuff; // 0xA0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _equippedLabel; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _avatarImage; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockedIconRoot; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _hintTextGrp; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintTextLabel; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _hintTextColor; // 0xD0
		private uint _currCount; // 0xD8
		private StringBuilder _bottomTextBuilder; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _subQualityBg; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subQualityText; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _subQualityRoot; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rankStarRoot; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _newCornerMark; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _popCornerMark; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cornerIcon; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _minusBtnRoot; // 0x120
		private Button _minusButton; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _countDownRoot; // 0x130
		private MonoItemCountDown _countDown; // 0x138
		private GameObject _fetchHint; // 0x140
		private GameObject _foodBestImg; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _foodWorstMat; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _defaultMat; // 0x158
		protected Action<int> _bagSlotClickHandler; // 0x160
		protected Action<int> _bagSlotLongPressHandler; // 0x168
		private MonoStarRate _rankStar; // 0x170
		private GameObject _rankStarObj; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _buffIcon; // 0x180
		public bool showBuffIcon; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _nameCardLock; // 0x190
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _itemMaskRoot; // 0x198
		private GameObject _itemMask; // 0x1A0
		private MonoLongPressButton _longPress; // 0x1A8
		private GameObject _suitIcon; // 0x1B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _suitIconTrans; // 0x1B8
		private MonoRemainingTimeSlot _remainingTime; // 0x1C0
		protected int _index; // 0x1D0
		protected uint _itemID; // 0x1D4
		private float _qualityType; // 0x1D8
		private bool _hightlighted; // 0x1DC
		private GameObject _extraBonusRoot; // 0x1E0
	
		// Properties
		public bool showEquippedLabel { /* [XID] */ /* 0x0000000189A79C60-0x0000000189A79C80 */ get => default; /* [XID] */ /* 0x0000000189A72000-0x0000000189A72020 */ set {} } // 0x00000001848EE1B0-0x00000001848EE280 0x00000001848EF8F0-0x00000001848EFA20
		public BagItem bagItem { /* [XID] */ /* 0x0000000189A810E0-0x0000000189A81120 */ get; /* [XID] */ /* 0x0000000189A8BC10-0x0000000189A8BC50 */ private set; } // 0x00000001848ED6E0-0x00000001848ED740 0x00000001848E7BA0-0x00000001848E7C10
		public Image avatarImage { /* [XID] */ /* 0x0000000189A961D0-0x0000000189A961F0 */ get => default; } // 0x00000001848ED630-0x00000001848ED6E0 
		public RectTransform lockedIconRoot { /* [XID] */ /* 0x0000000189A9D720-0x0000000189A9D740 */ get => default; } // 0x00000001848EDF70-0x00000001848EE020 
		public int index { /* [XID] */ /* 0x0000000189AB3FD0-0x0000000189AB3FF0 */ set {} } // 0x00000001848EED70-0x00000001848EEE20
		public uint itemID { /* [XID] */ /* 0x0000000189ABBD30-0x0000000189ABBD50 */ get => default; } // 0x00000001848EDED0-0x00000001848EDF70 
		public uint currCount { /* [XID] */ /* 0x0000000189AC3500-0x0000000189AC3520 */ set {} } // 0x00000001848EE8B0-0x00000001848EE960
		public uint needCount { /* [XID] */ /* 0x0000000189AE9140-0x0000000189AE9160 */ set {} } // 0x00000001848EEF10-0x00000001848EF210
		public bool selected { /* [XID] */ /* 0x0000000189AF8390-0x0000000189AF83B0 */ get => default; /* [XID] */ /* 0x0000000189AF0F10-0x0000000189AF0F30 */ set {} } // 0x00000001848EE020-0x00000001848EE1B0 0x00000001848EF210-0x00000001848EF3D0
		public bool highlight { /* [XID] */ /* 0x0000000189AFFAA0-0x0000000189AFFAC0 */ get => default; /* [XID] */ /* 0x0000000189B07010-0x0000000189B07030 */ set {} } // 0x00000001848EDE20-0x00000001848EDED0 0x00000001848EE960-0x00000001848EEB00
		public Button actionButton { /* [XID] */ /* 0x0000000189B3AF10-0x0000000189B3AF30 */ get => default; } // 0x00000001848ED590-0x00000001848ED630 
		public bool showCDGroup { /* [XID] */ /* 0x0000000189B42690-0x0000000189B426B0 */ set {} } // 0x00000001848EF4D0-0x00000001848EF5D0
		public string cdText { /* [XID] */ /* 0x0000000189B4A1D0-0x0000000189B4A1F0 */ set {} } // 0x00000001848EE500-0x00000001848EE5D0
		public float cdFillAmount { /* [XID] */ /* 0x0000000189B519D0-0x0000000189B519F0 */ set {} } // 0x00000001848EE440-0x00000001848EE500
		public Sprite icon { /* [XID] */ /* 0x0000000189B59190-0x0000000189B591B0 */ set {} } // 0x00000001848EECB0-0x00000001848EED70
		public Color iconColor { /* [XID] */ /* 0x0000000189B753D0-0x0000000189B753F0 */ set {} } // 0x00000001848EEBD0-0x00000001848EECB0
		public Color backgroundColor { /* [XID] */ /* 0x0000000189B7C820-0x0000000189B7C840 */ set {} } // 0x00000001848EE360-0x00000001848EE440
		public Color cornerMarkColor { /* [XID] */ /* 0x0000000189B84660-0x0000000189B84680 */ set {} } // 0x00000001848EE5D0-0x00000001848EE710
		public string countText { /* [XID] */ /* 0x0000000189B8B4F0-0x0000000189B8B510 */ set {} } // 0x00000001848EE7E0-0x00000001848EE8B0
		public bool showHintText { /* [XID] */ /* 0x0000000189B92C20-0x0000000189B92C40 */ set {} } // 0x00000001848EFA20-0x00000001848EFB20
		public string hintText { /* [XID] */ /* 0x0000000189B9A200-0x0000000189B9A220 */ set {} } // 0x00000001848EEB00-0x00000001848EEBD0
		public bool showBottomText { /* [XID] */ /* 0x0000000189BA8D10-0x0000000189BA8D30 */ set {} } // 0x00000001848EF3D0-0x00000001848EF4D0
		public string costText { /* [XID] */ /* 0x0000000189BB0460-0x0000000189BB0480 */ set {} } // 0x00000001848EE710-0x00000001848EE7E0
		public bool showCost { /* [XID] */ /* 0x0000000189BB78A0-0x0000000189BB78C0 */ set {} } // 0x00000001848EF7C0-0x00000001848EF8F0
		public MonoItemCountDown countDown { /* [XID] */ /* 0x0000000189BBEEE0-0x0000000189BBEF00 */ get => default; } // 0x00000001848ED740-0x00000001848ED900 
		public GameObject fetchHint { /* [XID] */ /* 0x0000000189BC6B90-0x0000000189BC6BB0 */ get => default; } // 0x00000001848EDAB0-0x00000001848EDC60 
		public bool showMask { /* [XID] */ /* 0x0000000189BCE860-0x0000000189BCE880 */ set {} } // 0x00000001848EFD80-0x00000001848EFF00
		public bool showMaskLockIcon { /* [XID] */ /* 0x0000000189BD5AE0-0x0000000189BD5B00 */ set {} } // 0x00000001848EFB20-0x00000001848EFD80
		public bool showMinusBtn { /* [XID] */ /* 0x0000000189BDD7D0-0x0000000189BDD7F0 */ set {} } // 0x00000001848EFF00-0x00000001848F0040
		public Button MinusBtn { /* [XID] */ /* 0x00000001895EA330-0x00000001895EA350 */ get => default; } // 0x00000001848ED490-0x00000001848ED590 
		public bool showNewCornerMark { /* [XID] */ /* 0x000000018961E960-0x000000018961E980 */ set {} } // 0x00000001848F0040-0x00000001848F01D0
		public bool showPopCornerMark { /* [XID] */ /* 0x0000000189625D80-0x0000000189625DA0 */ set {} } // 0x00000001848F01D0-0x00000001848F0370
		public bool showCornerIcon { /* [XID] */ /* 0x000000018962D6A0-0x000000018962D6C0 */ set {} } // 0x00000001848EF5D0-0x00000001848EF7C0
		public GameObject foodBestImg { /* [XID] */ /* 0x0000000189697230-0x0000000189697250 */ get => default; } // 0x00000001848EDC60-0x00000001848EDE20 
		public GameObject extraBonusRoot { /* [XID] */ /* 0x00000001896A57D0-0x00000001896A57F0 */ get => default; } // 0x00000001848ED900-0x00000001848EDAB0 
		public bool nameCardLocked { /* [XID] */ /* 0x00000001896C2CE0-0x00000001896C2D00 */ set {} } // 0x00000001848EEE20-0x00000001848EEF10
		public bool ShowRemainingTime { /* [XID] */ /* 0x00000001896E7BB0-0x00000001896E7BD0 */ set {} } // 0x00000001848EE280-0x00000001848EE360
		public bool showSuitIcon { /* [XID] */ /* 0x00000001896EF270-0x00000001896EF290 */ set {} } // 0x00000001848F0370-0x00000001848F04F0
	
		// Constructors
		public MonoBagProxySlot() {} // 0x00000001848ED2B0-0x00000001848ED490
	
		// Methods
		// [XID] // 0x0000000189AA4FD0-0x0000000189AA4FF0
		public void RegisterBagSlotClickHandler(Action<int> handler) {} // 0x00000001848EAA60-0x00000001848EAB10
		// [XID] // 0x0000000189AAC790-0x0000000189AAC7B0
		public void RegisterBagSlotLongPressHandler(Action<int> handler) {} // 0x00000001848EAB10-0x00000001848EAD30
		// [XID] // 0x0000000189ACABD0-0x0000000189ACABF0
		public void UpdateBagSlot(BagItemSlot bagItemSlot, bool showNumEqualOne = true /* Metadata: 0x00B10B08 */) {} // 0x00000001848ECA20-0x00000001848ECB10
		// [XID] // 0x0000000189AD2600-0x0000000189AD2620
		public void UpdateIconByConfig(ItemConfig itemConfig, bool showStar = false /* Metadata: 0x00B10B09 */, bool loadIcon = true /* Metadata: 0x00B10B0A */, bool setFoodQuality = true /* Metadata: 0x00B10B0B */, bool asyncLoadIcon = true /* Metadata: 0x00B10B0C */) {} // 0x00000001848ECB10-0x00000001848ECED0
		// [XID] // 0x0000000189ADA090-0x0000000189ADA0B0
		public void Refresh(BagItem item, bool showWeaponCost = false /* Metadata: 0x00B10B0D */, bool showStar = false /* Metadata: 0x00B10B0E */, bool showNumWhenEqualOne = true /* Metadata: 0x00B10B0F */) {} // 0x00000001848E9E60-0x00000001848EAA60
		// [XID] // 0x0000000189AE1990-0x0000000189AE19B0
		public void OnEnable() {} // 0x00000001848E90B0-0x00000001848E91E0
		// [XID] // 0x0000000189B0E850-0x0000000189B0E870
		public void UpdateBagSlotSelect(bool enable) {} // 0x00000001848EC860-0x00000001848ECA20
		// [XID] // 0x0000000189B15C40-0x0000000189B15C60
		public void UpdateAvatarIcon(BagItem item) {} // 0x00000001848EC700-0x00000001848EC860
		// [XID] // 0x0000000189B1D350-0x0000000189B1D370
		public void UpdateNoticeCorner(bool doShowNewCornerMark) {} // 0x00000001848ECED0-0x00000001848ED140
		// [XID] // 0x0000000189B24BD0-0x0000000189B24BF0
		private void SetAvatarIconOfItem(Image avatarIcon, BagItem item) {} // 0x00000001848E8340-0x00000001848E8570
		// [XID] // 0x0000000189B2C060-0x0000000189B2C080
		protected void Clear() {} // 0x00000001848E7C10-0x00000001848E7E30
		// [XID] // 0x0000000189B33610-0x0000000189B33630
		protected override void OnDestroy() {} // 0x00000001848E89C0-0x00000001848E90B0
		// [IDTag] // 0x0000000189B609C0-0x0000000189B60A00
		// [XID] // 0x0000000189B609C0-0x0000000189B60A00
		public void SetIconAsync(ItemConfig config) {} // 0x00000001848EB800-0x00000001848EB8C0
		// [IDTag] // 0x0000000189B6B0C0-0x0000000189B6B100
		// [XID] // 0x0000000189B6B0C0-0x0000000189B6B100
		public void SetIconAsync(string icon) {} // 0x00000001848EB8C0-0x00000001848EB980
		// [XID] // 0x0000000189BA18F0-0x0000000189BA1910
		public void ShowDeleteHintText() {} // 0x00000001848EC330-0x00000001848EC4A0
		// [XID] // 0x00000001895F17D0-0x00000001895F17F0
		private Button InstantiateMinusBtn() => default; // 0x00000001848E7EB0-0x00000001848E8060
		// [XID] // 0x00000001895F9270-0x00000001895F9290
		private MonoBagProxyQuickUseBuffSlot InstantiateQuickUseBuffIcon() => default; // 0x00000001848E8570-0x00000001848E8720
		// [XID] // 0x00000001896008A0-0x00000001896008C0
		private MonoRemainingTimeSlot InstantiateRemaingTime() => default; // 0x00000001848E7770-0x00000001848E7920
		// [XID] // 0x00000001896081C0-0x00000001896081E0
		private GameObject InstantiateMask() => default; // 0x00000001848E8720-0x00000001848E8870
		// [XID] // 0x000000018960FB60-0x000000018960FB80
		public void SetAppendPropNum(uint propNum, bool active = true /* Metadata: 0x00B10B10 */) {} // 0x00000001848EAE80-0x00000001848EAFE0
		// [XID] // 0x0000000189616E00-0x0000000189616E20
		public void ShowStar(int value) {} // 0x00000001848EC4A0-0x00000001848EC700
		// [XID] // 0x0000000189635260-0x0000000189635280
		public void SetCornerIcon(uint materialId) {} // 0x00000001848EB200-0x00000001848EB310
		// [XID] // 0x000000018963C900-0x000000018963C920
		public void SetSelectedMarkActive(bool active, int num = -1 /* Metadata: 0x00B10B11 */) {} // 0x00000001848EC100-0x00000001848EC330
		// [XID] // 0x0000000189643FE0-0x0000000189644000
		public void OnPointerClick(PointerEventData eventData) {} // 0x00000001848E91E0-0x00000001848E92E0
		// [XID] // 0x000000018964B790-0x000000018964B7B0
		private void OnLongPress() {} // 0x00000001848E92E0-0x00000001848E93A0
		// [XID] // 0x0000000189652F00-0x0000000189652F20
		private void OnLongPressClick() {} // 0x00000001848E7A80-0x00000001848E7B40
		// [XID] // 0x000000018965A5E0-0x000000018965A600
		public void SetAddStyle() {} // 0x00000001848EAD30-0x00000001848EAE80
		// [XID] // 0x0000000189661C30-0x0000000189661C50
		private void TrySetlockedIconRootActive(bool active) {} // 0x00000001848E7920-0x00000001848E7A80
		// [XID] // 0x00000001896697F0-0x0000000189669810
		public void RefreshCookRecipe(CookRecipeExcelConfig recipeConfig) {} // 0x00000001848E9A80-0x00000001848E9E60
		// [XID] // 0x00000001896712E0-0x0000000189671300
		public void SetBuffIcon(MaterialExcelConfig config) {} // 0x00000001848EAFE0-0x00000001848EB200
		// [XID] // 0x0000000189678BA0-0x0000000189678BC0
		public void SetDeleteIcon() {} // 0x00000001848EB310-0x00000001848EB420
		// [XID] // 0x00000001896801E0-0x0000000189680200
		public void RefreshCompoundItem(CompoundExcelConfig compoundConfig, CompoundItemData compoundData) {} // 0x00000001848E9420-0x00000001848E9A80
		// [XID] // 0x0000000189687DF0-0x0000000189687E10
		public void UpdateSimpleIconByConfig(ItemConfig itemConfig) {} // 0x00000001848ED140-0x00000001848ED2B0
		// [XID] // 0x000000018968F7F0-0x000000018968F810
		public void SetRankStyle(uint rank) {} // 0x00000001848EBDE0-0x00000001848EBFC0
		// [XID] // 0x000000018969E760-0x000000018969E780
		public void SetFoodQualityIcon(FoodQualityType type) {} // 0x00000001848EB5A0-0x00000001848EB800
		// [XID] // 0x00000001896ACFF0-0x00000001896AD010
		public void SetExtraBonusActive(bool active) {} // 0x00000001848EB420-0x00000001848EB5A0
		// [XID] // 0x00000001896B4660-0x00000001896B4680
		public void SetItemCountDesc(string countDesc, bool withEllipsis = false /* Metadata: 0x00B10B15 */) {} // 0x00000001848EB980-0x00000001848EBB00
		// [XID] // 0x00000001896BB890-0x00000001896BB8B0
		public void SetItemName(string name) {} // 0x00000001848EBB00-0x00000001848EBC60
		// [XID] // 0x00000001896CA200-0x00000001896CA220
		public bool IsMarkedWithNum() => default; // 0x00000001848E80E0-0x00000001848E8210
		// [XID] // 0x00000001896D18D0-0x00000001896D18F0
		public bool IsMarkedWithoutNum() => default; // 0x00000001848E8210-0x00000001848E8340
		// [XID] // 0x00000001896D90D0-0x00000001896D90F0
		public void SetQuickUseBuff(string hpIcon, string reviveIcon) {} // 0x00000001848EBC60-0x00000001848EBDE0
		// [XID] // 0x00000001896E0930-0x00000001896E0950
		public void SetRemaingTime(string str) {} // 0x00000001848EBFC0-0x00000001848EC100
		// [XID] // 0x00000001896F6C60-0x00000001896F6C80
		private GameObject InstantiateSuitIcon() => default; // 0x00000001848E8870-0x00000001848E89C0
	}
}
