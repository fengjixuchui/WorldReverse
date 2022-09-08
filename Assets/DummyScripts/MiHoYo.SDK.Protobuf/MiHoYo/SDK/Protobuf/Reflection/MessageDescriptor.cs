/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 5198
	{
		// Fields
		private static readonly HashSet<string> WellKnownTypeNames; // 0x00
		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x28
		private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x30
		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x38
	
		// Properties
		public override string Name { get => default; } // 0x0000000187D5EB70-0x0000000187D5EC20 
		internal DescriptorProto Proto { get; } // 0x0000000187D5ED40-0x0000000187D5EDA0 
		public System.Type ClrType { get; } // 0x0000000187D5E850-0x0000000187D5E8B0 
		public MiHoYo.SDK.Protobuf.MessageParser Parser { get; } // 0x0000000187D5ECE0-0x0000000187D5ED40 
		internal bool IsWellKnownType { get => default; } // 0x0000000187D5E910-0x0000000187D5EA50 
		internal bool IsWrapperType { get => default; } // 0x0000000187D5EA50-0x0000000187D5EB70 
		public FieldCollection Fields { get; } // 0x0000000187D5E8B0-0x0000000187D5E910 
		public IList<MessageDescriptor> NestedTypes { get; } // 0x0000000187D5EC20-0x0000000187D5EC80 
		public IList<OneofDescriptor> Oneofs { get; } // 0x0000000187D5EC80-0x0000000187D5ECE0 
	
		// Nested types
		public sealed class FieldCollection // TypeDefIndex: 5199
		{
			// Fields
			private readonly MessageDescriptor messageDescriptor; // 0x10
	
			// Properties
			public FieldDescriptor this[int number] { get => default; } // 0x0000000187D593E0-0x0000000187D594A0 
	
			// Constructors
			public FieldCollection() {} // Dummy constructor
			internal FieldCollection(MessageDescriptor messageDescriptor) {} // 0x0000000187D59370-0x0000000187D593E0
	
			// Methods
			public IList<FieldDescriptor> InDeclarationOrder() => default; // 0x0000000187D59290-0x0000000187D59300
			public IList<FieldDescriptor> InFieldNumberOrder() => default; // 0x0000000187D59300-0x0000000187D59370
		}
	
		// Constructors
		public MessageDescriptor() {} // Dummy constructor
		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000187D5E360-0x0000000187D5E850
		static MessageDescriptor() {} // 0x0000000187D5E1F0-0x0000000187D5E360
	
		// Methods
		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) => default; // 0x0000000187D5D770-0x0000000187D5DA10
		public FieldDescriptor FindFieldByNumber(int number) => default; // 0x0000000187D5E140-0x0000000187D5E1F0
		internal void CrossLink() {} // 0x0000000187D5DA10-0x0000000187D5E140
	}
}
