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
	public class MonoHomeworldLevelPage : MonoUIProxy // TypeDefIndex: 30257
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _homeworldLevelPage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _imgBg; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _bGImgBg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _keyL1; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _keyR1; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnHomeCU; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _shopMaterialsItem; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _keyHomeCoin; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAdsorbEffect2DController _homeCUGetEffect; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _homeLevelGrp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _levelRewardGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textHomeCoin; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textHomeworldLevel; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textHomeworldExp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _expBar; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textModule; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textComfort; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textComfortLevelName; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textHomeCoinToGet; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _homeCUTipsGrp; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _homeCUMaxGrp; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _homeCUStoreStates; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _levelRewardGetGrp; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _levelRewardNotReachedGrp; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _levelRewardReceivedGrp; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _levelRewardReceivedPS4Grp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCentreScroller _levelCentreScroller; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _levelFunctionList; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _djinnLevelUpGrp; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _djinnLevelTrans; // 0x130
		public int coinEffectMinNum; // 0x138
		public int coinEffectMaxNum; // 0x13C
	
		// Properties
		public UnityEngine.UI.Text textHomeCoin { /* [XID] */ /* 0x0000000189788E10-0x0000000189788E30 */ get => default; } // 0x00000001846F6520-0x00000001846F65D0 
		public UnityEngine.UI.Text textHomeworldLevel { /* [XID] */ /* 0x0000000189790400-0x0000000189790420 */ get => default; } // 0x00000001846F6680-0x00000001846F6730 
		public UnityEngine.UI.Text textHomeworldExp { /* [XID] */ /* 0x0000000189797D70-0x0000000189797D90 */ get => default; } // 0x00000001846F65D0-0x00000001846F6680 
		public SmoothMask expBar { /* [XID] */ /* 0x000000018979FA50-0x000000018979FA70 */ get => default; } // 0x00000001846F6050-0x00000001846F6100 
		public UnityEngine.UI.Text textModule { /* [XID] */ /* 0x00000001897A7050-0x00000001897A7070 */ get => default; } // 0x00000001846F6730-0x00000001846F67E0 
		public UnityEngine.UI.Text textComfort { /* [XID] */ /* 0x00000001897AE9C0-0x00000001897AE9E0 */ get => default; } // 0x00000001846F63C0-0x00000001846F6470 
		public UnityEngine.UI.Text textComfortLevelName { /* [XID] */ /* 0x00000001897B6850-0x00000001897B6870 */ get => default; } // 0x00000001846F6310-0x00000001846F63C0 
		public UnityEngine.UI.Text textHomeCoinToGet { /* [XID] */ /* 0x00000001897BE6B0-0x00000001897BE6D0 */ get => default; } // 0x00000001846F6470-0x00000001846F6520 
		public MonoCentreScroller levelCentreScroller { /* [XID] */ /* 0x00000001897C5D40-0x00000001897C5D60 */ get => default; } // 0x00000001846F6100-0x00000001846F61B0 
		public MonoSimpleReusableList levelFunctionList { /* [XID] */ /* 0x00000001897CD560-0x00000001897CD580 */ get => default; } // 0x00000001846F61B0-0x00000001846F6260 
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x00000001897D4B60-0x00000001897D4B80 */ get => default; } // 0x00000001846F6260-0x00000001846F6310 
		public bool ShowDjinnLevelUpGrp { /* [XID] */ /* 0x00000001897DC1E0-0x00000001897DC200 */ set {} } // 0x00000001846F6AE0-0x00000001846F6BC0
		public bool SwitchLevelReward { /* [XID] */ /* 0x00000001897F3040-0x00000001897F3060 */ set {} } // 0x00000001846F6BC0-0x00000001846F6CC0
		public bool SetHomeCUMax { /* [XID] */ /* 0x00000001897FA8F0-0x00000001897FA910 */ set {} } // 0x00000001846F67E0-0x00000001846F68E0
		public bool SetLevelRewardReached { /* [XID] */ /* 0x0000000189801F00-0x0000000189801F20 */ set {} } // 0x00000001846F68E0-0x00000001846F69E0
		public bool SetLevelRewardReceived { /* [XID] */ /* 0x0000000189809350-0x0000000189809370 */ set {} } // 0x00000001846F69E0-0x00000001846F6AE0
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x0000000189810B80-0x0000000189810BA0 */ get => default; } // 0x00000001846F5F90-0x00000001846F6050 
		public MonoUIContainer btnDescription { /* [XID] */ /* 0x0000000189818630-0x0000000189818650 */ get => default; } // 0x00000001846F5BD0-0x00000001846F5C90 
		public MonoUIContainer btnComfortTips { /* [XID] */ /* 0x000000018981FE80-0x000000018981FEA0 */ get => default; } // 0x00000001846F5B10-0x00000001846F5BD0 
		public MonoUIContainer btnHomeCU { /* [XID] */ /* 0x0000000189827460-0x0000000189827480 */ get => default; } // 0x00000001846F5D50-0x00000001846F5E10 
		public MonoUIContainer btnLevelReward { /* [XID] */ /* 0x000000018982E6E0-0x000000018982E700 */ get => default; } // 0x00000001846F5ED0-0x00000001846F5F90 
		public MonoUIContainer btnBackLevelReward { /* [XID] */ /* 0x0000000189836060-0x0000000189836080 */ get => default; } // 0x00000001846F5A50-0x00000001846F5B10 
		public MonoUIContainer btnFetchLevelReward { /* [XID] */ /* 0x000000018983D590-0x000000018983D5B0 */ get => default; } // 0x00000001846F5C90-0x00000001846F5D50 
		public MonoUIContainer btnItemDetailLevelReward { /* [XID] */ /* 0x0000000189844DD0-0x0000000189844DF0 */ get => default; } // 0x00000001846F5E10-0x00000001846F5ED0 
	
		// Constructors
		public MonoHomeworldLevelPage() {} // 0x00000001846F5910-0x00000001846F5A50
	
		// Methods
		// [XID] // 0x00000001897E3B30-0x00000001897E3B50
		public void SetDjinnLevel(int index) {} // 0x00000001846F5670-0x00000001846F57C0
		// [XID] // 0x00000001897EB7C0-0x00000001897EB7E0
		public void SetHomeCUStoreState(int state) {} // 0x00000001846F57C0-0x00000001846F5910
		// [XID] // 0x000000018984C1E0-0x000000018984C200
		public MonoElementSwitch GetHomeworldLevelPage() => default; // 0x00000001846F52B0-0x00000001846F5350
		// [XID] // 0x00000001898533B0-0x00000001898533D0
		public MonoUIContainer GetImgBg() => default; // 0x00000001846F5350-0x00000001846F53F0
		// [XID] // 0x000000018985AE40-0x000000018985AE60
		public MonoUIContainer GetBGImgBg() => default; // 0x00000001846F50C0-0x00000001846F5160
		// [XID] // 0x00000001898622E0-0x0000000189862300
		public MonoUIContainer GetKeyL1() => default; // 0x00000001846F5490-0x00000001846F5530
		// [XID] // 0x0000000189869770-0x0000000189869790
		public MonoUIContainer GetKeyR1() => default; // 0x00000001846F5530-0x00000001846F55D0
		// [XID] // 0x0000000189870970-0x0000000189870990
		public MonoUIContainer GetKeyHomeCoin() => default; // 0x00000001846F53F0-0x00000001846F5490
		// [XID] // 0x0000000189878400-0x0000000189878420
		public MonoAdsorbEffect2DController GetHomeCUGetEffect() => default; // 0x00000001846F5200-0x00000001846F52B0
		// [XID] // 0x000000018987F910-0x000000018987F930
		public Button GetShopMaterialsItem() => default; // 0x00000001846F55D0-0x00000001846F5670
		// [XID] // 0x0000000189886F60-0x0000000189886F80
		public Button GetBtnHomeCU() => default; // 0x00000001846F5160-0x00000001846F5200
	}
}
