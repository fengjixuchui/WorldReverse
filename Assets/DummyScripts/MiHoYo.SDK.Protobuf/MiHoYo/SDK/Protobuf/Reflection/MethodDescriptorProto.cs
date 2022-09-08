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
	internal sealed class MethodDescriptorProto : MiHoYo.SDK.Protobuf.IMessage<MethodDescriptorProto> // TypeDefIndex: 5142
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<MethodDescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private string inputType_; // 0x18
		private string outputType_; // 0x20
		private MethodOptions options_; // 0x28
		private bool clientStreaming_; // 0x30
		private bool serverStreaming_; // 0x31
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<MethodDescriptorProto> Parser { get => default; } // 0x0000000187D61970-0x0000000187D61A00 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D616D0-0x0000000187D617F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D61A60-0x0000000187D61AE0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x0000000187D61850-0x0000000187D618B0 0x0000000187D61BC0-0x0000000187D61C40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string InputType { get => default; set {} } // 0x0000000187D617F0-0x0000000187D61850 0x0000000187D61B40-0x0000000187D61BC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string OutputType { get => default; set {} } // 0x0000000187D61910-0x0000000187D61970 0x0000000187D61CA0-0x0000000187D61D20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodOptions Options { get => default; set {} } // 0x0000000187D618B0-0x0000000187D61910 0x0000000187D61C40-0x0000000187D61CA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool ClientStreaming { get => default; set {} } // 0x0000000187D61670-0x0000000187D616D0 0x0000000187D61AE0-0x0000000187D61B40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool ServerStreaming { get => default; set {} } // 0x0000000187D61A00-0x0000000187D61A60 0x0000000187D61D20-0x0000000187D61D80
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodDescriptorProto() {} // 0x0000000187D61490-0x0000000187D61520
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodDescriptorProto(MethodDescriptorProto other) {} // 0x0000000187D61520-0x0000000187D61670
		static MethodDescriptorProto() {} // 0x0000000187D61390-0x0000000187D61490
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodDescriptorProto Clone() => default; // 0x0000000187D605D0-0x0000000187D60650
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D60890-0x0000000187D60920
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(MethodDescriptorProto other) => default; // 0x0000000187D60650-0x0000000187D60890
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D60920-0x0000000187D60D30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D60EC0-0x0000000187D60F50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D60F50-0x0000000187D61390
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D60210-0x0000000187D605D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D60D30-0x0000000187D60EC0
	}
}
