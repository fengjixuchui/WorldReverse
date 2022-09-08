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
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.WellKnownTypes
{
	public sealed class ListValue : MiHoYo.SDK.Protobuf.IMessage<ListValue> // TypeDefIndex: 5112
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<ListValue> _parser; // 0x00
		private static readonly MiHoYo.SDK.Protobuf.FieldCodec<Value> _repeated_values_codec; // 0x08
		private readonly RepeatedField<Value> values_; // 0x10
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<ListValue> Parser { get => default; } // 0x0000000187D5C080-0x0000000187D5C110 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D5BF60-0x0000000187D5C080 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D5C110-0x0000000187D5C190 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ListValue() {} // 0x0000000187D5BE30-0x0000000187D5BEC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ListValue(ListValue other) {} // 0x0000000187D5BEC0-0x0000000187D5BF60
		static ListValue() {} // 0x0000000187D5BCE0-0x0000000187D5BE30
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ListValue Clone() => default; // 0x0000000187D5B7D0-0x0000000187D5B850
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D5B850-0x0000000187D5B8E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(ListValue other) => default; // 0x0000000187D5B8E0-0x0000000187D5B980
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D5B980-0x0000000187D5BA00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D5BB90-0x0000000187D5BC20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D5BC20-0x0000000187D5BCE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D5B720-0x0000000187D5B7D0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(ListValue other) {} // 0x0000000187D5BB00-0x0000000187D5BB90
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D5BA00-0x0000000187D5BB00
	}
}
