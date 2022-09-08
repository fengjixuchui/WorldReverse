/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public static class BehaviorTypeToSerializerTypeMap // TypeDefIndex: 4967
	{
		// Fields
		private static List<SerializationMapping> _mappings; // 0x00
	
		// Nested types
		private struct SerializationMapping // TypeDefIndex: 4968
		{
			// Fields
			public System.Type BehaviorType; // 0x00
			public System.Type SerializerType; // 0x08
		}
	
		// Constructors
		static BehaviorTypeToSerializerTypeMap() {} // 0x0000000185CE9AF0-0x0000000185CE9B80
	
		// Methods
		public static void Register(System.Type behaviorType, System.Type serializerType) {} // 0x0000000185CE9A20-0x0000000185CE9AF0
	}
}
