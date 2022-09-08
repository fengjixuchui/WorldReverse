/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer.Internal
{
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 4742
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x0000000188DD17D0-0x0000000188DD1830
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD0110-0x0000000188DD01D0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD01D0-0x0000000188DD0290
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x0000000188DD0400-0x0000000188DD1090
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD1090-0x0000000188DD17D0
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value) => default; // 0x0000000188DCFD10-0x0000000188DD0110
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType) {
			keyStorageType = default;
			valueStorageType = default;
		} // 0x0000000188DD0290-0x0000000188DD0400
	}
}
