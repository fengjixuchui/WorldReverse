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
	internal sealed class EnumDescriptorProto : MiHoYo.SDK.Protobuf.IMessage<EnumDescriptorProto> // TypeDefIndex: 5136
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<EnumDescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x08
		private readonly RepeatedField<EnumValueDescriptorProto> value_; // 0x18
		private EnumOptions options_; // 0x20
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<EnumDescriptorProto> Parser { get => default; } // 0x00000001864F6AB0-0x00000001864F6B40 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001864F68A0-0x00000001864F69F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864F6BA0-0x00000001864F6C20 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x00000001864F69F0-0x00000001864F6A50 0x00000001864F6C20-0x00000001864F6CA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<EnumValueDescriptorProto> Value { get => default; } // 0x00000001864F6B40-0x00000001864F6BA0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumOptions Options { get => default; set {} } // 0x00000001864F6A50-0x00000001864F6AB0 0x00000001864F6CA0-0x00000001864F6D00
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumDescriptorProto() {} // 0x00000001864F6800-0x00000001864F68A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumDescriptorProto(EnumDescriptorProto other) {} // 0x00000001864F66B0-0x00000001864F6800
		static EnumDescriptorProto() {} // 0x00000001864F6560-0x00000001864F66B0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumDescriptorProto Clone() => default; // 0x00000001864F5CA0-0x00000001864F5D20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001864F5D20-0x00000001864F5DB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(EnumDescriptorProto other) => default; // 0x00000001864F5DB0-0x00000001864F5F40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001864F5F40-0x00000001864F60F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x00000001864F6250-0x00000001864F62E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864F62E0-0x00000001864F6560
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001864F5AB0-0x00000001864F5CA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864F60F0-0x00000001864F6250
	}
}
