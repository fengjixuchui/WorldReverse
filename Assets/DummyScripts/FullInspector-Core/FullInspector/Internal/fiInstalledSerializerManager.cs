/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public static class fiInstalledSerializerManager // TypeDefIndex: 5016
	{
		// Fields
		private static fiISerializerMetadata _defaultMetadata; // 0x08
	
		// Properties
		public static List<fiISerializerMetadata> LoadedMetadata { get; private set; } // 0x0000000185CFF310-0x0000000185CFF3A0 0x0000000185CFF4C0-0x0000000185CFF550
		public static fiISerializerMetadata DefaultMetadata { get; } // 0x0000000185CFF220-0x0000000185CFF310 
		public static System.Type[] SerializationOptInAnnotations { get; private set; } // 0x0000000185CFF3A0-0x0000000185CFF430 0x0000000185CFF550-0x0000000185CFF5E0
		public static System.Type[] SerializationOptOutAnnotations { get; private set; } // 0x0000000185CFF430-0x0000000185CFF4C0 0x0000000185CFF5E0-0x0000000185CFF670
	
		// Constructors
		static fiInstalledSerializerManager() {} // 0x0000000185CFE910-0x0000000185CFF220
	
		// Methods
		private static fiISerializerMetadata GetProvider(System.Type type) => default; // 0x0000000185CFE740-0x0000000185CFE7F0
		public static bool TryGetLoadedSerializerType(out fiILoadedSerializers serializers) {
			serializers = default;
			return default;
		} // 0x0000000185CFE7F0-0x0000000185CFE910
	}
}
