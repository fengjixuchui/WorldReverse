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
	public class MonoBattlePassPage : MonoUIProxy // TypeDefIndex: 30988
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _expRoot; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _levelText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _expText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _weeklyExpText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _expMaxRoot; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _expBar; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _titleText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBPRewardPanel _rewardPanel; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBPMissionPanel _missionPanel; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBPStoryPanel _storyPanel; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevBtn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextBtn; // 0xA0
	
		// Properties
		public GameObject expRoot { /* [XID] */ /* 0x00000001898FB9E0-0x00000001898FBA00 */ get => default; } // 0x00000001848FEF30-0x00000001848FEFD0 
		public Text levelText { /* [XID] */ /* 0x00000001899033F0-0x0000000189903410 */ get => default; } // 0x00000001848FF2B0-0x00000001848FF350 
		public Text expText { /* [XID] */ /* 0x000000018990A940-0x000000018990A960 */ get => default; } // 0x00000001848FEFD0-0x00000001848FF070 
		public Text weeklyExpText { /* [XID] */ /* 0x0000000189912590-0x00000001899125B0 */ get => default; } // 0x00000001848FFEF0-0x00000001848FFF90 
		public GameObject expMaxRoot { /* [XID] */ /* 0x0000000189919EA0-0x0000000189919EC0 */ get => default; } // 0x00000001848FEE90-0x00000001848FEF30 
		public MonoProgressBar expBar { /* [XID] */ /* 0x00000001899216E0-0x0000000189921700 */ get => default; } // 0x00000001848FEDF0-0x00000001848FEE90 
		public Text titleText { /* [XID] */ /* 0x0000000189928E00-0x0000000189928E20 */ get => default; } // 0x00000001848FFE50-0x00000001848FFEF0 
		public MonoBPRewardPanel rewardPanel { /* [XID] */ /* 0x0000000189930350-0x0000000189930370 */ get => default; } // 0x00000001848FF950-0x00000001848FFA00 
		public MonoBPMissionPanel missionPanel { /* [XID] */ /* 0x0000000189937810-0x0000000189937830 */ get => default; } // 0x00000001848FF350-0x00000001848FF400 
		public MonoBPStoryPanel storyPanel { /* [XID] */ /* 0x000000018993F330-0x000000018993F350 */ get => default; } // 0x00000001848FFB80-0x00000001848FFC30 
		public MonoUIContainer prevBtn { /* [XID] */ /* 0x0000000189946940-0x0000000189946960 */ get => default; } // 0x00000001848FF570-0x00000001848FF620 
		public MonoUIContainer nextBtn { /* [XID] */ /* 0x000000018994DFE0-0x000000018994E000 */ get => default; } // 0x00000001848FF400-0x00000001848FF4B0 
		public Text timeText { /* [XID] */ /* 0x0000000189955660-0x0000000189955680 */ get => default; } // 0x00000001848FFD40-0x00000001848FFE50 
		public MonoUIContainer returnButton { /* [XID] */ /* 0x000000018995D140-0x000000018995D160 */ get => default; } // 0x00000001848FF7D0-0x00000001848FF890 
		public MonoUIContainer buyButton { /* [XID] */ /* 0x00000001899647E0-0x0000000189964800 */ get => default; } // 0x00000001848FEC70-0x00000001848FED30 
		public MonoUIContainer storyButton { /* [XID] */ /* 0x000000018996BEB0-0x000000018996BED0 */ get => default; } // 0x00000001848FFAC0-0x00000001848FFB80 
		public MonoUIContainer previewButton { /* [XID] */ /* 0x00000001899739A0-0x00000001899739C0 */ get => default; } // 0x00000001848FF620-0x00000001848FF6E0 
		public MonoUIContainer getAllButton { /* [XID] */ /* 0x000000018997AFF0-0x000000018997B010 */ get => default; } // 0x00000001848FF130-0x00000001848FF1F0 
		public MonoUIContainer ruleButton { /* [XID] */ /* 0x0000000189982B00-0x0000000189982B20 */ get => default; } // 0x00000001848FFA00-0x00000001848FFAC0 
		public MonoUIContainer buyLevelButton { /* [XID] */ /* 0x000000018998A2F0-0x000000018998A310 */ get => default; } // 0x00000001848FED30-0x00000001848FEDF0 
		public MonoUIContainer okBtnPS4 { /* [XID] */ /* 0x0000000189991BC0-0x0000000189991BE0 */ get => default; } // 0x00000001848FF4B0-0x00000001848FF570 
		public MonoUIContainer backBtnPS4 { /* [XID] */ /* 0x00000001899998D0-0x00000001899998F0 */ get => default; } // 0x00000001848FEBB0-0x00000001848FEC70 
		public MonoUIContainer gotoBtnPS4 { /* [XID] */ /* 0x00000001899A0FA0-0x00000001899A0FC0 */ get => default; } // 0x00000001848FF1F0-0x00000001848FF2B0 
		public MonoUIContainer rewardInfoBtnPS4 { /* [XID] */ /* 0x00000001899A89F0-0x00000001899A8A10 */ get => default; } // 0x00000001848FF890-0x00000001848FF950 
		public MonoUIContainer fetchBtnPS4 { /* [XID] */ /* 0x00000001899B0310-0x00000001899B0330 */ get => default; } // 0x00000001848FF070-0x00000001848FF130 
		public Transform previewRoot { /* [XID] */ /* 0x00000001899B75E0-0x00000001899B7600 */ get => default; } // 0x00000001848FF6E0-0x00000001848FF7D0 
		public MonoReusableList tabList { /* [XID] */ /* 0x00000001899BF040-0x00000001899BF060 */ get => default; } // 0x00000001848FFC30-0x00000001848FFD40 
	
		// Constructors
		public MonoBattlePassPage() {} // 0x00000001848FEB00-0x00000001848FEBB0
	}
}
