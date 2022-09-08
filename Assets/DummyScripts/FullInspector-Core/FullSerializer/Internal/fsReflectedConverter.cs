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
	public class fsReflectedConverter : fsConverter // TypeDefIndex: 4750
	{
		// Constructors
		public fsReflectedConverter() {} // 0x0000000188DDAD70-0x0000000188DDADD0
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DDA340-0x0000000188DDA480
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DDA9F0-0x0000000188DDAD70
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DDA540-0x0000000188DDA9F0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DDA480-0x0000000188DDA540
	}
}
