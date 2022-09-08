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
	public class MonoCookingPage : MonoUIProxy // TypeDefIndex: 30992
	{
		// Fields
		private const string ITEM_TIP_PREFAB_ROOT = "ART/UI/Menus/Widget/CookingPage/ItemTips_Cooking"; // Metadata: 0x00B11BB7
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _typeTitleText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCostLabel _weightLabel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _prevBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _nextBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _itemTipRoot; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookPanel _cookPanel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookPanel _compoundPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _closeBtn; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _haveText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _canMakeText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noItemRoot; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0xA8
		private MonoReusableList _tabList; // 0xB0
		private MonoCookingItemTip _cookItemTip; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _sortRoot; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _screenBackBtn; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanelRoot; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _screeningPanel; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screeningScroller; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectItemTipsObj; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadNavRegionBase _mainRegion; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadScrollRect _itemTipScrollRectHandler; // 0xF8
		private Vector2 _begin; // 0x100
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189B61C30-0x0000000189B61C50 */ get => default; } // 0x0000000184BBBF10-0x0000000184BBBFB0 
		public UnityEngine.UI.Text typeTitleText { /* [XID] */ /* 0x0000000189B698C0-0x0000000189B698E0 */ get => default; } // 0x0000000184BBBFB0-0x0000000184BBC050 
		public MonoCostLabel weightLabel { /* [XID] */ /* 0x0000000189B70EA0-0x0000000189B70EC0 */ get => default; } // 0x0000000184BBC050-0x0000000184BBC0F0 
		public Button prevBtn { /* [XID] */ /* 0x0000000189B78450-0x0000000189B78470 */ get => default; } // 0x0000000184BBB4A0-0x0000000184BBB540 
		public Button nextBtn { /* [XID] */ /* 0x0000000189B7F910-0x0000000189B7F930 */ get => default; } // 0x0000000184BBB350-0x0000000184BBB3F0 
		public Transform itemTipRoot { /* [XID] */ /* 0x0000000189B87460-0x0000000189B87480 */ get => default; } // 0x0000000184BBAD50-0x0000000184BBADF0 
		public MonoCookPanel cookPanel { /* [XID] */ /* 0x0000000189B8E530-0x0000000189B8E550 */ get => default; } // 0x0000000184BBA900-0x0000000184BBA9A0 
		public MonoCookPanel compoundPanel { /* [XID] */ /* 0x0000000189B959F0-0x0000000189B95A10 */ get => default; } // 0x0000000184BBA6A0-0x0000000184BBA740 
		public MonoUIContainer makeBtn { /* [XID] */ /* 0x0000000189B9CF90-0x0000000189B9CFB0 */ get => default; } // 0x0000000184BBB150-0x0000000184BBB250 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189BA48B0-0x0000000189BA48D0 */ get => default; } // 0x0000000184BBAAA0-0x0000000184BBABA0 
		public MonoUIContainer learnBtn { /* [XID] */ /* 0x0000000189BABBD0-0x0000000189BABBF0 */ get => default; } // 0x0000000184BBAEA0-0x0000000184BBAFA0 
		public Button makeButton { /* [XID] */ /* 0x0000000189BB32C0-0x0000000189BB32E0 */ get => default; } // 0x0000000184BBB250-0x0000000184BBB350 
		public Button closeButton { /* [XID] */ /* 0x0000000189BBA8A0-0x0000000189BBA8C0 */ get => default; } // 0x0000000184BBA5E0-0x0000000184BBA6A0 
		public Button fetchButton { /* [XID] */ /* 0x0000000189BC28C0-0x0000000189BC28E0 */ get => default; } // 0x0000000184BBABA0-0x0000000184BBACA0 
		public Button learnButton { /* [XID] */ /* 0x0000000189BCA020-0x0000000189BCA040 */ get => default; } // 0x0000000184BBAFA0-0x0000000184BBB0A0 
		public Button screenDropButton { /* [XID] */ /* 0x0000000189BD16F0-0x0000000189BD1710 */ get => default; } // 0x0000000184BBB6F0-0x0000000184BBB7F0 
		public UnityEngine.UI.Text haveText { /* [XID] */ /* 0x0000000189BD8CE0-0x0000000189BD8D00 */ get => default; } // 0x0000000184BBACA0-0x0000000184BBAD50 
		public UnityEngine.UI.Text canMakeText { /* [XID] */ /* 0x00000001895E58C0-0x00000001895E58E0 */ get => default; } // 0x0000000184BBA430-0x0000000184BBA4E0 
		public GameObject noItemRoot { /* [XID] */ /* 0x00000001895ED210-0x00000001895ED230 */ get => default; } // 0x0000000184BBB3F0-0x0000000184BBB4A0 
		public GameObject sortRoot { /* [XID] */ /* 0x00000001895F4890-0x00000001895F48B0 */ get => default; } // 0x0000000184BBBCF0-0x0000000184BBBDA0 
		public Button sortBtn { /* [XID] */ /* 0x00000001895FC000-0x00000001895FC020 */ get => default; } // 0x0000000184BBBBC0-0x0000000184BBBCF0 
		public MonoUIContainer screenDrop { /* [XID] */ /* 0x0000000189603A40-0x0000000189603A60 */ get => default; } // 0x0000000184BBB7F0-0x0000000184BBB900 
		public Transform GrpSort { /* [XID] */ /* 0x000000018960B3A0-0x000000018960B3C0 */ get => default; } // 0x0000000184BBA230-0x0000000184BBA330 
		public MonoUIContainer detailBtn { /* [XID] */ /* 0x0000000189612750-0x0000000189612770 */ get => default; } // 0x0000000184BBA9A0-0x0000000184BBAAA0 
		public MonoUIContainer backBtn { /* [XID] */ /* 0x000000018961A070-0x000000018961A090 */ get => default; } // 0x0000000184BBA330-0x0000000184BBA430 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x00000001896215B0-0x00000001896215D0 */ get => default; } // 0x0000000184BBA4E0-0x0000000184BBA5E0 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x0000000189628EC0-0x0000000189628EE0 */ get => default; } // 0x0000000184BBB540-0x0000000184BBB640 
		public Button screenBackBtn { /* [XID] */ /* 0x0000000189630840-0x0000000189630860 */ get => default; } // 0x0000000184BBB640-0x0000000184BBB6F0 
		public GameObject screeningPanelRoot { /* [XID] */ /* 0x00000001896382E0-0x0000000189638300 */ get => default; } // 0x0000000184BBB900-0x0000000184BBB9B0 
		public GameObject screeningPanel { /* [XID] */ /* 0x000000018963F6C0-0x000000018963F6E0 */ get => default; } // 0x0000000184BBB9B0-0x0000000184BBBA60 
		public MonoGridScroller screeningScroller { /* [XID] */ /* 0x0000000189646E80-0x0000000189646EA0 */ get => default; } // 0x0000000184BBBA60-0x0000000184BBBB10 
		public GameObject selectItemTipsObj { /* [XID] */ /* 0x000000018964E5D0-0x000000018964E5F0 */ get => default; } // 0x0000000184BBBB10-0x0000000184BBBBC0 
		public MonoJoypadNavRegionBase mainRegion { /* [XID] */ /* 0x0000000189655E00-0x0000000189655E20 */ get => default; } // 0x0000000184BBB0A0-0x0000000184BBB150 
		public MonoJoypadScrollRect itemTipScrollRectHandler { /* [XID] */ /* 0x000000018965D5E0-0x000000018965D600 */ get => default; } // 0x0000000184BBADF0-0x0000000184BBAEA0 
		public MonoReusableList tabList { /* [XID] */ /* 0x0000000189664D00-0x0000000189664D20 */ get => default; } // 0x0000000184BBBDA0-0x0000000184BBBF10 
		public MonoCookingItemTip cookItemTip { /* [XID] */ /* 0x000000018966C300-0x000000018966C320 */ get => default; } // 0x0000000184BBA740-0x0000000184BBA900 
	
		// Constructors
		public MonoCookingPage() {} // 0x0000000184BBA120-0x0000000184BBA230
	
		// Methods
		// [XID] // 0x0000000189674180-0x00000001896741A0
		public void SwitchPanel(CookingPageType type) {} // 0x0000000184BB9E70-0x0000000184BBA120
		// [XID] // 0x000000018967B9C0-0x000000018967B9E0
		public void ScrollTipsToBegin() {} // 0x0000000184BB9D70-0x0000000184BB9E70
		// [XID] // 0x00000001896830D0-0x00000001896830F0
		protected override void OnDestroy() {} // 0x0000000184BB9C00-0x0000000184BB9D70
	}
}
