/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Serializers.FullSerializer
{
	public class UnityObjectConverter : fsConverter // TypeDefIndex: 4962
	{
		// Constructors
		public UnityObjectConverter() {} // 0x0000000185CF8360-0x0000000185CF83C0
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000185CF7DD0-0x0000000185CF7ED0
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000185CF7F30-0x0000000185CF7F80
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000185CF7F80-0x0000000185CF7FD0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000185CF8170-0x0000000185CF8360
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000185CF7FD0-0x0000000185CF8170
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185CF7ED0-0x0000000185CF7F30
	}
}
