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
	public class MonoChannellerSlabSchemePage : MonoUIProxy // TypeDefIndex: 30054
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoShopMaterial _energyCost; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _plateContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _noBuffEffectTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevTabBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextTabBtn; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _grpTips; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _tabTrans; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _tabContent; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _effctHintAction; // 0x88
		// [Header] // 0x000000018964D050-0x000000018964D0A0
		[SerializeField] // 0x000000018964D050-0x000000018964D0A0
		private UnityEngine.UI.Text _buffName; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _buffDesc; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _buffCost; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _buffStar; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _buffChooseScrollView; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _purleBuffList; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _normalBuffList; // 0xC0
	
		// Properties
		public MonoShopMaterial energyCost { /* [XID] */ /* 0x0000000189686020-0x0000000189686040 */ get => default; } // 0x000000018480BFF0-0x000000018480C090 
		public MonoUIContainer prevTabBtn { /* [XID] */ /* 0x000000018968DDF0-0x000000018968DE10 */ get => default; } // 0x000000018480C400-0x000000018480C4A0 
		public MonoUIContainer nextTabBtn { /* [XID] */ /* 0x0000000189695760-0x0000000189695780 */ get => default; } // 0x000000018480C150-0x000000018480C1F0 
		public MonoUIContainer prevBtn { /* [XID] */ /* 0x000000018969CDD0-0x000000018969CDF0 */ get => default; } // 0x000000018480C340-0x000000018480C400 
		public MonoUIContainer nextBtn { /* [XID] */ /* 0x00000001896A40E0-0x00000001896A4100 */ get => default; } // 0x000000018480C090-0x000000018480C150 
		public MonoUIContainer BtnCourse { /* [XID] */ /* 0x00000001896AB6C0-0x00000001896AB6E0 */ get => default; } // 0x000000018480BAF0-0x000000018480BBB0 
		public MonoUIContainer BtnClose { /* [XID] */ /* 0x00000001896B2910-0x00000001896B2930 */ get => default; } // 0x000000018480BA30-0x000000018480BAF0 
		public MonoUIContainer BtnWearBuff { /* [XID] */ /* 0x00000001896BA060-0x00000001896BA080 */ get => default; } // 0x000000018480BC70-0x000000018480BD30 
		public MonoUIContainer BtnDetail { /* [XID] */ /* 0x00000001896C1330-0x00000001896C1350 */ get => default; } // 0x000000018480BBB0-0x000000018480BC70 
		public MonoUIContainer plateContainer { /* [XID] */ /* 0x00000001896C8A10-0x00000001896C8A30 */ get => default; } // 0x000000018480C2A0-0x000000018480C340 
		public UnityEngine.UI.Text buffName { /* [XID] */ /* 0x00000001896E6550-0x00000001896E6570 */ get => default; } // 0x000000018480BF40-0x000000018480BFF0 
		public UnityEngine.UI.Text buffDesc { /* [XID] */ /* 0x00000001896EDAC0-0x00000001896EDAE0 */ get => default; } // 0x000000018480BE90-0x000000018480BF40 
		public UnityEngine.UI.Text buffCost { /* [XID] */ /* 0x00000001896F5290-0x00000001896F52B0 */ get => default; } // 0x000000018480BDE0-0x000000018480BE90 
		public MonoStarRate starRate { /* [XID] */ /* 0x00000001896FCAF0-0x00000001896FCB10 */ get => default; } // 0x000000018480C550-0x000000018480C600 
		public MonoScrollRectExtention buffChooseScrollView { /* [XID] */ /* 0x0000000189703FD0-0x0000000189703FF0 */ get => default; } // 0x000000018480BD30-0x000000018480BDE0 
		public MonoSimpleReusableList purpleBuffList { /* [XID] */ /* 0x000000018970B8C0-0x000000018970B8E0 */ get => default; } // 0x000000018480C4A0-0x000000018480C550 
		public MonoSimpleReusableList normalBuffList { /* [XID] */ /* 0x0000000189713150-0x0000000189713170 */ get => default; } // 0x000000018480C1F0-0x000000018480C2A0 
	
		// Constructors
		public MonoChannellerSlabSchemePage() {} // 0x000000018480B960-0x000000018480BA30
	
		// Methods
		// [XID] // 0x00000001896D03C0-0x00000001896D03E0
		public void SetHintVisible(bool bVis) {} // 0x000000018480B5E0-0x000000018480B6C0
		// [XID] // 0x00000001896D7920-0x00000001896D7940
		public void SetSlabUnlocked(bool bVis) {} // 0x000000018480B880-0x000000018480B960
		// [XID] // 0x00000001896DF100-0x00000001896DF120
		public void SetHasBuff(bool bHas) {} // 0x000000018480B500-0x000000018480B5E0
		// [XID] // 0x000000018971A970-0x000000018971A990
		public void SetPageState(int pageState) {} // 0x000000018480B6C0-0x000000018480B880
	}
}
