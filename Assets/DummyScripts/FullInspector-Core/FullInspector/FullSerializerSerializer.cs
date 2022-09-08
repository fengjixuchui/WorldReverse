/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector.Internal.Preserve;
using FullSerializer;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[Preserve] // 0x00000001896AE370-0x00000001896AE380
	public class FullSerializerSerializer : BaseSerializer // TypeDefIndex: 4812
	{
		// Fields
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static fsSerializer _serializer; // 0xFFFFFFFF
		private static readonly List<fsSerializer> _serializers; // 0x00
		private static readonly List<System.Type> _converters; // 0x08
		private static readonly List<System.Type> _processors; // 0x10
	
		// Properties
		private static fsSerializer Serializer { get => default; } // 0x0000000185CEBFA0-0x0000000185CEC460 
		public override bool SupportsMultithreading { get => default; } // 0x0000000185CEC460-0x0000000185CEC4B0 
	
		// Constructors
		static FullSerializerSerializer() {} // 0x0000000185CEBE00-0x0000000185CEBF00
		public FullSerializerSerializer() {} // 0x0000000185CEBF00-0x0000000185CEBFA0
	
		// Methods
		public static void AddConverter<TConverter>()
			where TConverter : fsConverter, new() {}
		public static void AddProcessor<TProcessor>()
			where TProcessor : fsObjectProcessor, new() {}
		public override string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator) => default; // 0x0000000185CEBC70-0x0000000185CEBE00
		public override object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator) => default; // 0x0000000185CEB9B0-0x0000000185CEBB70
		private static bool EmitFailWarning(fsResult result) => default; // 0x0000000185CEBB70-0x0000000185CEBC70
	}
}
