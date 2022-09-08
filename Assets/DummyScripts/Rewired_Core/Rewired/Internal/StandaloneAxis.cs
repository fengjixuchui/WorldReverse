/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal sealed class StandaloneAxis // TypeDefIndex: 4066
	{
		// Fields
		[CustomObfuscation] // 0x0000000189927320-0x00000001899273A0
		// [Range] // 0x0000000189927320-0x00000001899273A0
		[SerializeField] // 0x0000000189927320-0x00000001899273A0
		// [Tooltip] // 0x0000000189927320-0x00000001899273A0
		private float _buttonActivationThreshold; // 0x10
		[CustomObfuscation] // 0x0000000189938E60-0x0000000189938EC0
		[SerializeField] // 0x0000000189938E60-0x0000000189938EC0
		// [Tooltip] // 0x0000000189938E60-0x0000000189938EC0
		private AxisCalibration _calibration; // 0x18
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private float _valueRaw; // 0x20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private float _valueRawPrev; // 0x24
		private AxisValueChangedEventHandler bAHHEOTptXbbAuqcuBlybpNijmlo; // 0x28
		private AxisValueChangedEventHandler PIBBycoMsklrsnetCHkZEQLHAAe; // 0x30
		private ButtonDownEventHandler QLpsgdBsNpiCwdhQbmRbLcTfOpx; // 0x38
		private ButtonUpEventHandler qSIQyuwGzfDncxVCOeVNgVZZGTZ; // 0x40
		private ButtonValueChangedEventHandler ggdKJFcGFJtmoXAjLNQowxDKXfC; // 0x48
		private ButtonDownEventHandler kGdMJhglTnDDTqlRsLAYFgITVmB; // 0x50
		private ButtonUpEventHandler bwoAGTdCSEqENFfeDQPfXmREVKaO; // 0x58
		private ButtonValueChangedEventHandler zTJEbAGFgaxBrHgJHWayUGhvKqR; // 0x60
	
		// Properties
		public float buttonActivationThreshold { get => default; } // 0x000000018530D350-0x000000018530D3C0 
		public AxisCalibration calibration { get => default; } // 0x000000018530D5E0-0x000000018530D640 
		public float valueRaw { get => default; } // 0x000000018530D950-0x000000018530D9C0 
		public float valueRawPrev { get => default; } // 0x000000018530D8E0-0x000000018530D950 
		public float value { get => default; } // 0x000000018530D9C0-0x000000018530DA50 
		public float valuePrev { get => default; } // 0x000000018530D850-0x000000018530D8E0 
		public bool rawButtonValue { get => default; } // 0x000000018530D6A0-0x000000018530D700 
		public bool rawButtonValuePrev { get => default; } // 0x000000018530D640-0x000000018530D6A0 
		public bool buttonValue { get => default; } // 0x000000018530D4D0-0x000000018530D5E0 
		public bool buttonValuePrev { get => default; } // 0x000000018530D3C0-0x000000018530D4D0 
		internal float rawMax { get => default; } // 0x000000018530D700-0x000000018530D7B0 
		internal float rawZero { get => default; } // 0x000000018530D7B0-0x000000018530D850 
	
		// Events
		private event AxisValueChangedEventHandler _AxisValueChangedEvent;
		public event AxisValueChangedEventHandler AxisValueChangedEvent;
		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent;
		public event AxisValueChangedEventHandler RawAxisValueChangedEvent;
		private event ButtonDownEventHandler _ButtonDownEvent;
		public event ButtonDownEventHandler ButtonDownEvent;
		private event ButtonUpEventHandler _ButtonUpEvent;
		public event ButtonUpEventHandler ButtonUpEvent;
		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent;
		public event ButtonValueChangedEventHandler ButtonValueChangedEvent;
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public delegate void AxisValueChangedEventHandler(float value); // TypeDefIndex: 4067; 0x00000001852F10C0-0x00000001852F1250
	
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public delegate void ButtonValueChangedEventHandler(bool value); // TypeDefIndex: 4068; 0x00000001852F1A40-0x00000001852F1BD0
	
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public delegate void ButtonDownEventHandler(); // TypeDefIndex: 4069; 0x00000001852F1470-0x00000001852F15D0
	
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public delegate void ButtonUpEventHandler(); // TypeDefIndex: 4070; 0x00000001852F1750-0x00000001852F18B0
	
		// Constructors
		internal StandaloneAxis() {} // 0x000000018530CF60-0x000000018530CFF0
	
		// Methods
		public void SetRawValue(float value) {} // 0x000000018530C830-0x000000018530CE80
		public void Clear() {} // 0x000000018530C2C0-0x000000018530C330
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static StandaloneAxis CreateRelative() => default; // 0x000000018530C330-0x000000018530C3C0
	}
}
