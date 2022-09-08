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
	public class fsDateConverter : fsConverter // TypeDefIndex: 4741
	{
		// Fields
		private const string DefaultDateTimeFormatString = "o"; // Metadata: 0x00ADA6E1
		private const string DateTimeOffsetFormatString = "o"; // Metadata: 0x00ADA6E6
	
		// Properties
		private string DateTimeFormatString { get => default; } // 0x0000000188DCFC80-0x0000000188DCFD10 
	
		// Constructors
		public fsDateConverter() {} // 0x0000000188DCFC20-0x0000000188DCFC80
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000188DCEFC0-0x0000000188DCF0D0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000188DCF920-0x0000000188DCFC20
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000188DCF0D0-0x0000000188DCF920
	}
}
