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
	public class MonoInLevelGachaSettlementPage : MonoUIProxy // TypeDefIndex: 29741
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _onceGridScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _allGridScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _scrollTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _posterTrans; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _showPrefab; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _slotPrefab; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _startEffect; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float clickLimitDuration; // 0x80
		public float beginIntervale; // 0x84
		public float intervalSeconds; // 0x88
		public float settleIntervalSeconds; // 0x8C
		public float posterBeginInterval; // 0x90
		public float posterIntervalSeconds; // 0x94
		public float settlePoasterIntervalSeconds; // 0x98
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _gachaBg; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _inlevelBg; // 0xA8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _grpShare; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _shareBtnContainer; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpFirstShare; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _firstShareNum; // 0xC8
	
		// Properties
		public MonoGridScroller allGridScroller { /* [XID] */ /* 0x00000001899AD290-0x00000001899AD2B0 */ get => default; } // 0x000000018470DAD0-0x000000018470DB70 
		public MonoGridScroller onceGridScroller { /* [XID] */ /* 0x00000001899B4AD0-0x00000001899B4AF0 */ get => default; } // 0x000000018470E230-0x000000018470E2D0 
		public Transform scrollTrans { /* [XID] */ /* 0x00000001899BC1D0-0x00000001899BC1F0 */ get => default; } // 0x000000018470E370-0x000000018470E410 
		public Transform posterTrans { /* [XID] */ /* 0x00000001899C3C10-0x00000001899C3C30 */ get => default; } // 0x000000018470E2D0-0x000000018470E370 
		public GameObject showPrefab { /* [XID] */ /* 0x00000001899CB310-0x00000001899CB330 */ get => default; } // 0x000000018470E4C0-0x000000018470E560 
		public GameObject slotPrefab { /* [XID] */ /* 0x00000001899D2840-0x00000001899D2860 */ get => default; } // 0x000000018470E560-0x000000018470E600 
		public GameObject startEffect { /* [XID] */ /* 0x00000001899D9F50-0x00000001899D9F70 */ get => default; } // 0x000000018470E600-0x000000018470E6A0 
		public Button closeBtn { /* [XID] */ /* 0x00000001899E1830-0x00000001899E1850 */ get => default; } // 0x000000018470E110-0x000000018470E230 
		public Button btnNext { /* [XID] */ /* 0x00000001899E8DE0-0x00000001899E8E00 */ get => default; } // 0x000000018470DDB0-0x000000018470DED0 
		public Button btnSkip { /* [XID] */ /* 0x00000001899F0760-0x00000001899F0780 */ get => default; } // 0x000000018470DFF0-0x000000018470E110 
		public Button btnCheck { /* [XID] */ /* 0x00000001899F7DA0-0x00000001899F7DC0 */ get => default; } // 0x000000018470DB70-0x000000018470DC90 
		public Button btnDetails { /* [XID] */ /* 0x00000001899FF410-0x00000001899FF430 */ get => default; } // 0x000000018470DC90-0x000000018470DDB0 
		public Button btnShare { /* [XID] */ /* 0x0000000189A06C90-0x0000000189A06CB0 */ get => default; } // 0x000000018470DED0-0x000000018470DFF0 
		public bool showCloseBtn { /* [XID] */ /* 0x0000000189A0E360-0x0000000189A0E380 */ set {} } // 0x000000018470E890-0x000000018470E9A0
		public bool showNextBtn { /* [XID] */ /* 0x0000000189A15900-0x0000000189A15920 */ set {} } // 0x000000018470ED80-0x000000018470EE90
		public bool showDetailBtn { /* [XID] */ /* 0x0000000189A1CDC0-0x0000000189A1CDE0 */ set {} } // 0x000000018470E9A0-0x000000018470EAB0
		public bool showCheckBtn { /* [XID] */ /* 0x0000000189A24300-0x0000000189A24320 */ set {} } // 0x000000018470E780-0x000000018470E890
		public bool showShareBtn { /* [XID] */ /* 0x0000000189A2B7E0-0x0000000189A2B800 */ set {} } // 0x000000018470EE90-0x000000018470EFA0
		public bool showGachaBg { /* [XID] */ /* 0x0000000189A32E40-0x0000000189A32E60 */ set {} } // 0x000000018470EBA0-0x000000018470EC90
		public bool showInlevelBg { /* [XID] */ /* 0x0000000189A3A690-0x0000000189A3A6B0 */ set {} } // 0x000000018470EC90-0x000000018470ED80
		public bool showShare { /* [XID] */ /* 0x0000000189A41FE0-0x0000000189A42000 */ set {} } // 0x000000018470EFA0-0x000000018470F090
		public MonoUIContainer shareBtn { /* [XID] */ /* 0x0000000189A49590-0x0000000189A495B0 */ get => default; } // 0x000000018470E410-0x000000018470E4C0 
		public bool showFirstShare { /* [XID] */ /* 0x0000000189A50F20-0x0000000189A50F40 */ set {} } // 0x000000018470EAB0-0x000000018470EBA0
		public uint firstShareNum { /* [XID] */ /* 0x0000000189A584A0-0x0000000189A584C0 */ set {} } // 0x000000018470E6A0-0x000000018470E780
	
		// Constructors
		public MonoInLevelGachaSettlementPage() {} // 0x000000018470D9D0-0x000000018470DAD0
	}
}
