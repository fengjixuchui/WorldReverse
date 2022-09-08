/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 4753
	{
		// Constructors
		public fsSerializationCallbackProcessor() {} // 0x0000000188DDC3D0-0x0000000188DDC470
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DDBDC0-0x0000000188DDBE80
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000188DDC300-0x0000000188DDC3D0
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DDBF50-0x0000000188DDC030
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DDC030-0x0000000188DDC300
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000188DDBE80-0x0000000188DDBF50
	}
}
