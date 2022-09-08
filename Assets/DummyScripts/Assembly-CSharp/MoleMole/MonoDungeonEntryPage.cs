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
	public class MonoDungeonEntryPage : MonoUIProxy // TypeDefIndex: 30996
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _dungeonSelectionScroller; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _previewImage; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descriptionLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _openTimeLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _descriptionScroll; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _possibleRewardGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _possibleRewardLabel; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _refreshRewardLabel; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _possibleRewardScroller; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _tipsGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _tipsBackground; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsLimitLevel; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _tipsLabel; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockIcon; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockIconText; // 0xC0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _entryCountGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _entryCountLabel; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _rewardKeyIcon; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _rewardKeyBtn; // 0xE0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _recommendElementsGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _recommendElementsLabel; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _recommendElementsList; // 0xF8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _restrictionTipsGrp; // 0x100
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.Material _greyMaterial; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMaterialItemRow _resinRow; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dungeonEntryTipsBtn; // 0x118
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _grpOnlineMatching; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _matchingTimeLabel; // 0x128
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _trialCharacterGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _trialCharacterScroller; // 0x138
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _grpBossTips; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _bossList; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bossTitle; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bossDesc; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _materialList; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _subType; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoWeeklyBossResinDiscountInfo _weeklyBossResinDiscountMono; // 0x170
		private bool? _passed; // 0x178
	
		// Properties
		public RectTransform grpOnlineMatching { /* [XID] */ /* 0x0000000189AB5710-0x0000000189AB5730 */ get => default; } // 0x0000000183F4BEB0-0x0000000183F4BF60 
		public UnityEngine.UI.Text matchingTimeLabel { /* [XID] */ /* 0x0000000189ABD110-0x0000000189ABD130 */ get => default; } // 0x0000000183F4BF60-0x0000000183F4C010 
		public bool showCloseBtnGrp { /* [XID] */ /* 0x0000000189AC4BA0-0x0000000189AC4BC0 */ set {} } // 0x0000000183F4D3D0-0x0000000183F4D4E0
		public Button closeButton { /* [XID] */ /* 0x0000000189ACC220-0x0000000189ACC240 */ get => default; } // 0x0000000183F4BB40-0x0000000183F4BC00 
		public bool showStartBtnGrp { /* [XID] */ /* 0x0000000189AD3D00-0x0000000189AD3D20 */ set {} } // 0x0000000183F4DBF0-0x0000000183F4DD00
		public Button startButton { /* [XID] */ /* 0x0000000189ADB7E0-0x0000000189ADB800 */ get => default; } // 0x0000000183F4C610-0x0000000183F4C6D0 
		public string startButtonText { /* [XID] */ /* 0x0000000189AE30A0-0x0000000189AE30C0 */ set {} } // 0x0000000183F4DF20-0x0000000183F4E000
		public bool showItemInfoBtn { /* [XID] */ /* 0x0000000189AEAA50-0x0000000189AEAA70 */ set {} } // 0x0000000183F4D5C0-0x0000000183F4D6C0
		public MonoUIContainer multiplayerButton { /* [XID] */ /* 0x0000000189AF2340-0x0000000189AF2360 */ get => default; } // 0x0000000183F4C0C0-0x0000000183F4C1D0 
		public Button cancelmatchButton { /* [XID] */ /* 0x0000000189AF9CC0-0x0000000189AF9CE0 */ get => default; } // 0x0000000183F4BA80-0x0000000183F4BB40 
		public bool showMultiplayerBtn { /* [XID] */ /* 0x0000000189B011F0-0x0000000189B01210 */ set {} } // 0x0000000183F4D7A0-0x0000000183F4D870
		public bool showCancelmatchBtn { /* [XID] */ /* 0x0000000189B08740-0x0000000189B08760 */ set {} } // 0x0000000183F4D300-0x0000000183F4D3D0
		public MonoGridScroller dungeonSelectionScroller { /* [XID] */ /* 0x0000000189B10080-0x0000000189B100A0 */ get => default; } // 0x0000000183F4BCB0-0x0000000183F4BD50 
		public MonoGridScroller possibleRewardScroller { /* [XID] */ /* 0x0000000189B171E0-0x0000000189B17200 */ get => default; } // 0x0000000183F4C1D0-0x0000000183F4C280 
		public string dungeonName { /* [XID] */ /* 0x0000000189B1EB60-0x0000000189B1EB80 */ set {} } // 0x0000000183F4CAE0-0x0000000183F4CBB0
		public Sprite previewImage { /* [XID] */ /* 0x0000000189B26450-0x0000000189B26470 */ set {} } // 0x0000000183F4D0A0-0x0000000183F4D160
		public string description { /* [XID] */ /* 0x0000000189B2D6D0-0x0000000189B2D6F0 */ set {} } // 0x0000000183F4C990-0x0000000183F4CAE0
		public bool needTips { /* [XID] */ /* 0x0000000189B34BA0-0x0000000189B34BC0 */ set {} } // 0x0000000183F4CD60-0x0000000183F4CE60
		public Color tipsBackground { /* [XID] */ /* 0x0000000189B3C3B0-0x0000000189B3C3D0 */ set {} } // 0x0000000183F4E000-0x0000000183F4E0E0
		public uint tipsLimitLevel { /* [XID] */ /* 0x0000000189B44020-0x0000000189B44040 */ set {} } // 0x0000000183F4E1F0-0x0000000183F4E340
		public bool showTipsLimitLevel { /* [XID] */ /* 0x0000000189B4B720-0x0000000189B4B740 */ set {} } // 0x0000000183F4DE10-0x0000000183F4DF20
		public bool showTipsLabel { /* [XID] */ /* 0x0000000189B52D90-0x0000000189B52DB0 */ set {} } // 0x0000000183F4DD00-0x0000000183F4DE10
		public bool showLockIcon { /* [XID] */ /* 0x0000000189B5A720-0x0000000189B5A740 */ set {} } // 0x0000000183F4D6C0-0x0000000183F4D7A0
		public string tipsContentID { /* [XID] */ /* 0x0000000189B61C10-0x0000000189B61C30 */ set {} } // 0x0000000183F4E0E0-0x0000000183F4E1F0
		public string lockIconText { /* [XID] */ /* 0x0000000189B698A0-0x0000000189B698C0 */ set {} } // 0x0000000183F4CC80-0x0000000183F4CD60
		public bool passed { /* [XID] */ /* 0x0000000189B70E80-0x0000000189B70EA0 */ set {} } // 0x0000000183F4CF30-0x0000000183F4D0A0
		public bool showPossibleRewardGrp { /* [XID] */ /* 0x0000000189B78430-0x0000000189B78450 */ set {} } // 0x0000000183F4D950-0x0000000183F4DA30
		public UnityEngine.UI.Text refreshRewardLabel { /* [XID] */ /* 0x0000000189B7F8F0-0x0000000189B7F910 */ get => default; } // 0x0000000183F4C330-0x0000000183F4C3E0 
		public bool showEntryCount { /* [XID] */ /* 0x0000000189B87440-0x0000000189B87460 */ set {} } // 0x0000000183F4D4E0-0x0000000183F4D5C0
		public string entryCountText { /* [XID] */ /* 0x0000000189B8E510-0x0000000189B8E530 */ set {} } // 0x0000000183F4CBB0-0x0000000183F4CC80
		public bool showRecommendElementsGrp { /* [XID] */ /* 0x0000000189B959D0-0x0000000189B959F0 */ set {} } // 0x0000000183F4DA30-0x0000000183F4DB10
		public string recommendElementsTitle { /* [XID] */ /* 0x0000000189B9CF70-0x0000000189B9CF90 */ set {} } // 0x0000000183F4D160-0x0000000183F4D230
		public MonoReusableList recommendElementsList { /* [XID] */ /* 0x0000000189BA4890-0x0000000189BA48B0 */ get => default; } // 0x0000000183F4C280-0x0000000183F4C330 
		public bool showOpenTimeGrp { /* [XID] */ /* 0x0000000189BABBB0-0x0000000189BABBD0 */ get => default; /* [XID] */ /* 0x0000000189BB32A0-0x0000000189BB32C0 */ set {} } // 0x0000000183F4C540-0x0000000183F4C610 0x0000000183F4D870-0x0000000183F4D950
		public string openTime { /* [XID] */ /* 0x0000000189BBA880-0x0000000189BBA8A0 */ set {} } // 0x0000000183F4CE60-0x0000000183F4CF30
		public bool showRestrictionTipsGrp { /* [XID] */ /* 0x0000000189BC28A0-0x0000000189BC28C0 */ set {} } // 0x0000000183F4DB10-0x0000000183F4DBF0
		public Sprite rewardKeyIcon { /* [XID] */ /* 0x0000000189BCA000-0x0000000189BCA020 */ set {} } // 0x0000000183F4D230-0x0000000183F4D300
		public Button rewardKeyButton { /* [XID] */ /* 0x0000000189BD16D0-0x0000000189BD16F0 */ get => default; } // 0x0000000183F4C490-0x0000000183F4C540 
		public UnityEngine.Material greyMaterial { /* [XID] */ /* 0x0000000189BD8CC0-0x0000000189BD8CE0 */ get => default; } // 0x0000000183F4BD50-0x0000000183F4BE00 
		public MonoMaterialItemRow resinRow { /* [XID] */ /* 0x00000001895E58A0-0x00000001895E58C0 */ get => default; } // 0x0000000183F4C3E0-0x0000000183F4C490 
		public MonoUIContainer dungeonEntryTipsBtn { /* [XID] */ /* 0x00000001895ED1F0-0x00000001895ED210 */ get => default; } // 0x0000000183F4BC00-0x0000000183F4BCB0 
		public Transform trialCharacterGrp { /* [XID] */ /* 0x00000001895F4870-0x00000001895F4890 */ get => default; } // 0x0000000183F4C780-0x0000000183F4C830 
		public MonoGridScroller trialCharacterScroller { /* [XID] */ /* 0x00000001895FBFE0-0x00000001895FC000 */ get => default; } // 0x0000000183F4C830-0x0000000183F4C8E0 
		public RectTransform grpBossTips { /* [XID] */ /* 0x0000000189603A20-0x0000000189603A40 */ get => default; } // 0x0000000183F4BE00-0x0000000183F4BEB0 
		public MonoReusableList bossList { /* [XID] */ /* 0x000000018960B380-0x000000018960B3A0 */ get => default; } // 0x0000000183F4B5F0-0x0000000183F4B6A0 
		public UnityEngine.UI.Text bossTitle { /* [XID] */ /* 0x0000000189612730-0x0000000189612750 */ get => default; } // 0x0000000183F4B6A0-0x0000000183F4B750 
		public UnityEngine.UI.Text bossDesc { /* [XID] */ /* 0x000000018961A050-0x000000018961A070 */ get => default; } // 0x0000000183F4B540-0x0000000183F4B5F0 
		public MonoSimpleReusableList materialList { /* [XID] */ /* 0x0000000189621590-0x00000001896215B0 */ get => default; } // 0x0000000183F4C010-0x0000000183F4C0C0 
		public RectTransform subType { /* [XID] */ /* 0x0000000189628EA0-0x0000000189628EC0 */ get => default; } // 0x0000000183F4C6D0-0x0000000183F4C780 
		public MonoUIContainer btnPreview { /* [XID] */ /* 0x0000000189630820-0x0000000189630840 */ get => default; } // 0x0000000183F4B970-0x0000000183F4BA80 
		public MonoUIContainer btnDescription { /* [XID] */ /* 0x00000001896382C0-0x00000001896382E0 */ get => default; } // 0x0000000183F4B750-0x0000000183F4B860 
		public MonoWeeklyBossResinDiscountInfo weeklyBossResinDiscountMono { /* [XID] */ /* 0x000000018963F6A0-0x000000018963F6C0 */ get => default; } // 0x0000000183F4C8E0-0x0000000183F4C990 
		public MonoUIContainer btnHalfTips { /* [XID] */ /* 0x0000000189646E60-0x0000000189646E80 */ get => default; } // 0x0000000183F4B860-0x0000000183F4B970 
	
		// Constructors
		public MonoDungeonEntryPage() {} // 0x0000000183F4B3D0-0x0000000183F4B540
	}
}
