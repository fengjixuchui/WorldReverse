/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
	// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
	public sealed class CustomController_Editor // TypeDefIndex: 3753
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string _name; // 0x10
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _descriptiveName; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int _id; // 0x20
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _typeGuidString; // 0x28
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<ControllerElementIdentifier> _elementIdentifiers; // 0x30
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Axis> _axes; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Button> _buttons; // 0x40
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int _elementIdentifierIdCounter; // 0x48
	
		// Properties
		public string name { get => default; } // 0x0000000185D693C0-0x0000000185D69420 
		public string descriptiveName { get => default; } // 0x0000000185D69300-0x0000000185D69360 
		public int id { get => default; } // 0x0000000185D69360-0x0000000185D693C0 
		public Guid typeGuid { get => default; } // 0x0000000185D69480-0x0000000185D69520 
		internal string typeGuidString { get => default; } // 0x0000000185D69420-0x0000000185D69480 
		public List<Axis> axes { get => default; } // 0x0000000185D69040-0x0000000185D690A0 
		public List<Button> buttons { get => default; } // 0x0000000185D692A0-0x0000000185D69300 
		public int buttonCount { get => default; } // 0x0000000185D691A0-0x0000000185D692A0 
		public int axisCount { get => default; } // 0x0000000185D690A0-0x0000000185D691A0 
	
		// Nested types
		[Serializable]
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public abstract class Element // TypeDefIndex: 3754
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string name; // 0x18
	
			// Constructors
			public Element() {} // 0x0000000185D6AA00-0x0000000185D6AA60
		}
	
		[Serializable]
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class Button : Element // TypeDefIndex: 3755
		{
			// Constructors
			public Button() {} // 0x0000000185D54670-0x0000000185D54710
		}
	
		[Serializable]
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class Axis : Element // TypeDefIndex: 3756
		{
			// Fields
			public AxisRange range; // 0x20
			public bool invert; // 0x24
			public float deadZone; // 0x28
			public float zero; // 0x2C
			public float min; // 0x30
			public float max; // 0x34
			public bool doNotCalibrateRange; // 0x38
			public AxisSensitivityType sensitivityType; // 0x3C
			public float sensitivity; // 0x40
			public AnimationCurve sensitivityCurve; // 0x48
			public HardwareAxisInfo axisInfo; // 0x50
	
			// Constructors
			public Axis() {} // 0x0000000185D545B0-0x0000000185D54670
		}
	
		// Constructors
		public CustomController_Editor() {} // 0x0000000185D68CA0-0x0000000185D68D70
	
		// Methods
		public string[] GetElementIdentifierNames() => default; // 0x0000000185D67D30-0x0000000185D67E90
		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted() => default; // 0x0000000185D67F30-0x0000000185D68310
		public bool ContainsElementIdentifier(int id) => default; // 0x0000000185D67C40-0x0000000185D67D30
		public int IndexOfElementIdentifier(int id) => default; // 0x0000000185D68310-0x0000000185D68420
		public ControllerElementIdentifier GetElementIdentifier(int id) => default; // 0x0000000185D67E90-0x0000000185D67F30
		internal ControllerElementType nPiClkKTjgGtnbhecTFAsHefaluP(int param_00008216) => default; // 0x0000000185D69520-0x0000000185D697C0
		internal bool fEwMNGJEXLDKgbjybglSRKStSQuf(int param_00008217, out AxisRange param_00008218) {
			param_00008218 = default;
			return default;
		} // 0x0000000185D68D70-0x0000000185D69040
		internal HardwareControllerMap_Game KDogQqmgPVdWpEwZDagggKagBxV() => default; // 0x0000000185D68420-0x0000000185D68CA0
	}
}
