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
	public class MonoCountSelectDialog : MonoUIProxy // TypeDefIndex: 30530
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _freeClickBtn; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _inputField; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _slider; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x60
		public UnityEngine.UI.Text infoText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _errorText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _increaseBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _decreaseBtn; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _minText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxText; // 0x90
		private MonoPS4IMEProxy _ps4ImeProxy; // 0x98
	
		// Properties
		public Button increaseBtn { /* [XID] */ /* 0x00000001896E2050-0x00000001896E2070 */ get => default; } // 0x0000000183F3A410-0x0000000183F3A4C0 
		public Button decreaseBtn { /* [XID] */ /* 0x00000001896E9550-0x00000001896E9570 */ get => default; } // 0x0000000183F3A2B0-0x0000000183F3A370 
		public string minText { /* [XID] */ /* 0x00000001896F07A0-0x00000001896F07C0 */ set {} } // 0x0000000183F3A9F0-0x0000000183F3AAC0
		public string maxText { /* [XID] */ /* 0x00000001896F7F60-0x00000001896F7F80 */ set {} } // 0x0000000183F3A920-0x0000000183F3A9F0
		public string errorText { /* [XID] */ /* 0x00000001896FF960-0x00000001896FF980 */ set {} } // 0x0000000183F3A760-0x0000000183F3A920
		public Button freeClickButton { /* [XID] */ /* 0x0000000189706F70-0x0000000189706F90 */ get => default; } // 0x0000000183F3A370-0x0000000183F3A410 
		public Button closeButton { /* [XID] */ /* 0x000000018970E850-0x000000018970E870 */ get => default; } // 0x0000000183F39F20-0x0000000183F3A0D0 
		public Button cancelButton { /* [XID] */ /* 0x0000000189715CD0-0x0000000189715CF0 */ get => default; } // 0x0000000183F39D40-0x0000000183F39F20 
		public Button confirmButton { /* [XID] */ /* 0x000000018971D6E0-0x000000018971D700 */ get => default; } // 0x0000000183F3A0D0-0x0000000183F3A2B0 
		public string title { /* [XID] */ /* 0x0000000189724AD0-0x0000000189724AF0 */ set {} } // 0x0000000183F3AAC0-0x0000000183F3AB90
		public InputField inputField { /* [XID] */ /* 0x000000018972C320-0x000000018972C340 */ get => default; } // 0x0000000183F3A4C0-0x0000000183F3A580 
		public Slider slider { /* [XID] */ /* 0x00000001897339E0-0x0000000189733A00 */ get => default; } // 0x0000000183F3A6A0-0x0000000183F3A760 
		public MonoPS4IMEProxy ps4IMEProxy { /* [XID] */ /* 0x000000018973B140-0x000000018973B160 */ get => default; } // 0x0000000183F3A580-0x0000000183F3A6A0 
	
		// Constructors
		public MonoCountSelectDialog() {} // 0x0000000183F39CA0-0x0000000183F39D40
	}
}
