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
	public class fsArrayConverter : fsConverter // TypeDefIndex: 4740
	{
		// Constructors
		public fsArrayConverter() {} // 0x0000000188DCE830-0x0000000188DCE890
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DCDE10-0x0000000188DCDE90
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000188DCDF50-0x0000000188DCDFA0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000188DCDFA0-0x0000000188DCDFF0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DCE450-0x0000000188DCE830
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DCDFF0-0x0000000188DCE450
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DCDE90-0x0000000188DCDF50
	}
}
