/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	internal sealed class FieldDescriptorProto : MiHoYo.SDK.Protobuf.IMessage<FieldDescriptorProto> // TypeDefIndex: 5129
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FieldDescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private int number_; // 0x18
		private Types.Label label_; // 0x1C
		private Types.Type type_; // 0x20
		private string typeName_; // 0x28
		private string extendee_; // 0x30
		private string defaultValue_; // 0x38
		private int oneofIndex_; // 0x40
		private string jsonName_; // 0x48
		private FieldOptions options_; // 0x50
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FieldDescriptorProto> Parser { get => default; } // 0x00000001864FE1C0-0x00000001864FE250 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001864FDDD0-0x00000001864FDF20 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864FE310-0x00000001864FE390 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x00000001864FE040-0x00000001864FE0A0 0x00000001864FE510-0x00000001864FE590
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int Number { get => default; set {} } // 0x00000001864FE0A0-0x00000001864FE100 0x00000001864FE590-0x00000001864FE5F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Types.Label Label { get => default; } // 0x00000001864FDFE0-0x00000001864FE040 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Types.Type Type { get => default; } // 0x00000001864FE2B0-0x00000001864FE310 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string TypeName { get => default; set {} } // 0x00000001864FE250-0x00000001864FE2B0 0x00000001864FE6B0-0x00000001864FE730
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Extendee { get => default; set {} } // 0x00000001864FDF20-0x00000001864FDF80 0x00000001864FE410-0x00000001864FE490
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string DefaultValue { get => default; set {} } // 0x00000001864FDD70-0x00000001864FDDD0 0x00000001864FE390-0x00000001864FE410
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int OneofIndex { get => default; set {} } // 0x00000001864FE100-0x00000001864FE160 0x00000001864FE5F0-0x00000001864FE650
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string JsonName { get => default; set {} } // 0x00000001864FDF80-0x00000001864FDFE0 0x00000001864FE490-0x00000001864FE510
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldOptions Options { get => default; set {} } // 0x00000001864FE160-0x00000001864FE1C0 0x00000001864FE650-0x00000001864FE6B0
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5130
		{
			// Nested types
			internal enum Type // TypeDefIndex: 5131
			{
				Double = 1,
				Float = 2,
				Int64 = 3,
				Uint64 = 4,
				Int32 = 5,
				Fixed64 = 6,
				Fixed32 = 7,
				Bool = 8,
				String = 9,
				Group = 10,
				Message = 11,
				Bytes = 12,
				Uint32 = 13,
				Enum = 14,
				Sfixed32 = 15,
				Sfixed64 = 16,
				Sint32 = 17,
				Sint64 = 18
			}
	
			internal enum Label // TypeDefIndex: 5132
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldDescriptorProto() {} // 0x00000001864FDB60-0x00000001864FDC10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldDescriptorProto(FieldDescriptorProto other) {} // 0x00000001864FDC10-0x00000001864FDD70
		static FieldDescriptorProto() {} // 0x00000001864FDA60-0x00000001864FDB60
	
		// Methods
		private void OnConstruction() {} // 0x00000001864FCFA0-0x00000001864FD040
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FieldDescriptorProto Clone() => default; // 0x00000001864FC260-0x00000001864FC2E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001864FC2E0-0x00000001864FC370
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FieldDescriptorProto other) => default; // 0x00000001864FC370-0x00000001864FC6A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001864FC6A0-0x00000001864FCD90
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x00000001864FD040-0x00000001864FD0D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864FD0D0-0x00000001864FDA60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001864FBB30-0x00000001864FC260
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864FCD90-0x00000001864FCFA0
	}
}
