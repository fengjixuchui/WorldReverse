/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	[Preserve] // 0x0000000189803330-0x0000000189803340
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable // TypeDefIndex: 3486
	{
		// Fields
		[Serialize] // 0x0000000189BD70F0-0x0000000189BD7130
		[SerializeField] // 0x0000000189BD70F0-0x0000000189BD7130
		private Type _type; // 0x10
		[Serialize] // 0x00000001895E6CF0-0x00000001895E6D30
		[SerializeField] // 0x00000001895E6CF0-0x00000001895E6D30
		private ControllerType _controllerType; // 0x14
		[Serialize] // 0x00000001895F2CD0-0x00000001895F2D20
		[SerializeField] // 0x00000001895F2CD0-0x00000001895F2D20
		private string _guid; // 0x18
		[Serialize] // 0x00000001895FEC10-0x00000001895FEC50
		[SerializeField] // 0x00000001895FEC10-0x00000001895FEC50
		private string _hardwareIdentifier; // 0x20
		[Serialize] // 0x000000018960B140-0x000000018960B180
		[SerializeField] // 0x000000018960B140-0x000000018960B180
		private int _controllerId; // 0x28
		[NonSerialized]
		private Guid BVYaTrLWdjEMRUrycmhzODtgLLX; // 0x2C
	
		// Properties
		internal bool hasControllerType { get => default; } // 0x0000000185D60600-0x0000000185D60660 
		public Type type { get => default; } // 0x0000000185D60660-0x0000000185D606C0 
		public ControllerType controllerType { get => default; } // 0x0000000185D603C0-0x0000000185D60420 
		public Guid hardwareTypeGuid { get => default; } // 0x0000000185D60540-0x0000000185D60600 
		public string hardwareIdentifier { get => default; } // 0x0000000185D604E0-0x0000000185D60540 
		public Guid controllerTemplateTypeGuid { get => default; } // 0x0000000185D60300-0x0000000185D603C0 
		public Guid deviceInstanceGuid { get => default; } // 0x0000000185D60420-0x0000000185D604E0 
		public int controllerId { get => default; } // 0x0000000185D602A0-0x0000000185D60300 
	
		// Nested types
		public enum Type // TypeDefIndex: 3487
		{
			All = 0,
			ControllerType = 1,
			HardwareType = 2,
			ControllerTemplateType = 3,
			PersistentControllerInstance = 4,
			SessionControllerInstance = 5
		}
	
		// Constructors
		internal ControllerSetSelector(Type type) {} // 0x0000000185D60110-0x0000000185D601D0
		public ControllerSetSelector() {} // 0x0000000185D5FFD0-0x0000000185D60040
		public ControllerSetSelector(ControllerSetSelector source) {} // 0x0000000185D601D0-0x0000000185D602A0
		internal ControllerSetSelector(Type type, ControllerType controllerType, string guid, string hardwareIdentifier, int controllerId) {} // 0x0000000185D60040-0x0000000185D60110
	
		// Methods
		public bool Matches(Controller controller) => default; // 0x0000000185D5F910-0x0000000185D5FC50
		public override string ToString() => default; // 0x0000000185D5FCD0-0x0000000185D5FEE0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000185D5FEE0-0x0000000185D5FF80
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185D5FF80-0x0000000185D5FFD0
		object IDeepCloneable.DeepClone() => default; // 0x0000000185D5FC50-0x0000000185D5FCD0
	}
}
