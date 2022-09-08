/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActivityWaterSpirit : MonoUIProxy // TypeDefIndex: 30284
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _descButton; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _activityTitle; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _activityTimeLeft; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _activityDesc; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _rewardDesc; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollTextDesc; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _challengeGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _challengeExploreButton; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeExploreTitle; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeExploreDesc; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _challengeBossButton; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _challengeBossDescGrp; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _challengeBossLockGrp; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossLockTitle; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossTitle; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossConsume; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossMaterial1Num; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossMaterialOr; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _challengeBossMaterial2Num; // 0xF0
	
		// Properties
		public Transform coinRoot { /* [XID] */ /* 0x000000018988FB20-0x000000018988FB40 */ get => default; } // 0x00000001852ECA90-0x00000001852ECB30 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x0000000189897000-0x0000000189897020 */ get => default; } // 0x00000001852EC020-0x00000001852EC0E0 
		public MonoUIContainer btnExit { /* [XID] */ /* 0x000000018989E540-0x000000018989E560 */ get => default; } // 0x00000001852EBEA0-0x00000001852EBF60 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x00000001898A6060-0x00000001898A6080 */ get => default; } // 0x00000001852EBBA0-0x00000001852EBC60 
		public MonoUIContainer btnOK { /* [XID] */ /* 0x00000001898AD610-0x00000001898AD630 */ get => default; } // 0x00000001852EC0E0-0x00000001852EC1A0 
		public MonoUIContainer btnCheck { /* [XID] */ /* 0x00000001898B4BB0-0x00000001898B4BD0 */ get => default; } // 0x00000001852EBD20-0x00000001852EBDE0 
		public MonoUIContainer btnDesc { /* [XID] */ /* 0x00000001898BC6C0-0x00000001898BC6E0 */ get => default; } // 0x00000001852EBDE0-0x00000001852EBEA0 
		public MonoUIContainer btnExplore { /* [XID] */ /* 0x00000001898C3CA0-0x00000001898C3CC0 */ get => default; } // 0x00000001852EBF60-0x00000001852EC020 
		public MonoUIContainer btnBoss { /* [XID] */ /* 0x00000001898CB520-0x00000001898CB540 */ get => default; } // 0x00000001852EBC60-0x00000001852EBD20 
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x00000001898D2C30-0x00000001898D2C50 */ get => default; } // 0x00000001852ECBD0-0x00000001852ECC70 
		public MonoUIContainer descButton { /* [XID] */ /* 0x00000001898DA540-0x00000001898DA560 */ get => default; } // 0x00000001852ECB30-0x00000001852ECBD0 
		public Text activityTitle { /* [XID] */ /* 0x00000001898E2210-0x00000001898E2230 */ get => default; } // 0x00000001852EBB00-0x00000001852EBBA0 
		public Text activityTimeLeft { /* [XID] */ /* 0x00000001898E9DF0-0x00000001898E9E10 */ get => default; } // 0x00000001852EBA60-0x00000001852EBB00 
		public Text activityDesc { /* [XID] */ /* 0x00000001898F1520-0x00000001898F1540 */ get => default; } // 0x00000001852EB9C0-0x00000001852EBA60 
		public Transform rewardGrp { /* [XID] */ /* 0x00000001898F8CE0-0x00000001898F8D00 */ get => default; } // 0x00000001852ECD10-0x00000001852ECDB0 
		public Text rewardDesc { /* [XID] */ /* 0x0000000189900680-0x00000001899006A0 */ get => default; } // 0x00000001852ECC70-0x00000001852ECD10 
		public ScrollRect scrollTextDesc { /* [XID] */ /* 0x0000000189907DF0-0x0000000189907E10 */ get => default; } // 0x00000001852ECE60-0x00000001852ECF10 
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x000000018990F570-0x000000018990F590 */ get => default; } // 0x00000001852ECDB0-0x00000001852ECE60 
		public Transform challengeGrp { /* [XID] */ /* 0x0000000189916FF0-0x0000000189917010 */ get => default; } // 0x00000001852EC9E0-0x00000001852ECA90 
		public Button challengeExploreButton { /* [XID] */ /* 0x000000018991E710-0x000000018991E730 */ get => default; } // 0x00000001852EC7D0-0x00000001852EC880 
		public Text challengeExploreTitle { /* [XID] */ /* 0x0000000189925F70-0x0000000189925F90 */ get => default; } // 0x00000001852EC930-0x00000001852EC9E0 
		public Text challengeExploreDesc { /* [XID] */ /* 0x000000018992D560-0x000000018992D580 */ get => default; } // 0x00000001852EC880-0x00000001852EC930 
		public Button challengeBossButton { /* [XID] */ /* 0x0000000189934AB0-0x0000000189934AD0 */ get => default; } // 0x00000001852EC1A0-0x00000001852EC250 
		public Transform challengeBossDescGrp { /* [XID] */ /* 0x000000018993C580-0x000000018993C5A0 */ get => default; } // 0x00000001852EC300-0x00000001852EC3B0 
		public Transform challengeBossLockGrp { /* [XID] */ /* 0x0000000189943BF0-0x0000000189943C10 */ get => default; } // 0x00000001852EC3B0-0x00000001852EC460 
		public Text challengeBossLockTitle { /* [XID] */ /* 0x000000018994B0F0-0x000000018994B110 */ get => default; } // 0x00000001852EC460-0x00000001852EC510 
		public Text challengeBossTitle { /* [XID] */ /* 0x0000000189952B20-0x0000000189952B40 */ get => default; } // 0x00000001852EC720-0x00000001852EC7D0 
		public Text challengeBossConsume { /* [XID] */ /* 0x000000018995A050-0x000000018995A070 */ get => default; } // 0x00000001852EC250-0x00000001852EC300 
		public Text challengeBossMaterial1Num { /* [XID] */ /* 0x0000000189961A60-0x0000000189961A80 */ get => default; } // 0x00000001852EC510-0x00000001852EC5C0 
		public Text challengeBossMaterialOr { /* [XID] */ /* 0x0000000189969110-0x0000000189969130 */ get => default; } // 0x00000001852EC670-0x00000001852EC720 
		public Text challengeBossMaterial2Num { /* [XID] */ /* 0x0000000189970BF0-0x0000000189970C10 */ get => default; } // 0x00000001852EC5C0-0x00000001852EC670 
	
		// Constructors
		public MonoActivityWaterSpirit() {} // 0x00000001852EB8D0-0x00000001852EB9C0
	}
}
