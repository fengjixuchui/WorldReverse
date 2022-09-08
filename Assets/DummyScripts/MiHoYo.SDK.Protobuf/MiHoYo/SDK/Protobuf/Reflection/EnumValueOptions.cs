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
	internal sealed class EnumValueOptions : MiHoYo.SDK.Protobuf.IMessage<EnumValueOptions> // TypeDefIndex: 5159
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<EnumValueOptions> _parser; // 0x00
		private bool deprecated_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<EnumValueOptions> Parser { get => default; } // 0x00000001864FA530-0x00000001864FA5C0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001864FA3E0-0x00000001864FA530 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864FA5C0-0x00000001864FA640 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x00000001864FA380-0x00000001864FA3E0 0x00000001864FA640-0x00000001864FA6A0
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumValueOptions() {} // 0x00000001864FA2F0-0x00000001864FA380
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumValueOptions(EnumValueOptions other) {} // 0x00000001864FA250-0x00000001864FA2F0
		static EnumValueOptions() {} // 0x00000001864FA100-0x00000001864FA250
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumValueOptions Clone() => default; // 0x00000001864F9A30-0x00000001864F9AB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001864F9BE0-0x00000001864F9C70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(EnumValueOptions other) => default; // 0x00000001864F9AB0-0x00000001864F9BE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001864F9C70-0x00000001864F9D90
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x00000001864F9EC0-0x00000001864F9F50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864F9F50-0x00000001864FA100
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001864F9930-0x00000001864F9A30
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864F9D90-0x00000001864F9EC0
	}
}
