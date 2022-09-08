/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior // TypeDefIndex: 4149
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int _id; // 0x10
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _joystickAxisSensitivity; // 0x20
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _digitalAxisSimulation; // 0x24
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool _digitalAxisSnap; // 0x25
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private bool _digitalAxisInstantReverse; // 0x26
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _digitalAxisGravity; // 0x28
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _digitalAxisSensitivity; // 0x2C
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private MouseXYAxisMode _mouseXYAxisMode; // 0x30
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private MouseOtherAxisMode _mouseOtherAxisMode; // 0x34
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _mouseXYAxisSensitivity; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; // 0x3C
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _mouseOtherAxisSensitivity; // 0x40
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _customControllerAxisSensitivity; // 0x44
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _buttonDoublePressSpeed; // 0x48
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _buttonShortPressTime; // 0x4C
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _buttonShortPressExpiresIn; // 0x50
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _buttonLongPressTime; // 0x54
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _buttonLongPressExpiresIn; // 0x58
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _buttonDeadZone; // 0x5C
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private float _buttonDownBuffer; // 0x60
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _buttonRepeatRate; // 0x64
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private float _buttonRepeatDelay; // 0x68
	
		// Properties
		public int id { get => default; internal set {} } // 0x0000000185835790-0x00000001858357F0 0x0000000185836110-0x0000000185836170
		public string name { get => default; internal set {} } // 0x0000000185835A60-0x0000000185835AC0 0x0000000185836360-0x00000001858363C0
		public float joystickAxisSensitivity { get => default; } // 0x00000001858357F0-0x0000000185835860 
		public bool digitalAxisSimulation { get => default; set {} } // 0x00000001858356D0-0x0000000185835730 0x0000000185836050-0x00000001858360B0
		public bool digitalAxisSnap { get => default; set {} } // 0x0000000185835730-0x0000000185835790 0x00000001858360B0-0x0000000185836110
		public bool digitalAxisInstantReverse { get => default; set {} } // 0x0000000185835600-0x0000000185835660 0x0000000185835F60-0x0000000185835FC0
		public float digitalAxisGravity { get => default; set {} } // 0x0000000185835590-0x0000000185835600 0x0000000185835EB0-0x0000000185835F60
		public float digitalAxisSensitivity { get => default; set {} } // 0x0000000185835660-0x00000001858356D0 0x0000000185835FC0-0x0000000185836050
		public MouseXYAxisMode mouseXYAxisMode { get => default; set {} } // 0x0000000185835990-0x00000001858359F0 0x0000000185836260-0x00000001858362C0
		public MouseOtherAxisMode mouseOtherAxisMode { get => default; set {} } // 0x0000000185835860-0x00000001858358C0 0x0000000185836170-0x00000001858361D0
		public float mouseXYAxisSensitivity { get => default; set {} } // 0x00000001858359F0-0x0000000185835A60 0x00000001858362C0-0x0000000185836360
		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc { get => default; } // 0x0000000185835930-0x0000000185835990 
		public float mouseOtherAxisSensitivity { get => default; set {} } // 0x00000001858358C0-0x0000000185835930 0x00000001858361D0-0x0000000185836260
		public float customControllerAxisSensitivity { get => default; } // 0x0000000185835520-0x0000000185835590 
		public float buttonDoublePressSpeed { get => default; set {} } // 0x00000001858351A0-0x0000000185835210 0x0000000185835B50-0x0000000185835BE0
		public float buttonShortPressTime { get => default; set {} } // 0x00000001858354B0-0x0000000185835520 0x0000000185835E20-0x0000000185835EB0
		public float buttonShortPressExpiresIn { get => default; set {} } // 0x0000000185835440-0x00000001858354B0 0x0000000185835D90-0x0000000185835E20
		public float buttonLongPressTime { get => default; set {} } // 0x00000001858352F0-0x0000000185835360 0x0000000185835D00-0x0000000185835D90
		public float buttonLongPressExpiresIn { get => default; set {} } // 0x0000000185835280-0x00000001858352F0 0x0000000185835C70-0x0000000185835D00
		public float buttonDeadZone { get => default; set {} } // 0x0000000185835130-0x00000001858351A0 0x0000000185835AC0-0x0000000185835B50
		public float buttonDownBuffer { get => default; set {} } // 0x0000000185835210-0x0000000185835280 0x0000000185835BE0-0x0000000185835C70
		public float buttonRepeatRate { get => default; } // 0x00000001858353D0-0x0000000185835440 
		public float buttonRepeatDelay { get => default; } // 0x0000000185835360-0x00000001858353D0 
	
		// Constructors
		public InputBehavior() {} // 0x00000001858350A0-0x0000000185835130
		public InputBehavior(InputBehavior source) {} // 0x0000000185835010-0x00000001858350A0
	
		// Methods
		public string ToXmlString() => default; // 0x0000000185834520-0x0000000185834650
		public bool ImportXmlString(string xmlString) => default; // 0x0000000185834000-0x0000000185834130
		public InputBehavior Clone() => default; // 0x0000000185833F80-0x0000000185834000
		public void Reset() {} // 0x0000000185834130-0x00000001858341F0
		internal SerializedObject ZIeRIePeTSQWAIzEhmUQcKNbKpi() => default; // 0x0000000185834650-0x0000000185835010
		internal void wdORaALJIVHeMdYgqVfHekvpUfr(SerializedObject param_00008ad0) {} // 0x00000001858363C0-0x0000000185836710
		private static void TmfijbZUILGIfPMjACWKbxEIKPo(InputBehavior param_00008ad1, InputBehavior param_00008ad2, bool param_00008ad3) {} // 0x00000001858341F0-0x0000000185834520
	}
}
