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
	public class MonoCharacterPage : MonoUIProxy // TypeDefIndex: 30453
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _returnButton; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoCostLabel _costLabel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _elementIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _pendantBgIcon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _elementName; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarName; // 0x68
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoAvatarInfoBrief _avatarInfo; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x78
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _prevAvatarButton; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextAvatarButton; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevAvatarButtonPS4; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextAvatarButtonPS4; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _propertyButton; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _weaponButton; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _relicButton; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _skillButton; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _talentButton; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _fettersButton; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _grpTab; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _grpBg; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _helpBtn; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _exitBtnPS4; // 0xE8
		// [Header] // 0x0000000189BDD780-0x0000000189BDD7D0
		[SerializeField] // 0x0000000189BDD780-0x0000000189BDD7D0
		private MonoUIContainer _fetterRewardButton; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetterRewardButtonPS4; // 0xF8
		public MonoVerticalScroller fetterInfoScroller; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFetterBaseInfo _fetterBaseInfo; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoUIContainer fetterStoryBtnContainer; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoUIContainer fetterVoiceBtnContainer; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoUIContainer fetterStoryBtnContainerPS4; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoUIContainer fetterVoiceBtnContainerPS4; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject fetterInfoPanelGO; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject fetterLevelGo; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text fetterLevelText; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject fetterBarGO; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public SmoothMask fetterBar; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _fetterGrpActionPS4; // 0x158
		private const string SHOP_MATERIAL_ITEM_PATH = "ART/UI/Menus/Widget/ShopMaterialsItem"; // Metadata: 0x00B1111E
		private GameObject _sCoinLabel; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x168
		// [Header] // 0x00000001897962B0-0x0000000189796300
		[SerializeField] // 0x00000001897962B0-0x0000000189796300
		private MonoItemTip _weaponItemTip; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBagProxySlot _weaponIconSlot; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoWeaponChangeTip _weaponChangeTip; // 0x180
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _weaponItemPanel; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _weaponChangePanel; // 0x190
		public RectTransform WeaponItemPanelNow; // 0x198
		public MonoItemTip WeaponItemPanelItemTip; // 0x1A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _weaponEquippedLabel; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _weaponEquippedAvatarIcon; // 0x1B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _weaponEquippedAvatarName; // 0x1B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _weaponScrollRect; // 0x1C0
		public GameObject blackBackground; // 0x1C8
		// [Header] // 0x00000001896987F0-0x0000000189698820
		public MonoRelicInfoBrief relicInfo; // 0x1D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _relicBackBtn; // 0x1D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _relicSuiteDesc; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _relicChangePanel; // 0x1E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoRelicChangeTip _relicChangeTip; // 0x1F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LabelGroup[] _relicSuiteText; // 0x1F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _relicNoSuiteText; // 0x200
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _relicEquippedLabel; // 0x208
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _relicEquippedAvatarIcon; // 0x210
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _relicEquippedAvatarName; // 0x218
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _relicScrollRect; // 0x220
		// [Header] // 0x00000001896EAB20-0x00000001896EAB70
		[SerializeField] // 0x00000001896EAB20-0x00000001896EAB70
		private MonoAvatarTalentPanel _talentPanel; // 0x228
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _talentBackBtn; // 0x230
		// [Header] // 0x00000001896FE540-0x00000001896FE590
		[SerializeField] // 0x00000001896FE540-0x00000001896FE590
		private MonoAvatarSkillPanel _skillPanel; // 0x238
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _grpAvatarInfo; // 0x240
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpLowAvatarInfo; // 0x248
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAvatarPreviewInfo _avatarPreviewInfo; // 0x250
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _playerInfoMenu; // 0x258
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerNameText; // 0x260
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playerUIDText; // 0x268
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _playerPS4ID; // 0x270
		[SerializeField] // 0x0000000189742AB0-0x0000000189742B10
		[Space] // 0x0000000189742AB0-0x0000000189742B10
		// [Tooltip] // 0x0000000189742AB0-0x0000000189742B10
		private float _scrollShieldAngle; // 0x278
	
		// Properties
		public Button helpButton { /* [XID] */ /* 0x00000001897518B0-0x00000001897518D0 */ get => default; } // 0x0000000184810A80-0x0000000184810B30 
		public MonoUIContainer starUpBtn { /* [XID] */ /* 0x0000000189758E80-0x0000000189758EA0 */ get => default; } // 0x00000001848120C0-0x00000001848121D0 
		public MonoUIContainer levelUpBtn { /* [XID] */ /* 0x0000000189760B10-0x0000000189760B30 */ get => default; } // 0x0000000184810B30-0x0000000184810C40 
		public MonoUIContainer appearanceBtn { /* [XID] */ /* 0x0000000189767DD0-0x0000000189767DF0 */ get => default; } // 0x000000018480FAD0-0x000000018480FBE0 
		public MonoUIContainer breachMaterialBtn { /* [XID] */ /* 0x000000018976F3A0-0x000000018976F3C0 */ get => default; } // 0x000000018480FDD0-0x000000018480FEE0 
		public Button talentButton { /* [XID] */ /* 0x0000000189776DC0-0x0000000189776DE0 */ get => default; } // 0x00000001848124A0-0x0000000184812550 
		public Button fettersButton { /* [XID] */ /* 0x000000018977E480-0x000000018977E4A0 */ get => default; } // 0x0000000184810870-0x0000000184810920 
		public Button closeButton { /* [XID] */ /* 0x0000000189785BB0-0x0000000189785BD0 */ get => default; } // 0x0000000184810000-0x00000001848100B0 
		public Button prevAvatarButton { /* [XID] */ /* 0x000000018978D310-0x000000018978D330 */ get => default; } // 0x0000000184811080-0x0000000184811140 
		public Button nextAvatarButton { /* [XID] */ /* 0x0000000189794670-0x0000000189794690 */ get => default; } // 0x0000000184810D00-0x0000000184810DC0 
		public Button prevAvatarButtonPS4 { /* [XID] */ /* 0x000000018979CB00-0x000000018979CB20 */ get => default; } // 0x0000000184810FC0-0x0000000184811080 
		public Button nextAvatarButtonPS4 { /* [XID] */ /* 0x00000001897A3F60-0x00000001897A3F80 */ get => default; } // 0x0000000184810C40-0x0000000184810D00 
		public Button characterSelectButton { /* [XID] */ /* 0x00000001897AB4E0-0x00000001897AB500 */ get => default; } // 0x000000018480FEE0-0x0000000184810000 
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x00000001897B32D0-0x00000001897B32F0 */ get => default; } // 0x0000000184810460-0x0000000184810500 
		public MonoReusableList tabContainer { /* [XID] */ /* 0x00000001897BB1F0-0x00000001897BB210 */ get => default; } // 0x00000001848121D0-0x00000001848122E0 
		public MonoScrollRectExtention tabScroller { /* [XID] */ /* 0x00000001897C29D0-0x00000001897C29F0 */ get => default; } // 0x00000001848122E0-0x00000001848123F0 
		public MonoCostLabel costLabel { /* [XID] */ /* 0x00000001897CA1F0-0x00000001897CA210 */ get => default; } // 0x0000000184810160-0x0000000184810200 
		public MonoAvatarInfoBrief avatarInfo { /* [XID] */ /* 0x00000001897D1890-0x00000001897D18B0 */ get => default; } // 0x000000018480FBE0-0x000000018480FC80 
		public Image elementIcon { /* [XID] */ /* 0x00000001897D96B0-0x00000001897D96D0 */ get => default; } // 0x0000000184810320-0x00000001848103C0 
		public Image pendantBgIcon { /* [XID] */ /* 0x00000001897E0A30-0x00000001897E0A50 */ get => default; } // 0x0000000184810DC0-0x0000000184810E60 
		public UnityEngine.UI.Text elementName { /* [XID] */ /* 0x00000001897E80F0-0x00000001897E8110 */ get => default; } // 0x00000001848103C0-0x0000000184810460 
		public UnityEngine.UI.Text avatarName { /* [XID] */ /* 0x00000001897EFD90-0x00000001897EFDB0 */ get => default; } // 0x000000018480FC80-0x000000018480FD20 
		public Button propertyButton { /* [XID] */ /* 0x00000001897F7580-0x00000001897F75A0 */ get => default; } // 0x0000000184811140-0x00000001848111F0 
		public Button weaponButton { /* [XID] */ /* 0x00000001897FEC90-0x00000001897FECB0 */ get => default; } // 0x0000000184812A60-0x0000000184812B10 
		public Button relicButton { /* [XID] */ /* 0x00000001898063D0-0x00000001898063F0 */ get => default; } // 0x00000001848112A0-0x0000000184811350 
		public Button skillButton { /* [XID] */ /* 0x000000018980DA70-0x000000018980DA90 */ get => default; } // 0x0000000184811EA0-0x0000000184811F50 
		public Button detailPropertyButton { /* [XID] */ /* 0x0000000189815250-0x0000000189815270 */ get => default; } // 0x0000000184810200-0x0000000184810320 
		public MonoFetterBaseInfo fetterBaseInfo { /* [XID] */ /* 0x000000018981CC70-0x000000018981CC90 */ get => default; } // 0x00000001848105B0-0x0000000184810660 
		public CanvasGroup grpTab { /* [XID] */ /* 0x00000001898240B0-0x00000001898240D0 */ get => default; } // 0x00000001848109D0-0x0000000184810A80 
		public CanvasGroup grpBg { /* [XID] */ /* 0x000000018982BAB0-0x000000018982BAD0 */ get => default; } // 0x0000000184810920-0x00000001848109D0 
		public RectTransform fetterGrpActionPS4 { /* [XID] */ /* 0x0000000189833090-0x00000001898330B0 */ get => default; } // 0x0000000184810660-0x0000000184810710 
		public MonoUIContainer fetterRewardButton { /* [XID] */ /* 0x000000018983A540-0x000000018983A560 */ get => default; } // 0x00000001848107C0-0x0000000184810870 
		public MonoUIContainer fetterRewardButtonPS4 { /* [XID] */ /* 0x0000000189841B40-0x0000000189841B60 */ get => default; } // 0x0000000184810710-0x00000001848107C0 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189849050-0x0000000189849070 */ get => default; } // 0x00000001848100B0-0x0000000184810160 
		public MonoShopMaterial sCoinLabel { /* [XID] */ /* 0x00000001898507D0-0x00000001898507F0 */ get => default; } // 0x0000000184811AA0-0x0000000184811CA0 
		public bool showWeaponEquippedLabel { /* [XID] */ /* 0x000000018985EC50-0x000000018985EC70 */ set {} } // 0x00000001848139C0-0x0000000184813AC0
		public Sprite weaponEquippedAvatarIconSprite { /* [XID] */ /* 0x00000001898663D0-0x00000001898663F0 */ set {} } // 0x0000000184813AC0-0x0000000184813B90
		public string weaponEquippedAvatarName { /* [XID] */ /* 0x000000018986DCE0-0x000000018986DD00 */ set {} } // 0x0000000184813B90-0x0000000184813C60
		public MonoUIContainer weaponPromoteBtnContainer { /* [XID] */ /* 0x0000000189875080-0x00000001898750A0 */ get => default; } // 0x0000000184812F90-0x00000001848130A0 
		public MonoUIContainer weaponReplaceBtnContainer { /* [XID] */ /* 0x000000018987CCF0-0x000000018987CD10 */ get => default; } // 0x00000001848130A0-0x00000001848131B0 
		public MonoItemTip weaponItemTip { /* [XID] */ /* 0x0000000189883C90-0x0000000189883CB0 */ get => default; } // 0x0000000184812EE0-0x0000000184812F90 
		public MonoBagProxySlot weaponIconSlot { /* [XID] */ /* 0x000000018988B330-0x000000018988B350 */ get => default; } // 0x0000000184812C70-0x0000000184812D20 
		public MonoWeaponChangeTip weaponChangeTip { /* [XID] */ /* 0x0000000189892A70-0x0000000189892A90 */ get => default; } // 0x0000000184812BC0-0x0000000184812C70 
		public RectTransform weaponItemPanel { /* [XID] */ /* 0x000000018989A0F0-0x000000018989A110 */ get => default; } // 0x0000000184812E30-0x0000000184812EE0 
		public RectTransform weaponChangePanel { /* [XID] */ /* 0x00000001898A13B0-0x00000001898A13D0 */ get => default; } // 0x0000000184812B10-0x0000000184812BC0 
		public RectTransform weaponItemBtns { /* [XID] */ /* 0x00000001898A8C20-0x00000001898A8C40 */ get => default; } // 0x0000000184812D20-0x0000000184812E30 
		public ScrollRect weaponScrollRect { /* [XID] */ /* 0x00000001898B05A0-0x00000001898B05C0 */ get => default; } // 0x00000001848131B0-0x0000000184813260 
		public bool showRelicEquippedLabel { /* [XID] */ /* 0x00000001898B7B90-0x00000001898B7BB0 */ set {} } // 0x00000001848138C0-0x00000001848139C0
		public Sprite relicEquippedAvatarIconSprite { /* [XID] */ /* 0x00000001898BF180-0x00000001898BF1A0 */ set {} } // 0x0000000184813260-0x0000000184813330
		public string relicEquippedAvatarName { /* [XID] */ /* 0x00000001898C6B20-0x00000001898C6B40 */ set {} } // 0x0000000184813330-0x0000000184813400
		public MonoUIContainer relicPromoteBtnContainer { /* [XID] */ /* 0x00000001898CE100-0x00000001898CE120 */ get => default; } // 0x0000000184811670-0x0000000184811780 
		public MonoUIContainer relicReplaceBtnContainer { /* [XID] */ /* 0x00000001898D5B70-0x00000001898D5B90 */ get => default; } // 0x0000000184811780-0x0000000184811890 
		public RectTransform relicSuiteDesc { /* [XID] */ /* 0x00000001898DD840-0x00000001898DD860 */ get => default; } // 0x0000000184811940-0x00000001848119F0 
		public RectTransform relicChangePanel { /* [XID] */ /* 0x00000001898E5070-0x00000001898E5090 */ get => default; } // 0x0000000184811350-0x0000000184811400 
		public RectTransform relicItemBtns { /* [XID] */ /* 0x00000001898EC8E0-0x00000001898EC900 */ get => default; } // 0x00000001848114B0-0x00000001848115C0 
		public Button relicBackBtn { /* [XID] */ /* 0x00000001898F42F0-0x00000001898F4310 */ get => default; } // 0x00000001848111F0-0x00000001848112A0 
		public MonoRelicChangeTip relicChangeTip { /* [XID] */ /* 0x00000001898FBAC0-0x00000001898FBAE0 */ get => default; } // 0x0000000184811400-0x00000001848114B0 
		public LabelGroup[] relicSuiteText { /* [XID] */ /* 0x0000000189903490-0x00000001899034B0 */ get => default; } // 0x00000001848119F0-0x0000000184811AA0 
		public GameObject relicNoSuiteText { /* [XID] */ /* 0x000000018990A9E0-0x000000018990AA00 */ get => default; } // 0x00000001848115C0-0x0000000184811670 
		public MonoUIContainer exitBtnPS4 { /* [XID] */ /* 0x0000000189912670-0x0000000189912690 */ get => default; } // 0x0000000184810500-0x00000001848105B0 
		public ScrollRect relicScrollRect { /* [XID] */ /* 0x0000000189919F40-0x0000000189919F60 */ get => default; } // 0x0000000184811890-0x0000000184811940 
		public MonoAvatarTalentPanel talentPanel { /* [XID] */ /* 0x0000000189921760-0x0000000189921780 */ get => default; } // 0x0000000184812790-0x0000000184812840 
		public MonoUIContainer talentBackBtn { /* [XID] */ /* 0x0000000189928E60-0x0000000189928E80 */ get => default; } // 0x00000001848123F0-0x00000001848124A0 
		public MonoUIContainer upgradeTalentBtn { /* [XID] */ /* 0x00000001899303F0-0x0000000189930410 */ get => default; } // 0x0000000184812950-0x0000000184812A60 
		public MonoUIContainer selectTalentBtn { /* [XID] */ /* 0x00000001899378C0-0x00000001899378E0 */ get => default; } // 0x0000000184811D50-0x0000000184811EA0 
		public MonoUIContainer talentCheckBtnContainer { /* [XID] */ /* 0x000000018993F3B0-0x000000018993F3D0 */ get => default; } // 0x0000000184812550-0x0000000184812610 
		public MonoUIContainer talentExitBtnContainer { /* [XID] */ /* 0x00000001899469A0-0x00000001899469C0 */ get => default; } // 0x00000001848126D0-0x0000000184812790 
		public MonoUIContainer talentCheckNeedBtn { /* [XID] */ /* 0x000000018994E060-0x000000018994E080 */ get => default; } // 0x0000000184812610-0x00000001848126D0 
		public MonoUIContainer upgradeSkillBtn { /* [XID] */ /* 0x00000001899556A0-0x00000001899556C0 */ get => default; } // 0x0000000184812840-0x0000000184812950 
		public MonoAvatarSkillPanel skillPanel { /* [XID] */ /* 0x000000018995D1C0-0x000000018995D1E0 */ get => default; } // 0x0000000184812010-0x00000001848120C0 
		public MonoUIContainer skillCheckBtnContainer { /* [XID] */ /* 0x0000000189964840-0x0000000189964860 */ get => default; } // 0x0000000184811F50-0x0000000184812010 
		public bool showGroAvatarInfo { /* [XID] */ /* 0x00000001899739C0-0x00000001899739E0 */ set {} } // 0x0000000184813510-0x0000000184813600
		public bool showGroLowAvatarInfo { /* [XID] */ /* 0x000000018997B010-0x000000018997B030 */ set {} } // 0x0000000184813600-0x00000001848136F0
		public MonoAvatarPreviewInfo avatarPreviewInfo { /* [XID] */ /* 0x0000000189982B60-0x0000000189982B80 */ get => default; } // 0x000000018480FD20-0x000000018480FDD0 
		public bool showPlayerInfo { /* [XID] */ /* 0x000000018998A330-0x000000018998A350 */ set {} } // 0x00000001848136F0-0x00000001848137E0
		public UnityEngine.UI.Text playerNameText { /* [XID] */ /* 0x0000000189991C00-0x0000000189991C20 */ get => default; } // 0x0000000184810E60-0x0000000184810F10 
		public UnityEngine.UI.Text playerUIDText { /* [XID] */ /* 0x0000000189999930-0x0000000189999950 */ get => default; } // 0x0000000184810F10-0x0000000184810FC0 
		public bool showPlayerPS4ID { /* [XID] */ /* 0x00000001899A0FE0-0x00000001899A1000 */ set {} } // 0x00000001848137E0-0x00000001848138C0
		public string setPlayerPS4ID { /* [XID] */ /* 0x00000001899A8AB0-0x00000001899A8AD0 */ set {} } // 0x0000000184813400-0x0000000184813510
		public float scrollShieldAngle { /* [XID] */ /* 0x00000001899B03F0-0x00000001899B0410 */ get => default; } // 0x0000000184811CA0-0x0000000184811D50 
	
		// Constructors
		public MonoCharacterPage() {} // 0x000000018480F890-0x000000018480FAD0
	
		// Methods
		// [XID] // 0x0000000189857BA0-0x0000000189857BC0
		protected override void OnDestroy() {} // 0x000000018480F5B0-0x000000018480F6D0
		// [XID] // 0x000000018996BED0-0x000000018996BEF0
		public void SetFetterLevel(AvatarIdentityType type, uint level, float percent = 0f /* Metadata: 0x00B11119 */, bool showPercent = true /* Metadata: 0x00B1111D */) {} // 0x000000018480F6D0-0x000000018480F890
	}
}
