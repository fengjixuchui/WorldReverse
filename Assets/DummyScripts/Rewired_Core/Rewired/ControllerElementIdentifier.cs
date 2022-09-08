/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal // TypeDefIndex: 4111
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string _name; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string _positiveName; // 0x20
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string _negativeName; // 0x28
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private ControllerElementType _elementType; // 0x30
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private CompoundControllerElementType _compoundElementType; // 0x34
		internal readonly bool isMappableOnPlatform; // 0x38
		private bool opqFCidZJywDAhKxeolcaVpqNEsC; // 0x39
		private static ControllerElementIdentifier ikKKjpkzjdHJabGJHEcubgXrQyU; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000185E78460-0x0000000185E784C0 
		public string name { get => default; internal set {} } // 0x0000000185E784C0-0x0000000185E78520 0x0000000185E785E0-0x0000000185E78650
		public string positiveName { get => default; internal set {} } // 0x0000000185E78580-0x0000000185E785E0 0x0000000185E786C0-0x0000000185E78820
		public string negativeName { get => default; internal set {} } // 0x0000000185E78520-0x0000000185E78580 0x0000000185E78650-0x0000000185E786C0
		public ControllerElementType elementType { get => default; } // 0x0000000185E78400-0x0000000185E78460 
		internal static ControllerElementIdentifier BlankReadOnly { get => default; } // 0x0000000185E78310-0x0000000185E78400 
	
		// Constructors
		public ControllerElementIdentifier() {} // 0x0000000185E78170-0x0000000185E781D0
		public ControllerElementIdentifier(ControllerElementIdentifier source) {} // 0x0000000185E781D0-0x0000000185E78310
		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform) {} // 0x0000000185E78030-0x0000000185E780E0
		internal ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType) {} // 0x0000000185E780E0-0x0000000185E78170
	
		// Methods
		public ControllerElementIdentifier Clone() => default; // 0x0000000185E77C50-0x0000000185E77CD0
		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange) => default; // 0x0000000185E77CD0-0x0000000185E77FA0
		private void QblXkCsMfRtCRnWiBRNEJpaBQVM() {} // 0x0000000185E77FA0-0x0000000185E78030
	}
}
