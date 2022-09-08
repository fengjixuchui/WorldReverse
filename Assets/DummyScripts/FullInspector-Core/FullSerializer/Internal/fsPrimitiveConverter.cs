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
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 4749
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x0000000188DDA190-0x0000000188DDA1F0
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD8A50-0x0000000188DD8BA0
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000188DD8BA0-0x0000000188DD8BF0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000188DD8BF0-0x0000000188DD8C40
		private static bool UseBool(System.Type type) => default; // 0x0000000188DD9CC0-0x0000000188DD9D60
		private static bool UseInt64(System.Type type) => default; // 0x0000000188DD9E70-0x0000000188DDA0B0
		private static bool UseDouble(System.Type type) => default; // 0x0000000188DD9D60-0x0000000188DD9E70
		private static bool UseString(System.Type type) => default; // 0x0000000188DDA0B0-0x0000000188DDA190
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD9460-0x0000000188DD9CC0
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x0000000188DD8C40-0x0000000188DD9460
	}
}
