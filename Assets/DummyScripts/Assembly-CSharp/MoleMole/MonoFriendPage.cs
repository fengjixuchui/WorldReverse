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
	public class MonoFriendPage : MonoUIProxy // TypeDefIndex: 30778
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _typeTitleText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _friendList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _friendListPanel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _friendRequestList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _friendAddPanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _multiplayRecentlyList; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _multiplayRecentlyPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _uidInputField; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noFriendTips; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noRequestTips; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noRecentlyTips; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevBtn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextBtn; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Text _currFriendNum; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _totalFriendNum; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _currRequestNum; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _totalRequestNum; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _friendAddInputHighlight; // 0xD0
		private MonoReusableList _tabList; // 0xD8
		public GameObject JoypadKeyList; // 0xE0
	
		// Properties
		public Text typeTitleText { /* [XID] */ /* 0x0000000189680140-0x0000000189680160 */ get => default; } // 0x0000000184AEFD00-0x0000000184AEFDA0 
		public MonoGridScroller friendList { /* [XID] */ /* 0x0000000189687D30-0x0000000189687D50 */ get => default; } // 0x0000000184AEEC50-0x0000000184AEECF0 
		public RectTransform friendListPanel { /* [XID] */ /* 0x000000018968F730-0x000000018968F750 */ get => default; } // 0x0000000184AEEBB0-0x0000000184AEEC50 
		public MonoGridScroller friendRequestList { /* [XID] */ /* 0x0000000189697170-0x0000000189697190 */ get => default; } // 0x0000000184AEECF0-0x0000000184AEED90 
		public RectTransform friendAddPanel { /* [XID] */ /* 0x000000018969E670-0x000000018969E690 */ get => default; } // 0x0000000184AEE990-0x0000000184AEEA30 
		public MonoGridScroller multiplayRecentlyList { /* [XID] */ /* 0x00000001896A5750-0x00000001896A5770 */ get => default; } // 0x0000000184AEEFD0-0x0000000184AEF070 
		public RectTransform multiplayRecentlyPanel { /* [XID] */ /* 0x00000001896ACF70-0x00000001896ACF90 */ get => default; } // 0x0000000184AEF070-0x0000000184AEF110 
		public InputField uidInputField { /* [XID] */ /* 0x00000001896B4590-0x00000001896B45B0 */ get => default; } // 0x0000000184AEFDA0-0x0000000184AEFE50 
		public Text currFriendNum { /* [XID] */ /* 0x00000001896BB810-0x00000001896BB830 */ get => default; } // 0x0000000184AEE6C0-0x0000000184AEE770 
		public Text totalFriendNum { /* [XID] */ /* 0x00000001896C2C60-0x00000001896C2C80 */ get => default; } // 0x0000000184AEFBA0-0x0000000184AEFC50 
		public Text currRequestNum { /* [XID] */ /* 0x00000001896CA180-0x00000001896CA1A0 */ get => default; } // 0x0000000184AEE770-0x0000000184AEE820 
		public Text totalRequestNum { /* [XID] */ /* 0x00000001896D1850-0x00000001896D1870 */ get => default; } // 0x0000000184AEFC50-0x0000000184AEFD00 
		public RectTransform friendAddInputHighlight { /* [XID] */ /* 0x00000001896D9050-0x00000001896D9070 */ get => default; } // 0x0000000184AEE820-0x0000000184AEE8D0 
		public MonoReusableList tabList { /* [XID] */ /* 0x00000001896E08D0-0x00000001896E08F0 */ get => default; } // 0x0000000184AEF970-0x0000000184AEFAE0 
		public MonoUIContainer closeBtn { /* [XID] */ /* 0x00000001896E7B30-0x00000001896E7B50 */ get => default; } // 0x0000000184AEE600-0x0000000184AEE6C0 
		public MonoUIContainer closeBtn2 { /* [XID] */ /* 0x00000001896EF1D0-0x00000001896EF1F0 */ get => default; } // 0x0000000184AEE480-0x0000000184AEE540 
		public MonoUIContainer closeBtn3 { /* [XID] */ /* 0x00000001896F6BE0-0x00000001896F6C00 */ get => default; } // 0x0000000184AEE540-0x0000000184AEE600 
		public MonoUIContainer searchBtn { /* [XID] */ /* 0x00000001896FE4C0-0x00000001896FE4E0 */ get => default; } // 0x0000000184AEF6C0-0x0000000184AEF780 
		public MonoUIContainer pasteBtn { /* [XID] */ /* 0x0000000189705620-0x0000000189705640 */ get => default; } // 0x0000000184AEF3D0-0x0000000184AEF490 
		public MonoUIContainer friendAddYes { /* [XID] */ /* 0x000000018970D120-0x000000018970D140 */ get => default; } // 0x0000000184AEEA30-0x0000000184AEEAF0 
		public MonoUIContainer friendAddNo { /* [XID] */ /* 0x0000000189714550-0x0000000189714570 */ get => default; } // 0x0000000184AEE8D0-0x0000000184AEE990 
		public Dropdown sortTypeDropdown { /* [XID] */ /* 0x000000018971BFD0-0x000000018971BFF0 */ get => default; } // 0x0000000184AEF840-0x0000000184AEF970 
		public MonoUIContainer sortBtn { /* [XID] */ /* 0x0000000189723480-0x00000001897234A0 */ get => default; } // 0x0000000184AEF780-0x0000000184AEF840 
		public RectTransform noFriendTips { /* [XID] */ /* 0x000000018972ABC0-0x000000018972ABE0 */ get => default; } // 0x0000000184AEF1C0-0x0000000184AEF270 
		public RectTransform noRequestTips { /* [XID] */ /* 0x00000001897322D0-0x00000001897322F0 */ get => default; } // 0x0000000184AEF320-0x0000000184AEF3D0 
		public RectTransform noRecentlyTips { /* [XID] */ /* 0x00000001897399C0-0x00000001897399E0 */ get => default; } // 0x0000000184AEF270-0x0000000184AEF320 
		public MonoUIContainer joinBtn { /* [XID] */ /* 0x00000001897415A0-0x00000001897415C0 */ get => default; } // 0x0000000184AEEF10-0x0000000184AEEFD0 
		public MonoUIContainer joinBtn2 { /* [XID] */ /* 0x0000000189748E60-0x0000000189748E80 */ get => default; } // 0x0000000184AEEE50-0x0000000184AEEF10 
		public MonoUIContainer friendDetailBtn { /* [XID] */ /* 0x0000000189750310-0x0000000189750330 */ get => default; } // 0x0000000184AEEAF0-0x0000000184AEEBB0 
		public MonoUIContainer playerDetailBtn2 { /* [XID] */ /* 0x00000001897578B0-0x00000001897578D0 */ get => default; } // 0x0000000184AEF490-0x0000000184AEF550 
		public MonoUIContainer playerDetailBtn { /* [XID] */ /* 0x000000018975F2B0-0x000000018975F2D0 */ get => default; } // 0x0000000184AEF550-0x0000000184AEF610 
		public MonoUIContainer inputBtn { /* [XID] */ /* 0x00000001897666F0-0x0000000189766710 */ get => default; } // 0x0000000184AEED90-0x0000000184AEEE50 
		public MonoUIContainer prevBtn { /* [XID] */ /* 0x000000018976DD70-0x000000018976DD90 */ get => default; } // 0x0000000184AEF610-0x0000000184AEF6C0 
		public MonoUIContainer nextBtn { /* [XID] */ /* 0x0000000189775480-0x00000001897754A0 */ get => default; } // 0x0000000184AEF110-0x0000000184AEF1C0 
		public MonoUIContainer blacklistBtn { /* [XID] */ /* 0x000000018977CD30-0x000000018977CD50 */ get => default; } // 0x0000000184AEE3C0-0x0000000184AEE480 
		public MonoUIContainer talkPS4 { /* [XID] */ /* 0x0000000189784750-0x0000000189784770 */ get => default; } // 0x0000000184AEFAE0-0x0000000184AEFBA0 
	
		// Constructors
		public MonoFriendPage() {} // 0x0000000184AEE2E0-0x0000000184AEE3C0
	}
}
