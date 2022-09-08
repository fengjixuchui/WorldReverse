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
	public class fsTypeConverter : fsConverter // TypeDefIndex: 4751
	{
		// Constructors
		public fsTypeConverter() {} // 0x0000000188DE1E00-0x0000000188DE1E60
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DE1920-0x0000000188DE19E0
		public override bool RequestCycleSupport(System.Type type) => default; // 0x0000000188DE1A40-0x0000000188DE1A90
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x0000000188DE1A90-0x0000000188DE1AE0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DE1CC0-0x0000000188DE1E00
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DE1AE0-0x0000000188DE1CC0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DE19E0-0x0000000188DE1A40
	}
}
