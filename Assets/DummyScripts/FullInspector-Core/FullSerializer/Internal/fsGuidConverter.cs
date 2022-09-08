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
	public class fsGuidConverter : fsConverter // TypeDefIndex: 4745
	{
		// Constructors
		public fsGuidConverter() {} // 0x0000000188DD34C0-0x0000000188DD3520
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD3080-0x0000000188DD3120
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000188DD31A0-0x0000000188DD31F0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000188DD31F0-0x0000000188DD3240
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD33A0-0x0000000188DD34C0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DD3240-0x0000000188DD33A0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD3120-0x0000000188DD31A0
	}
}
