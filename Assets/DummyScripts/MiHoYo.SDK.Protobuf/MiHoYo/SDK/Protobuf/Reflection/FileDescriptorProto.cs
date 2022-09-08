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
	internal sealed class FileDescriptorProto : MiHoYo.SDK.Protobuf.IMessage<FileDescriptorProto> // TypeDefIndex: 5120
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FileDescriptorProto> _parser; // 0x00
		private string name_; // 0x10
		private string package_; // 0x18
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<string> _repeated_dependency_codec; // 0x08
		private readonly RepeatedField<string> dependency_; // 0x20
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<int> _repeated_publicDependency_codec; // 0x10
		private readonly RepeatedField<int> publicDependency_; // 0x28
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<int> _repeated_weakDependency_codec; // 0x18
		private readonly RepeatedField<int> weakDependency_; // 0x30
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x20
		private readonly RepeatedField<DescriptorProto> messageType_; // 0x38
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x40
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x30
		private readonly RepeatedField<ServiceDescriptorProto> service_; // 0x48
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x38
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x50
		private FileOptions options_; // 0x58
		private SourceCodeInfo sourceCodeInfo_; // 0x60
		private string syntax_; // 0x68
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FileDescriptorProto> Parser { get => default; } // 0x00000001865040A0-0x0000000186504130 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000186503D70-0x0000000186503EC0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001865042B0-0x0000000186504330 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Name { get => default; set {} } // 0x0000000186503F80-0x0000000186503FE0 0x0000000186504330-0x00000001865043B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Package { get => default; set {} } // 0x0000000186504040-0x00000001865040A0 0x0000000186504410-0x0000000186504490
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<string> Dependency { get => default; } // 0x0000000186503D10-0x0000000186503D70 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<int> PublicDependency { get => default; } // 0x0000000186504130-0x0000000186504190 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<DescriptorProto> MessageType { get => default; } // 0x0000000186503F20-0x0000000186503F80 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x0000000186503EC0-0x0000000186503F20 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public RepeatedField<ServiceDescriptorProto> Service { get => default; } // 0x0000000186504190-0x00000001865041F0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileOptions Options { get => default; set {} } // 0x0000000186503FE0-0x0000000186504040 0x00000001865043B0-0x0000000186504410
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public SourceCodeInfo SourceCodeInfo { get => default; set {} } // 0x00000001865041F0-0x0000000186504250 0x0000000186504490-0x00000001865044F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Syntax { get => default; set {} } // 0x0000000186504250-0x00000001865042B0 0x00000001865044F0-0x0000000186504570
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorProto() {} // 0x0000000186503B90-0x0000000186503D10
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorProto(FileDescriptorProto other) {} // 0x00000001865038D0-0x0000000186503B90
		static FileDescriptorProto() {} // 0x0000000186503630-0x00000001865038D0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorProto Clone() => default; // 0x0000000186502190-0x0000000186502210
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000186502210-0x00000001865022A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FileDescriptorProto other) => default; // 0x00000001865022A0-0x0000000186502620
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000186502620-0x0000000186502AA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000186502F30-0x0000000186502FC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000186502FC0-0x0000000186503630
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000186501C70-0x0000000186502190
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000186502AA0-0x0000000186502F30
	}
}
