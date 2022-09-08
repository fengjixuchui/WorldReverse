/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	internal sealed class DescriptorProto : MiHoYo.SDK.Protobuf.IMessage<DescriptorProto> // TypeDefIndex: 5122
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<DescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x08
		private readonly RepeatedField<FieldDescriptorProto> field_; // 0x18
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x10
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x20
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x18
		private readonly RepeatedField<DescriptorProto> nestedType_; // 0x28
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x20
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x30
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec; // 0x28
		private readonly RepeatedField<Types.ExtensionRange> extensionRange_; // 0x38
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x30
		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; // 0x40
		private MessageOptions options_; // 0x48
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec; // 0x38
		private readonly RepeatedField<Types.ReservedRange> reservedRange_; // 0x50
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<string> _repeated_reservedName_codec; // 0x40
		private readonly RepeatedField<string> reservedName_; // 0x58
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<DescriptorProto> Parser { get => default; } // 0x00000001864EF260-0x00000001864EF2F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001864EEED0-0x00000001864EF020 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864EF2F0-0x00000001864EF370 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x00000001864EF0E0-0x00000001864EF140 0x00000001864EF370-0x00000001864EF3F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<FieldDescriptorProto> Field { get => default; } // 0x00000001864EF080-0x00000001864EF0E0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<DescriptorProto> NestedType { get => default; } // 0x00000001864EF140-0x00000001864EF1A0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x00000001864EF020-0x00000001864EF080 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<OneofDescriptorProto> OneofDecl { get => default; } // 0x00000001864EF1A0-0x00000001864EF200 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MessageOptions Options { get => default; set {} } // 0x00000001864EF200-0x00000001864EF260 0x00000001864EF3F0-0x00000001864EF450
	
		// Nested types
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static class Types // TypeDefIndex: 5123
		{
			// Nested types
			internal sealed class ExtensionRange : MiHoYo.SDK.Protobuf.IMessage<ExtensionRange> // TypeDefIndex: 5124
			{
				// Fields
				private static readonly MiHoYo.SDK.Protobuf.MessageParser<ExtensionRange> _parser; // 0x00
				private int start_; // 0x10
				private int end_; // 0x14
	
				// Properties
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MiHoYo.SDK.Protobuf.MessageParser<ExtensionRange> Parser { get => default; } // 0x00000001864FB340-0x00000001864FB3D0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MessageDescriptor Descriptor { get => default; } // 0x00000001864FB1C0-0x00000001864FB2E0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864FB430-0x00000001864FB4B0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int Start { get => default; set {} } // 0x00000001864FB3D0-0x00000001864FB430 0x00000001864FB510-0x00000001864FB570
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int End { get => default; set {} } // 0x00000001864FB2E0-0x00000001864FB340 0x00000001864FB4B0-0x00000001864FB510
	
				// Constructors
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ExtensionRange() {} // 0x00000001864FB090-0x00000001864FB0F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ExtensionRange(ExtensionRange other) {} // 0x00000001864FB0F0-0x00000001864FB1C0
				static ExtensionRange() {} // 0x00000001864FAF90-0x00000001864FB090
	
				// Methods
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ExtensionRange Clone() => default; // 0x00000001864FA850-0x00000001864FA8D0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override bool Equals(object other) => default; // 0x00000001864FA8D0-0x00000001864FA960
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool Equals(ExtensionRange other) => default; // 0x00000001864FA960-0x00000001864FAA80
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override int GetHashCode() => default; // 0x00000001864FAA80-0x00000001864FAC00
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override string ToString() => default; // 0x00000001864FACC0-0x00000001864FAD50
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864FAD50-0x00000001864FAF90
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int CalculateSize() => default; // 0x00000001864FA6A0-0x00000001864FA850
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864FAC00-0x00000001864FACC0
			}
	
			internal sealed class ReservedRange : MiHoYo.SDK.Protobuf.IMessage<ReservedRange> // TypeDefIndex: 5126
			{
				// Fields
				private static readonly MiHoYo.SDK.Protobuf.MessageParser<ReservedRange> _parser; // 0x00
				private int start_; // 0x10
				private int end_; // 0x14
	
				// Properties
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MiHoYo.SDK.Protobuf.MessageParser<ReservedRange> Parser { get => default; } // 0x0000000186513830-0x00000001865138C0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public static MessageDescriptor Descriptor { get => default; } // 0x00000001865136B0-0x00000001865137D0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000186513920-0x00000001865139A0 
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int Start { get => default; set {} } // 0x00000001865138C0-0x0000000186513920 0x0000000186513A00-0x0000000186513A60
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int End { get => default; set {} } // 0x00000001865137D0-0x0000000186513830 0x00000001865139A0-0x0000000186513A00
	
				// Constructors
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ReservedRange() {} // 0x0000000186513650-0x00000001865136B0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ReservedRange(ReservedRange other) {} // 0x0000000186513580-0x0000000186513650
				static ReservedRange() {} // 0x0000000186513480-0x0000000186513580
	
				// Methods
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public ReservedRange Clone() => default; // 0x0000000186512D40-0x0000000186512DC0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override bool Equals(object other) => default; // 0x0000000186512EE0-0x0000000186512F70
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public bool Equals(ReservedRange other) => default; // 0x0000000186512DC0-0x0000000186512EE0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override int GetHashCode() => default; // 0x0000000186512F70-0x00000001865130F0
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public override string ToString() => default; // 0x00000001865131B0-0x0000000186513240
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000186513240-0x0000000186513480
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public int CalculateSize() => default; // 0x0000000186512B90-0x0000000186512D40
				[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
				public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001865130F0-0x00000001865131B0
			}
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public DescriptorProto() {} // 0x00000001864EED40-0x00000001864EEED0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public DescriptorProto(DescriptorProto other) {} // 0x00000001864EEB00-0x00000001864EED40
		static DescriptorProto() {} // 0x00000001864EE7F0-0x00000001864EEB00
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public DescriptorProto Clone() => default; // 0x00000001864ED850-0x00000001864ED8D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001864EDBA0-0x00000001864EDC30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(DescriptorProto other) => default; // 0x00000001864ED8D0-0x00000001864EDBA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001864EDC30-0x00000001864EDF00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x00000001864EE350-0x00000001864EE3E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864EE3E0-0x00000001864EE7F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001864ED4D0-0x00000001864ED850
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864EDF00-0x00000001864EE350
	}
}
