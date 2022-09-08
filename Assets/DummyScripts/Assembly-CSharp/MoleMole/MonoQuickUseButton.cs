/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoQuickUseButton : MonoActionBtn // TypeDefIndex: 31110
	{
		// Fields
		private const string FOOD_QUALITY_BEST_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_DeliciousCooking"; // Metadata: 0x00B11ED2
		// [Header] // 0x00000001899FF2D0-0x00000001899FF310
		[SerializeField] // 0x00000001899FF2D0-0x00000001899FF310
		private Image _icon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _iconCanvasGroup; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _disableIcon; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _foodWorstMat; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _defaultMat; // 0x78
		// [Header] // 0x0000000189A287A0-0x0000000189A287F0
		[SerializeField] // 0x0000000189A287A0-0x0000000189A287F0
		private GameObject _numGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _numCanvasGroup; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _numText; // 0x90
		// [Header] // 0x0000000189A437C0-0x0000000189A43800
		[SerializeField] // 0x0000000189A437C0-0x0000000189A43800
		private GameObject _cdGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _cdText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _cdMask; // 0xA8
		// [Header] // 0x0000000189A5E6D0-0x0000000189A5E720
		[SerializeField] // 0x0000000189A5E6D0-0x0000000189A5E720
		private Image _buffIcon; // 0xB0
		// [Header] // 0x0000000189A6A8B0-0x0000000189A6A900
		[SerializeField] // 0x0000000189A6A8B0-0x0000000189A6A900
		private MonoPrefabPlugin _prefabPlugin; // 0xB8
		// [Header] // 0x0000000189A76650-0x0000000189A76690
		[SerializeField] // 0x0000000189A76650-0x0000000189A76690
		private GameObject _returnGrp; // 0xC0
		// [Header] // 0x0000000189A82890-0x0000000189A828E0
		[SerializeField] // 0x0000000189A82890-0x0000000189A828E0
		private GameObject _maxHaloGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _progressFullHalo; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _progressFullHaloBlur; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progressGrp; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _energyEffectGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _addEffect; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _maxEffect; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progressMask; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _progressImage; // 0x108
		private GameObject _foodBestImg; // 0x110
		private ParticleSystem _cdEndEffect; // 0x120
		private WidgetSystemManager _widgetSystemManager; // 0x128
		// [Header] // 0x0000000189AD5950-0x0000000189AD59B0
		[ReadOnly] // 0x0000000189AD5950-0x0000000189AD59B0
		[SerializeField] // 0x0000000189AD5950-0x0000000189AD59B0
		private WidgetActionButtonState _currentActionPanelState; // 0x130
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		private WidgetActionButtonState _nextActionPanelState; // 0x134
		private float lastCd; // 0x13C
		private bool _lastCdState; // 0x140
		private bool _currentCdState; // 0x141
		private string[] cdTextStr; // 0x148
		private static float _iFixFuncUpdateInterval; // 0x00
		private DateTime _nextIFixFuncRunTime; // 0x150
		private bool _energyFull; // 0x160
		private Transform _energyFullHaloGrp; // 0x168
	
		// Properties
		public Image Icon { /* [XID] */ /* 0x0000000189AF9C80-0x0000000189AF9CA0 */ get => default; } // 0x000000018442BF60-0x000000018442C000 
		public CanvasGroup IconCanvasGroup { /* [XID] */ /* 0x0000000189B01190-0x0000000189B011B0 */ get => default; } // 0x000000018442BEC0-0x000000018442BF60 
		public Image DisableIcon { /* [XID] */ /* 0x0000000189B08720-0x0000000189B08740 */ get => default; } // 0x000000018442BCD0-0x000000018442BD70 
		public UnityEngine.Material FoodWorstMat { /* [XID] */ /* 0x0000000189B10060-0x0000000189B10080 */ get => default; } // 0x000000018442BE20-0x000000018442BEC0 
		public UnityEngine.Material DefaultMat { /* [XID] */ /* 0x0000000189B171C0-0x0000000189B171E0 */ get => default; } // 0x000000018442BC30-0x000000018442BCD0 
		public GameObject NumGrp { /* [XID] */ /* 0x0000000189B1EB20-0x0000000189B1EB40 */ get => default; } // 0x000000018442C210-0x000000018442C2C0 
		public CanvasGroup NumCanvasGroup { /* [XID] */ /* 0x0000000189B26410-0x0000000189B26430 */ get => default; } // 0x000000018442C160-0x000000018442C210 
		public SimpleText NumText { /* [XID] */ /* 0x0000000189B2D690-0x0000000189B2D6B0 */ get => default; } // 0x000000018442C2C0-0x000000018442C370 
		public GameObject CdGrp { /* [XID] */ /* 0x0000000189B34B60-0x0000000189B34B80 */ get => default; } // 0x000000018442BA20-0x000000018442BAD0 
		public SimpleText CdText { /* [XID] */ /* 0x0000000189B3C370-0x0000000189B3C390 */ get => default; } // 0x000000018442BB80-0x000000018442BC30 
		public SmoothMask CdMask { /* [XID] */ /* 0x0000000189B43FE0-0x0000000189B44000 */ get => default; } // 0x000000018442BAD0-0x000000018442BB80 
		public Image BuffIcon { /* [XID] */ /* 0x0000000189B4B6E0-0x0000000189B4B700 */ get => default; } // 0x000000018442B970-0x000000018442BA20 
		public MonoPrefabPlugin PrefabPlugin { /* [XID] */ /* 0x0000000189B52D50-0x0000000189B52D70 */ get => default; } // 0x000000018442C370-0x000000018442C420 
		public GameObject ReturnGrp { /* [XID] */ /* 0x0000000189B5A6E0-0x0000000189B5A700 */ get => default; } // 0x000000018442C790-0x000000018442C840 
		public GameObject MAXHaloGrp { /* [XID] */ /* 0x0000000189B61BD0-0x0000000189B61BF0 */ get => default; } // 0x000000018442C0B0-0x000000018442C160 
		public Image ProgressFullHalo { /* [XID] */ /* 0x0000000189B69860-0x0000000189B69880 */ get => default; } // 0x000000018442C4D0-0x000000018442C580 
		public Image ProgressFullHaloBlur { /* [XID] */ /* 0x0000000189B70E40-0x0000000189B70E60 */ get => default; } // 0x000000018442C420-0x000000018442C4D0 
		public GameObject ProgressGrp { /* [XID] */ /* 0x0000000189B783F0-0x0000000189B78410 */ get => default; } // 0x000000018442C580-0x000000018442C630 
		public GameObject EnergyEffectGrp { /* [XID] */ /* 0x0000000189B7F8B0-0x0000000189B7F8D0 */ get => default; } // 0x000000018442BD70-0x000000018442BE20 
		public MonoUIEffect AddEffect { /* [XID] */ /* 0x0000000189B87400-0x0000000189B87420 */ get => default; } // 0x000000018442B8C0-0x000000018442B970 
		public MonoUIEffect MAXEffect { /* [XID] */ /* 0x0000000189B8E4D0-0x0000000189B8E4F0 */ get => default; } // 0x000000018442C000-0x000000018442C0B0 
		public SmoothMask ProgressMask { /* [XID] */ /* 0x0000000189B95990-0x0000000189B959B0 */ get => default; } // 0x000000018442C6E0-0x000000018442C790 
		public Image ProgressImage { /* [XID] */ /* 0x0000000189B9CF30-0x0000000189B9CF50 */ get => default; } // 0x000000018442C630-0x000000018442C6E0 
		private LCWidget lcWidget { /* [XID] */ /* 0x0000000189BA4830-0x0000000189BA4870 */ get; /* [XID] */ /* 0x0000000189BAEA70-0x0000000189BAEAB0 */ set; } // 0x0000000184429C10-0x0000000184429C70 0x0000000184429EA0-0x0000000184429F10
		private WidgetSystemManager widgetSystemManager { /* [XID] */ /* 0x0000000189BB8FD0-0x0000000189BB8FF0 */ get => default; } // 0x0000000184429F10-0x0000000184429FF0 
		public GameObject foodBestImg { /* [XID] */ /* 0x0000000189BC0DA0-0x0000000189BC0DC0 */ get => default; } // 0x000000018442C8F0-0x000000018442CAB0 
		public bool ProgressShow { /* [XID] */ /* 0x0000000189BC84E0-0x0000000189BC8500 */ set {} } // 0x000000018442CAB0-0x000000018442CC00
		public Color progressFillColor { /* [XID] */ /* 0x0000000189BCFD50-0x0000000189BCFD70 */ set {} } // 0x000000018442CCF0-0x000000018442CFB0
		private bool inCD { /* [XID] */ /* 0x0000000189602060-0x00000001896020A0 */ get; /* [XID] */ /* 0x000000018960C8F0-0x000000018960C930 */ set; } // 0x0000000184428F80-0x0000000184428FE0 0x0000000184428F10-0x0000000184428F80
		private bool _turnToCd_FlipFlop { /* [XID] */ /* 0x000000018963C740-0x000000018963C760 */ get => default; } // 0x0000000184428A60-0x0000000184428B10 
		private bool _turnToNoCd_FlipFlop { /* [XID] */ /* 0x0000000189643E70-0x0000000189643E90 */ get => default; } // 0x0000000184429DF0-0x0000000184429EA0 
		public bool energyFull { /* [XID] */ /* 0x000000018969E5D0-0x000000018969E5F0 */ get => default; /* [XID] */ /* 0x00000001896970F0-0x0000000189697110 */ set {} } // 0x000000018442C840-0x000000018442C8F0 0x000000018442CC00-0x000000018442CCF0
	
		// Constructors
		public MonoQuickUseButton() {} // 0x000000018442B780-0x000000018442B8C0
		static MonoQuickUseButton() {} // 0x000000018442B720-0x000000018442B780
	
		// Methods
		// [XID] // 0x0000000189BD7390-0x0000000189BD73B0
		private bool DoStateMachineUpdate() => default; // 0x0000000184429220-0x0000000184429390
		// [XID] // 0x0000000189BDEE70-0x0000000189BDEE90
		private void ReInitGrp() {} // 0x0000000184427E80-0x0000000184427FD0
		// [XID] // 0x00000001895EBB00-0x00000001895EBB20
		private void RefreshState() {} // 0x0000000184429800-0x0000000184429C10
		// [XID] // 0x00000001895F2E60-0x00000001895F2E80
		public bool SetActive(bool active, ActionPanelState state) => default; // 0x000000018442AC70-0x000000018442AE70
		// [XID] // 0x00000001895FA6C0-0x00000001895FA6E0
		private void UpdateLcWidgetFlag() {} // 0x000000018442A160-0x000000018442A360
		// [XID] // 0x0000000189616C70-0x0000000189616C90
		public override bool OnRealPointerDown(PointerEventData eventData) => default; // 0x000000018442A760-0x000000018442A9A0
		// [XID] // 0x000000018961E820-0x000000018961E840
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018442A650-0x000000018442A760
		// [XID] // 0x0000000189625C20-0x0000000189625C40
		protected override void Update() {} // 0x000000018442B540-0x000000018442B720
		// [XID] // 0x000000018962D540-0x000000018962D560
		protected override void OnDestroy() {} // 0x000000018442A450-0x000000018442A5B0
		// [XID] // 0x0000000189635100-0x0000000189635120
		private void OnEnable() {} // 0x000000018442A5B0-0x000000018442A650
		// [XID] // 0x000000018964B5B0-0x000000018964B5D0
		private void ChangeOnCd() {} // 0x0000000184428080-0x0000000184428210
		// [XID] // 0x0000000189652DC0-0x0000000189652DE0
		private void ChangeCdEnd() {} // 0x0000000184429C70-0x0000000184429DF0
		// [XID] // 0x000000018965A4C0-0x000000018965A4E0
		public string ChangeString(int t, float cd) => default; // 0x0000000184428290-0x0000000184428840
		// [XID] // 0x0000000189661B10-0x0000000189661B30
		private void ClearCdState() {} // 0x000000018442A360-0x000000018442A450
		// [XID] // 0x00000001896696B0-0x00000001896696D0
		private void SetUpLcWidget() {} // 0x0000000184428CC0-0x0000000184428E70
		// [XID] // 0x00000001896711A0-0x00000001896711C0
		private void UpdateCD(BagItemSlot item) {} // 0x0000000184429390-0x0000000184429800
		// [XID] // 0x0000000189678A60-0x0000000189678A80
		public static void SetIFixFuncUpdateInterval(float val) {} // 0x000000018442B440-0x000000018442B540
		// [XID] // 0x0000000189680060-0x0000000189680080
		private void IFixPrepareSetActiveFunc(bool active) {} // 0x0000000184427FD0-0x0000000184428080
		// [XID] // 0x0000000189687C90-0x0000000189687CB0
		private void IFixPrepareUpdateFunc() {} // 0x0000000184428FE0-0x00000001844291C0
		// [XID] // 0x000000018968F690-0x000000018968F6B0
		private void IFixPrepareUpdateFuncInternal() {} // 0x0000000184428E70-0x0000000184428F10
		// [XID] // 0x00000001896A56B0-0x00000001896A56D0
		private void ClearEnergyState() {} // 0x000000018442A9A0-0x000000018442AA40
		// [XID] // 0x00000001896ACEF0-0x00000001896ACF10
		private void SetNormalIcon(BagItem item) {} // 0x0000000184429FF0-0x000000018442A160
		// [XID] // 0x00000001896B44D0-0x00000001896B44F0
		public void SetFoodAndBuffIcon(BagItemSlot itemSlot) {} // 0x000000018442AE70-0x000000018442B1A0
		// [XID] // 0x00000001896BB7B0-0x00000001896BB7D0
		public void SetFoodQualityIcon(MaterialExcelConfig config) {} // 0x000000018442B1A0-0x000000018442B440
		// [XID] // 0x00000001896C2C20-0x00000001896C2C40
		private void RefreshNum() {} // 0x0000000184428B10-0x0000000184428C60
		// [XID] // 0x00000001896CA140-0x00000001896CA160
		public void CreateCDEndEffect() {} // 0x0000000184428840-0x00000001844289E0
		// [XID] // 0x00000001896D17F0-0x00000001896D1810
		public void PlayCDEndEffect() {} // 0x000000018442AB70-0x000000018442AC70
		// [XID] // 0x00000001896D8FD0-0x00000001896D8FF0
		public void PlayAddEffect() {} // 0x000000018442AA40-0x000000018442AB70
	}
}
