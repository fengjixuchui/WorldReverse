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
	public class MonoSliderSetting : MonoBaseSettingItem // TypeDefIndex: 31042
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _title; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputField; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _sliderContainer; // 0x38
	
		// Properties
		public string description { /* [XID] */ /* 0x0000000189615720-0x0000000189615740 */ set {} } // 0x0000000184FF8820-0x0000000184FF88F0
		public bool enableInputField { /* [XID] */ /* 0x000000018961CF00-0x000000018961CF20 */ set {} } // 0x0000000184FF88F0-0x0000000184FF89C0
		public Slider slider { /* [XID] */ /* 0x0000000189624470-0x0000000189624490 */ get => default; } // 0x0000000184FF8760-0x0000000184FF8820 
		public float sliderShowValue { /* [XID] */ /* 0x000000018962BB40-0x000000018962BB60 */ set {} } // 0x0000000184FF8A80-0x0000000184FF8B50
		public string sliderShowValueStr { /* [XID] */ /* 0x00000001896336B0-0x00000001896336D0 */ set {} } // 0x0000000184FF89C0-0x0000000184FF8A80
	
		// Constructors
		public MonoSliderSetting() {} // 0x0000000184FF86F0-0x0000000184FF8760
	}
}
