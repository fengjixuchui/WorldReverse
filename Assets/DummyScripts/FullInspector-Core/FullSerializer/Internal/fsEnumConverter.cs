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
	public class fsEnumConverter : fsConverter // TypeDefIndex: 4743
	{
		// Constructors
		public fsEnumConverter() {} // 0x0000000188DD23A0-0x0000000188DD2400
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD1830-0x0000000188DD1900
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000188DD19B0-0x0000000188DD1A00
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000188DD1A00-0x0000000188DD1A50
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD1900-0x0000000188DD19B0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD1FB0-0x0000000188DD23A0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DD1A50-0x0000000188DD1FB0
		private static bool ArrayContains<T>(T[] values, T value) => default;
	}
}
