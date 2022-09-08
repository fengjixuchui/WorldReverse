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
	public class MonoSpringUsePage : MonoUIProxy // TypeDefIndex: 31016
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _increaseBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _decreaseBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _autoRecoverToggle; // 0x58
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _autoRecoverThresholdLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currSpring; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxSpring; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _springFill; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _recoveryTime; // 0x80
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoGridScroller _teamContainer; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _otherAvatarScroller; // 0x90
	
		// Properties
		public MonoGridScroller teamScroller { /* [XID] */ /* 0x000000018964CFB0-0x000000018964CFD0 */ get => default; } // 0x0000000184FFBA20-0x0000000184FFBAD0 
		public MonoGridScroller preparingScroller { /* [XID] */ /* 0x0000000189654740-0x0000000189654760 */ get => default; } // 0x0000000184FFB970-0x0000000184FFBA20 
		public uint maxSpring { /* [XID] */ /* 0x000000018965BE30-0x000000018965BE50 */ set {} } // 0x0000000184FFBED0-0x0000000184FFBFA0
		public uint currSpring { /* [XID] */ /* 0x0000000189663420-0x0000000189663440 */ set {} } // 0x0000000184FFBBF0-0x0000000184FFBCC0
		public float springRatio { /* [XID] */ /* 0x000000018966AE30-0x000000018966AE50 */ set {} } // 0x0000000184FFBFA0-0x0000000184FFC090
		public uint hoursRecovery { /* [XID] */ /* 0x0000000189672A50-0x0000000189672A70 */ set {} } // 0x0000000184FFBCC0-0x0000000184FFBED0
		public Toggle autoUseToggle { /* [XID] */ /* 0x000000018967A190-0x000000018967A1B0 */ get => default; } // 0x0000000184FFB570-0x0000000184FFB630 
		public Button closeButton { /* [XID] */ /* 0x0000000189681960-0x0000000189681980 */ get => default; } // 0x0000000184FFB630-0x0000000184FFB810 
		public Button increaseButton { /* [XID] */ /* 0x0000000189689410-0x0000000189689430 */ get => default; } // 0x0000000184FFB8C0-0x0000000184FFB970 
		public Button decreaseButton { /* [XID] */ /* 0x0000000189691070-0x0000000189691090 */ get => default; } // 0x0000000184FFB810-0x0000000184FFB8C0 
		public uint autoUseThreshold { /* [XID] */ /* 0x00000001896987B0-0x00000001896987D0 */ set {} } // 0x0000000184FFBAD0-0x0000000184FFBBF0
	
		// Constructors
		public MonoSpringUsePage() {} // 0x0000000184FFB4D0-0x0000000184FFB570
	}
}
