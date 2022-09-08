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
	internal sealed class ServiceOptions : MiHoYo.SDK.Protobuf.IMessage<ServiceOptions> // TypeDefIndex: 5161
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<ServiceOptions> _parser; // 0x00
		private bool deprecated_; // 0x10
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<ServiceOptions> Parser { get => default; } // 0x0000000187D68F60-0x0000000187D68FF0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187D68E40-0x0000000187D68F60 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D68FF0-0x0000000187D69070 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Deprecated { get => default; set {} } // 0x0000000187D68DE0-0x0000000187D68E40 0x0000000187D69070-0x0000000187D690D0
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceOptions() {} // 0x0000000187D68CB0-0x0000000187D68D40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceOptions(ServiceOptions other) {} // 0x0000000187D68D40-0x0000000187D68DE0
		static ServiceOptions() {} // 0x0000000187D68B60-0x0000000187D68CB0
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ServiceOptions Clone() => default; // 0x0000000187D684D0-0x0000000187D68550
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D68680-0x0000000187D68710
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(ServiceOptions other) => default; // 0x0000000187D68550-0x0000000187D68680
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D68710-0x0000000187D68830
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D68960-0x0000000187D689F0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D689F0-0x0000000187D68B60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D683D0-0x0000000187D684D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D68830-0x0000000187D68960
	}
}
