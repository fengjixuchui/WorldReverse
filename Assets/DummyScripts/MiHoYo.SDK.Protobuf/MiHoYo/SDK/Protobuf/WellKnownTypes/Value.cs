/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.WellKnownTypes
{
	public sealed class Value : MiHoYo.SDK.Protobuf.IMessage<Value> // TypeDefIndex: 5109
	{
		// Fields
		private static readonly MiHoYo.SDK.Protobuf.MessageParser<Value> _parser; // 0x00
		private object kind_; // 0x10
		private KindOneofCase kindCase_; // 0x18
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.MessageParser<Value> Parser { get => default; } // 0x0000000187D73690-0x0000000187D73720 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { get => default; } // 0x0000000187D73330-0x0000000187D73450 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187D73840-0x0000000187D738C0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public NullValue NullValue { get => default; set {} } // 0x0000000187D73540-0x0000000187D735E0 0x0000000187D739C0-0x0000000187D73A50
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public double NumberValue { get => default; set {} } // 0x0000000187D735E0-0x0000000187D73690 0x0000000187D73A50-0x0000000187D73AE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string StringValue { get => default; set {} } // 0x0000000187D73720-0x0000000187D737B0 0x0000000187D73AE0-0x0000000187D73B70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool BoolValue { get => default; set {} } // 0x0000000187D73290-0x0000000187D73330 0x0000000187D738C0-0x0000000187D73950
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Struct StructValue { get => default; set {} } // 0x0000000187D737B0-0x0000000187D73840 0x0000000187D73B70-0x0000000187D73BE0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public ListValue ListValue { get => default; set {} } // 0x0000000187D734B0-0x0000000187D73540 0x0000000187D73950-0x0000000187D739C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public KindOneofCase KindCase { get => default; } // 0x0000000187D73450-0x0000000187D734B0 
	
		// Nested types
		public enum KindOneofCase // TypeDefIndex: 5110
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Value() {} // 0x0000000187D73020-0x0000000187D73090
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Value(Value other) {} // 0x0000000187D73090-0x0000000187D73290
		static Value() {} // 0x0000000187D72F20-0x0000000187D73020
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public Value Clone() => default; // 0x0000000187D72380-0x0000000187D72400
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override bool Equals(object other) => default; // 0x0000000187D725E0-0x0000000187D72670
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public bool Equals(Value other) => default; // 0x0000000187D72400-0x0000000187D725E0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override int GetHashCode() => default; // 0x0000000187D72670-0x0000000187D72AB0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public override string ToString() => default; // 0x0000000187D72CD0-0x0000000187D72D60
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x0000000187D72D60-0x0000000187D72F20
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public int CalculateSize() => default; // 0x0000000187D72060-0x0000000187D72380
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x0000000187D72AB0-0x0000000187D72CD0
	}
}
