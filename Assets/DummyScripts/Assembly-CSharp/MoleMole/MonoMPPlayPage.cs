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
	public class MonoMPPlayPage : MonoUIProxy // TypeDefIndex: 31013
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		// [Header] // 0x00000001897FC0E0-0x00000001897FC130
		[SerializeField] // 0x00000001897FC0E0-0x00000001897FC130
		private RectTransform _coinsAndResinGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _coinsGrp; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _resinGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMaterialItemRow _resinInfo; // 0x60
		// [Header] // 0x000000018981E340-0x000000018981E390
		[SerializeField] // 0x000000018981E340-0x000000018981E390
		private Text _title; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _description; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollTextDesc; // 0x78
		// [Header] // 0x0000000189838D40-0x0000000189838D80
		[SerializeField] // 0x0000000189838D40-0x0000000189838D80
		private RectTransform _consumeTipsGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _consumeTipsText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _consumeCoinImage; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _consumeCoinNum; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _consumeMaterialOr; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _consumeResinNum; // 0xA8
		// [Header] // 0x0000000189869690-0x00000001898696D0
		[SerializeField] // 0x0000000189869690-0x00000001898696D0
		private RectTransform _upAvatarGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _upAvatarTips; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _upAvatarScroller; // 0xC0
		// [Header] // 0x0000000189883C10-0x0000000189883C50
		[SerializeField] // 0x0000000189883C10-0x0000000189883C50
		private RectTransform _buffTitleGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _buffTitle; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _buffListGrp; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _buffReusableList; // 0xE0
		// [Header] // 0x00000001898A5F10-0x00000001898A5F60
		[SerializeField] // 0x00000001898A5F10-0x00000001898A5F60
		private RectTransform _possibleRewardTextGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _possibleRewardText; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _possibleRewardGrp; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _possibleRewardReusableList; // 0x100
		// [Header] // 0x00000001898C84D0-0x00000001898C8510
		[SerializeField] // 0x00000001898C84D0-0x00000001898C8510
		private RectTransform _waitMatchGrp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _waitMatchTip; // 0x110
		// [Header] // 0x00000001898DBAD0-0x00000001898DBB20
		[SerializeField] // 0x00000001898DBAD0-0x00000001898DBB20
		private RectTransform _onlineMatchingGrp; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _matchingTimeLabel; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _startMatchTips; // 0x128
	
		// Properties
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x00000001898F7370-0x00000001898F7390 */ get => default; } // 0x0000000182F0CF10-0x0000000182F0CFB0 
		public RectTransform coinsAndResinGrp { /* [XID] */ /* 0x00000001898FEAE0-0x00000001898FEB00 */ get => default; } // 0x0000000182F0C7B0-0x0000000182F0C850 
		public RectTransform coinsGrp { /* [XID] */ /* 0x0000000189906200-0x0000000189906220 */ get => default; } // 0x0000000182F0C850-0x0000000182F0C8F0 
		public RectTransform resinGrp { /* [XID] */ /* 0x000000018990DCA0-0x000000018990DCC0 */ get => default; } // 0x0000000182F0D3D0-0x0000000182F0D470 
		public MonoMaterialItemRow resinInfo { /* [XID] */ /* 0x0000000189915470-0x0000000189915490 */ get => default; } // 0x0000000182F0D470-0x0000000182F0D510 
		public RectTransform consumeTipsGrp { /* [XID] */ /* 0x000000018991CE80-0x000000018991CEA0 */ get => default; } // 0x0000000182F0CBB0-0x0000000182F0CC60 
		public Text consumeTipsText { /* [XID] */ /* 0x0000000189924750-0x0000000189924770 */ get => default; } // 0x0000000182F0CC60-0x0000000182F0CD10 
		public Image consumeCoinImage { /* [XID] */ /* 0x000000018992BD00-0x000000018992BD20 */ get => default; } // 0x0000000182F0C8F0-0x0000000182F0C9A0 
		public Text consumeCoinNum { /* [XID] */ /* 0x0000000189933250-0x0000000189933270 */ get => default; } // 0x0000000182F0C9A0-0x0000000182F0CA50 
		public Text consumeMaterialOr { /* [XID] */ /* 0x000000018993ADA0-0x000000018993ADC0 */ get => default; } // 0x0000000182F0CA50-0x0000000182F0CB00 
		public Text consumeResinNum { /* [XID] */ /* 0x0000000189941DF0-0x0000000189941E10 */ get => default; } // 0x0000000182F0CB00-0x0000000182F0CBB0 
		public RectTransform upAvatarGrp { /* [XID] */ /* 0x00000001899498B0-0x00000001899498D0 */ get => default; } // 0x0000000182F0D8A0-0x0000000182F0D950 
		public Text upAvatarTips { /* [XID] */ /* 0x00000001899512E0-0x0000000189951300 */ get => default; } // 0x0000000182F0DA00-0x0000000182F0DAB0 
		public MonoGridScroller upAvatarScroller { /* [XID] */ /* 0x0000000189958890-0x00000001899588B0 */ get => default; } // 0x0000000182F0D950-0x0000000182F0DA00 
		public RectTransform buffTitleGrp { /* [XID] */ /* 0x000000018995FF50-0x000000018995FF70 */ get => default; } // 0x0000000182F0C590-0x0000000182F0C640 
		public Text buffTitle { /* [XID] */ /* 0x00000001899679F0-0x0000000189967A10 */ get => default; } // 0x0000000182F0C640-0x0000000182F0C6F0 
		public RectTransform buffListGrp { /* [XID] */ /* 0x000000018996EB70-0x000000018996EB90 */ get => default; } // 0x0000000182F0C430-0x0000000182F0C4E0 
		public MonoSimpleReusableList buffReusableList { /* [XID] */ /* 0x0000000189976750-0x0000000189976770 */ get => default; } // 0x0000000182F0C4E0-0x0000000182F0C590 
		public RectTransform possibleRewardTextGrp { /* [XID] */ /* 0x000000018997DB90-0x000000018997DBB0 */ get => default; } // 0x0000000182F0D270-0x0000000182F0D320 
		public Text possibleRewardText { /* [XID] */ /* 0x0000000189985530-0x0000000189985550 */ get => default; } // 0x0000000182F0D320-0x0000000182F0D3D0 
		public RectTransform possibleRewardGrp { /* [XID] */ /* 0x000000018998D2F0-0x000000018998D310 */ get => default; } // 0x0000000182F0D110-0x0000000182F0D1C0 
		public MonoSimpleReusableList possibleRewardReusableList { /* [XID] */ /* 0x0000000189994DD0-0x0000000189994DF0 */ get => default; } // 0x0000000182F0D1C0-0x0000000182F0D270 
		public RectTransform waitMatchGrp { /* [XID] */ /* 0x000000018999C670-0x000000018999C690 */ get => default; } // 0x0000000182F0DAB0-0x0000000182F0DB60 
		public Text waitMatchTip { /* [XID] */ /* 0x00000001899A40E0-0x00000001899A4100 */ get => default; } // 0x0000000182F0DB60-0x0000000182F0DC10 
		public MonoUIContainer startBtn { /* [XID] */ /* 0x00000001899ABAB0-0x00000001899ABAD0 */ get => default; } // 0x0000000182F0D5D0-0x0000000182F0D690 
		public MonoUIContainer startSingleBtn { /* [XID] */ /* 0x00000001899B3490-0x00000001899B34B0 */ get => default; } // 0x0000000182F0D740-0x0000000182F0D800 
		public MonoUIContainer cancelBtn { /* [XID] */ /* 0x00000001899BA810-0x00000001899BA830 */ get => default; } // 0x0000000182F0C6F0-0x0000000182F0C7B0 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x00000001899C2110-0x00000001899C2130 */ get => default; } // 0x0000000182F0D510-0x0000000182F0D5D0 
		public MonoUIContainer courseBtn { /* [XID] */ /* 0x00000001899C9810-0x00000001899C9830 */ get => default; } // 0x0000000182F0CD10-0x0000000182F0CDD0 
		public Text title { /* [XID] */ /* 0x00000001899D1090-0x00000001899D10B0 */ get => default; } // 0x0000000182F0D800-0x0000000182F0D8A0 
		public Text description { /* [XID] */ /* 0x00000001899D8580-0x00000001899D85A0 */ get => default; } // 0x0000000182F0CE70-0x0000000182F0CF10 
		public ScrollRect descriptionScrollRect { /* [XID] */ /* 0x00000001899DFC10-0x00000001899DFC30 */ get => default; } // 0x0000000182F0CDD0-0x0000000182F0CE70 
		public RectTransform onlineMatchingGrp { /* [XID] */ /* 0x00000001899E7660-0x00000001899E7680 */ get => default; } // 0x0000000182F0D060-0x0000000182F0D110 
		public Text matchingTimeLabel { /* [XID] */ /* 0x00000001899EEC30-0x00000001899EEC50 */ get => default; } // 0x0000000182F0CFB0-0x0000000182F0D060 
		public RectTransform startMatchTips { /* [XID] */ /* 0x00000001899F64B0-0x00000001899F64D0 */ get => default; } // 0x0000000182F0D690-0x0000000182F0D740 
	
		// Constructors
		public MonoMPPlayPage() {} // 0x0000000182F0C310-0x0000000182F0C430
	}
}
