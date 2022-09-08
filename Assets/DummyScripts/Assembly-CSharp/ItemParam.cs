/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemParam : MessageBase, IMessage<ItemParam> // TypeDefIndex: 25986
{
	// Fields
	private static readonly MessageParser<ItemParam> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0A91F
	private uint itemId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B0A923
	private uint count_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemParam> Parser { get => default; } // 0x00000001838DB710-0x00000001838DB7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838DB4A0-0x00000001838DB530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838DB190-0x00000001838DB210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838DAC20-0x00000001838DAC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838DBC80-0x00000001838DBD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838DBA10-0x00000001838DBA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838DB530-0x00000001838DB620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838DBB90-0x00000001838DBBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838DB2B0-0x00000001838DB3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x00000001838DB830-0x00000001838DB8D0 0x00000001838DBBE0-0x00000001838DBC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x00000001838DB8D0-0x00000001838DB970 0x00000001838DAB80-0x00000001838DAC20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam() {} // 0x00000001838DC030-0x00000001838DC090
	static ItemParam() {} // 0x00000001838DBF70-0x00000001838DC030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam Clone() => default; // 0x00000001838DB620-0x00000001838DB710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam ShallowCopy() => default; // 0x00000001838DB210-0x00000001838DB2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838DADB0-0x00000001838DAE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838DB970-0x00000001838DB9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838DB9C0-0x00000001838DBA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838DAE00-0x00000001838DAE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838DAF90-0x00000001838DB060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemParam other) => default; // 0x00000001838DAE70-0x00000001838DAF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838DB3A0-0x00000001838DB4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838DBD70-0x00000001838DBF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838DBA70-0x00000001838DBB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838DB060-0x00000001838DB190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemParam other) {} // 0x00000001838DAC80-0x00000001838DADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838DAA80-0x00000001838DAB80
}

