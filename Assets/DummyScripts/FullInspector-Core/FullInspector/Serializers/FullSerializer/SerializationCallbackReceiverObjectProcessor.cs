/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Serializers.FullSerializer
{
	public class SerializationCallbackReceiverObjectProcessor : fsObjectProcessor // TypeDefIndex: 4961
	{
		// Constructors
		public SerializationCallbackReceiverObjectProcessor() {} // 0x0000000185CF5E10-0x0000000185CF5E90
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000185CF59F0-0x0000000185CF5C30
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000185CF5D70-0x0000000185CF5E10
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000185CF5CD0-0x0000000185CF5D20
		public override void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x0000000185CF5D20-0x0000000185CF5D70
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000185CF5C30-0x0000000185CF5CD0
	}
}
