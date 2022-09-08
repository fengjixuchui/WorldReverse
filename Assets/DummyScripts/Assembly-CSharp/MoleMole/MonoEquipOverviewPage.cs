/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoEquipOverviewPage : MonoUIProxy // TypeDefIndex: 31000
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _showStarUpBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _showLevelUpBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _showItemTipBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _showAwakenBtn; // 0x58
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoLocalizedText _equipTypeLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _equipNameLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _pageIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _equipedAvatar; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private ScrollRect _itemTipsContainer; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _starUpContainer; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _levelUpContainer; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _awakenContainer; // 0x98
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _menuTabGroup; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _starUpTip; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _starUpTipText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoEquipSelect _equipSelect; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCostLabel _costLabel; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _helpBtn; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _backButton; // 0xD8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform[] _gripItemTipsGroup; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button[] _itemTipsBtnBackGroup; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _itemTipsAnimator; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _itemTipsFadeOutTime; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _strengthenItemTipContainer; // 0x100
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _selectPanleCancelBtn; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _selectPanleSelectBtn; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _selectPanleBackBtn; // 0x118
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private ScrollRect _itemTipsScrollRect; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _detailSelect; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _panelDetailSelect; // 0x130
		private MonoItemTip _itemTips; // 0x138
		private MonoItemTip _strengthenItemTip; // 0x140
		private MonoEquipStarUp _starUp; // 0x148
		private MonoEquipLevelUp _levelUp; // 0x150
		private MonoEquipAwaken _awaken; // 0x158
		public GameObject RestrictionTips; // 0x160
		public UnityEngine.UI.Text RestrictionText; // 0x168
		private const string SHOP_MATERIAL_ITEM_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B11C15
		private GameObject _sCoinLabel; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x178
		private const string ITEMTIPS_PREFAB_PATH = "ART/UI/Menus/Widget/ItemTips"; // Metadata: 0x00B11C3E
		private const string STARUP_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipStarUp"; // Metadata: 0x00B11C5E
		private const string LEVELUP_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipLevelUp"; // Metadata: 0x00B11C8F
		private const string AWAKEN_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipAwaken"; // Metadata: 0x00B11CC1
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _activityTipsTrans; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _activityTips; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tipsBarContainer; // 0x190
		private const string TIPS_PREFAB_PATH = "ART/UI/Menus/Widget/Activity/ActivityTips_TopBar"; // Metadata: 0x00B11CF2
		private MonoEquipTipsBar _tipsBar; // 0x198
	
		// Properties
		public RectTransform[] gripItemTipsGroup { /* [XID] */ /* 0x0000000189946920-0x0000000189946940 */ get => default; } // 0x0000000183CAD7B0-0x0000000183CAD860 
		public Button[] itemTipsBtnBackGroup { /* [XID] */ /* 0x000000018994DFC0-0x000000018994DFE0 */ get => default; } // 0x0000000183CADA90-0x0000000183CADB40 
		public Animator itemTipsAnimator { /* [XID] */ /* 0x0000000189955640-0x0000000189955660 */ get => default; } // 0x0000000183CAD9E0-0x0000000183CADA90 
		public float itemTipsFadeOutTime { /* [XID] */ /* 0x000000018995D120-0x000000018995D140 */ get => default; } // 0x0000000183CADBF0-0x0000000183CADCA0 
		public Button backButton { /* [XID] */ /* 0x00000001899647C0-0x00000001899647E0 */ get => default; } // 0x0000000183CAD000-0x0000000183CAD0C0 
		public Button showStarUpButton { /* [XID] */ /* 0x000000018996BE90-0x000000018996BEB0 */ get => default; } // 0x0000000183CAECE0-0x0000000183CAED80 
		public Button showLevelUpButton { /* [XID] */ /* 0x0000000189973980-0x00000001899739A0 */ get => default; } // 0x0000000183CAEC40-0x0000000183CAECE0 
		public Button showItemTipBtn { /* [XID] */ /* 0x000000018997AFD0-0x000000018997AFF0 */ get => default; } // 0x0000000183CAEBA0-0x0000000183CAEC40 
		public Button starUpButton { /* [XID] */ /* 0x0000000189982AE0-0x0000000189982B00 */ get => default; } // 0x0000000183CAEFE0-0x0000000183CAF110 
		public Button levelUpButton { /* [XID] */ /* 0x000000018998A2D0-0x000000018998A2F0 */ get => default; } // 0x0000000183CADF20-0x0000000183CAE0D0 
		public Button breakMaterialPreviewButton { /* [XID] */ /* 0x0000000189991BA0-0x0000000189991BC0 */ get => default; } // 0x0000000183CAD0C0-0x0000000183CAD1F0 
		public Button helpButton { /* [XID] */ /* 0x00000001899998B0-0x00000001899998D0 */ get => default; } // 0x0000000183CAD860-0x0000000183CAD910 
		public string equipTypeTextID { /* [XID] */ /* 0x00000001899A0F80-0x00000001899A0FA0 */ set {} } // 0x0000000183CAFAA0-0x0000000183CAFB60
		public string equipName { /* [XID] */ /* 0x00000001899A89D0-0x00000001899A89F0 */ set {} } // 0x0000000183CAF9D0-0x0000000183CAFAA0
		public Image pageIcon { /* [XID] */ /* 0x00000001899B02F0-0x00000001899B0310 */ get => default; } // 0x0000000183CAE450-0x0000000183CAE4F0 
		public ScrollRect itemTipsContainer { /* [XID] */ /* 0x00000001899B75C0-0x00000001899B75E0 */ get => default; } // 0x0000000183CADB40-0x0000000183CADBF0 
		public MonoItemTip itemTips { /* [XID] */ /* 0x00000001899BF020-0x00000001899BF040 */ get => default; } // 0x0000000183CADD50-0x0000000183CADF20 
		public bool isStrengthenItemTipLoaded { /* [XID] */ /* 0x00000001899C69E0-0x00000001899C6A00 */ get => default; } // 0x0000000183CAD910-0x0000000183CAD9E0 
		public MonoItemTip strengthenItemTip { /* [XID] */ /* 0x00000001899CDF80-0x00000001899CDFA0 */ get => default; } // 0x0000000183CAF760-0x0000000183CAF920 
		public MonoUIContainer storyButton { /* [XID] */ /* 0x00000001899D56B0-0x00000001899D56D0 */ get => default; } // 0x0000000183CAF650-0x0000000183CAF760 
		public MonoUIContainer detailButton { /* [XID] */ /* 0x00000001899DCAB0-0x00000001899DCAD0 */ get => default; } // 0x0000000183CAD350-0x0000000183CAD4A0 
		public MonoUIContainer selectPanelDetailButton { /* [XID] */ /* 0x00000001899E4730-0x00000001899E4750 */ get => default; } // 0x0000000183CAE7A0-0x0000000183CAE8F0 
		public MonoEquipStarUp starUp { /* [XID] */ /* 0x0000000189A11030-0x0000000189A11050 */ get => default; } // 0x0000000183CAF490-0x0000000183CAF650 
		public MonoEquipLevelUp levelUp { /* [XID] */ /* 0x0000000189A183E0-0x0000000189A18400 */ get => default; } // 0x0000000183CAE1E0-0x0000000183CAE3A0 
		public GameObject menuTabGroup { /* [XID] */ /* 0x0000000189A1FA90-0x0000000189A1FAB0 */ get => default; } // 0x0000000183CAE3A0-0x0000000183CAE450 
		public GameObject starUpTip { /* [XID] */ /* 0x0000000189A26E50-0x0000000189A26E70 */ get => default; } // 0x0000000183CAF3E0-0x0000000183CAF490 
		public UnityEngine.UI.Text starUpTipText { /* [XID] */ /* 0x0000000189A2E690-0x0000000189A2E6B0 */ get => default; } // 0x0000000183CAF330-0x0000000183CAF3E0 
		public MonoUIContainer equipBtn { /* [XID] */ /* 0x0000000189A35FE0-0x0000000189A36000 */ get => default; } // 0x0000000183CAD550-0x0000000183CAD660 
		public Image equipedAvatar { /* [XID] */ /* 0x0000000189A3D5E0-0x0000000189A3D600 */ get => default; } // 0x0000000183CAD710-0x0000000183CAD7B0 
		public MonoEquipSelect equipSelect { /* [XID] */ /* 0x0000000189A44CB0-0x0000000189A44CD0 */ get => default; } // 0x0000000183CAD660-0x0000000183CAD710 
		public MonoCostLabel costLabel { /* [XID] */ /* 0x0000000189A4C500-0x0000000189A4C520 */ get => default; } // 0x0000000183CAD2A0-0x0000000183CAD350 
		public MonoNeedLabel awakenNeedLabel { /* [XID] */ /* 0x0000000189A53C60-0x0000000189A53C80 */ get => default; } // 0x0000000183CACD30-0x0000000183CACE40 
		public MonoNeedLabel levelUpNeedLabel { /* [XID] */ /* 0x0000000189A5B6B0-0x0000000189A5B6D0 */ get => default; } // 0x0000000183CAE0D0-0x0000000183CAE1E0 
		public MonoNeedLabel starUpNeedLabel { /* [XID] */ /* 0x0000000189A62D00-0x0000000189A62D20 */ get => default; } // 0x0000000183CAF220-0x0000000183CAF330 
		public MonoEquipAwaken awaken { /* [XID] */ /* 0x0000000189A6A900-0x0000000189A6A920 */ get => default; } // 0x0000000183CACE40-0x0000000183CAD000 
		public Button showAwakenBtn { /* [XID] */ /* 0x0000000189A71F40-0x0000000189A71F60 */ get => default; } // 0x0000000183CAEB00-0x0000000183CAEBA0 
		public Button awakenButton { /* [XID] */ /* 0x0000000189A79BA0-0x0000000189A79BC0 */ get => default; } // 0x0000000183CACC00-0x0000000183CACD30 
		public Button sortBtn { /* [XID] */ /* 0x0000000189A81040-0x0000000189A81060 */ get => default; } // 0x0000000183CAED80-0x0000000183CAEEB0 
		public Dropdown sortTypeDropdown { /* [XID] */ /* 0x0000000189A88A80-0x0000000189A88AA0 */ get => default; } // 0x0000000183CAEEB0-0x0000000183CAEFE0 
		public MonoUIContainer starUpCheckBtn { /* [XID] */ /* 0x0000000189A90250-0x0000000189A90270 */ get => default; } // 0x0000000183CAF110-0x0000000183CAF220 
		public MonoUIContainer selectPanleCancelBtn { /* [XID] */ /* 0x0000000189A9EDE0-0x0000000189A9EE00 */ get => default; } // 0x0000000183CAE9A0-0x0000000183CAEA50 
		public MonoUIContainer selectPanleSelectBtn { /* [XID] */ /* 0x0000000189AA6710-0x0000000189AA6730 */ get => default; } // 0x0000000183CAEA50-0x0000000183CAEB00 
		public MonoUIContainer selectPanleBackBtn { /* [XID] */ /* 0x0000000189AADD60-0x0000000189AADD80 */ get => default; } // 0x0000000183CAE8F0-0x0000000183CAE9A0 
		public ScrollRect itemTipsScrollRect { /* [XID] */ /* 0x0000000189AB56F0-0x0000000189AB5710 */ get => default; } // 0x0000000183CADCA0-0x0000000183CADD50 
		public GameObject detailSelect { /* [XID] */ /* 0x0000000189ABD0F0-0x0000000189ABD110 */ get => default; } // 0x0000000183CAD4A0-0x0000000183CAD550 
		public GameObject panelDetailSelect { /* [XID] */ /* 0x0000000189AC4B80-0x0000000189AC4BA0 */ get => default; } // 0x0000000183CAE4F0-0x0000000183CAE5A0 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189ACC200-0x0000000189ACC220 */ get => default; } // 0x0000000183CAD1F0-0x0000000183CAD2A0 
		public MonoShopMaterial sCoinLabel { /* [XID] */ /* 0x0000000189AD3CE0-0x0000000189AD3D00 */ get => default; } // 0x0000000183CAE5A0-0x0000000183CAE7A0 
		public Transform activityTipsTrans { /* [XID] */ /* 0x0000000189AE3080-0x0000000189AE30A0 */ get => default; } // 0x0000000183CACAA0-0x0000000183CACB50 
		public UnityEngine.UI.Text activityTips { /* [XID] */ /* 0x0000000189AEAA30-0x0000000189AEAA50 */ get => default; } // 0x0000000183CACB50-0x0000000183CACC00 
		public MonoEquipTipsBar tipsBar { /* [XID] */ /* 0x0000000189AF2320-0x0000000189AF2340 */ get => default; } // 0x0000000183CAF920-0x0000000183CAF9D0 
	
		// Constructors
		public MonoEquipOverviewPage() {} // 0x0000000183CAC910-0x0000000183CACAA0
	
		// Methods
		// [XID] // 0x00000001899EB9E0-0x00000001899EBA00
		public void ShowBottomBtn(bool show) {} // 0x0000000183CAC1B0-0x0000000183CAC300
		// [XID] // 0x00000001899F34D0-0x00000001899F34F0
		public void ShowLevelUp() {} // 0x0000000183CAC4D0-0x0000000183CAC640
		// [XID] // 0x00000001899FAE90-0x00000001899FAEB0
		public void ShowStarUp() {} // 0x0000000183CAC640-0x0000000183CAC7B0
		// [XID] // 0x0000000189A020E0-0x0000000189A02100
		public void ShowItemTips() {} // 0x0000000183CAC300-0x0000000183CAC4D0
		// [XID] // 0x0000000189A098D0-0x0000000189A098F0
		public void ShowAwaken() {} // 0x0000000183CAC040-0x0000000183CAC1B0
		// [XID] // 0x0000000189A97A40-0x0000000189A97A60
		public void UpdateBtnLockState(ItemLockState lockState) {} // 0x0000000183CAC7B0-0x0000000183CAC910
		// [XID] // 0x0000000189ADB7C0-0x0000000189ADB7E0
		protected override void OnDestroy() {} // 0x0000000183CABCB0-0x0000000183CAC040
		// [XID] // 0x0000000189AF9CA0-0x0000000189AF9CC0
		public MonoEquipTipsBar CreateTipsBar() => default; // 0x0000000183CABA60-0x0000000183CABC50
	}
}
