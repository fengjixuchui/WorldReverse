/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap // TypeDefIndex: 4104
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal int _actionCategoryId; // 0x10
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal int _actionId; // 0x14
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal ControllerElementType _elementType; // 0x18
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		internal int _elementIdentifierId; // 0x1C
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal AxisRange _axisRange; // 0x20
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal bool _invert; // 0x24
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		internal Pole _axisContribution; // 0x28
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		internal KeyboardKeyCode _keyboardKeyCode; // 0x2C
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		internal ModifierKey _modifierKey1; // 0x30
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal ModifierKey _modifierKey2; // 0x34
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		internal ModifierKey _modifierKey3; // 0x38
		[NonSerialized]
		internal ControllerMap JdetZGSYAxuUPraClBlCSLMWOmU; // 0x40
		[NonSerialized]
		internal bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x48
		[NonSerialized]
		internal string ccLqwqerDNLPbYOQRmZkNRvlnZD; // 0x50
		[NonSerialized]
		internal string jUqISdUetYbnjgLgoIZFzsPzuHC; // 0x58
		[NonSerialized]
		internal int mMyVYAPDqUrVlKvCuSgnRJfZwdm; // 0x60
		[NonSerialized]
		internal readonly int rOuBUzbbciWwktcpmiPWpQIKoaAa; // 0x64
		private static int uidCounter; // 0x00
		private static StringBuilder s_toStringSB; // 0x08
	
		// Properties
		public int actionId { get => default; } // 0x0000000185A94140-0x0000000185A941A0 
		public ControllerElementType elementType { get => default; internal set {} } // 0x0000000185A94450-0x0000000185A944B0 0x0000000185A95670-0x0000000185A956D0
		public int elementIdentifierId { get => default; set {} } // 0x0000000185A94330-0x0000000185A94390 0x0000000185A953D0-0x0000000185A95670
		public AxisRange axisRange { get => default; set {} } // 0x0000000185A94200-0x0000000185A94260 0x0000000185A952B0-0x0000000185A953D0
		public bool invert { get => default; set {} } // 0x0000000185A94610-0x0000000185A94670 0x0000000185A956D0-0x0000000185A95730
		public Pole axisContribution { get => default; set {} } // 0x0000000185A941A0-0x0000000185A94200 0x0000000185A951F0-0x0000000185A952B0
		public KeyboardKeyCode keyboardKeyCode { get => default; set {} } // 0x0000000185A94760-0x0000000185A947C0 0x0000000185A957B0-0x0000000185A958B0
		public ModifierKey modifierKey1 { get => default; } // 0x0000000185A947C0-0x0000000185A94820 
		public ModifierKey modifierKey2 { get => default; } // 0x0000000185A94820-0x0000000185A94880 
		public ModifierKey modifierKey3 { get => default; } // 0x0000000185A94880-0x0000000185A948E0 
		public AxisType axisType { get => default; } // 0x0000000185A94260-0x0000000185A942D0 
		public ModifierKeyFlags modifierKeyFlags { get => default; } // 0x0000000185A948E0-0x0000000185A94980 
		public KeyCode keyCode { get => default; set {} } // 0x0000000185A946F0-0x0000000185A94760 0x0000000185A95730-0x0000000185A957B0
		public bool hasModifiers { get => default; } // 0x0000000185A94510-0x0000000185A945B0 
		public ControllerMap controllerMap { get => default; } // 0x0000000185A942D0-0x0000000185A94330 
		public bool enabled { get => default; } // 0x0000000185A944B0-0x0000000185A94510 
		public string elementIdentifierName { get => default; } // 0x0000000185A94390-0x0000000185A943F0 
		public string actionDescriptiveName { get => default; } // 0x0000000185A940E0-0x0000000185A94140 
		public int elementIndex { get => default; } // 0x0000000185A943F0-0x0000000185A94450 
		public int id { get => default; } // 0x0000000185A945B0-0x0000000185A94610 
		private bool isKeyboardMap { get => default; } // 0x0000000185A94670-0x0000000185A946F0 
		private static int nextUid { get => default; } // 0x0000000185A94980-0x0000000185A94AE0 
	
		// Constructors
		public ActionElementMap() {} // 0x0000000185A93CF0-0x0000000185A93D90
		public ActionElementMap(ActionElementMap map) {} // 0x0000000185A94040-0x0000000185A940E0
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange) {} // 0x0000000185A93F80-0x0000000185A94040
		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert) {} // 0x0000000185A93D90-0x0000000185A93E40
		public ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3) {} // 0x0000000185A93E40-0x0000000185A93F80
		static ActionElementMap() {} // 0x0000000185A93C90-0x0000000185A93CF0
	
		// Methods
		internal static bool lrnrCzJkUCjDHPoqSOHzRASvAkAd(ActionElementMap param_000088ae) => default; // 0x0000000185A94C10-0x0000000185A94CD0
		internal static void qgsdKNFPMNwQyZTFEZFcvtiRJvm(ActionElementMap param_000088af, ActionElementMap param_000088b0) {} // 0x0000000185A94F50-0x0000000185A951F0
		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment) => default; // 0x0000000185A92000-0x0000000185A92180
		public bool CheckForAssignmentConflict(ActionElementMap elementMap) => default; // 0x0000000185A91E70-0x0000000185A92000
		public bool ShowInField(AxisRange fieldActionRange) => default; // 0x0000000185A930D0-0x0000000185A93350
		public bool IsTarget(IControllerElementTarget elementTarget) => default; // 0x0000000185A92C80-0x0000000185A92F60
		internal void IKsKsQjqHpGcmPftZSVTCEpXtFB(ControllerMap param_000088cf) {} // 0x0000000185A92AC0-0x0000000185A92BA0
		private void IKsKsQjqHpGcmPftZSVTCEpXtFB(bool param_000088d0) {} // 0x0000000185A92BA0-0x0000000185A92C80
		private void IKsKsQjqHpGcmPftZSVTCEpXtFB(ControllerType param_000088d1, HardwareControllerMap_Game param_000088d2, bool param_000088d3) {} // 0x0000000185A92450-0x0000000185A92AC0
		private void vqhKBZdPDCprRoXORisLFpTMfls() {} // 0x0000000185A958B0-0x0000000185A95CB0
		internal void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x0000000185A94CD0-0x0000000185A94E00
		private bool YCgclHbbGNoPDuziLFIrwrZRnhjU(KeyboardKeyCode param_000088d4, ModifierKeyFlags param_000088d5) => default; // 0x0000000185A93BE0-0x0000000185A93C90
		private bool ogHpLKiGYnmnmTgAiHhxornbzvc(int param_000088d6, AxisRange param_000088d7) => default; // 0x0000000185A94E00-0x0000000185A94F50
		private bool iGatOJnTiRWMQCgrdKhDscmElMv(ElementAssignmentType param_000088d8) => default; // 0x0000000185A94AE0-0x0000000185A94C10
		private void xooIDYnnQgtVptGzEJXHHUhVVdc() {} // 0x0000000185A95FB0-0x0000000185A96020
		private void OfdlLMePveHqkaPWXgpevlpOPzm() {} // 0x0000000185A92F60-0x0000000185A930D0
		internal SerializedObject wGWQXZtIQyRkZMrIKWqTSlWZlQY() => default; // 0x0000000185A95CB0-0x0000000185A95FB0
		internal void DzhGtommJNlpRFKUAFaKGOCHKTz(SerializedObject param_000088d9) {} // 0x0000000185A92180-0x0000000185A92450
		public override string ToString() => default; // 0x0000000185A93350-0x0000000185A93BE0
	}
}
