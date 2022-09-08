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
	internal class MonoActivitySeaLampPage : MonoUIProxy // TypeDefIndex: 30358
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _contriText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _tab1Btn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _tab2Btn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _tab3Btn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noticeContainer; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _webBtn; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _tipsBtn1; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _storyShowRoot; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _storyClose; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _storyTitle; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _storyTime; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _storyDesc; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _storyImage; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _timeText1; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _targetBtn; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList1; // 0xC0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _pic2; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _content2; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _notOpen2; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _notOpenRewardList2; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _haveText; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _todayText; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tipsBtn2; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _timeText2; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _lampList; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _needList2; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList2; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _lampBtn; // 0x120
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _pic3; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _content3; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _notOpen3; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tipsBtn3; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _timeText3; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _needList3; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSegmentProgressBar _progressBar; // 0x158
	
		// Properties
		public MonoUIContainer webBtn { /* [XID] */ /* 0x000000018981FE60-0x000000018981FE80 */ get => default; } // 0x00000001852DE560-0x00000001852DE600 
		public RectTransform storyShowRoot { /* [XID] */ /* 0x0000000189827440-0x0000000189827460 */ get => default; } // 0x00000001852DDB40-0x00000001852DDBF0 
		public RectTransform storyClose { /* [XID] */ /* 0x000000018982E6C0-0x000000018982E6E0 */ get => default; } // 0x00000001852DD820-0x00000001852DD8D0 
		public Text storyTitle { /* [XID] */ /* 0x0000000189836040-0x0000000189836060 */ get => default; } // 0x00000001852DDCA0-0x00000001852DDD50 
		public Text storyTime { /* [XID] */ /* 0x000000018983D570-0x000000018983D590 */ get => default; } // 0x00000001852DDBF0-0x00000001852DDCA0 
		public Text storyDesc { /* [XID] */ /* 0x0000000189844DB0-0x0000000189844DD0 */ get => default; } // 0x00000001852DD9E0-0x00000001852DDA90 
		public Image[] storyImage { /* [XID] */ /* 0x000000018984C1C0-0x000000018984C1E0 */ get => default; } // 0x00000001852DDA90-0x00000001852DDB40 
		public RectTransform pic2 { /* [XID] */ /* 0x0000000189853390-0x00000001898533B0 */ get => default; } // 0x00000001852DD3F0-0x00000001852DD4A0 
		public RectTransform content2 { /* [XID] */ /* 0x000000018985AE20-0x000000018985AE40 */ get => default; } // 0x00000001852DC8D0-0x00000001852DC980 
		public RectTransform notOpen2 { /* [XID] */ /* 0x00000001898622C0-0x00000001898622E0 */ get => default; } // 0x00000001852DD140-0x00000001852DD1F0 
		public MonoSimpleReusableList notOpenRewardList2 { /* [XID] */ /* 0x0000000189869750-0x0000000189869770 */ get => default; } // 0x00000001852DD2A0-0x00000001852DD350 
		public RectTransform pic3 { /* [XID] */ /* 0x0000000189870950-0x0000000189870970 */ get => default; } // 0x00000001852DD4A0-0x00000001852DD550 
		public RectTransform content3 { /* [XID] */ /* 0x00000001898783E0-0x0000000189878400 */ get => default; } // 0x00000001852DC980-0x00000001852DCA30 
		public RectTransform notOpen3 { /* [XID] */ /* 0x000000018987F8F0-0x000000018987F910 */ get => default; } // 0x00000001852DD1F0-0x00000001852DD2A0 
		public RectTransform noticeContainer { /* [XID] */ /* 0x0000000189886F40-0x0000000189886F60 */ get => default; } // 0x00000001852DD350-0x00000001852DD3F0 
		public Text contriText { /* [XID] */ /* 0x000000018988E0F0-0x000000018988E110 */ get => default; } // 0x00000001852DCA30-0x00000001852DCAD0 
		public Button clickBtn { /* [XID] */ /* 0x0000000189895740-0x0000000189895760 */ get => default; } // 0x00000001852DC7C0-0x00000001852DC8D0 
		public MonoUIContainer tipsBtn1 { /* [XID] */ /* 0x000000018989CEA0-0x000000018989CEC0 */ get => default; } // 0x00000001852DE2B0-0x00000001852DE350 
		public Text timeText1 { /* [XID] */ /* 0x00000001898A4660-0x00000001898A4680 */ get => default; } // 0x00000001852DE0A0-0x00000001852DE150 
		public MonoSimpleReusableList rewardList1 { /* [XID] */ /* 0x00000001898ABB20-0x00000001898ABB40 */ get => default; } // 0x00000001852DD6C0-0x00000001852DD770 
		public Button targetBtn { /* [XID] */ /* 0x00000001898B32D0-0x00000001898B32F0 */ get => default; } // 0x00000001852DDF30-0x00000001852DDFE0 
		public Text haveText { /* [XID] */ /* 0x00000001898BAFD0-0x00000001898BAFF0 */ get => default; } // 0x00000001852DCD10-0x00000001852DCDC0 
		public Text todayText { /* [XID] */ /* 0x00000001898C2340-0x00000001898C2360 */ get => default; } // 0x00000001852DE4B0-0x00000001852DE560 
		public MonoUIContainer tipsBtn2 { /* [XID] */ /* 0x00000001898C9D40-0x00000001898C9D60 */ get => default; } // 0x00000001852DE350-0x00000001852DE400 
		public Text timeText2 { /* [XID] */ /* 0x00000001898D1340-0x00000001898D1360 */ get => default; } // 0x00000001852DE150-0x00000001852DE200 
		public MonoSimpleReusableList lampList { /* [XID] */ /* 0x00000001898D8C00-0x00000001898D8C20 */ get => default; } // 0x00000001852DCF30-0x00000001852DCFE0 
		public MonoSimpleReusableList needList2 { /* [XID] */ /* 0x00000001898E08D0-0x00000001898E08F0 */ get => default; } // 0x00000001852DCFE0-0x00000001852DD090 
		public MonoSimpleReusableList rewardList2 { /* [XID] */ /* 0x00000001898E8430-0x00000001898E8450 */ get => default; } // 0x00000001852DD770-0x00000001852DD820 
		public Button lampBtn { /* [XID] */ /* 0x00000001898EFBB0-0x00000001898EFBD0 */ get => default; } // 0x00000001852DCE80-0x00000001852DCF30 
		public MonoUIContainer tipsBtn3 { /* [XID] */ /* 0x00000001898F73F0-0x00000001898F7410 */ get => default; } // 0x00000001852DE400-0x00000001852DE4B0 
		public Text timeText3 { /* [XID] */ /* 0x00000001898FEB60-0x00000001898FEB80 */ get => default; } // 0x00000001852DE200-0x00000001852DE2B0 
		public MonoSimpleReusableList needList3 { /* [XID] */ /* 0x00000001899062A0-0x00000001899062C0 */ get => default; } // 0x00000001852DD090-0x00000001852DD140 
		public MonoSegmentProgressBar progressBar { /* [XID] */ /* 0x000000018990DD60-0x000000018990DD80 */ get => default; } // 0x00000001852DD550-0x00000001852DD600 
		public Button tab1Btn { /* [XID] */ /* 0x0000000189915510-0x0000000189915530 */ get => default; } // 0x00000001852DDD50-0x00000001852DDDF0 
		public Button tab2Btn { /* [XID] */ /* 0x000000018991CF60-0x000000018991CF80 */ get => default; } // 0x00000001852DDDF0-0x00000001852DDE90 
		public Button tab3Btn { /* [XID] */ /* 0x00000001899247D0-0x00000001899247F0 */ get => default; } // 0x00000001852DDE90-0x00000001852DDF30 
		public MonoUIContainer returnButton { /* [XID] */ /* 0x000000018992BD80-0x000000018992BDA0 */ get => default; } // 0x00000001852DD600-0x00000001852DD6C0 
		public MonoUIContainer contributionButton { /* [XID] */ /* 0x00000001899332B0-0x00000001899332D0 */ get => default; } // 0x00000001852DCAD0-0x00000001852DCB90 
		public MonoUIContainer action1Button { /* [XID] */ /* 0x000000018993AE20-0x000000018993AE40 */ get => default; } // 0x00000001852DC340-0x00000001852DC400 
		public MonoUIContainer action2Button { /* [XID] */ /* 0x0000000189941E90-0x0000000189941EB0 */ get => default; } // 0x00000001852DC400-0x00000001852DC4C0 
		public MonoUIContainer action3Button { /* [XID] */ /* 0x0000000189949970-0x0000000189949990 */ get => default; } // 0x00000001852DC4C0-0x00000001852DC580 
		public RectTransform storyComplete { /* [XID] */ /* 0x00000001899513A0-0x00000001899513C0 */ get => default; } // 0x00000001852DD8D0-0x00000001852DD9E0 
		public MonoUIContainer changePageButton { /* [XID] */ /* 0x00000001899589D0-0x00000001899589F0 */ get => default; } // 0x00000001852DC700-0x00000001852DC7C0 
		public MonoUIContainer btnSwitchPrev { /* [XID] */ /* 0x000000018995FFF0-0x0000000189960010 */ get => default; } // 0x00000001852DC640-0x00000001852DC700 
		public MonoUIContainer btnSwitchNext { /* [XID] */ /* 0x0000000189967AB0-0x0000000189967AD0 */ get => default; } // 0x00000001852DC580-0x00000001852DC640 
		public MonoUIContainer targetButton { /* [XID] */ /* 0x000000018996EC50-0x000000018996EC70 */ get => default; } // 0x00000001852DDFE0-0x00000001852DE0A0 
		public MonoUIContainer focusItemBtn { /* [XID] */ /* 0x0000000189976850-0x0000000189976870 */ get => default; } // 0x00000001852DCC50-0x00000001852DCD10 
		public MonoUIContainer itemDetailBtn { /* [XID] */ /* 0x000000018997DC70-0x000000018997DC90 */ get => default; } // 0x00000001852DCDC0-0x00000001852DCE80 
		public MonoUIContainer exitBtn { /* [XID] */ /* 0x0000000189985620-0x0000000189985640 */ get => default; } // 0x00000001852DCB90-0x00000001852DCC50 
	
		// Constructors
		public MonoActivitySeaLampPage() {} // 0x00000001852DC1F0-0x00000001852DC340
	}
}
