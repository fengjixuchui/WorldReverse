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
	internal sealed class ServiceDescriptorProto : MiHoYo.SDK.Protobuf.IMessage<ServiceDescriptorProto> // TypeDefIndex: 5140
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<ServiceDescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x08
		private readonly RepeatedField<MethodDescriptorProto> method_; // 0x18
		private ServiceOptions options_; // 0x20
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<ServiceDescriptorProto> Parser { get => default; } // 0x0000000187D67D20-0x0000000187D67DB0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D67AE0-0x0000000187D67C00 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D67DB0-0x0000000187D67E30 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x0000000187D67C60-0x0000000187D67CC0 0x0000000187D67E30-0x0000000187D67EB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<MethodDescriptorProto> Method { get => default; } // 0x0000000187D67C00-0x0000000187D67C60 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceOptions Options { get => default; set {} } // 0x0000000187D67CC0-0x0000000187D67D20 0x0000000187D67EB0-0x0000000187D67F10
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceDescriptorProto() {} // 0x0000000187D678F0-0x0000000187D67990
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceDescriptorProto(ServiceDescriptorProto other) {} // 0x0000000187D67990-0x0000000187D67AE0
		static ServiceDescriptorProto() {} // 0x0000000187D677A0-0x0000000187D678F0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceDescriptorProto Clone() => default; // 0x0000000187D66F70-0x0000000187D66FF0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D67180-0x0000000187D67210
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(ServiceDescriptorProto other) => default; // 0x0000000187D66FF0-0x0000000187D67180
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D67210-0x0000000187D673C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D67520-0x0000000187D675B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D675B0-0x0000000187D677A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D66D80-0x0000000187D66F70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D673C0-0x0000000187D67520
	}
}
