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
	public class MonoActivitySubPageLanternRite : MonoUIProxy // TypeDefIndex: 31178
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _activityTime; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textStage; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textProgress; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progressMask; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnMainQuest; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnMiniQuest; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnChess; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnShop; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnMakeLampLocked; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textLampNum; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnMakeLampAdd; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnContract; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _contractCompleted1; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _contractCompleted2; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _contractImage; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _makeLamepRoot; // 0xC0
	
		// Properties
		public Text activityTime { /* [XID] */ /* 0x00000001895F00E0-0x00000001895F0100 */ get => default; } // 0x00000001852E4970-0x00000001852E4A10 
		public Text textStage { /* [XID] */ /* 0x00000001895F7B90-0x00000001895F7BB0 */ get => default; } // 0x00000001852E5360-0x00000001852E5400 
		public Text textProgress { /* [XID] */ /* 0x00000001895FEED0-0x00000001895FEEF0 */ get => default; } // 0x00000001852E52C0-0x00000001852E5360 
		public SmoothMask progressMask { /* [XID] */ /* 0x0000000189606730-0x0000000189606750 */ get => default; } // 0x00000001852E5170-0x00000001852E5210 
		public MonoUIContainer btnMainQuest { /* [XID] */ /* 0x000000018960E0B0-0x000000018960E0D0 */ get => default; } // 0x00000001852E4B60-0x00000001852E4C00 
		public MonoUIContainer btnMiniQuest { /* [XID] */ /* 0x0000000189615700-0x0000000189615720 */ get => default; } // 0x00000001852E4D60-0x00000001852E4E00 
		public MonoUIContainer btnChess { /* [XID] */ /* 0x000000018961CEE0-0x000000018961CF00 */ get => default; } // 0x00000001852E4A10-0x00000001852E4AB0 
		public MonoUIContainer btnShop { /* [XID] */ /* 0x0000000189624450-0x0000000189624470 */ get => default; } // 0x00000001852E4E00-0x00000001852E4EB0 
		public Button btnMakeLampLocked { /* [XID] */ /* 0x000000018962BB20-0x000000018962BB40 */ get => default; } // 0x00000001852E4CB0-0x00000001852E4D60 
		public Text textLampNum { /* [XID] */ /* 0x0000000189633690-0x00000001896336B0 */ get => default; } // 0x00000001852E5210-0x00000001852E52C0 
		public MonoUIContainer btnMakeLampAdd { /* [XID] */ /* 0x000000018963AF50-0x000000018963AF70 */ get => default; } // 0x00000001852E4C00-0x00000001852E4CB0 
		public Button btnContract { /* [XID] */ /* 0x0000000189642660-0x0000000189642680 */ get => default; } // 0x00000001852E4AB0-0x00000001852E4B60 
		public RectTransform contractCompleted1 { /* [XID] */ /* 0x0000000189649D70-0x0000000189649D90 */ get => default; } // 0x00000001852E4EB0-0x00000001852E4F60 
		public RectTransform contractCompleted2 { /* [XID] */ /* 0x0000000189651470-0x0000000189651490 */ get => default; } // 0x00000001852E4F60-0x00000001852E5010 
		public Image contractImage { /* [XID] */ /* 0x0000000189658C10-0x0000000189658C30 */ get => default; } // 0x00000001852E5010-0x00000001852E50C0 
		public RectTransform makeLamepRoot { /* [XID] */ /* 0x0000000189660360-0x0000000189660380 */ get => default; } // 0x00000001852E50C0-0x00000001852E5170 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x0000000189667CA0-0x0000000189667CC0 */ get => default; } // 0x00000001852E4640-0x00000001852E4750 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x000000018966F790-0x000000018966F7B0 */ get => default; } // 0x00000001852E4530-0x00000001852E4640 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189677100-0x0000000189677120 */ get => default; } // 0x00000001852E4250-0x00000001852E4310 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x000000018967E6B0-0x000000018967E6D0 */ get => default; } // 0x00000001852E4860-0x00000001852E4970 
		public MonoUIContainer BtnDescription { /* [XID] */ /* 0x0000000189685EC0-0x0000000189685EE0 */ get => default; } // 0x00000001852E4420-0x00000001852E4530 
		public MonoUIContainer BtnMakeLamp { /* [XID] */ /* 0x000000018968DCF0-0x000000018968DD10 */ get => default; } // 0x00000001852E4750-0x00000001852E4860 
		public MonoUIContainer BtnContract { /* [XID] */ /* 0x0000000189695640-0x0000000189695660 */ get => default; } // 0x00000001852E4310-0x00000001852E4420 
	
		// Constructors
		public MonoActivitySubPageLanternRite() {} // 0x00000001852E41E0-0x00000001852E4250
	}
}
