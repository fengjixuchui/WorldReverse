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
	public class MonoReputationPage : MonoUIProxy // TypeDefIndex: 30477
	{
		// Fields
		// [Header] // 0x0000000189AC3480-0x0000000189AC3500
		// [Range] // 0x0000000189AC3480-0x0000000189AC3500
		[SerializeField] // 0x0000000189AC3480-0x0000000189AC3500
		[Space] // 0x0000000189AC3480-0x0000000189AC3500
		private float _closeFadeOutDuration; // 0x40
		// [Header] // 0x0000000189AD5A10-0x0000000189AD5A80
		// [Range] // 0x0000000189AD5A10-0x0000000189AD5A80
		[SerializeField] // 0x0000000189AD5A10-0x0000000189AD5A80
		private float _gotoQuestFadeOutDuration; // 0x44
		// [Range] // 0x0000000189A52310-0x0000000189A52350
		[SerializeField] // 0x0000000189A52310-0x0000000189A52350
		private float _expAddDuration; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _panels; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgImage; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgMaskImage; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _bgEffectContainer; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cityText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _splash; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _labelText; // 0x88
		// [Header] // 0x0000000189B2D7C0-0x0000000189B2D820
		[SerializeField] // 0x0000000189B2D7C0-0x0000000189B2D820
		[Space] // 0x0000000189B2D7C0-0x0000000189B2D820
		private UnityEngine.UI.Text _reputationLevel; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationExp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _reputationIcon; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Slider _rewardSlider; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rewardBtn; // 0xB0
		// [Header] // 0x0000000189B5A7E0-0x0000000189B5A840
		[SerializeField] // 0x0000000189B5A7E0-0x0000000189B5A840
		[Space] // 0x0000000189B5A7E0-0x0000000189B5A840
		private MonoUIContainer _huntingContainer; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _residentContainer; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _exploreContainer; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _questContainer; // 0xD0
		// [Header] // 0x0000000189B7F990-0x0000000189B7F9F0
		[SerializeField] // 0x0000000189B7F990-0x0000000189B7F9F0
		[Space] // 0x0000000189B7F990-0x0000000189B7F9F0
		private UnityEngine.UI.Text _huntingTitle; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _huntingProgress; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _huntingGridScoller; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _huntingNextRefreshTime; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _huntingCheckBtn; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _huntingFetchBtn; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _huntingGiveUpBtn; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _huntingDetailBtn; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _huntingPanelContainer; // 0x118
		// [Header] // 0x0000000189BCA0A0-0x0000000189BCA100
		[SerializeField] // 0x0000000189BCA0A0-0x0000000189BCA100
		[Space] // 0x0000000189BCA0A0-0x0000000189BCA100
		private UnityEngine.UI.Text _residentTitle; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _residentProgress; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _residentGridScoller; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _residentNextRefreshTime; // 0x138
		// [Header] // 0x00000001895F48F0-0x00000001895F4950
		[SerializeField] // 0x00000001895F48F0-0x00000001895F4950
		[Space] // 0x00000001895F48F0-0x00000001895F4950
		private UnityEngine.UI.Text _exploreTitle; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exploreProgress; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _exploreGridScoller; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _exploreFetchBtn; // 0x158
		// [Header] // 0x000000018961A0F0-0x000000018961A140
		[SerializeField] // 0x000000018961A0F0-0x000000018961A140
		[Space] // 0x000000018961A0F0-0x000000018961A140
		private UnityEngine.UI.Text _questTitle; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _questProgress; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _questGridScoller; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _questFetchBtn; // 0x178
	
		// Properties
		public float closeFadeOutDuration { /* [XID] */ /* 0x000000018963F7A0-0x000000018963F7C0 */ get => default; } // 0x000000018443AB10-0x000000018443ABC0 
		public float gotoQuestFadeOutDuration { /* [XID] */ /* 0x0000000189646FA0-0x0000000189646FC0 */ get => default; } // 0x000000018443ADD0-0x000000018443AE80 
		public float expAddDuration { /* [XID] */ /* 0x000000018964E710-0x000000018964E730 */ get => default; } // 0x000000018443ABC0-0x000000018443AC70 
		public Image bgImage { /* [XID] */ /* 0x0000000189655F00-0x0000000189655F20 */ get => default; } // 0x000000018443A9D0-0x000000018443AA70 
		public Image bgMaskImage { /* [XID] */ /* 0x000000018965D6E0-0x000000018965D700 */ get => default; } // 0x000000018443AA70-0x000000018443AB10 
		public RectTransform bgEffectContainer { /* [XID] */ /* 0x0000000189664DE0-0x0000000189664E00 */ get => default; } // 0x000000018443A930-0x000000018443A9D0 
		public string cityText { /* [XID] */ /* 0x000000018966C400-0x000000018966C420 */ set {} } // 0x000000018443B9E0-0x000000018443BAB0
		public string labelText { /* [XID] */ /* 0x00000001896742C0-0x00000001896742E0 */ set {} } // 0x000000018443BEC0-0x000000018443BF90
		public bool ShowLabelText { /* [XID] */ /* 0x000000018967BAA0-0x000000018967BAC0 */ set {} } // 0x000000018443B8D0-0x000000018443B9E0
		public string reputationLevel { /* [XID] */ /* 0x00000001896831B0-0x00000001896831D0 */ set {} } // 0x000000018443C2D0-0x000000018443C3A0
		public string reputationExp { /* [XID] */ /* 0x000000018968AC40-0x000000018968AC60 */ set {} } // 0x000000018443C200-0x000000018443C2D0
		public Image reputationIcon { /* [XID] */ /* 0x0000000189692940-0x0000000189692960 */ get => default; } // 0x000000018443B610-0x000000018443B6C0 
		public float reputationExpProgress { /* [XID] */ /* 0x0000000189699CC0-0x0000000189699CE0 */ set {} } // 0x000000018443C130-0x000000018443C200
		public Button rewardBtn { /* [XID] */ /* 0x00000001896A13E0-0x00000001896A1400 */ get => default; } // 0x000000018443B820-0x000000018443B8D0 
		public MonoUIContainer huntingContainer { /* [XID] */ /* 0x00000001896A8850-0x00000001896A8870 */ get => default; } // 0x000000018443AF30-0x000000018443AFE0 
		public MonoUIContainer residentContainer { /* [XID] */ /* 0x00000001896AFA20-0x00000001896AFA40 */ get => default; } // 0x000000018443B6C0-0x000000018443B770 
		public MonoUIContainer exploreContainer { /* [XID] */ /* 0x00000001896B7390-0x00000001896B73B0 */ get => default; } // 0x000000018443AC70-0x000000018443AD20 
		public MonoUIContainer questContainer { /* [XID] */ /* 0x00000001896BE4C0-0x00000001896BE4E0 */ get => default; } // 0x000000018443B4B0-0x000000018443B560 
		public List<GameObject> panels { /* [XID] */ /* 0x00000001896C5CF0-0x00000001896C5D10 */ get => default; } // 0x000000018443B410-0x000000018443B4B0 
		public MonoUIContainer BtnDescription0 { /* [XID] */ /* 0x00000001896CD460-0x00000001896CD480 */ get => default; } // 0x000000018443A4B0-0x000000018443A570 
		public MonoUIContainer BtnDescription1 { /* [XID] */ /* 0x00000001896D4890-0x00000001896D48B0 */ get => default; } // 0x000000018443A570-0x000000018443A630 
		public MonoUIContainer BtnDescription2 { /* [XID] */ /* 0x00000001896DBF50-0x00000001896DBF70 */ get => default; } // 0x000000018443A630-0x000000018443A6F0 
		public MonoUIContainer BtnDescription3 { /* [XID] */ /* 0x00000001896E36E0-0x00000001896E3700 */ get => default; } // 0x000000018443A6F0-0x000000018443A7B0 
		public MonoUIContainer BtnDescription4 { /* [XID] */ /* 0x00000001896EAB00-0x00000001896EAB20 */ get => default; } // 0x000000018443A7B0-0x000000018443A870 
		public MonoUIContainer BtnReturn0 { /* [XID] */ /* 0x00000001896F1EC0-0x00000001896F1EE0 */ get => default; } // 0x000000018443A870-0x000000018443A930 
		public MonoUIContainer BtnBack1 { /* [XID] */ /* 0x00000001896F9890-0x00000001896F98B0 */ get => default; } // 0x000000018443A1B0-0x000000018443A270 
		public MonoUIContainer BtnBack2 { /* [XID] */ /* 0x00000001897010D0-0x00000001897010F0 */ get => default; } // 0x000000018443A270-0x000000018443A330 
		public MonoUIContainer BtnBack3 { /* [XID] */ /* 0x00000001897087A0-0x00000001897087C0 */ get => default; } // 0x000000018443A330-0x000000018443A3F0 
		public MonoUIContainer BtnBack4 { /* [XID] */ /* 0x0000000189710110-0x0000000189710130 */ get => default; } // 0x000000018443A3F0-0x000000018443A4B0 
		public MonoUIContainer BtnAllGet3 { /* [XID] */ /* 0x00000001897174B0-0x00000001897174D0 */ get => default; } // 0x000000018443A030-0x000000018443A0F0 
		public MonoUIContainer BtnAllGet4 { /* [XID] */ /* 0x000000018971EF30-0x000000018971EF50 */ get => default; } // 0x000000018443A0F0-0x000000018443A1B0 
		public string huntingTitle { /* [XID] */ /* 0x0000000189726510-0x0000000189726530 */ set {} } // 0x000000018443BDF0-0x000000018443BEC0
		public string huntingProgress { /* [XID] */ /* 0x000000018972DAD0-0x000000018972DAF0 */ set {} } // 0x000000018443BD20-0x000000018443BDF0
		public MonoGridScroller huntingGridScoller { /* [XID] */ /* 0x0000000189735250-0x0000000189735270 */ get => default; } // 0x000000018443B1F0-0x000000018443B2A0 
		public string huntingNextRefreshTime { /* [XID] */ /* 0x000000018973CCD0-0x000000018973CCF0 */ set {} } // 0x000000018443BC50-0x000000018443BD20
		public MonoUIContainer huntingFetchBtn { /* [XID] */ /* 0x0000000189744250-0x0000000189744270 */ get => default; } // 0x000000018443B090-0x000000018443B140 
		public MonoUIContainer huntingGiveUpBtn { /* [XID] */ /* 0x000000018974BF50-0x000000018974BF70 */ get => default; } // 0x000000018443B140-0x000000018443B1F0 
		public MonoUIContainer huntingCheckBtn { /* [XID] */ /* 0x0000000189753230-0x0000000189753250 */ get => default; } // 0x000000018443AE80-0x000000018443AF30 
		public MonoUIContainer huntingDetailBtn { /* [XID] */ /* 0x000000018975A630-0x000000018975A650 */ get => default; } // 0x000000018443AFE0-0x000000018443B090 
		public MonoUIContainer huntingPanelContainer { /* [XID] */ /* 0x00000001897622C0-0x00000001897622E0 */ get => default; } // 0x000000018443B2A0-0x000000018443B350 
		public MonoReputationHuntingPanel huntingPanel { /* [XID] */ /* 0x00000001897698C0-0x00000001897698E0 */ get => default; } // 0x000000018443B350-0x000000018443B410 
		public string residentTitle { /* [XID] */ /* 0x0000000189770E10-0x0000000189770E30 */ set {} } // 0x000000018443C540-0x000000018443C610
		public string residentProgress { /* [XID] */ /* 0x00000001897787A0-0x00000001897787C0 */ set {} } // 0x000000018443C470-0x000000018443C540
		public MonoGridScroller residentGridScoller { /* [XID] */ /* 0x000000018977FCE0-0x000000018977FD00 */ get => default; } // 0x000000018443B770-0x000000018443B820 
		public string residentNextRefreshTime { /* [XID] */ /* 0x00000001897875C0-0x00000001897875E0 */ set {} } // 0x000000018443C3A0-0x000000018443C470
		public string exploreTitle { /* [XID] */ /* 0x000000018978EBF0-0x000000018978EC10 */ set {} } // 0x000000018443BB80-0x000000018443BC50
		public string exploreProgress { /* [XID] */ /* 0x00000001897963A0-0x00000001897963C0 */ set {} } // 0x000000018443BAB0-0x000000018443BB80
		public MonoGridScroller exploreGridScoller { /* [XID] */ /* 0x000000018979E470-0x000000018979E490 */ get => default; } // 0x000000018443AD20-0x000000018443ADD0 
		public bool showExploreFetchBtn { /* [XID] */ /* 0x00000001897A5BF0-0x00000001897A5C10 */ set {} } // 0x000000018443C610-0x000000018443C6F0
		public string questTitle { /* [XID] */ /* 0x00000001897AD160-0x00000001897AD180 */ set {} } // 0x000000018443C060-0x000000018443C130
		public string questProgress { /* [XID] */ /* 0x00000001897B5190-0x00000001897B51B0 */ set {} } // 0x000000018443BF90-0x000000018443C060
		public MonoGridScroller questGridScoller { /* [XID] */ /* 0x00000001897BCE00-0x00000001897BCE20 */ get => default; } // 0x000000018443B560-0x000000018443B610 
		public bool showQuestFetchBtn { /* [XID] */ /* 0x00000001897C4180-0x00000001897C41A0 */ set {} } // 0x000000018443C6F0-0x000000018443C7D0
	
		// Constructors
		public MonoReputationPage() {} // 0x0000000184439EC0-0x000000018443A030
	}
}
