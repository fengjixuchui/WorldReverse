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
	public class MonoItemSlot : MonoSpriteProxy, IPointerClickHandler // TypeDefIndex: 30416
	{
		// Fields
		private const string MINUS_BUTTON_PATH = "ART/UI/TemplateUI/Btn_Minus"; // Metadata: 0x00B10CFD
		private const string FETCH_HINT_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_FetchHint"; // Metadata: 0x00B10D1C
		private const string FOOD_QUALITY_BEST_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_DeliciousCooking"; // Metadata: 0x00B10D49
		private const string ITEM_SLOT_MASK_PATH = "ART/UI/Menus/Widget/BagItemSlot_Mask"; // Metadata: 0x00B10D7D
		private const string SUITICON_PATH = "ART/UI/Menus/Widget/BagItemSlot_RelicSuitIcon"; // Metadata: 0x00B10DA5
		private const string AVAILABLE_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_Available"; // Metadata: 0x00B10DD6
		private const string RECEIVED_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_HaveReceived"; // Metadata: 0x00B10E03
		private const string LOCK_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_Lock"; // Metadata: 0x00B10E33
		private const string FURNITURE_BLUEPRINT_ICON_NAME = "UI_Buff_Furniture_Blueprint"; // Metadata: 0x00B10E5B
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected Image _iconImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _txtItemNum; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionButton; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform _grpNum; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject[] _selectedImgs; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorBg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorIcon; // 0x58
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		private uint _currCount; // 0x60
		private StringBuilder _bottomTextBuilder; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _subQualityBg; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subQualityText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _subQualityRoot; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rankStarRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _newCornerMark; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _minusBtnRoot; // 0x98
		private Button _minusButton; // 0xA0
		private GameObject _fetchHint; // 0xA8
		private GameObject _foodBestImg; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _foodWorstMat; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _defaultMat; // 0xC0
		private MonoStarRate _rankStar; // 0xC8
		private GameObject _rankStarObj; // 0xD0
		private GameObject _itemMask; // 0xD8
		private IndexEvent _onClick; // 0xE0
		private MonoLongPressButton _longPress; // 0xE8
		private float _qualityType; // 0xF0
		private GameObject _suitIcon; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _suitIconTrans; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redPoint; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _availabelIconRoot; // 0x110
		private GameObject _availabelIcon; // 0x118
		private GameObject _receivedIcon; // 0x120
		private GameObject _lockIcon; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _tagRoot; // 0x130
		public GameObject tagChild; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _buffIcon; // 0x140
		protected int _index; // 0x148
		protected uint _itemID; // 0x14C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public uint userData; // 0x150
		private Action<int> _longPressHandler; // 0x158
		private Action<int> _clickHandler; // 0x160
		private uint _needCount; // 0x168
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x0000000189B44130-0x0000000189B44150 */ get => default; } // 0x000000018432C700-0x000000018432C7A0 
		public IndexEvent onClick { /* [XID] */ /* 0x0000000189B4B7E0-0x0000000189B4B800 */ get => default; } // 0x000000018432CBB0-0x000000018432CC60 
		public int index { /* [XID] */ /* 0x0000000189B52E90-0x0000000189B52EB0 */ set {} } // 0x000000018432D3E0-0x000000018432D490
		public uint itemID { /* [XID] */ /* 0x0000000189B5A860-0x0000000189B5A880 */ get => default; } // 0x000000018432CB10-0x000000018432CBB0 
		public uint currCount { /* [XID] */ /* 0x0000000189B61D10-0x0000000189B61D30 */ set {} } // 0x000000018432D190-0x000000018432D240
		public uint needCount { /* [XID] */ /* 0x0000000189BB3380-0x0000000189BB33A0 */ set {} } // 0x000000018432D490-0x000000018432D790
		public bool selected { /* [XID] */ /* 0x0000000189BC2960-0x0000000189BC2980 */ get => default; /* [XID] */ /* 0x0000000189BBA940-0x0000000189BBA960 */ set {} } // 0x000000018432CC60-0x000000018432CDF0 0x000000018432D790-0x000000018432D950
		public Button actionButton { /* [XID] */ /* 0x00000001895E5940-0x00000001895E5960 */ get => default; } // 0x000000018432C660-0x000000018432C700 
		public Sprite icon { /* [XID] */ /* 0x00000001895ED290-0x00000001895ED2B0 */ set {} } // 0x000000018432D320-0x000000018432D3E0
		public Color iconColor { /* [XID] */ /* 0x00000001895F4950-0x00000001895F4970 */ set {} } // 0x000000018432D240-0x000000018432D320
		public Color backgroundColor { /* [XID] */ /* 0x00000001895FC0C0-0x00000001895FC0E0 */ set {} } // 0x000000018432CEA0-0x000000018432CF80
		public Color cornerMarkColor { /* [XID] */ /* 0x0000000189603AC0-0x0000000189603AE0 */ set {} } // 0x000000018432CF80-0x000000018432D0C0
		public string countText { /* [XID] */ /* 0x000000018960B420-0x000000018960B440 */ set {} } // 0x000000018432D0C0-0x000000018432D190
		public bool showBottomText { /* [XID] */ /* 0x00000001896127D0-0x00000001896127F0 */ set {} } // 0x000000018432DAB0-0x000000018432DB90
		public GameObject fetchHint { /* [XID] */ /* 0x000000018961A140-0x000000018961A160 */ get => default; } // 0x000000018432C7A0-0x000000018432C950 
		public bool showMinusBtn { /* [XID] */ /* 0x0000000189621630-0x0000000189621650 */ set {} } // 0x000000018432DE60-0x000000018432DFF0
		public bool showMask { /* [XID] */ /* 0x0000000189628F60-0x0000000189628F80 */ set {} } // 0x000000018432DCE0-0x000000018432DE60
		public bool showSuitIcon { /* [XID] */ /* 0x00000001896308E0-0x0000000189630900 */ set {} } // 0x000000018432E330-0x000000018432E4B0
		public bool showAvailabelIcon { /* [XID] */ /* 0x00000001896383A0-0x00000001896383C0 */ set {} } // 0x000000018432D950-0x000000018432DAB0
		public bool showReceivedIcon { /* [XID] */ /* 0x000000018963F7C0-0x000000018963F7E0 */ set {} } // 0x000000018432E0F0-0x000000018432E240
		public bool showLockIcon { /* [XID] */ /* 0x0000000189646FC0-0x0000000189646FE0 */ set {} } // 0x000000018432DB90-0x000000018432DCE0
		public bool showRedPoint { /* [XID] */ /* 0x000000018964E730-0x000000018964E750 */ set {} } // 0x000000018432E240-0x000000018432E330
		public Button MinusBtn { /* [XID] */ /* 0x0000000189655F20-0x0000000189655F40 */ get => default; } // 0x000000018432C560-0x000000018432C660 
		public bool showNewCornerMark { /* [XID] */ /* 0x0000000189692960-0x0000000189692980 */ set {} } // 0x000000018432DFF0-0x000000018432E0F0
		public Transform tagRoot { /* [XID] */ /* 0x00000001896B73B0-0x00000001896B73D0 */ get => default; } // 0x000000018432CDF0-0x000000018432CEA0 
		public GameObject foodBestImg { /* [XID] */ /* 0x00000001896BE4E0-0x00000001896BE500 */ get => default; } // 0x000000018432C950-0x000000018432CB10 
	
		// Constructors
		public MonoItemSlot() {} // 0x000000018432C3E0-0x000000018432C560
	
		// Methods
		// [XID] // 0x0000000189B69920-0x0000000189B69940
		public void RegisterItemLongPressAndClickHandler(Action<int> longPressHandler, Action<int> clickHandler) {} // 0x000000018432AC40-0x000000018432AE70
		// [XID] // 0x0000000189B70F20-0x0000000189B70F40
		private void OnLongPress() {} // 0x000000018432A0D0-0x000000018432A190
		// [XID] // 0x0000000189B784F0-0x0000000189B78510
		private void OnLongPressClick() {} // 0x0000000184329140-0x0000000184329200
		// [XID] // 0x0000000189B7FA10-0x0000000189B7FA30
		public void UpdateBagSlot(BagItemSlot bagItemSlot) {} // 0x000000018432BD80-0x000000018432BE60
		// [XID] // 0x0000000189B874C0-0x0000000189B874E0
		public void UpdateIconByConfig(ItemConfig itemConfig, bool showStar = false /* Metadata: 0x00B10CF8 */) {} // 0x000000018432BE60-0x000000018432C270
		// [XID] // 0x0000000189B8E5F0-0x0000000189B8E610
		public void ClearNum() {} // 0x0000000184328E50-0x0000000184328F90
		// [XID] // 0x0000000189B95AD0-0x0000000189B95AF0
		public void ResetDefaultGiven(Sprite defaultIcon) {} // 0x000000018432AE70-0x000000018432B0E0
		// [XID] // 0x0000000189B9D070-0x0000000189B9D090
		public void Refresh(BagItem item, bool showWeaponCost = false /* Metadata: 0x00B10CF9 */, bool showStar = false /* Metadata: 0x00B10CFA */, bool showNumWhenEqualOne = true /* Metadata: 0x00B10CFB */) {} // 0x000000018432A420-0x000000018432AC40
		// [XID] // 0x0000000189BA49B0-0x0000000189BA49D0
		public void OnEnable() {} // 0x0000000184329ED0-0x000000018432A000
		// [XID] // 0x0000000189BABCD0-0x0000000189BABCF0
		public void SetItemCountDesc(string countDesc) {} // 0x000000018432B7E0-0x000000018432B900
		// [XID] // 0x0000000189BCA100-0x0000000189BCA120
		public void UpdateBagSlotSelect(bool enable) {} // 0x000000018432BBC0-0x000000018432BD80
		// [XID] // 0x0000000189BD1790-0x0000000189BD17B0
		protected void Clear() {} // 0x0000000184329260-0x0000000184329460
		// [XID] // 0x0000000189BD8D60-0x0000000189BD8D80
		protected override void OnDestroy() {} // 0x0000000184329880-0x0000000184329ED0
		// [XID] // 0x000000018965D700-0x000000018965D720
		private Button InstantiateMinusBtn() => default; // 0x0000000184329460-0x00000001843295D0
		// [XID] // 0x0000000189664E00-0x0000000189664E20
		private GameObject InstantiateMask() => default; // 0x00000001843295D0-0x0000000184329730
		// [XID] // 0x000000018966C420-0x000000018966C440
		private GameObject InstantiateSuitIcon() => default; // 0x0000000184329730-0x0000000184329880
		// [XID] // 0x00000001896742E0-0x0000000189674300
		private GameObject InstantiatePrefab(string path, Transform root = null) => default; // 0x0000000184328F90-0x0000000184329140
		// [XID] // 0x000000018967BAC0-0x000000018967BAE0
		public void SetAppendPropNum(uint propNum, bool active = true /* Metadata: 0x00B10CFC */) {} // 0x000000018432B280-0x000000018432B3E0
		// [XID] // 0x00000001896831D0-0x00000001896831F0
		public void ShowStar(int value) {} // 0x000000018432B900-0x000000018432BBC0
		// [XID] // 0x000000018968AC60-0x000000018968AC80
		public void SetBuffIcon(MaterialExcelConfig config) {} // 0x000000018432B3E0-0x000000018432B580
		// [XID] // 0x0000000189699CE0-0x0000000189699D00
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018432A000-0x000000018432A0D0
		// [XID] // 0x00000001896A1400-0x00000001896A1420
		public void SetAddStyle() {} // 0x000000018432B0E0-0x000000018432B280
		// [XID] // 0x00000001896A8870-0x00000001896A8890
		public void RefreshCookRecipe(CookRecipeExcelConfig recipeConfig) {} // 0x000000018432A190-0x000000018432A420
		// [XID] // 0x00000001896AFA40-0x00000001896AFA60
		public void UpdateSimpleIconByConfig(ItemConfig itemConfig) {} // 0x000000018432C270-0x000000018432C3E0
		// [XID] // 0x00000001896C5D10-0x00000001896C5D30
		public void SetFoodQualityIcon(FoodQualityType type) {} // 0x000000018432B580-0x000000018432B7E0
	}
}
