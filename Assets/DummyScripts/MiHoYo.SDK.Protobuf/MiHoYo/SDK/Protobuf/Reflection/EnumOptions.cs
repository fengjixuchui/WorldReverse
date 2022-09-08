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
	internal sealed class EnumOptions : MiHoYo.SDK.Protobuf.IMessage<EnumOptions> // TypeDefIndex: 5157
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<EnumOptions> _parser; // 0x00
		private bool allowAlias_; // 0x10
		private bool deprecated_; // 0x11
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<EnumOptions> Parser { get => default; } // 0x00000001864F7F70-0x00000001864F8000 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001864F7E20-0x00000001864F7F70 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001864F8000-0x00000001864F8080 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool AllowAlias { get => default; set {} } // 0x00000001864F7D60-0x00000001864F7DC0 0x00000001864F8080-0x00000001864F80E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x00000001864F7DC0-0x00000001864F7E20 0x00000001864F80E0-0x00000001864F8140
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumOptions() {} // 0x00000001864F7C20-0x00000001864F7CB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumOptions(EnumOptions other) {} // 0x00000001864F7CB0-0x00000001864F7D60
		static EnumOptions() {} // 0x00000001864F7AD0-0x00000001864F7C20
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public EnumOptions Clone() => default; // 0x00000001864F7240-0x00000001864F72C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x00000001864F72C0-0x00000001864F7350
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(EnumOptions other) => default; // 0x00000001864F7350-0x00000001864F74A0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x00000001864F74A0-0x00000001864F7650
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x00000001864F77A0-0x00000001864F7830
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001864F7830-0x00000001864F7AD0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x00000001864F7100-0x00000001864F7240
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001864F7650-0x00000001864F77A0
	}
}
