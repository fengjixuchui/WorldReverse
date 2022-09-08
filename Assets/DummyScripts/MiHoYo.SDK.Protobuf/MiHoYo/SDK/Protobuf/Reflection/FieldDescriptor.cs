/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 5190
	{
		// Fields
		private EnumDescriptor enumType; // 0x28
		private MessageDescriptor messageType; // 0x30
		private FieldType fieldType; // 0x38
		private readonly string propertyName; // 0x40
		private IFieldAccessor accessor; // 0x48
	
		// Properties
		public MessageDescriptor ContainingType { get; } // 0x00000001864FFAF0-0x00000001864FFB50 
		public OneofDescriptor ContainingOneof { get; } // 0x00000001864FFA90-0x00000001864FFAF0 
		public string JsonName { get; } // 0x00000001864FFED0-0x00000001864FFF30 
		internal FieldDescriptorProto Proto { get; } // 0x0000000186500010-0x0000000186500070 
		public override string Name { get => default; } // 0x00000001864FFF30-0x0000000186500010 
		public IFieldAccessor Accessor { get => default; } // 0x00000001864FFA30-0x00000001864FFA90 
		public bool IsRepeated { get => default; } // 0x00000001864FFDF0-0x00000001864FFED0 
		public bool IsMap { get => default; } // 0x00000001864FFC90-0x00000001864FFDF0 
		public FieldType FieldType { get => default; } // 0x00000001864FFC30-0x00000001864FFC90 
		public int FieldNumber { get => default; } // 0x00000001864FFB50-0x00000001864FFC30 
	
		// Constructors
		public FieldDescriptor() {} // Dummy constructor
		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName) {} // 0x00000001864FF450-0x00000001864FFA30
	
		// Methods
		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type) => default; // 0x00000001864FF2E0-0x00000001864FF450
		public int CompareTo(FieldDescriptor other) => default; // 0x00000001864FE730-0x00000001864FE870
		internal void CrossLink() {} // 0x00000001864FEAC0-0x00000001864FF2E0
		private IFieldAccessor CreateAccessor() => default; // 0x00000001864FE870-0x00000001864FEAC0
	}
}
