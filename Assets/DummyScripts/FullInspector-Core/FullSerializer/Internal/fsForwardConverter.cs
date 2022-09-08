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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 4744
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x0000000188DD2FF0-0x0000000188DD3080
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DD2400-0x0000000188DD2480
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x0000000188DD2540-0x0000000188DD2880
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DD2CC0-0x0000000188DD2FF0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DD2880-0x0000000188DD2CC0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000188DD2480-0x0000000188DD2540
	}
}
