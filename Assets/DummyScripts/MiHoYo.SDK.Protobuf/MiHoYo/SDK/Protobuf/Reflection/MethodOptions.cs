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
	internal sealed class MethodOptions : MiHoYo.SDK.Protobuf.IMessage<MethodOptions> // TypeDefIndex: 5163
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<MethodOptions> _parser; // 0x00
		private bool deprecated_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<MethodOptions> Parser { get => default; } // 0x0000000187D63000-0x0000000187D63090 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D62EE0-0x0000000187D63000 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D63090-0x0000000187D63110 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x0000000187D62E80-0x0000000187D62EE0 0x0000000187D63110-0x0000000187D63170
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodOptions() {} // 0x0000000187D62DF0-0x0000000187D62E80
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodOptions(MethodOptions other) {} // 0x0000000187D62D50-0x0000000187D62DF0
		static MethodOptions() {} // 0x0000000187D62C00-0x0000000187D62D50
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MethodOptions Clone() => default; // 0x0000000187D62570-0x0000000187D625F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D62720-0x0000000187D627B0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(MethodOptions other) => default; // 0x0000000187D625F0-0x0000000187D62720
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D627B0-0x0000000187D628D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D62A00-0x0000000187D62A90
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D62A90-0x0000000187D62C00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D62470-0x0000000187D62570
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D628D0-0x0000000187D62A00
	}
}
