/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 5378
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		private readonly ThreadSafeStore<TypeNameKey, System.Type> _typeCache; // 0x10
	
		// Nested types
		internal struct TypeNameKey : IEquatable<TypeNameKey> // TypeDefIndex: 5379
		{
			// Fields
			internal readonly string AssemblyName; // 0x00
			internal readonly string TypeName; // 0x08
	
			// Constructors
			public TypeNameKey(string assemblyName, string typeName) {
				AssemblyName = default;
				TypeName = default;
			} // 0x00000001863652D0-0x0000000186365350
	
			// Methods
			public override int GetHashCode() => default; // 0x00000001863652C0-0x00000001863652D0
			public override bool Equals(object obj) => default; // 0x00000001863650E0-0x00000001863651F0
			public bool Equals(TypeNameKey other) => default; // 0x00000001863651F0-0x00000001863652C0
		}
	
		// Constructors
		public DefaultSerializationBinder() {} // 0x0000000186348530-0x0000000186348600
		static DefaultSerializationBinder() {} // 0x00000001863484B0-0x0000000186348530
	
		// Methods
		private static System.Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey) => default; // 0x00000001863481B0-0x00000001863484B0
		public override System.Type BindToType(string assemblyName, string typeName) => default; // 0x00000001863480C0-0x00000001863481B0
	}
}
