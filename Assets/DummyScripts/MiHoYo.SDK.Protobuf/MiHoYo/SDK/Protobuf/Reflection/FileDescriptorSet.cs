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
	internal sealed class FileDescriptorSet : MiHoYo.SDK.Protobuf.IMessage<FileDescriptorSet> // TypeDefIndex: 5118
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<FileDescriptorSet> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x08
		private readonly RepeatedField<FileDescriptorProto> file_; // 0x10
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<FileDescriptorSet> Parser { get => default; } // 0x0000000186504E70-0x0000000186504F00 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000186504D20-0x0000000186504E70 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000186504F00-0x0000000186504F80 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorSet() {} // 0x0000000186504C90-0x0000000186504D20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorSet(FileDescriptorSet other) {} // 0x0000000186504BF0-0x0000000186504C90
		static FileDescriptorSet() {} // 0x0000000186504AA0-0x0000000186504BF0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public FileDescriptorSet Clone() => default; // 0x0000000186504620-0x00000001865046A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001865046A0-0x0000000186504730
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(FileDescriptorSet other) => default; // 0x0000000186504730-0x00000001865047D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001865047D0-0x0000000186504850
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000186504950-0x00000001865049E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001865049E0-0x0000000186504AA0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000186504570-0x0000000186504620
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000186504850-0x0000000186504950
	}
}
