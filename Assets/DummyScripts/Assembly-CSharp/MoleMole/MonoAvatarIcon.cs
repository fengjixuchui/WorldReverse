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
	public class MonoAvatarIcon : MonoSpriteProxy, INavSelectable // TypeDefIndex: 30399
	{
		// Fields
		private const string QUALITY_ICON_FOUR_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon_Quality4"; // Metadata: 0x00B10A3D
		private const string QUALITY_ICON_FIVE_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon_Quality5"; // Metadata: 0x00B10A68
		private const string TRIAL_ICON_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon_Trial"; // Metadata: 0x00B10A93
		private const string AVATAR_ICON_MASK_PATH = "ART/UI/Menus/Widget/BagItemSlot_Mask"; // Metadata: 0x00B10ABB
		private const string AVATAR_ADD_ICON = "UI_Icon_Add"; // Metadata: 0x00B10AE3
		private const string AVATAR_ADD_TEAM = "UI_Icon_Team"; // Metadata: 0x00B10AF2
		private const string AVATAR_ADD_TEXT = "--"; // Metadata: 0x00B10B02
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _actionButton; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLongPressButton _longPress; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _icon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _selectedHint; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _deadIconMaterial; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _defaultMaterial; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ParticleSystem _useEffect; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cost; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _teamSign; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorBg; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorIcon; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _qualityIconRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _trialIconRoot; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _elementIcon; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _newCornerMark; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _popUpCornerMark; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoPrefabPlugin _plugin; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _extendIndex; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _hungerIndex; // 0xBC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _recoveryEffIndex; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _conditionIndex; // 0xC4
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _maskRoot; // 0xC8
		private GameObject _mask; // 0xD0
		private int _index; // 0xD8
		private MonoAvatarIconExtension _extension; // 0xE0
		private MonoAvatarIconSatiation _satiationExtension; // 0xE8
		private RectTransform _recoveryEff; // 0xF0
		private GameObject _qualityIcon4; // 0xF8
		private GameObject _qualityIcon5; // 0x100
		private GameObject _trialIcon; // 0x108
		public GameObject hintTextGO; // 0x110
		public UnityEngine.UI.Text hintText; // 0x118
		public GameObject teamNumMark; // 0x120
		public UnityEngine.UI.Text teamNumMarkText; // 0x128
		public GameObject teamCheckIcon; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _teamNumImageArray; // 0x138
		private float _qualityType; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _careIcon; // 0x148
		private RectTransform _condition; // 0x150
		public ulong guid; // 0x158
		private int _selectedIndex; // 0x160
	
		// Properties
		public GameObject qualityIcon4 { /* [XID] */ /* 0x0000000189A110D0-0x0000000189A110F0 */ get => default; } // 0x000000018421FAB0-0x000000018421FC50 
		public GameObject qualityIcon5 { /* [XID] */ /* 0x0000000189A18480-0x0000000189A184A0 */ get => default; } // 0x000000018421FC50-0x000000018421FDF0 
		public GameObject trialIcon { /* [XID] */ /* 0x0000000189A1FBC0-0x0000000189A1FBE0 */ get => default; } // 0x000000018421FFB0-0x0000000184220150 
		public string levelLabel { /* [XID] */ /* 0x0000000189A2E730-0x0000000189A2E750 */ set {} } // 0x0000000184220660-0x0000000184220730
		public int quality { /* [XID] */ /* 0x0000000189A36080-0x0000000189A360A0 */ set {} } // 0x0000000184220930-0x0000000184220B40
		public bool selected { /* [XID] */ /* 0x0000000189A3D6A0-0x0000000189A3D6C0 */ set {} } // 0x0000000184220C50-0x0000000184220D50
		public bool isTrial { /* [XID] */ /* 0x0000000189A44D50-0x0000000189A44D70 */ set {} } // 0x0000000184220530-0x0000000184220660
		public bool up { /* [XID] */ /* 0x0000000189A4C5A0-0x0000000189A4C5C0 */ set {} } // 0x0000000184221600-0x0000000184221760
		public int index { /* [XID] */ /* 0x0000000189A53D40-0x0000000189A53D60 */ get => default; /* [XID] */ /* 0x0000000189A5B750-0x0000000189A5B770 */ set {} } // 0x000000018421F970-0x000000018421FA10 0x0000000184220480-0x0000000184220530
		public UnityEngine.UI.Text cost { /* [XID] */ /* 0x0000000189A62E00-0x0000000189A62E20 */ get => default; } // 0x000000018421F820-0x000000018421F8C0 
		public GameObject teamSign { /* [XID] */ /* 0x0000000189A6A960-0x0000000189A6A980 */ get => default; } // 0x000000018421FF00-0x000000018421FFB0 
		public Image colorBg { /* [XID] */ /* 0x0000000189A72020-0x0000000189A72040 */ get => default; } // 0x000000018421F6D0-0x000000018421F770 
		public Image colorIcon { /* [XID] */ /* 0x0000000189A79C80-0x0000000189A79CA0 */ get => default; } // 0x000000018421F770-0x000000018421F820 
		public Image elementIcon { /* [XID] */ /* 0x0000000189A81120-0x0000000189A81140 */ get => default; } // 0x000000018421F8C0-0x000000018421F970 
		public bool showMask { /* [XID] */ /* 0x0000000189A88B40-0x0000000189A88B60 */ set {} } // 0x0000000184220E60-0x0000000184220FE0
		public LifeState lifeState { /* [XID] */ /* 0x0000000189A9EEB0-0x0000000189A9EED0 */ set {} } // 0x0000000184220730-0x0000000184220820
		public bool forceRefresh { /* [XID] */ /* 0x0000000189ABD1D0-0x0000000189ABD1F0 */ set {} } // 0x0000000184220150-0x0000000184220260
		public float satiationRatio { /* [XID] */ /* 0x0000000189AC4C60-0x0000000189AC4C80 */ get => default; /* [XID] */ /* 0x0000000189ACC2E0-0x0000000189ACC300 */ set {} } // 0x000000018421FDF0-0x000000018421FF00 0x0000000184220B40-0x0000000184220C50
		public float hpRatio { /* [XID] */ /* 0x0000000189AF2440-0x0000000189AF2460 */ set {} } // 0x0000000184220370-0x0000000184220480
		public uint hoursRemain { /* [XID] */ /* 0x0000000189AF9DE0-0x0000000189AF9E00 */ set {} } // 0x0000000184220260-0x0000000184220370
		public bool showBottomText { /* [XID] */ /* 0x0000000189B01350-0x0000000189B01370 */ set {} } // 0x0000000184220D50-0x0000000184220E60
		public bool showPreHpRatio { /* [XID] */ /* 0x0000000189B08860-0x0000000189B08880 */ set {} } // 0x00000001842211E0-0x00000001842212F0
		public float preHpRatio { /* [XID] */ /* 0x0000000189B10200-0x0000000189B10220 */ set {} } // 0x0000000184220820-0x0000000184220930
		public Button actionButton { /* [XID] */ /* 0x0000000189B17320-0x0000000189B17340 */ get => default; } // 0x000000018421F580-0x000000018421F620 
		public MonoLongPressButton longPress { /* [XID] */ /* 0x0000000189B1ECC0-0x0000000189B1ECE0 */ get => default; } // 0x000000018421FA10-0x000000018421FAB0 
		public Color teamMarkColor { /* [XID] */ /* 0x0000000189B7C840-0x0000000189B7C860 */ set {} } // 0x0000000184221440-0x0000000184221600
		public bool showTeamCheckIcon { /* [XID] */ /* 0x0000000189B84680-0x0000000189B846A0 */ set {} } // 0x00000001842212F0-0x0000000184221440
		public bool showNewCornerMark { /* [XID] */ /* 0x0000000189B8B510-0x0000000189B8B530 */ set {} } // 0x0000000184220FE0-0x00000001842210E0
		public bool showPopUpCornerMark { /* [XID] */ /* 0x0000000189B92C40-0x0000000189B92C60 */ set {} } // 0x00000001842210E0-0x00000001842211E0
		public RectTransform careIcon { /* [XID] */ /* 0x0000000189BA8D30-0x0000000189BA8D50 */ get => default; } // 0x000000018421F620-0x000000018421F6D0 
	
		// Constructors
		public MonoAvatarIcon() {} // 0x000000018421F420-0x000000018421F580
	
		// Methods
		// [XID] // 0x0000000189A26F10-0x0000000189A26F30
		protected override void OnDestroy() {} // 0x000000018421D0D0-0x000000018421D300
		// [XID] // 0x0000000189A902F0-0x0000000189A90310
		public void SetIcon(Sprite sprite, bool isDead = false /* Metadata: 0x00B10A31 */) {} // 0x000000018421ECD0-0x000000018421EDF0
		// [XID] // 0x0000000189A97AE0-0x0000000189A97B00
		public void SetIconAlpha(float alpha) {} // 0x000000018421EAF0-0x000000018421ECD0
		// [XID] // 0x0000000189AA67F0-0x0000000189AA6810
		public void ShowUseEffect() {} // 0x000000018421F1C0-0x000000018421F2F0
		// [XID] // 0x0000000189AADE80-0x0000000189AADEA0
		public void CreateExtension() {} // 0x000000018421CAA0-0x000000018421CBB0
		// [XID] // 0x0000000189AB5830-0x0000000189AB5850
		public void DealSatiationExtension(bool show) {} // 0x000000018421CCD0-0x000000018421CE30
		// [XID] // 0x0000000189AD3DC0-0x0000000189AD3DE0
		public void CreateRecoveryEff() {} // 0x000000018421CBB0-0x000000018421CCD0
		// [XID] // 0x0000000189ADB8C0-0x0000000189ADB8E0
		public void PlayRecoveryOnceEff() {} // 0x000000018421D580-0x000000018421D6D0
		// [XID] // 0x0000000189AE31A0-0x0000000189AE31C0
		public void PlayRecoveryLoopEff() {} // 0x000000018421D450-0x000000018421D580
		// [XID] // 0x0000000189AEAB70-0x0000000189AEAB90
		public void StopRecoveryLoopEff() {} // 0x000000018421F2F0-0x000000018421F420
		// [IDTag] // 0x0000000189B26510-0x0000000189B26550
		// [XID] // 0x0000000189B26510-0x0000000189B26550
		public void SetAvatarIcon(AvatarDataItem dataItem, bool showCost = false /* Metadata: 0x00B10A32 */, bool showExploreInfo = false /* Metadata: 0x00B10A33 */) {} // 0x000000018421DC50-0x000000018421E150
		// [XID] // 0x0000000189B30590-0x0000000189B305B0
		public void SetAvatarAddIcon() {} // 0x000000018421D810-0x000000018421D9B0
		// [XID] // 0x0000000189B37EB0-0x0000000189B37ED0
		public void SetAvatarTeamIcon() {} // 0x000000018421E800-0x000000018421E9C0
		// [IDTag] // 0x0000000189B3F8A0-0x0000000189B3F8E0
		// [XID] // 0x0000000189B3F8A0-0x0000000189B3F8E0
		public void SetAvatarIcon(string avatarIconName, uint level, ElementType elementType, bool isUp, uint configId = 0 /* Metadata: 0x00B10A34 */) {} // 0x000000018421E5E0-0x000000018421E800
		// [IDTag] // 0x0000000189B4A1F0-0x0000000189B4A230
		// [XID] // 0x0000000189B4A1F0-0x0000000189B4A230
		public void SetAvatarIcon(AvatarExcelConfig avatarConfig, uint level) {} // 0x000000018421D9B0-0x000000018421DC50
		// [IDTag] // 0x0000000189B54750-0x0000000189B54790
		// [XID] // 0x0000000189B54750-0x0000000189B54790
		public void SetAvatarIcon(AvatarExcelConfig avatarConfig, bool asyncLoadIcon = true /* Metadata: 0x00B10A38 */) {} // 0x000000018421E150-0x000000018421E5E0
		// [XID] // 0x0000000189B5F1B0-0x0000000189B5F1D0
		public Transform CreateEffect(string effectName) => default; // 0x000000018421C9D0-0x000000018421CAA0
		// [XID] // 0x0000000189B667A0-0x0000000189B667C0
		public void SetHint(string hint) {} // 0x000000018421E9C0-0x000000018421EAF0
		// [XID] // 0x0000000189B6DD20-0x0000000189B6DD40
		public void SetMarkNo(int index = 0 /* Metadata: 0x00B10A39 */) {} // 0x000000018421EDF0-0x000000018421EEB0
		// [XID] // 0x0000000189B753F0-0x0000000189B75410
		public void RefreshMarkNo() {} // 0x000000018421D6D0-0x000000018421D810
		// [XID] // 0x0000000189B9A220-0x0000000189B9A240
		public void SetupQualityType(QualityType qualityType) {} // 0x000000018421EF70-0x000000018421F1C0
		// [XID] // 0x0000000189BA1910-0x0000000189BA1930
		public void OnEnable() {} // 0x000000018421D300-0x000000018421D450
		// [XID] // 0x0000000189BB0480-0x0000000189BB04A0
		private GameObject InstantiateMask() => default; // 0x000000018421CF80-0x000000018421D0D0
		// [XID] // 0x0000000189BB78C0-0x0000000189BB78E0
		public void SetNavSelected(bool selected) {} // 0x000000018421EEB0-0x000000018421EF70
	}
}
