/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal // TypeDefIndex: 3928
	{
		// Fields
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string description; // 0x20
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string templateGuid; // 0x28
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string className; // 0x30
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; // 0x38
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<Entry> joysticks; // 0x40
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private SpecialElementEntry[] specialElements; // 0x48
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int elementIdentifierIdCounter; // 0x50
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int joystickIdCounter; // 0x54
	
		// Properties
		public override Guid Guid { get => default; } // 0x00000001850FC620-0x00000001850FC6C0 
		public string ControllerName { get => default; } // 0x00000001850FC520-0x00000001850FC580 
		public string ClassName { get => default; } // 0x00000001850FC4C0-0x00000001850FC520 
		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers { get => default; } // 0x00000001850FC580-0x00000001850FC620 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get => default; } // 0x00000001850FADA0-0x00000001850FAE40 
		string IHardwareControllerTemplateMap_Internal.name { get => default; } // 0x00000001850FB6B0-0x00000001850FB710 
		Guid IHardwareControllerTemplateMap_Internal.typeGuid { get => default; } // 0x00000001850FB710-0x00000001850FB7A0 
	
		// Nested types
		[Serializable]
		public sealed class Entry // TypeDefIndex: 3929
		{
			// Fields
			public int id; // 0x10
			public string name; // 0x18
			public string joystickGuid; // 0x20
			public string fileGuid; // 0x28
			public List<ElementIdentifierMap> elementIdentifierMappings; // 0x30
	
			// Properties
			public Guid JoystickGuid { get => default; } // 0x00000001850F92F0-0x00000001850F9420 
	
			// Constructors
			public Entry() {} // 0x00000001850F9290-0x00000001850F92F0
	
			// Methods
			public int GetTemplateElementId(int joystickElementId) => default; // 0x00000001850F9150-0x00000001850F9290
			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results) {} // 0x00000001850F8FD0-0x00000001850F9150
		}
	
		[Serializable]
		public sealed class ElementIdentifierMap // TypeDefIndex: 3930
		{
			// Fields
			public int templateId; // 0x10
			public int joystickId; // 0x14
			public int joystickId2; // 0x18
			public bool splitAxis; // 0x1C
	
			// Constructors
			public ElementIdentifierMap() {} // 0x00000001850F7560-0x00000001850F75C0
		}
	
		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 3931
		{
			// Fields
			public int elementIdentifierId; // 0x10
			public string data; // 0x18
	
			// Constructors
			public SpecialElementEntry() {} // 0x0000000185106520-0x0000000185106590
	
			// Methods
			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>()
				where T : ControllerTemplateSpecialElementMapping => default;
		}
	
		// Constructors
		public HardwareJoystickTemplateMap() {} // 0x00000001850FB7A0-0x00000001850FB830
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id) => default; // 0x00000001850F9920-0x00000001850F9A00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public bool ContainsElementIdentifier(int id) => default; // 0x00000001850F9420-0x00000001850F94A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public string[] GetElementIdentifierNames() => default; // 0x00000001850F95E0-0x00000001850F9770
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int[] GetElementIdentifierIds() => default; // 0x00000001850F94A0-0x00000001850F95E0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate) => default; // 0x00000001850F9770-0x00000001850F9920
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) {
			names = default;
			ids = default;
			return default;
		} // 0x00000001850FA240-0x00000001850FA6F0
		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids) {
			names = default;
			ids = default;
			return default;
		} // 0x00000001850FA6F0-0x00000001850FAB90
		public string[] GetJoystickNames() => default; // 0x00000001850FA0F0-0x00000001850FA240
		public int[] GetJoystickIds() => default; // 0x00000001850F9F80-0x00000001850FA0F0
		public Guid GetJoystickGuid(int joystickId) => default; // 0x00000001850F9B90-0x00000001850F9DB0
		public int GetJoystickId(Guid guid) => default; // 0x00000001850F9DB0-0x00000001850F9F80
		public string GetJoystickFileGuidString(int joystickId) => default; // 0x00000001850F9A00-0x00000001850F9B90
		internal bool gXYtfQHDORUhFLHiQPsElDGjDcyi(ControllerMap_Editor param_0000849d, HardwareJoystickMap param_0000849e, Guid param_0000849f, out string param_000084a0) {
			param_000084a0 = default;
			return default;
		} // 0x00000001850FB9F0-0x00000001850FC4C0
		internal ControllerTemplateElementIdentifier kZyebRAzUtSAJHkfiJvLlRHqLYz(Guid param_000084a1, int param_000084a2) => default; // 0x00000001850FC6C0-0x00000001850FC9A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal SpecialElementEntry[] GetSpecialElementsOrig() => default; // 0x00000001850FAB90-0x00000001850FABF0
		private Entry aiHwPNekHXEhGGWjXNksfPnxocu(Guid param_000084a3) => default; // 0x00000001850FB830-0x00000001850FB9F0
		private int PehHoCchNiANONEXkwEgzBLPEmn(int param_000084a4) => default; // 0x00000001850FABF0-0x00000001850FAD20
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int param_000084a5) => default; // 0x00000001850FAD20-0x00000001850FADA0
		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount() => default; // 0x00000001850FB3B0-0x00000001850FB420
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int param_000084a6) => default; // 0x00000001850FB620-0x00000001850FB6B0
		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int param_000084a7) => default; // 0x00000001850FB5A0-0x00000001850FB620
		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int param_000084a8) => default; // 0x00000001850FB420-0x00000001850FB5A0
		qFwngCMEUbVOUWUBpxMUVdPUzPt IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller param_000084a9, int param_000084aa) => default; // 0x00000001850FAE40-0x00000001850FB120
		qFwngCMEUbVOUWUBpxMUVdPUzPt IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller param_000084ab, int param_000084ac) => default; // 0x00000001850FB120-0x00000001850FB3B0
	}
}
