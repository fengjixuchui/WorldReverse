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
	public class fsNullableConverter : fsConverter // TypeDefIndex: 4748
	{
		// Constructors
		public fsNullableConverter() {} // 0x0000000188DD7060-0x0000000188DD70C0
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD6C90-0x0000000188DD6DC0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD6F40-0x0000000188DD7060
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DD6E20-0x0000000188DD6F40
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD6DC0-0x0000000188DD6E20
	}
}
