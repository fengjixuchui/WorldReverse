/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OrderDisplayNotify : MessageBase, IMessage<OrderDisplayNotify> // TypeDefIndex: 24710
{
	// Fields
	private static readonly MessageParser<OrderDisplayNotify> _parser; // 0x00
	public const int OrderIdFieldNumber = 1; // Metadata: 0x00B070D7
	private uint orderId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OrderDisplayNotify> Parser { get => default; } // 0x0000000181FABC30-0x0000000181FABCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FAB9C0-0x0000000181FABA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FAB6D0-0x0000000181FAB750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FAB1E0-0x0000000181FAB240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FAC0C0-0x0000000181FAC1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FABF30-0x0000000181FABF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FABA50-0x0000000181FABB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FAC070-0x0000000181FAC0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FAB7F0-0x0000000181FAB8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OrderId { get => default; set {} } // 0x0000000181FABDA0-0x0000000181FABE40 0x0000000181FABE90-0x0000000181FABF30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24711
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24712
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4106
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderDisplayNotify() {} // 0x0000000181FAC3E0-0x0000000181FAC440
	static OrderDisplayNotify() {} // 0x0000000181FAC320-0x0000000181FAC3E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderDisplayNotify Clone() => default; // 0x0000000181FABB40-0x0000000181FABC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderDisplayNotify ShallowCopy() => default; // 0x0000000181FAB750-0x0000000181FAB7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FAB350-0x0000000181FAB3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FABD50-0x0000000181FABDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FABE40-0x0000000181FABE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FAB3A0-0x0000000181FAB410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FAB410-0x0000000181FAB4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OrderDisplayNotify other) => default; // 0x0000000181FAB4E0-0x0000000181FAB5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FAB8E0-0x0000000181FAB9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FAC1B0-0x0000000181FAC320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FABF90-0x0000000181FAC070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FAB5E0-0x0000000181FAB6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OrderDisplayNotify other) {} // 0x0000000181FAB240-0x0000000181FAB350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FAB100-0x0000000181FAB1E0
}

