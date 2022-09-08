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
	public class MonoActivityChannellerSlabDungeonPage : MonoUIProxy // TypeDefIndex: 30178
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _activityChannellerSlabDungeonPage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _imgBg; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _factorList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnItemDetailPS4; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnSelectDifficultyPS4; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReturnPS4; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _channellerSlabContent; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _difficulty; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dropdown; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _restrictionsScrollView; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnChallenge; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnChallengePS4; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnSelectPS4; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _grpActionPS4BtnBackPS4; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnRewardInfo; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReturn; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnBack; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSelectStage; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpStageBestScore; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textStageBestScore; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpStageLocked; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textStageLocked; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textStageName; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpSelectDifficulty; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultyScoreRatio; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultyBestScore; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultySuccessScore; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultySelectedRestrictionCount; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _timeRestrictionList; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _monsterHpRestrictionList; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _restrictionList; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _scrollRectExtension; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpStageSelectHint; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _stageList; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _totScore; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDungeonTitle; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultyDungeonTitle; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textDifficultyBaseScore; // 0x178
	
		// Properties
		public GameObject grpSelectStage { /* [XID] */ /* 0x000000018968AC80-0x000000018968ACA0 */ get => default; } // 0x00000001863089E0-0x0000000186308A90 
		public MonoSimpleReusableList stageList { /* [XID] */ /* 0x0000000189692980-0x00000001896929A0 */ get => default; } // 0x0000000186308EB0-0x0000000186308F60 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189699D20-0x0000000189699D40 */ get => default; } // 0x0000000186308D50-0x0000000186308E00 
		public MonoReusableList totScore { /* [XID] */ /* 0x00000001896A1440-0x00000001896A1460 */ get => default; } // 0x0000000186309010-0x00000001863090C0 
		public GameObject grpStageBestScore { /* [XID] */ /* 0x00000001896A88D0-0x00000001896A88F0 */ get => default; } // 0x0000000186308A90-0x0000000186308B40 
		public string textStageBestScore { /* [XID] */ /* 0x00000001896AFAA0-0x00000001896AFAC0 */ set {} } // 0x0000000186309670-0x0000000186309740
		public GameObject grpStageLocked { /* [XID] */ /* 0x00000001896B7410-0x00000001896B7430 */ get => default; } // 0x0000000186308B40-0x0000000186308BF0 
		public string textStageLocked { /* [XID] */ /* 0x00000001896BE540-0x00000001896BE560 */ set {} } // 0x0000000186309740-0x0000000186309810
		public string textStageName { /* [XID] */ /* 0x00000001896C5D70-0x00000001896C5D90 */ set {} } // 0x0000000186309810-0x00000001863098E0
		public GameObject grpSelectDifficulty { /* [XID] */ /* 0x00000001896CD4C0-0x00000001896CD4E0 */ get => default; } // 0x0000000186308880-0x0000000186308930 
		public string textDifficultyScoreRatio { /* [XID] */ /* 0x00000001896D48F0-0x00000001896D4910 */ set {} } // 0x0000000186309330-0x0000000186309400
		public string textDifficultyBestScore { /* [XID] */ /* 0x00000001896DBF90-0x00000001896DBFB0 */ set {} } // 0x0000000186309190-0x0000000186309260
		public string textDifficultySuccessScore { /* [XID] */ /* 0x00000001896E3720-0x00000001896E3740 */ set {} } // 0x00000001863094D0-0x00000001863095A0
		public string textDifficultySelectedRestrictionCount { /* [XID] */ /* 0x00000001896EAB70-0x00000001896EAB90 */ set {} } // 0x0000000186309400-0x00000001863094D0
		public MonoSimpleReusableList timeRestrictionList { /* [XID] */ /* 0x00000001896F1F20-0x00000001896F1F40 */ get => default; } // 0x0000000186308F60-0x0000000186309010 
		public MonoSimpleReusableList monsterHpRestrictionList { /* [XID] */ /* 0x00000001896F9900-0x00000001896F9920 */ get => default; } // 0x0000000186308BF0-0x0000000186308CA0 
		public MonoSimpleReusableList restrictionList { /* [XID] */ /* 0x0000000189701110-0x0000000189701130 */ get => default; } // 0x0000000186308CA0-0x0000000186308D50 
		public MonoScrollRectExtention scrollRectExtension { /* [XID] */ /* 0x0000000189708800-0x0000000189708820 */ get => default; } // 0x0000000186308E00-0x0000000186308EB0 
		public GameObject grpSelectStageHint { /* [XID] */ /* 0x0000000189710130-0x0000000189710150 */ get => default; } // 0x0000000186308930-0x00000001863089E0 
		public string textDungeonTitle { /* [XID] */ /* 0x00000001897174F0-0x0000000189717510 */ set {} } // 0x00000001863095A0-0x0000000186309670
		public string textDifficultyDungeonTitle { /* [XID] */ /* 0x000000018971EFB0-0x000000018971EFD0 */ set {} } // 0x0000000186309260-0x0000000186309330
		public string textDifficultyBaseScore { /* [XID] */ /* 0x00000001897265D0-0x00000001897265F0 */ set {} } // 0x00000001863090C0-0x0000000186309190
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x000000018972DB10-0x000000018972DB30 */ get => default; } // 0x0000000186308400-0x00000001863084C0 
		public MonoUIContainer btnSelectDifficultyStage { /* [XID] */ /* 0x0000000189735290-0x00000001897352B0 */ get => default; } // 0x0000000186308580-0x0000000186308640 
		public MonoUIContainer btnOKStage { /* [XID] */ /* 0x000000018973CD10-0x000000018973CD30 */ get => default; } // 0x0000000186308280-0x0000000186308340 
		public MonoUIContainer btnBackStage { /* [XID] */ /* 0x0000000189744290-0x00000001897442B0 */ get => default; } // 0x0000000186307EC0-0x0000000186307F80 
		public MonoUIContainer btnFetchStage { /* [XID] */ /* 0x000000018974BF70-0x000000018974BF90 */ get => default; } // 0x0000000186308100-0x00000001863081C0 
		public MonoUIContainer btnItemDetailStage { /* [XID] */ /* 0x0000000189753250-0x0000000189753270 */ get => default; } // 0x00000001863081C0-0x0000000186308280 
		public MonoUIContainer btnRewardInfo { /* [XID] */ /* 0x000000018975A650-0x000000018975A670 */ get => default; } // 0x00000001863084C0-0x0000000186308580 
		public MonoUIContainer btnBackDifficulty { /* [XID] */ /* 0x0000000189762300-0x0000000189762320 */ get => default; } // 0x0000000186307E00-0x0000000186307EC0 
		public MonoUIContainer btnSelectDifficulty { /* [XID] */ /* 0x0000000189769900-0x0000000189769920 */ get => default; } // 0x0000000186308640-0x0000000186308700 
		public MonoUIContainer btnChallengeDifficulty { /* [XID] */ /* 0x0000000189770E70-0x0000000189770E90 */ get => default; } // 0x0000000186307F80-0x0000000186308040 
		public MonoUIContainer btnPlate { /* [XID] */ /* 0x0000000189778800-0x0000000189778820 */ get => default; } // 0x0000000186308340-0x0000000186308400 
		public MonoUIContainer btnCheck { /* [XID] */ /* 0x000000018977FD40-0x000000018977FD60 */ get => default; } // 0x0000000186308040-0x0000000186308100 
		public MonoUIContainer btnTabL1 { /* [XID] */ /* 0x0000000189787620-0x0000000189787640 */ get => default; } // 0x0000000186308700-0x00000001863087C0 
		public MonoUIContainer btnTabR1 { /* [XID] */ /* 0x000000018978EC50-0x000000018978EC70 */ get => default; } // 0x00000001863087C0-0x0000000186308880 
	
		// Constructors
		public MonoActivityChannellerSlabDungeonPage() {} // 0x0000000186307C90-0x0000000186307E00
	
		// Methods
		// [XID] // 0x0000000189796400-0x0000000189796420
		public MonoElementSwitch GetActivityChannellerSlabDungeonPage() => default; // 0x00000001863070B0-0x0000000186307150
		// [XID] // 0x000000018979E4D0-0x000000018979E4F0
		public MonoUIContainer GetImgBg() => default; // 0x0000000186307AA0-0x0000000186307B40
		// [XID] // 0x00000001897A5C50-0x00000001897A5C70
		public MonoSimpleReusableList GetFactorList() => default; // 0x0000000186307950-0x00000001863079F0
		// [XID] // 0x00000001897AD1C0-0x00000001897AD1E0
		public MonoSimpleReusableList GetMonsterList() => default; // 0x0000000186307B40-0x0000000186307BE0
		// [XID] // 0x00000001897B51F0-0x00000001897B5210
		public MonoUIContainer GetBtnItemDetailPS4() => default; // 0x0000000186307360-0x0000000186307400
		// [XID] // 0x00000001897BCE60-0x00000001897BCE80
		public MonoUIContainer GetBtnSelectDifficultyPS4() => default; // 0x0000000186307600-0x00000001863076A0
		// [XID] // 0x00000001897C41E0-0x00000001897C4200
		public MonoUIContainer GetBtnReturnPS4() => default; // 0x0000000186307400-0x00000001863074A0
		// [XID] // 0x00000001897CBA60-0x00000001897CBA80
		public MonoUIContainer GetChannellerSlabContent() => default; // 0x0000000186307750-0x00000001863077F0
		// [XID] // 0x00000001897D3370-0x00000001897D3390
		public Button GetDifficulty() => default; // 0x00000001863077F0-0x00000001863078A0
		// [XID] // 0x00000001897DADD0-0x00000001897DADF0
		public MonoUIContainer GetDropdown() => default; // 0x00000001863078A0-0x0000000186307950
		// [XID] // 0x00000001897E24E0-0x00000001897E2500
		public MonoGridScroller GetRestrictionsScrollView() => default; // 0x0000000186307BE0-0x0000000186307C90
		// [XID] // 0x00000001897E9C50-0x00000001897E9C70
		public MonoUIContainer GetBtnChallenge() => default; // 0x00000001863072B0-0x0000000186307360
		// [XID] // 0x00000001897F1910-0x00000001897F1930
		public MonoUIContainer GetBtnChallengePS4() => default; // 0x0000000186307200-0x00000001863072B0
		// [XID] // 0x00000001897F9060-0x00000001897F9080
		public MonoUIContainer GetBtnSelectPS4() => default; // 0x00000001863076A0-0x0000000186307750
		// [XID] // 0x0000000189800670-0x0000000189800690
		public MonoUIContainer GetGrpActionPS4BtnBackPS4() => default; // 0x00000001863079F0-0x0000000186307AA0
		// [XID] // 0x0000000189807CF0-0x0000000189807D10
		public MonoUIContainer GetBtnRewardInfo() => default; // 0x0000000186307550-0x0000000186307600
		// [XID] // 0x000000018980F5F0-0x000000018980F610
		public MonoUIContainer GetBtnReturn() => default; // 0x00000001863074A0-0x0000000186307550
		// [XID] // 0x0000000189816C60-0x0000000189816C80
		public MonoUIContainer GetBtnBack() => default; // 0x0000000186307150-0x0000000186307200
	}
}
