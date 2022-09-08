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
	public class MonoDungeonEndDialog : MonoUIProxy // TypeDefIndex: 30533
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _victoryGroup; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _failureGroup; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _successDesc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _failureDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtFactorTitle; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtQuitBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtAgainBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtReviveCount; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtReviveMax; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _recommendedGO; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _recommendList; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _dungeonFactorList; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _recommendScroller; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _victoryTitle; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonBG; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _resinCountText; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _resinCountTextRoot; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _condenseResinCountText; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _condenseResinCountTextRoot; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tipsRoot; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _trialSuccessGO; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTrialSuccess; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _victorySubTitleRoot; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _victorySubTitle; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _victorySubName; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _failureSubTitleRoot; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _failureSubTitle; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _failureSubName; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _failTipsGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _failTips; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _failTipsTitle; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpScore; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtScore; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _scoreNew; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpHighestScore; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtHighestScore; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtWaitForInvite; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTimeChallengeHint; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _scoreIcon; // 0x180
		private bool _isFadeInAniFinish; // 0x188
	
		// Properties
		public MonoSimpleReusableList failTips { /* [XID] */ /* 0x0000000189941E70-0x0000000189941E90 */ get => default; } // 0x0000000183F49020-0x0000000183F490D0 
		public UnityEngine.UI.Text failTipsTitle { /* [XID] */ /* 0x0000000189949950-0x0000000189949970 */ get => default; } // 0x0000000183F48F70-0x0000000183F49020 
		public bool showSubTitle { /* [XID] */ /* 0x0000000189951380-0x00000001899513A0 */ set {} } // 0x0000000183F4A4D0-0x0000000183F4A5D0
		public bool showTrialSuccGrp { /* [XID] */ /* 0x0000000189958970-0x0000000189958990 */ set {} } // 0x0000000183F4A5D0-0x0000000183F4A6C0
		public string subTitle { /* [XID] */ /* 0x000000018995FFD0-0x000000018995FFF0 */ set {} } // 0x0000000183F4A7B0-0x0000000183F4A8A0
		public string subName { /* [XID] */ /* 0x0000000189967A90-0x0000000189967AB0 */ set {} } // 0x0000000183F4A6C0-0x0000000183F4A7B0
		public RectTransform grpScore { /* [XID] */ /* 0x000000018996EC30-0x000000018996EC50 */ get => default; } // 0x0000000183F49220-0x0000000183F492D0 
		public UnityEngine.UI.Text txtScore { /* [XID] */ /* 0x0000000189976830-0x0000000189976850 */ get => default; } // 0x0000000183F49CF0-0x0000000183F49DA0 
		public RectTransform scoreNew { /* [XID] */ /* 0x000000018997DC50-0x000000018997DC70 */ get => default; } // 0x0000000183F497A0-0x0000000183F49850 
		public RectTransform grpHighestScore { /* [XID] */ /* 0x0000000189985600-0x0000000189985620 */ get => default; } // 0x0000000183F49170-0x0000000183F49220 
		public UnityEngine.UI.Text txtHighestScore { /* [XID] */ /* 0x000000018998D3F0-0x000000018998D410 */ get => default; } // 0x0000000183F49A40-0x0000000183F49AF0 
		public UnityEngine.UI.Text txtWaitForInvite { /* [XID] */ /* 0x0000000189994E70-0x0000000189994E90 */ get => default; } // 0x0000000183F49F00-0x0000000183F49FB0 
		public RectTransform tipsRoot { /* [XID] */ /* 0x000000018999C710-0x000000018999C730 */ get => default; } // 0x0000000183F49850-0x0000000183F49900 
		public RectTransform resinCountTextRoot { /* [XID] */ /* 0x00000001899A41C0-0x00000001899A41E0 */ get => default; } // 0x0000000183F494E0-0x0000000183F49590 
		public UnityEngine.UI.Text resinCountText { /* [XID] */ /* 0x00000001899ABBA0-0x00000001899ABBC0 */ get => default; } // 0x0000000183F49590-0x0000000183F49640 
		public RectTransform condenseResinCountTextRoot { /* [XID] */ /* 0x00000001899B34F0-0x00000001899B3510 */ get => default; } // 0x0000000183F48D60-0x0000000183F48E10 
		public UnityEngine.UI.Text condenseResinCountText { /* [XID] */ /* 0x00000001899BA8D0-0x00000001899BA8F0 */ get => default; } // 0x0000000183F48E10-0x0000000183F48EC0 
		public Button buttonBG { /* [XID] */ /* 0x00000001899C21D0-0x00000001899C21F0 */ get => default; } // 0x0000000183F48CB0-0x0000000183F48D60 
		public ScrollRect recommendScroller { /* [XID] */ /* 0x00000001899C98E0-0x00000001899C9900 */ get => default; } // 0x0000000183F49430-0x0000000183F494E0 
		public UnityEngine.UI.Text victoryTitle { /* [XID] */ /* 0x00000001899D1110-0x00000001899D1130 */ get => default; } // 0x0000000183F4A050-0x0000000183F4A100 
		public UnityEngine.UI.Text txtTrialSucc { /* [XID] */ /* 0x00000001899D8620-0x00000001899D8640 */ get => default; } // 0x0000000183F49E50-0x0000000183F49F00 
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x00000001899DFCB0-0x00000001899DFCD0 */ get => default; } // 0x0000000183F49640-0x0000000183F496F0 
		public bool showRecommendContent { /* [XID] */ /* 0x00000001899E76C0-0x00000001899E76E0 */ set {} } // 0x0000000183F4A380-0x0000000183F4A4D0
		public bool showFailTips { /* [XID] */ /* 0x00000001899EEC90-0x00000001899EECB0 */ set {} } // 0x0000000183F4A290-0x0000000183F4A380
		public MonoSimpleReusableList recommendList { /* [XID] */ /* 0x00000001899F6550-0x00000001899F6570 */ get => default; } // 0x0000000183F49380-0x0000000183F49430 
		public MonoSimpleReusableList dungeonFactorList { /* [XID] */ /* 0x00000001899FDA70-0x00000001899FDA90 */ get => default; } // 0x0000000183F48EC0-0x0000000183F48F70 
		public UnityEngine.UI.Text txtFactorTitle { /* [XID] */ /* 0x0000000189A05470-0x0000000189A05490 */ get => default; } // 0x0000000183F499A0-0x0000000183F49A40 
		public UnityEngine.UI.Text SuccessDesc { /* [XID] */ /* 0x0000000189A0C7B0-0x0000000189A0C7D0 */ get => default; } // 0x0000000183F48C10-0x0000000183F48CB0 
		public UnityEngine.UI.Text FailureDesc { /* [XID] */ /* 0x0000000189A14180-0x0000000189A141A0 */ get => default; } // 0x0000000183F48B70-0x0000000183F48C10 
		public UnityEngine.UI.Text txtQuitBtn { /* [XID] */ /* 0x0000000189A1B3D0-0x0000000189A1B3F0 */ get => default; } // 0x0000000183F49AF0-0x0000000183F49B90 
		public bool showAutoQuitLabel { /* [XID] */ /* 0x0000000189A22CD0-0x0000000189A22CF0 */ set {} } // 0x0000000183F4A1B0-0x0000000183F4A290
		public UnityEngine.UI.Text txtAgainBtn { /* [XID] */ /* 0x0000000189A29FA0-0x0000000189A29FC0 */ get => default; } // 0x0000000183F49900-0x0000000183F499A0 
		public UnityEngine.UI.Text txtReviveCount { /* [XID] */ /* 0x0000000189A314A0-0x0000000189A314C0 */ get => default; } // 0x0000000183F49B90-0x0000000183F49C40 
		public UnityEngine.UI.Text txtReviveMax { /* [XID] */ /* 0x0000000189A38F50-0x0000000189A38F70 */ get => default; } // 0x0000000183F49C40-0x0000000183F49CF0 
		public RectTransform victoryGroup { /* [XID] */ /* 0x0000000189A406D0-0x0000000189A406F0 */ get => default; } // 0x0000000183F49FB0-0x0000000183F4A050 
		public RectTransform failureGroup { /* [XID] */ /* 0x0000000189A47DF0-0x0000000189A47E10 */ get => default; } // 0x0000000183F490D0-0x0000000183F49170 
		public MonoUIContainer BtnQuit { /* [XID] */ /* 0x0000000189A56C90-0x0000000189A56CB0 */ get => default; } // 0x0000000183F489F0-0x0000000183F48AB0 
		public MonoUIContainer BtnAgain { /* [XID] */ /* 0x0000000189A5E7E0-0x0000000189A5E800 */ get => default; } // 0x0000000183F48870-0x0000000183F48930 
		public MonoUIContainer BtnRevive { /* [XID] */ /* 0x0000000189A65F60-0x0000000189A65F80 */ get => default; } // 0x0000000183F48AB0-0x0000000183F48B70 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x0000000189A6D5F0-0x0000000189A6D610 */ get => default; } // 0x0000000183F48930-0x0000000183F489F0 
		public bool isFadeInAniFinish { /* [XID] */ /* 0x0000000189A8BBF0-0x0000000189A8BC10 */ get => default; /* [XID] */ /* 0x0000000189A842E0-0x0000000189A84300 */ set {} } // 0x0000000183F492D0-0x0000000183F49380 0x0000000183F4A100-0x0000000183F4A1B0
		public UnityEngine.UI.Text txtTimeChallengeHint { /* [XID] */ /* 0x0000000189A931A0-0x0000000189A931C0 */ get => default; } // 0x0000000183F49DA0-0x0000000183F49E50 
		public Image scoreIcon { /* [XID] */ /* 0x0000000189A9AC00-0x0000000189A9AC20 */ get => default; } // 0x0000000183F496F0-0x0000000183F497A0 
	
		// Constructors
		public MonoDungeonEndDialog() {} // 0x0000000183F48720-0x0000000183F48870
	
		// Methods
		// [XID] // 0x0000000189A4F570-0x0000000189A4F590
		public Animator GetAnimator() => default; // 0x0000000183F48460-0x0000000183F48520
		// [XID] // 0x0000000189A74D70-0x0000000189A74D90
		public void SetBtnActive(MonoUIContainer btnContainer, bool active) {} // 0x0000000183F48600-0x0000000183F48720
		// [XID] // 0x0000000189A7C9C0-0x0000000189A7C9E0
		public void ScrollRecommendScrollToBegin() {} // 0x0000000183F48520-0x0000000183F48600
	}
}
