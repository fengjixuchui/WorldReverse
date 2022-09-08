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
	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 4752
	{
		// Constructors
		public fsWeakReferenceConverter() {} // 0x0000000188DE4710-0x0000000188DE4A70
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DE3C00-0x0000000188DE3CA0
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000188DE3D20-0x0000000188DE3D70
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000188DE3D70-0x0000000188DE3DC0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DE4340-0x0000000188DE4710
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DE3DC0-0x0000000188DE4340
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DE3CA0-0x0000000188DE3D20
	}
}
