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
	internal sealed class MessageOptions : MiHoYo.SDK.Protobuf.IMessage<MessageOptions> // TypeDefIndex: 5148
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<MessageOptions> _parser; // 0x00
		private bool messageSetWireFormat_; // 0x10
		private bool noStandardDescriptorAccessor_; // 0x11
		private bool deprecated_; // 0x12
		private bool mapEntry_; // 0x13
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<MessageOptions> Parser { get => default; } // 0x0000000187D5FF80-0x0000000187D60010 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D5FD40-0x0000000187D5FE60 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D60010-0x0000000187D60090 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool MessageSetWireFormat { get => default; set {} } // 0x0000000187D5FEC0-0x0000000187D5FF20 0x0000000187D60150-0x0000000187D601B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool NoStandardDescriptorAccessor { get => default; set {} } // 0x0000000187D5FF20-0x0000000187D5FF80 0x0000000187D601B0-0x0000000187D60210
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x0000000187D5FCE0-0x0000000187D5FD40 0x0000000187D60090-0x0000000187D600F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool MapEntry { get => default; set {} } // 0x0000000187D5FE60-0x0000000187D5FEC0 0x0000000187D600F0-0x0000000187D60150
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MessageOptions() {} // 0x0000000187D5FC50-0x0000000187D5FCE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MessageOptions(MessageOptions other) {} // 0x0000000187D5FB90-0x0000000187D5FC50
		static MessageOptions() {} // 0x0000000187D5FA40-0x0000000187D5FB90
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MessageOptions Clone() => default; // 0x0000000187D5EF70-0x0000000187D5EFF0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D5F180-0x0000000187D5F210
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(MessageOptions other) => default; // 0x0000000187D5EFF0-0x0000000187D5F180
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D5F210-0x0000000187D5F4C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D5F660-0x0000000187D5F6F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D5F6F0-0x0000000187D5FA40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D5EDA0-0x0000000187D5EF70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D5F4C0-0x0000000187D5F660
	}
}
